using DrugLib;
using DrugLib.Model;
using DrugLib.Presenter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LR3
{
    
    public partial class MainForm : Form, IDrugsView
    {
        private DrugsPresenter presenter_;
        public MainForm()
        {
            InitializeComponent();
            presenter_ = new DrugsPresenter(new CsvDrugsModel(), this);

        }
        public void ShowCategories(List<string> categories)
        {
            CategoriesListBox.DataSource = categories;
        }
        public void ShowDrugsInCategory(List<Drugs> drugs)
        {
            DrugsComboBox.DataSource = null;
            DrugsComboBox.DataSource = drugs;
            DrugsComboBox.DisplayMember = "Name";
        }

        public void ShowDrugDetails(Drugs drug)
        {
            PriceLabel.Text = drug.Price;
            ManufacturerLabel.Text = drug.Manufacturer;
            DateLabel.Text = drug.Date;
            ProviderLabel.Text = drug.Provider;
            try
            {
                DrugPictureBox.Load(drug.ImagePath);
            }
            catch
            {}
        }
        public void ShowOrderSummary(Dictionary<string, int> orderItems)
        {
            string orderText = "Ваш заказ:\n";
            foreach (var item in orderItems)
            {
                orderText += $"{item.Key}: {item.Value} шт.\n";
            }
            MessageBox.Show(orderText, "Текущий заказ");
        }
        public string GetSelectedCategory()
        {
            return CategoriesListBox.SelectedItem?.ToString();
        }
        public Drugs GetSelectedDrug()
        {
            return DrugsComboBox.SelectedItem as Drugs;
        }
        public int GetOrderQuantity()
        {
            return (int)QuantityNumericUpDown.Value;
        }
        private void CategoriesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            presenter_.CategorySelected();
        }
        private void DrugsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            presenter_.DrugSelected();
        }
        private void OrderButton_Click(object sender, EventArgs e)
        {
            presenter_.AddToOrder();
        }
    }
}

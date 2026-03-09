using DrugLib.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrugLib.Presenter
{
    public class DrugsPresenter
    {
        private IDrugsModel model_;
        private IDrugsView view_;

        public DrugsPresenter(IDrugsModel model, IDrugsView view)
        {
            model_ = model;
            view_ = view;

            var allData = model_.LoadData();
            view_.ShowCategories(allData.Keys.ToList());
        }

        public void CategorySelected()
        {
            string category = view_.GetSelectedCategory();
            if (!string.IsNullOrEmpty(category))
            {
                var allData = model_.LoadData();
                if (allData.ContainsKey(category))
                {
                    view_.ShowDrugsInCategory(allData[category]);
                }
            }
        }

        public void DrugSelected()
        {
            Drugs drug = view_.GetSelectedDrug();
            if (drug != null)
            {
                view_.ShowDrugDetails(drug);
            }
        }

        public void AddToOrder()
        {
            Drugs drug = view_.GetSelectedDrug();
            int quantity = view_.GetOrderQuantity();

            if (drug != null && quantity > 0)
            {
                model_.AddOrderItem(drug.Name, quantity);
                view_.ShowOrderSummary(model_.GetOrderItems());
            }
        }
    }
}

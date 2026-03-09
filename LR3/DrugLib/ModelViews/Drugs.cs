using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrugLib
{
    public class Drugs
    {
        private string name_;
        private int price_;
        private string manufacturer_;
        private DateTime shelfLifeDate_;
        private string provide_;
        private string imagePath_;

        public Drugs(string name, string price, string manufacturer, string date, string provider, string imagePath)
        {
            name_ = name;
            if (!int.TryParse(price, out price_))
            {
                price_ = 0;
            }
            manufacturer_ = manufacturer;
            shelfLifeDate_ = DateTime.Parse(date);
            provide_ = provider;
            imagePath_ = imagePath;
        }

        public string Name
        {
            get { return name_; }
        }
        public string Price
        {
            get { return price_.ToString("0"); }
        }
        public string Manufacturer
        {
            get { return manufacturer_; }
        }
        public string Date
        {
            get { return shelfLifeDate_.ToString("dd.MM.yyyy"); }
        }
        public string Provider
        {
            get { return provide_; }
        }
        public string ImagePath
        {
            get { return imagePath_; }
        }
    }
}

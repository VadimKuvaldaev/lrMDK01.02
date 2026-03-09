using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrugLib.Model
{
    public class CsvDrugsModel : IDrugsModel
    {
        private Dictionary<string, List<Drugs>> drugs_ = new Dictionary<string, List<Drugs>>();
        private Dictionary<string, int> orderItems_ = new Dictionary<string, int>();
        private FileDrugStorage fileStorage_ = new FileDrugStorage();

        public CsvDrugsModel()
        {
            drugs_ = fileStorage_.LoadDataFromCsv();
        }
        public void AddOrderItem(string drugName, int quantity)
        {
            if (orderItems_.ContainsKey(drugName))
            {
                orderItems_[drugName] += quantity;
            }
            else
            {
                orderItems_[drugName] = quantity;
            }
        }

        public void ClearOrder()
        {
            orderItems_.Clear();
        }

        public Dictionary<string, int> GetOrderItems()
        {
            return orderItems_;
        }

        public Dictionary<string, List<Drugs>> LoadData()
        {
            return drugs_;
        }

        public Dictionary<string, List<Drugs>> LoadDataFromCsv()
        {
            throw new NotImplementedException();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrugLib.Model
{
    public interface IDrugsModel
    {
        Dictionary<string, List<Drugs>> LoadData();
        void AddOrderItem(string drugName, int quantity);
        Dictionary<string, int> GetOrderItems();
        void ClearOrder();
        
    }
}

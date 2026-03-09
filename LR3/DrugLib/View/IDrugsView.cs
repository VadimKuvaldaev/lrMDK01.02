using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrugLib
{
    public interface IDrugsView
    {
        void ShowCategories(List<string> categories);
        void ShowDrugsInCategory(List<Drugs> drugs);
        void ShowDrugDetails(Drugs drug);
        void ShowOrderSummary(Dictionary<string, int> orderItems);
        string GetSelectedCategory();
        Drugs GetSelectedDrug();
        int GetOrderQuantity();
    }
}

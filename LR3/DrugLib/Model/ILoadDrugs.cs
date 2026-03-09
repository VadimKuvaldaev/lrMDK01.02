using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrugLib.Model
{
    public interface ILoadDrugs
    {
        Dictionary<string, List<Drugs>> LoadDataFromCsv();
    }
}

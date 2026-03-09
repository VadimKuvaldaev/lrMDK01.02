using DrugLib.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrugLib
{
    public class FileDrugStorage : ILoadDrugs
    {
        public Dictionary<string, List<Drugs>> LoadDataFromCsv()
        {
            Dictionary<string, List<Drugs>> result = new Dictionary<string, List<Drugs>>();

            using (StreamReader reader = new StreamReader("data.csv", Encoding.GetEncoding(1251)))
            {
                reader.ReadLine();

                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] drugInfo = line.Split(';');

                    string category = drugInfo[0];
                    string name = drugInfo[1];
                    string price = drugInfo[2];
                    string manufacturer = drugInfo[3];
                    string date = drugInfo[4];
                    string provider = drugInfo[5];
                    string imagePath = drugInfo[6];

                    Drugs drug = new Drugs(name, price, manufacturer, date, provider, imagePath);

                    if (!result.ContainsKey(category))
                    {
                        result[category] = new List<Drugs>();
                    }

                    result[category].Add(drug);
                }
            }

            return result;
        }
    }
}

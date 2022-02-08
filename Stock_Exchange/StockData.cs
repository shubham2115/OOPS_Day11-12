using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_Exchange
{
    internal class StockData
    {


        public void StockList(string FilePath)
        {
            try
            {
                string json;
                using (StreamReader reader = new StreamReader(FilePath))
                {
                    json = reader.ReadToEnd();
                    var stocks = JsonConvert.DeserializeObject<List<GetSet>>(json);
                    Console.WriteLine("Name\t" + "Unit\t" + "PricePerShare\t" + "Total Value Of Stocks\t");
                    int totalvalue = 0;
                    foreach (var data in stocks)
                    {
                        Console.WriteLine(data.Name + "\t" + data.NumberOfShare + "\t" + data.SharePrice + "\t" + data.NumberOfShare * data.SharePrice);
                        totalvalue += data.SharePrice * data.NumberOfShare;
                    }
                    Console.WriteLine("Total stock Value\t ", +totalvalue);


                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}



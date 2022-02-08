using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcept
{
    internal class InventoryManagement
    {
        public void ReadData(string filepath)
        {
            try
            {


                
                using (StreamReader reader = new StreamReader(filepath))
                {
                    var json = reader.ReadToEnd();
                    var items = JsonConvert.DeserializeObject<List<Inventorylist>>(json);
                    Console.WriteLine("Name\t" + "Price\t" + "Weight\t" + "Total Amount");
                    foreach (var data in items)
                    {
                        Console.WriteLine(data.Ricelist + "\t" +data.Price + "\t" + data.Weight + "\t" + data.Price * data.Weight);
                    }
                }
            }catch (Exception ex)
            {
                Console.WriteLine("Exception Occurred" +ex.Message);
            }
        }
    }
}

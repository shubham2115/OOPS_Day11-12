using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_UC_2_Grocery_Inventory
{
    public class GroceryReader
    {

        List<Grocery> ricelist = new List<Grocery>();
        List<Grocery> wheatlist = new List<Grocery>();
        List<Grocery> pulseslist = new List<Grocery>();
        public void ReadDate(string filepath)
        {

            using (StreamReader reader = new StreamReader(filepath))
            {
                var json = reader.ReadToEnd();
                var items = JsonConvert.DeserializeObject<InventoryGrocery>(json);
                this.ricelist = items.Rice;
                this.wheatlist = items.Wheat;
                this.pulseslist = items.Pulses;
                var ricePrice = 0;
                var wheatPrice = 0;
                var pulsesPrice = 0;
                Console.WriteLine("Name\t" + "Price\t" + "Weight\t" + "Total Amount");
                foreach (var item in ricelist)
                {
                    Console.WriteLine(item.Name + "\t" + item.Price + "\t" + item.Weight + "\t" + item.Price * item.Weight);
                    ricePrice += item.Price * item.Weight;
                }
                Console.WriteLine($"----------Total Rice Price: {ricePrice}----------");

                Console.WriteLine("Name\t" + "Price\t" + "Weight\t" + "Total Amount");
                foreach (var item in wheatlist)
                {
                    Console.WriteLine(item.Name + "\t" + item.Price + "\t" + item.Weight + "\t" + item.Price * item.Weight);
                    wheatPrice += item.Price * item.Weight;

                }
                Console.WriteLine($"----------Total Wheat Price: {ricePrice}----------");

                Console.WriteLine("Name\t" + "Price\t" + "Weight\t" + "Total Amount");
                foreach (var item in pulseslist)
                {
                    Console.WriteLine(item.Name + "\t" + item.Price + "\t" + item.Weight + "\t" + item.Price * item.Weight);
                    pulsesPrice += item.Price * item.Weight;
                }

                Console.WriteLine($"----------Total Pulses Price: {pulsesPrice}----------");
            }
        }
    }
}

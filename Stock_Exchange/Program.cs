using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_Exchange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StockData data = new StockData();
            data.StockList(@"D:\Stock_Exchange\Stock_Exchange\Stock.json");
        }
    }
}

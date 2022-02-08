using System;
namespace OOPSConcept
{
    public class Program
    {
        public static void Main()
        {
            InventoryManagement inventoryManagement = new InventoryManagement();
            inventoryManagement.ReadData(@"D:\OOPSConcept\OOPS_Day11-12\Inventory.json");
            Console.ReadKey();
        }
        
    }
}
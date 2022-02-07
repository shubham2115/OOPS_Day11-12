using System;
namespace OOPSConcept
{
    public class Program
    {
        public static void Main()
        {
            InventoryManagement inventoryManagement = new InventoryManagement();
            inventoryManagement.ReadData(@"D:\OOPS1\Inventory.json");
            Console.ReadKey();
        }
        
    }
}
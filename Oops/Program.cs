using Oops.InventoryManagement;
using System;

namespace Oops
{
    class Program
    {
        const string INVENTORY_JSON =@"C:\Users\DELL\source\repos\Oops\InventoryManagement\Inventory.json";
        static void Main(string[] args)
        {
            Inventorymain inventoryMain = new Inventorymain();
            inventoryMain.DisplayData(INVENTORY_JSON);
        }
    }
}

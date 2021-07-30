using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Oops.InventoryManagement
{
    public class Inventorymain
    {
        public void DisplayData(string filepath)
        {
            try
            {
                using (StreamReader read = new StreamReader(filepath))
                {
                    var json = read.ReadToEnd();
                    var items = JsonConvert.DeserializeObject<List<InventoryModel>>(json);
                    Console.WriteLine("Name\tWeight\tRate\tAmount");
                    foreach (var item in items)
                    {
                        Console.WriteLine("{0}" + "\t" + "{1}" + "\t" + "{2}" + "\t" + "{3}", item.Name, item.Weight, item.PricePerKg, item.Weight * item.PricePerKg);
                    }
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem
{
    public class Item
    {
        public int ID { get; set; }
        public string name { get; set; }
        public int quantity { get; set; }
        public int Pprice { get; set; }
        public int Sprice { get; set; }
    }
}

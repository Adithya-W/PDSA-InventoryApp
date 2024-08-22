using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem
{
    internal class Salesorder
    {
        int ID { get; set; }
        int CID { get; set; }
        int IID { get; set; }
        int quantity { get; set; }
        DateTime date { get; set; }     
    }
}

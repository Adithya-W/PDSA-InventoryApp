using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
    public partial class homepage : Form
    {
        public homepage()
        {
            InitializeComponent();
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            Inventory invForm = new Inventory();
            invForm.Show();
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            Customers cusForm = new Customers();
            cusForm.Show();
        }

        private void btnSuppliers_Click(object sender, EventArgs e)
        {
            Suppliers supForm = new Suppliers();
            supForm.Show();
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            SalesOrders salesForm = new SalesOrders();
            salesForm.Show();
        }

        private void btnPurchases_Click(object sender, EventArgs e)
        {
            PurchaseOrders purchaseForm = new PurchaseOrders();
            purchaseForm.Show();
        }
    }
}

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
    public partial class PurchaseOrders : Form
    {
        public PurchaseOrders()
        {
            InitializeComponent();
        }

        private void purchaseOrdersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.purchaseOrdersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.inventorySystemDataSet);

        }

        private void PurchaseOrders_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'inventorySystemDataSet.PurchaseOrders' table. You can move, or remove it, as needed.
            this.purchaseOrdersTableAdapter.Fill(this.inventorySystemDataSet.PurchaseOrders);

        }

        private void purchaseOrdersDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (purchaseOrdersDataGridView.Columns[e.ColumnIndex].Name == "Delete")
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this order?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    var currentRow = (DataRowView)purchaseOrdersDataGridView.Rows[e.RowIndex].DataBoundItem;
                    int id = (int)currentRow["pOrderID"];

                    deleteRecords obj = new deleteRecords();
                    obj.deletePurchase(id);

                    purchaseOrdersBindingSource.RemoveCurrent();
                }
            }
        }

        private void btnAddPurchaseOrder_Click(object sender, EventArgs e)
        {
            AddPurchaseOrder frm = new AddPurchaseOrder();
            frm.Show();
        }
    }
}

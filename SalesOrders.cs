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
    public partial class SalesOrders : Form
    {
        public SalesOrders()
        {
            InitializeComponent();
        }

        private void salesOrdersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.salesOrdersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.inventorySystemDataSet);

        }

        private void SalesOrders_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'inventorySystemDataSet.SalesOrders' table. You can move, or remove it, as needed.
            this.salesOrdersTableAdapter.Fill(this.inventorySystemDataSet.SalesOrders);

        }

        private void salesOrdersDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (salesOrdersDataGridView.Columns[e.ColumnIndex].Name == "Delete")
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this order?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    var currentRow = (DataRowView)salesOrdersDataGridView.Rows[e.RowIndex].DataBoundItem;
                    int id = (int)currentRow["sOrderID"];

                    deleteRecords obj = new deleteRecords();
                    obj.deleteSale(id);

                    salesOrdersBindingSource.RemoveCurrent();
                }
            }
        }

        private void btnAddSalesOrder_Click(object sender, EventArgs e)
        {
            AddSalesOrder frm = new AddSalesOrder();
            frm.Show();
        }
    }
}

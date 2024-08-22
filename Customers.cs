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
    public partial class Customers : Form
    {
        public Customers()
        {
            InitializeComponent();
        }

        private void customersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.inventorySystemDataSet);

        }

        private void Customers_Load(object sender, EventArgs e)
        {
            
            this.customersTableAdapter.Fill(this.inventorySystemDataSet.Customers);

        }

        private void customersDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (customersDataGridView.Columns[e.ColumnIndex].Name == "Delete")
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this customer?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    var currentRow = (DataRowView)customersDataGridView.Rows[e.RowIndex].DataBoundItem;
                    int id = (int)currentRow["customerID"];

                    deleteRecords obj = new deleteRecords();
                    obj.deleteCustomer(id);

                    customersBindingSource.RemoveCurrent();
                }
            }
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            AddCustomer frm = new AddCustomer();
            frm.Show();
        }

        //search bar logic
        private void txtSearchCustomers_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtSearchCustomers.Text.ToLower();

            if (string.IsNullOrEmpty(searchText))
            {
                customersBindingSource.RemoveFilter();
            }
            else
            {
                customersBindingSource.Filter = $"name LIKE '*{searchText}*'";
            }
        }
    }
}

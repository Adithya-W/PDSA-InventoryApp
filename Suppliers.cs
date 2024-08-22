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
    public partial class Suppliers : Form
    {
        public Suppliers()
        {
            InitializeComponent();
        }

        private void Suppliers_Load(object sender, EventArgs e)
        {
            this.suppliersTableAdapter.Fill(this.inventorySystemDataSet.Suppliers);
        }

        private void suppliersDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (suppliersDataGridView.Columns[e.ColumnIndex].Name == "Delete")
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this supplier?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    var currentRow = (DataRowView)suppliersDataGridView.Rows[e.RowIndex].DataBoundItem;
                    int id = (int)currentRow["supplierID"];

                    deleteRecords obj = new deleteRecords();
                    obj.deleteSupplier(id);

                    suppliersBindingSource.RemoveCurrent();
                }
            }
        }

        private void btnAddSupplier_Click(object sender, EventArgs e)
        {
            AddSupplier frm = new AddSupplier();
            frm.Show();
        }

        //search bar logic
        private void txtSearchSuppliers_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtSearchSuppliers.Text.ToLower();

            if (string.IsNullOrEmpty(searchText))
            {
                suppliersBindingSource.RemoveFilter();
            }
            else
            {
                suppliersBindingSource.Filter = $"name LIKE '*{searchText}*'";
            }
        }
    }
}

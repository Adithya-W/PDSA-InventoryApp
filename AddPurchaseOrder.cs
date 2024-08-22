using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
    public partial class AddPurchaseOrder : Form
    {
        public AddPurchaseOrder()
        {
            InitializeComponent();
        }

        private void btnSavePOrder_Click(object sender, EventArgs e)
        {
            int SID = Convert.ToInt32(txtSupplierID.Text.Trim());
            int IID = Convert.ToInt32(txtPItemID.Text.Trim());
            int quantity = Convert.ToInt32(txtPQuantity.Text.Trim());
            DateTime date = dtpPurchaseOrder.Value.Date;


            try
            {
                Connect c = new Connect();
                SqlConnection con = c.GetConnection();

                if (con.State == System.Data.ConnectionState.Closed)
                {
                    con.Open();
                }

                SqlCommand cmd = new SqlCommand("insert into PurchaseOrders (supplierID,itemID,pQuantity,pDate) values (@SID,@IID,@quantity,@date)", con);

                cmd.Parameters.AddWithValue("@SID", SID);
                cmd.Parameters.AddWithValue("@IID", IID);
                cmd.Parameters.AddWithValue("@quantity", quantity);
                cmd.Parameters.AddWithValue("@date", date);

                int result = cmd.ExecuteNonQuery();
                con.Close();

                if (result > 0)
                {
                    MessageBox.Show("Record added successfully", "Add New Purchase Order", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show("Something went wrong, try again later", "Add New Purchase Order", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                throw new Exception("Error" + ex.Message);
            }
        }

        private void btnClearPOrder_Click(object sender, EventArgs e)
        {
            txtSupplierID.Clear();
            txtPItemID.Clear();
            txtPQuantity.Clear();
        }
    }
}

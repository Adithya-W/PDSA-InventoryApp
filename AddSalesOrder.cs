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
    public partial class AddSalesOrder : Form
    {
        public AddSalesOrder()
        {
            InitializeComponent();
        }

        private void btnSaveSOrder_Click(object sender, EventArgs e)
        {
            int CID = Convert.ToInt32(txtCustomerID.Text.Trim());
            int IID = Convert.ToInt32(txtSItemID.Text.Trim());
            int quantity = Convert.ToInt32(txtSQuantity.Text.Trim());
            DateTime date = dtpSalesOrder.Value.Date;


            try
            {
                Connect c = new Connect();
                SqlConnection con = c.GetConnection();

                if (con.State == System.Data.ConnectionState.Closed)
                {
                    con.Open();
                }

                SqlCommand cmd = new SqlCommand("insert into PurchaseOrders (customerID,itemID,sQuantity,sDate) values (@CID,@IID,@quantity,@date)", con);

                cmd.Parameters.AddWithValue("@CID", CID);
                cmd.Parameters.AddWithValue("@IID", IID);
                cmd.Parameters.AddWithValue("@quantity", quantity);
                cmd.Parameters.AddWithValue("@date", date);

                int result = cmd.ExecuteNonQuery();
                con.Close();

                if (result > 0)
                {
                    MessageBox.Show("Record added successfully", "Add New Sales Order", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show("Something went wrong, try again later", "Add New Sales Order", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                throw new Exception("Error" + ex.Message);
            }
        }

        private void btnClearSOrder_Click(object sender, EventArgs e)
        {
            txtCustomerID.Clear();
            txtSItemID.Clear();
            txtSQuantity.Clear();
        }
    }
}

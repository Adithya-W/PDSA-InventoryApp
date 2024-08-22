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
    public partial class AddSupplier : Form
    {
        public AddSupplier()
        {
            InitializeComponent();
        }

        private void btnSaveSupplier_Click(object sender, EventArgs e)
        {
            String name = txtSupplierName.Text.Trim();
            String phone = txtSPhone.Text.Trim();
            String email = txtSEmail.Text.Trim();
            String address = txtSAddress.Text.Trim();


            try
            {
                Connect c = new Connect();
                SqlConnection con = c.GetConnection();

                if (con.State == System.Data.ConnectionState.Closed)
                {
                    con.Open();
                }

                SqlCommand cmd = new SqlCommand("insert into Suppliers (name,phone,address,email) values (@name,@phone,@address,@email)", con);

                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@phone", phone);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@address", address);

                int result = cmd.ExecuteNonQuery();
                con.Close();

                if (result > 0)
                {
                    MessageBox.Show("Record added successfully", "Add New Supplier", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show("Something went wrong, try again later", "Add New Supplier", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                throw new Exception("Error" + ex.Message);
            }
        }

        private void btnClearSupplier_Click(object sender, EventArgs e)
        {
            txtSupplierName.Clear();
            txtSAddress.Clear();
            txtSEmail.Clear();
            txtSPhone.Clear();
        }
    }
}

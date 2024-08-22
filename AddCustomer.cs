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
    public partial class AddCustomer : Form
    {
        public AddCustomer()
        {
            InitializeComponent();
        }

        private void btnSaveCustomer_Click(object sender, EventArgs e)
        {
            String name = txtCustomerName.Text.Trim();
            String phone = txtCPhone.Text.Trim();
            String email = txtCEmail.Text.Trim();
            String address = txtCAddress.Text.Trim();
            

            try
            {
                Connect c = new Connect();
                SqlConnection con = c.GetConnection();

                if (con.State == System.Data.ConnectionState.Closed)
                {
                    con.Open();
                }

                SqlCommand cmd = new SqlCommand("insert into Customers (name,phone,address,email) values (@name,@phone,@address,@email)", con);

                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@phone", phone);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@address", address);

                int result = cmd.ExecuteNonQuery();
                con.Close();

                if (result > 0)
                {
                    MessageBox.Show("Record added successfully", "Add New Customer", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show("Something went wrong, try again later", "Add New Customer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                throw new Exception("Error" + ex.Message);
            }

        }

        private void btnClearCustomer_Click(object sender, EventArgs e)
        {
            txtCustomerName.Clear();
            txtCAddress.Clear();
            txtCEmail.Clear();
            txtCPhone.Clear();
        }
    }
}

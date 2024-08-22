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
    public partial class AddItem : Form
    {
        public AddItem()
        {
            InitializeComponent();
        }

        private void btnSaveItem_Click(object sender, EventArgs e)
        {
            String name = txtItemName.Text.Trim();
            int quantity = Convert.ToInt32(txtQuantity.Text.Trim());
            float Pprice = Convert.ToSingle(txtPurchasePrice.Text.Trim());
            float Sprice = Convert.ToSingle(txtSalePrice.Text.Trim());



            try
            {
                Connect c = new Connect();
                SqlConnection con = c.GetConnection();

                if (con.State == System.Data.ConnectionState.Closed)
                {
                    con.Open();
                }

                SqlCommand cmd = new SqlCommand("insert into Inventory (name,quantity,purchasePrice,salePrice) values (@name,@quantity,@Pprice,@Sprice)", con);

                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@quantity", quantity);
                cmd.Parameters.AddWithValue("@Pprice", Pprice);
                cmd.Parameters.AddWithValue("@Sprice", Sprice);

                int result = cmd.ExecuteNonQuery();
                con.Close();

                if (result > 0)
                {
                    MessageBox.Show("Record added successfully", "Add New Item", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show("Something went wrong, try again later", "Add New Item", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                throw new Exception("Error" + ex.Message);
            }
        }

        private void btnClearItem_Click(object sender, EventArgs e)
        {
            txtItemName.Clear();
            txtQuantity.Clear();
            txtPurchasePrice.Clear();
            txtSalePrice.Clear();
        }
    }
}

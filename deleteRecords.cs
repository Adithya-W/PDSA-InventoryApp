using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
    internal class deleteRecords
    {
        public void deleteItem(int id)
        {
            try
            {
                Connect c = new Connect();
                SqlConnection con = c.GetConnection();

                if (con.State == System.Data.ConnectionState.Closed)
                {
                    con.Open();
                }

                SqlCommand cmd = new SqlCommand("delete from Inventory where itemID=@id", con);

                cmd.Parameters.AddWithValue("@id", id);
                int result = cmd.ExecuteNonQuery();

                con.Close();

                if (result > 0)
                {
                    MessageBox.Show("Record deleted successfully", "Delete Item", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show("Something went wrong, please try again later", "Delete Item", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(Exception ex)
            {
                throw new Exception ("Error" + ex.Message);
            }
        }

        public void deleteCustomer(int id)
        {
            try
            {
                Connect c = new Connect();
                SqlConnection con = c.GetConnection();

                if (con.State == System.Data.ConnectionState.Closed)
                {
                    con.Open();
                }

                SqlCommand cmd = new SqlCommand("delete from Customers where customerID=@id", con);

                cmd.Parameters.AddWithValue("@id", id);
                int result = cmd.ExecuteNonQuery();

                con.Close();

                if (result > 0)
                {
                    MessageBox.Show("Record deleted successfully", "Delete Item", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show("Something went wrong, please try again later", "Delete Item", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error" + ex.Message); 
            }
        }

        public void deletePurchase(int id)
        {
            try
            {
                Connect c = new Connect();
                SqlConnection con = c.GetConnection();

                if (con.State == System.Data.ConnectionState.Closed)
                {
                    con.Open();
                }

                SqlCommand cmd = new SqlCommand("delete from PurchaseOrders where pOrderID=@id", con);

                cmd.Parameters.AddWithValue("@id", id);
                int result = cmd.ExecuteNonQuery();

                con.Close();

                if (result > 0)
                {
                    MessageBox.Show("Record deleted successfully", "Delete Item", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show("Something went wrong, please try again later", "Delete Item", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error" + ex.Message);
            }
        }

        public void deleteSale(int id)
        {
            try
            {
                Connect c = new Connect();
                SqlConnection con = c.GetConnection();

                if (con.State == System.Data.ConnectionState.Closed)
                {
                    con.Open();
                }

                SqlCommand cmd = new SqlCommand("delete from SalesOrders where sOrderID=@id", con);

                cmd.Parameters.AddWithValue("@id", id);
                int result = cmd.ExecuteNonQuery();

                con.Close();

                if (result > 0)
                {
                    MessageBox.Show("Record deleted successfully", "Delete Item", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show("Something went wrong, please try again later", "Delete Item", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error" + ex.Message);
            }
        }

        public void deleteSupplier(int id)
        {
            try
            {
                Connect c = new Connect();
                SqlConnection con = c.GetConnection();

                if (con.State == System.Data.ConnectionState.Closed)
                {
                    con.Open();
                }

                SqlCommand cmd = new SqlCommand("delete from Suppliers where supplierID=@id", con);

                cmd.Parameters.AddWithValue("@id", id);
                int result = cmd.ExecuteNonQuery();

                con.Close();

                if (result > 0)
                {
                    MessageBox.Show("Record deleted successfully", "Delete Item", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show("Something went wrong, please try again later", "Delete Item", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error" + ex.Message);
            }
        }
    }
}

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
    public partial class Inventory : Form
    {
        public Inventory()
        {
            InitializeComponent();
        }

        private void inventoryBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.inventoryBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.inventorySystemDataSet);

        }

        private void Inventory_Load(object sender, EventArgs e)
        {
            try
            {
                this.inventoryTableAdapter.Fill(this.inventorySystemDataSet.Inventory);
            }
            catch (Exception ex)
            {
                
                MessageBox.Show("Error Occured: " + ex.Message);
            }
   
            cmbSortInventory.Items.Add("Sale Price (Highest)"); 
            cmbSortInventory.Items.Add("Sale Price (Lowest)");
            cmbSortInventory.Items.Add("Purchase Price (Highest)");
            cmbSortInventory.Items.Add("Purchase Price (Lowest)");
            cmbSortInventory.Items.Add("Name(A-Z)");
            cmbSortInventory.Items.Add("Name(Z-A)");
            cmbSortInventory.SelectedIndex = 0;

        }

        private void inventoryDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (inventoryDataGridView.Columns[e.ColumnIndex].Name == "Delete") 
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this item?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    var currentRow = (DataRowView)inventoryDataGridView.Rows[e.RowIndex].DataBoundItem;
                    int id = (int)currentRow["itemID"];

                    deleteRecords obj = new deleteRecords();
                    obj.deleteItem(id); 

                    inventoryBindingSource.RemoveCurrent();
                }
            }

        }

        //add item button logic
        private void btnAddItem_Click(object sender, EventArgs e)
        {
            AddItem frm = new AddItem();
            frm.Show();
        }

        //combo box logic
        private void cmbSortInventory_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedOption = cmbSortInventory.SelectedItem.ToString(); 

            List<Item> items = getItemList();

            List<Item> sortedItems = new List<Item>();

            if (selectedOption == "Name (A-Z)")
            {
                sortedItems = sortItemsByNameAscending(items);
            }
            else if (selectedOption == "Name (Z-A)")
            {
                sortedItems = sortItemsByNameDescending(items);
            }
            else if (selectedOption == "Sale Price (Highest)")
            {
                sortedItems = sortItemsBySalePriceDescending(items);
            }
            else if (selectedOption == "Sale Price (Lowest)")
            {
                sortedItems = sortItemsBySalePriceAscending(items);
            }
            else if (selectedOption == "Purchase Price (Lowest)")
            {
                sortedItems = sortItemsByPurchasePriceAscending(items);
            }
            else if (selectedOption == "Purchase Price (Highest)")
            {
                sortedItems = sortItemsByPurchasePriceDescending(items);
            }

            SortedItemsMenu frm = new SortedItemsMenu();
            frm.LoadData(sortedItems);
            frm.Show();
        }


        private List<Item> getItemList()
        {
            /*retrieves data from database, uses get and set methods to store it in variables of Item class, 
            then creates a list of objects made from Item class*/
              
            List<Item> l1 = new List<Item>();

            try
            {
                Connect c = new Connect();
                SqlConnection con = c.GetConnection();

                if (con.State == System.Data.ConnectionState.Closed)
                {
                    con.Open();
                }

                string query = "SELECT itemID, name, quantity, purchasePrice, salePrice FROM Inventory"; 

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Item itm = new Item()
                            {
                                ID = reader.GetInt32(0),
                                name = reader.GetString(1),
                                quantity = reader.GetInt32(2),
                                Pprice = reader.GetInt32(3),
                                Sprice = reader.GetInt32(4)
                            };
                            l1.Add(itm);
                        }
                    }
                }

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: "+ ex.Message);
            }

            return l1;
        }

        //merge sort algorithmss to sort  names alphabetically
        private List<Item> sortItemsByNameAscending(List<Item> l1)
        {
            if (l1.Count <= 1)
                return l1;

            int mid = l1.Count / 2;
            List<Item> left = new List<Item>(l1.GetRange(0, mid));
            List<Item> right = new List<Item>(l1.GetRange(mid, l1.Count - mid));

            left = sortItemsByNameAscending(left);
            right = sortItemsByNameAscending(right);

            return Merge(left, right);
        }

        private List<Item> Merge(List<Item> left, List<Item> right)
        {
            int i = 0, j = 0;
            List<Item> mergedList = new List<Item>(left.Count + right.Count);

            while (i < left.Count && j < right.Count)
            {
                if (string.Compare(left[i].name, right[j].name, StringComparison.Ordinal) <= 0)
                {
                    mergedList.Add(left[i++]);
                }
                else
                {
                    mergedList.Add(right[j++]);
                }
            }

            while (i < left.Count)
            {
                mergedList.Add(left[i++]);
            }

            while (j < right.Count)
            {
                mergedList.Add(right[j++]);
            }

            return mergedList;
        }


        //to sort items in descending order
        private List<Item> sortItemsByNameDescending(List<Item> l1)
        {
            if (l1.Count <= 1)
                return l1;

            int mid = l1.Count / 2;
            List<Item> left = new List<Item>(l1.GetRange(0, mid));
            List<Item> right = new List<Item>(l1.GetRange(mid, l1.Count - mid));

            left = sortItemsByNameDescending(left);
            right = sortItemsByNameDescending(right);

            return MergeDescending(left, right);
        }

        private List<Item> MergeDescending(List<Item> left, List<Item> right)
        {
            int i = 0, j = 0;
            List<Item> mergedList = new List<Item>(left.Count + right.Count);

            while (i < left.Count && j < right.Count)
            {
                if (string.Compare(left[i].name, right[j].name, StringComparison.Ordinal) >= 0)
                {
                    mergedList.Add(left[i++]);
                }
                else
                {
                    mergedList.Add(right[j++]);
                }
            }

            while (i < left.Count)
            {
                mergedList.Add(left[i++]);
            }

            while (j < right.Count)
            {
                mergedList.Add(right[j++]);
            }

            return mergedList;
        }


        //bubble sort algorithms to sort by sale price
        private List<Item> sortItemsBySalePriceAscending(List<Item> items)
        {
            List<Item> sortedItems = new List<Item>(items); 

            int n = sortedItems.Count;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (sortedItems[j].Sprice > sortedItems[j + 1].Sprice)
                    {
                        Item temp = sortedItems[j];
                        sortedItems[j] = sortedItems[j + 1];
                        sortedItems[j + 1] = temp;
                    }
                }
            }

            return sortedItems;
        }

        //in descending order 
        private List<Item> sortItemsBySalePriceDescending(List<Item> items)
        {
            List<Item> sortedItems = new List<Item>(items); 

            int n = sortedItems.Count;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (sortedItems[j].Sprice < sortedItems[j + 1].Sprice)
                    {
                        Item temp = sortedItems[j];
                        sortedItems[j] = sortedItems[j + 1];
                        sortedItems[j + 1] = temp;
                    }
                }
            }

            return sortedItems;
        }


        //bubble sort to sort by purchase price 
        private List<Item> sortItemsByPurchasePriceAscending(List<Item> items)
        {
            List<Item> sortedItems = new List<Item>(items);

            int n = sortedItems.Count;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (sortedItems[j].Pprice > sortedItems[j + 1].Pprice)
                    {
                        Item temp = sortedItems[j];
                        sortedItems[j] = sortedItems[j + 1];
                        sortedItems[j + 1] = temp;
                    }
                }
            }

            return sortedItems;
        }

        //descending order
        private List<Item> sortItemsByPurchasePriceDescending(List<Item> items)
        {
            List<Item> sortedItems = new List<Item>(items);

            int n = sortedItems.Count;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (sortedItems[j].Pprice < sortedItems[j + 1].Pprice)
                    {
                        Item temp = sortedItems[j];
                        sortedItems[j] = sortedItems[j + 1];
                        sortedItems[j + 1] = temp;
                    }
                }
            }

            return sortedItems;
        }

        //search bar
        private void txtSearchInventory_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtSearchInventory.Text.ToLower();

            if (string.IsNullOrEmpty(searchText))
            {
                inventoryBindingSource.RemoveFilter();
            }
            else
            {
                inventoryBindingSource.Filter = $"name LIKE '*{searchText}*'";
            }
        }

        
    }

}

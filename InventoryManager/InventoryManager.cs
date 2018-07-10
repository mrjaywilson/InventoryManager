// Namespace Declaration
using System;
using System.Windows.Forms;

/*
 *      Program:        Milestone 4
 *      File:           FileManager.cs
 *      Description:    Handles file management.
 *      Author:         Jay Wilson
 *      Class:          CST-117
 *      Date:           July 7, 2018
 */

/// <summary>
/// Namespace Declaration
/// </summary>
namespace InventoryManager
{
    // Class Declaration
    public partial class InventoryManager : Form
    {
        /// <summary>
        /// Declare and initialize variables.
        /// </summary>
        FileManager fileManager;
        static Inventory inventory;
        public const int HT_CAPTION = 0x2;
        public const int WM_NCLBUTTONDOWN = 0xA1;

        // Set Attribute
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        // handler for moving the form with the mouse
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        // Set Attribute
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        // handler for moving the form with the mouse
        public static extern bool ReleaseCapture();

        /// <summary>
        /// Entry-point
        /// </summary>
        public InventoryManager()
        {
            // Initialize Components
            InitializeComponent();

            // Add Items to Inventory
            inventory = new Inventory();

            // Set up the columns for the Inventory List
            lvInventory.Columns[0].Width = 126;
            lvInventory.Columns[1].Width = 126;
            lvInventory.Columns[2].Width = 113;
            lvInventory.Columns[3].Width = 200;
            lvInventory.Columns[4].Width = 41;
            lvInventory.Columns[5].Width = 65;

            // Initialize the filemanager
            fileManager = new FileManager(inventory);

            // Fill the list with the inventory
            FillList(inventory);
        }

        /// <summary>
        /// View Current Inventory
        /// </summary>
        private void btnViewInventory_Click(object sender, EventArgs e)
        {
            // Fill the list with the inventory
            FillList(inventory);
        }

        /// <summary>
        /// Method to fill the inventory list with a given list of items
        /// </summary>
        /// <param name="inventoryList">List of items to fill the inventory view.</param>
        public void FillList(Inventory inventoryList)
        {
            // If the inventory list is full...
            if (lvInventory.Items.Count > 0)
            {
                // Go ahead and clear the list
                lvInventory.Items.Clear();
            }

            // Iterate through the list
            foreach (Item item in inventoryList)
            {
                // Add each inventory item to the list
                lvInventory.Items.Add(new ListViewItem(new string[]
                {
                    item.department.ToString(),
                    item.name.ToString(),
                    item.sku.ToString(),
                    item.description.ToString(),
                    item.count.ToString(),
                    "$" + (item.price / 100.00).ToString()
                }));
            }
        }

        /// <summary>
        /// Button to exit the application
        /// </summary>
        private void btnExit_Click(object sender, EventArgs e)
        {
            // Exit the application
            Application.Exit();
        }

        /// <summary>
        /// Button to add new item to inventory
        /// </summary>
        private void btnNewItem_Click(object sender, EventArgs e)
        {
            // Declare and initialize form
            NewItem newItem = new NewItem(inventory, this);

            // Show the form
            newItem.ShowDialog(this);
        }

        /// <summary>
        /// Button to search for given terms
        /// </summary>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            // Declare and initialize object
            Inventory searchResults = new Inventory();

            // Declare and initilize enum search type
            Inventory.SearchType searchType = Inventory.SearchType.Name;

            // Check each radio button to decide what to do
            if (rbByName.Checked == true)
            {
                // Search by name...
                searchType = Inventory.SearchType.Name;
            }
            else if (rbByDescription.Checked == true)
            {
                // Search by Description
                searchType = Inventory.SearchType.Description;
            }
            else if (rbByDepartment.Checked == true)
            {
                // Search by Department
                searchType = Inventory.SearchType.Department;
            }
            else if (rbBySku.Checked == true)
            {
                // Search by SKU
                long.TryParse(txtSearch.Text, out long sku);

                try
                {
                    // Fill the list with the results
                    FillList(inventory.FindItemBySKU(sku));
                } catch
                {
                    // Let the user know the SKU was not found
                    MessageBox.Show(this, "SKU not found!");
                }
                return;
            }

            // Fill the list with the results
            FillList(inventory.FindItemsBySearchType(txtSearch.Text, searchType));
        }

        /// <summary>
        /// Button to remove an item from the inventory
        /// </summary>
        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
            // if there is no item selected
            if (lvInventory.SelectedIndices == null || lvInventory.SelectedIndices.Count == 0)
            {
                // Let the user know they need to select an item
                MessageBox.Show(this, "No item selected. Please select and item from list to remove it from inventory.");
            }
            else
            {
                // Ask the user if htey are sure they want to permanently remove the item
                DialogResult result = MessageBox.Show(this, "Are you sure you want to permanently remove the selected item?", "Warning", MessageBoxButtons.YesNo);

                // If the user reports 'yes'...
                if (result == DialogResult.Yes)
                {
                    // Get the SKU number from the list
                    long.TryParse(lvInventory.SelectedItems[0].SubItems[2].ToString().Substring(
                        18, lvInventory.SelectedItems[0].SubItems[2].ToString().Length - 19), out long sku);

                    // Remove the item from the inventory
                    inventory.RemoveItem(inventory.IndexOf(sku));

                    // Refresh the list
                    FillList(inventory);
                }
                else
                {
                    // Otherwise, let the user no item has been removed
                    MessageBox.Show(this, "No item removed.");
                }
            }
        }

        /// <summary>
        /// Button to edit the selected item
        /// </summary>
        private void btnEditItem_Click(object sender, EventArgs e)
        {
            // if there is no item selected
            if (lvInventory.SelectedIndices == null || lvInventory.SelectedIndices.Count == 0)
            {
                // Let the user know they need to select an item to continue
                MessageBox.Show(this, "You must select an item before you can do that.");
                return;
            }

            // Get the SKU number from the item list
            long.TryParse(lvInventory.SelectedItems[0].SubItems[2].ToString().Substring(
                18, lvInventory.SelectedItems[0].SubItems[2].ToString().Length - 19), out long sku);

            // If there is something wrong with the SKU...
            if (sku == 0)
            {
                // Let the user know.
                MessageBox.Show(this, "There is soemthing wrong with the SKU, please check your selection and try again.");
            }

            // Create a new editItem object
            EditItem editItem = new EditItem(inventory, sku);

            // Show the form as a child of the main form
            editItem.ShowDialog(this);
        }

        /// <summary>
        /// Button to save the inventory
        /// </summary>
        private void btnSaveInventory_Click(object sender, EventArgs e)
        {
            // As the user if they are sure they would like to save the data
            DialogResult result = MessageBox.Show(this, "Are you sure you want to save the data?", "Notice", MessageBoxButtons.OKCancel);

            // If the user reports they are sure...
            if (result == DialogResult.OK)
            {
                // Save the inventory
                fileManager.SaveInventory();
            }
            else
            {
                // Otherwise, let the user know the data was not saved
                MessageBox.Show(this, "Data not saved!");
            }
        }

        /// <summary>
        /// Button to Restock Items
        /// </summary>
        private void btnRestockItems_Click(object sender, EventArgs e)
        {
            // Declare and initialize the restock object
            RestockItem restockItem = new RestockItem(inventory, this);

            // Show the form as a child of the main form
            restockItem.ShowDialog(this);
        }

        /// <summary>
        /// Within this region, window movement is handled since there are no
        /// window borders.
        /// </summary>
        #region Mouse Events to move the form around
        private void InventoryManager_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void lblTitle_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }

        }
        #endregion
    }
}

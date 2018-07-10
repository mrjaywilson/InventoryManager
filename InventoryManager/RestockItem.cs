// Namespace Declarations
using System.Windows.Forms;

/*
 *      Program:        Milestone 4
 *      File:           NewItem.cs
 *      Description:    Handles newItem form.
 *      Author:         Jay Wilson
 *      Class:          CST-117
 *      Date:           July 7, 2018
 */

/// <summary>
/// Namespace Declaration
/// </summary>
namespace InventoryManager
{
    /// <summary>
    /// Class Declaration
    /// </summary>
    public partial class RestockItem : Form
    {
        /// <summary>
        /// Declare private variables
        /// </summary>
        private Inventory _inventory;
        private InventoryManager _inventoryManager;

        /// <summary>
        /// Declare and initialize inventory object for restock
        /// </summary>
        private Inventory _restockInventory = new Inventory();

        /// <summary>
        /// Entrypoint for restock form object
        /// </summary>
        /// <param name="inventory">Inventory Reference.</param>
        /// <param name="inventoryManager">Inventory Management reference.</param>
        public RestockItem(Inventory inventory, InventoryManager inventoryManager)
        {
            // Initialize form components
            InitializeComponent();

            // Initialize references
            _inventory = inventory;
            _inventoryManager = inventoryManager;

            // Setup the columns of the list
            lvItemList.Columns[0].Width = 123;
            lvItemList.Columns[1].Width = 77;
            lvItemList.Columns[2].Width = 68;

            // Fill the list with the inventory
            FillItemList(_inventory);
        }

        /// <summary>
        /// Method to fill the inventory list with a given list of items
        /// </summary>
        /// <param name="inventoryList">List of items to fill the inventory view.</param>
        public void FillItemList(Inventory inventoryList)
        {
            // Iterate through the list
            foreach (Item item in inventoryList)
            {
                // Add each inventory item to the list
                lvItemList.Items.Add(new ListViewItem(new string[]
                {
                    item.name.ToString(),
                    item.sku.ToString(),
                    item.count.ToString()
                }));
            }
        }

        /// <summary>
        /// Method to fill the restock list with give nlist of items
        /// </summary>
        /// <param name="inventoryList"></param>
        public void FillRestockList(Inventory inventoryList)
        {
            // Iterate through the list
            foreach (Item item in inventoryList)
            {
                // Add each inventory item to the list
                lvRestockList.Items.Add(new ListViewItem(new string[]
                {
                    item.name.ToString(),
                    item.sku.ToString(),
                    item.count.ToString()
                }));
            }
        }

        /// <summary>
        /// Button to restock items.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRestock_Click(object sender, System.EventArgs e)
        {
            // In the qty is blank...
            if (txtQty.Text == "")
            {
                // Let the use know they must set the qty first.
                MessageBox.Show(this, "QTY must be set first.");
                return;
            }

            // If the Item list is not selected
            if (lvItemList.SelectedIndices == null || lvItemList.SelectedIndices.Count == 0)
            {
                // Let hte use know they need to select an item to continue
                MessageBox.Show(this, "You must select an item before you can do that.");
                return;
            }

            // Get the SKU from the list
            long.TryParse(lvItemList.SelectedItems[0].SubItems[1].ToString().Substring(
                18, lvItemList.SelectedItems[0].SubItems[1].ToString().Length - 19), out long sku);

            // Get the quantity from the textbox
            int.TryParse(txtQty.Text, out int qty);

            // If the SKU is 0
            if (sku == 0)
            {
                // Let the user know there s an issue with the SKU
                MessageBox.Show(this, "SKU number is not right, please recheck selection and try again.");
                return;
            }

            // If the QTY is 0...
            if (qty == 0)
            {
                // Let the user know the QTY cannot be zero
                MessageBox.Show(this, "Quantity cannot be 0.");
            }

            // Iterate through each item in the restock inventory list
            foreach (Item item in _restockInventory)
            {
                // If the SKU matches one...
                if (item.sku == sku)
                {
                    // Let the user know they can't add the same item to the list.
                    MessageBox.Show(this, "Item already exists in restock list.");
                    return;
                }
            }

            // Iterate through the invnetory
            foreach (Item item in _inventory)
            {
                // If the SKU matches a SKU...
                if (item.sku == sku)
                {
                    // Get a copy of hte item...
                    Item newItem = item.Copy();

                    // Add the copy to the restock Inventory
                    _restockInventory.AddItem(newItem);

                    // Change the quantity of that item
                    _restockInventory.GetItem(_restockInventory.IndexOf(sku)).count = qty;

                    // Clear the restock list
                    lvRestockList.Items.Clear();

                    // Fill the restock list with updated restock inventory
                    FillRestockList(_restockInventory);
                    return;
                }
            }
        }

        /// <summary>
        /// Button to remove an item from the restock onventory
        /// </summary>
        private void btnRemoveItem_Click(object sender, System.EventArgs e)
        {
            // If the user has not selected an item yet...
            if (lvItemList.SelectedIndices == null || lvItemList.SelectedIndices.Count == 0)
            {
                // Let the user know they need to select an item from the restock list to remove
                MessageBox.Show(this, "You must select an item before you can do that.");
                return;
            }

            // Get the SKU number
            long.TryParse(lvItemList.SelectedItems[0].SubItems[1].ToString().Substring(
                18, lvItemList.SelectedItems[0].SubItems[1].ToString().Length - 19), out long sku);

            // If the SKU is 0
            if (sku == 0)
            {
                // Let the user know to check selection
                MessageBox.Show(this, "SKU number is not right, please recheck selection and try again.");
                return;
            }

            // iterate through the restock inventory
            foreach (Item item in _restockInventory)
            {
                // If an item number matches a SKU...
                if (item.sku == sku)
                {
                    // Remove that specific item
                    _restockInventory.RemoveItem(_restockInventory.IndexOf(sku));

                    // Clear the listview
                    lvRestockList.Items.Clear();

                    // Refresh the listview
                    FillRestockList(_restockInventory);
                    return;
                }
            }

        }

        /// <summary>
        /// Button to cancel restock.
        /// </summary>
        private void btnCancel_Click(object sender, System.EventArgs e)
        {
            // Close the form
            Dispose();
        }

        /// <summary>
        /// Button to complete the restock
        /// </summary>
        private void btnComplete_Click(object sender, System.EventArgs e)
        {
            // Make sure the user wants to update the item quantities
            DialogResult result = MessageBox.Show(this, "Are you sure you want to generate the purchase order now?", "Notice", MessageBoxButtons.YesNo);

            // If no...
            if (result == DialogResult.No)
            {
                return;
            }

            GeneratePurchaseOrder generatePurchaseOrder = new GeneratePurchaseOrder();

            generatePurchaseOrder.GeneratePO(_restockInventory);

            //// Iterate through the inventory
            //foreach (Item iventoryItem in _inventory)
            //{
            //    // Iterate through the restock inventory
            //    foreach (Item restockItem in _restockInventory)
            //    {
            //        // If the restock sku matches one in the inventory...
            //        if (restockItem.sku == iventoryItem.sku)
            //        {
            //            // Update the quantity                           
            //            iventoryItem.count += restockItem.count;
            //        }
            //    }
            //}

            //// Let the user know the items were updated
            //MessageBox.Show(this, "All items updated!", "Notice");

            //// refresh the Inventory Manager
            //_inventoryManager.FillList(_inventory);

            // Close the form.
            Dispose();
        }
    }
}
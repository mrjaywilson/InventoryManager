// Namespace Declaration
using System;
using System.Collections.Generic;
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
    public partial class NewItem : Form
    {
        /// <summary>
        /// Declare and initialize private variables
        /// </summary>
        private Inventory _inventory;
        private InventoryManager _inventoryManager;

        // Declare and intialize department object
        Departments departments = new Departments();

        /// <summary>
        /// Constructor, entrypoint of NewItem form
        /// </summary>
        /// <param name="inventory">Inventory reference.</param>
        /// <param name="inventoryManager">Inventory Manager reference.</param>
        public NewItem(Inventory inventory, InventoryManager inventoryManager)
        {
            // Initialize form components
            InitializeComponent();

            // Set up the references
            _inventory = inventory;
            _inventoryManager = inventoryManager;

            // Populate the Departments combobox
            PopulateDepartments();
        }

        /// <summary>
        /// Button to cancel adding an item to the inventory
        /// </summary>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            // Dispose of the form
            Dispose();
        }

        /// <summary>
        /// Method to check if the form is complete
        /// </summary>
        private bool IsFormComplete()
        {
            // Check all the fields...
            if (cmbDepartment.SelectedIndex != -1 &&
                txtDescription.Text != "" &&
                txtName.Text != "" &&
                txtPrice.Text != "" &&
                txtQty.Text != "" &&
                txtSku.Text != "")
            {
                // If all good, return true.
                return true;
            }

            // Otherwise, false
            return false;
        }

        /// <summary>
        /// Button to add item to the inventory
        /// </summary>
        private void btnAddItem_Click(object sender, EventArgs e)
        {
            // Check if the form is complete, and if it is...
            if (IsFormComplete())
            {
                // Get from the textboxes the qty, SKU, and price
                int.TryParse(txtQty.Text, out int qty);
                long.TryParse(txtSku.Text, out long sku);
                double.TryParse(txtPrice.Text, out double price);

                // If the price does greater than 0...
                if (price > 0)
                {
                    // Add the new inventory item with the fields
                    _inventory.AddItem(new Item(cmbDepartment.Items[cmbDepartment.SelectedIndex].ToString(), txtName.Text, sku, txtDescription.Text, qty, (int)(price * 100)));
                }

                // Refresh the lsit in the main form
                _inventoryManager.FillList(_inventory);

                // Close this form
                Dispose();
            }
            else
            {
                // Let the user know their entry is incomplete
                MessageBox.Show(this, "Form Incomplete!");
            }
        }

        /// <summary>
        /// Event to watch for combobox change
        /// </summary>
        private void cmbDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Iterate through the departments
            foreach (KeyValuePair<int, string> kvp in departments.DepartmentList)
            {
                // If the value equals the selected item...
                if (kvp.Value == cmbDepartment.SelectedItem.ToString())
                {
                    // Set the department number
                    txtDepartmentNumber.Text = kvp.Key.ToString();
                }
            }
        }

        /// <summary>
        /// Button to assign a SKU number.
        /// </summary>
        private void btnAssignSku_Click(object sender, EventArgs e)
        {
            // Declare and initialize new stockKeeper object
            StockKeeper stock = new StockKeeper();

            // Attempt to get department number from textbox
            int.TryParse(txtDepartmentNumber.Text, out int departmentNumber);

            // If the department number doesn't equal 0
            if (departmentNumber != 0)
            {
                // Generate new SKU and place in textbox
                txtSku.Text = stock.GenerateSKU(departmentNumber, _inventory).ToString();
            }
            else
            {
                // Let user know how to fix issue.
                MessageBox.Show(this, "Please select correct department number.");
            }
        }

        /// <summary>
        /// Method to populate the department
        /// </summary>
        private void PopulateDepartments()
        {
            // Iterate through the department list
            foreach (KeyValuePair<int, string> kvp in departments.DepartmentList)
            {
                // Add the items to the combolist
                cmbDepartment.Items.Add(kvp.Value);
            }
        }
    }
}

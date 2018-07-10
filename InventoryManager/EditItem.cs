using System;
using System.Collections.Generic;
using System.Windows.Forms;

/*
 *      Program:        Milestone 4
 *      File:           EditItem.cs
 *      Description:    Handles the form that edits items.
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
    public partial class EditItem : Form
    {
        /// <summary>
        /// Declare variables and objects
        /// </summary>
        private long _sku;
        private Inventory _inventory;
        private int comboIndex;

        /// <summary>
        /// Declare and intialize department list
        /// </summary>
        Departments departments = new Departments();

        /// <summary>
        /// Edit Item form object.
        /// </summary>
        /// <param name="inventory">Reference to inventory list.</param>
        /// <param name="sku">Sku number to handle which item to edit.</param>
        public EditItem(Inventory inventory, long sku)
        {
            // Initialize components on the form
            InitializeComponent();

            // Setup the reference to the inventory and value to sku
            _inventory = inventory;
            _sku = sku;

            // Populate the combolist with departments
            PopulateDepartments();

            // Populate the rest of the fields with the information from the item
            // that is currently being edited.
            populateFields();
        }

        /// <summary>
        /// Button to cancel editing the items.
        /// </summary>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            // Let user know information may be lost if form is cancelled
            DialogResult result = MessageBox.Show(this, "Warning: Any changes you made will be lost!\n\nAre you sure you want to cancel editing this item?", "WARNING", MessageBoxButtons.YesNo);

            // If the user does cancel...
            if (result == DialogResult.Yes)
            {
                // Dispose of the edit Form
                Dispose();
            }
        }

        /// <summary>
        /// Method to populate the fields
        /// </summary>
        private void populateFields()
        {
            // Iterate through the combolist
            for (int i = 0; i < cmbDepartment.Items.Count; i++)
            {
                // if the department is found...
                if (cmbDepartment.Items[i].ToString().Equals(_inventory.GetItem(_inventory.IndexOf(_sku)).department.ToString()))
                {
                    // assign the selected index
                    cmbDepartment.SelectedIndex = i;

                    // Iterate through the department list
                    foreach (KeyValuePair<int, string> kvp in departments.DepartmentList)
                    {
                        // If the department name matches...
                        if (kvp.Value.Equals(cmbDepartment.Items[i].ToString()))
                        {
                            // Set the department field to the correct department number
                            txtDepartmentNumber.Text = kvp.Key.ToString();
                        }
                    }
                }
            }

            // set comboindex to the selected index
            comboIndex = cmbDepartment.SelectedIndex;

            // Set the other fields to the correct values
            txtDescription.Text = _inventory.GetItem(_inventory.IndexOf(_sku)).description;
            txtName.Text = _inventory.GetItem(_inventory.IndexOf(_sku)).name;
            txtPrice.Text = (_inventory.GetItem(_inventory.IndexOf(_sku)).price / 100.00).ToString();
            txtQty.Text = _inventory.GetItem(_inventory.IndexOf(_sku)).count.ToString();
            txtSku.Text = _inventory.GetItem(_inventory.IndexOf(_sku)).sku.ToString();
        }

        /// <summary>
        /// Button to save the edits to the item.
        /// </summary>
        private void btnSave_Click(object sender, EventArgs e)
        {
            // As the user if they are sure they want to save the edits
            DialogResult result = MessageBox.Show(this, "Are you sure you want to save the item modifications? Once saved, it cannot be undone.", "Warning", MessageBoxButtons.OKCancel);

            // If yes...
            if (result == DialogResult.OK)
            {
                try
                {
                    // Set the description of the item to the textbox text
                    _inventory.GetItem(_inventory.IndexOf(_sku)).description = txtDescription.Text;

                    // Set the name of the item to the textbox text
                    _inventory.GetItem(_inventory.IndexOf(_sku)).name = txtName.Text;

                    // Get the price from the textbox
                    double.TryParse(txtPrice.Text, out double price);

                    // Get the count from the textbox
                    int.TryParse(txtQty.Text, out int count);

                    // Get the SKU from the textbox
                    long.TryParse(txtSku.Text, out long sku);

                    // If the price, count, or sku are 0
                    if (price == 0 || count == 0 || sku == 0)
                    {
                        // let the user know there is a problem
                        MessageBox.Show(this, "There seems to be a problem with one of the fields. Please verify the values and try again, or click CANCEL to stop the modification.");
                        return;
                    }

                    // Set the price, count(qty), and sku
                    _inventory.GetItem(_inventory.IndexOf(_sku)).price = (int)(price * 100);
                    _inventory.GetItem(_inventory.IndexOf(_sku)).count = count;
                    _inventory.GetItem(_inventory.IndexOf(_sku)).sku = sku;

                    // Close the form
                    Dispose();
                }
                catch (Exception ex)
                {
                    // For any issues, show the messagebox
                    MessageBox.Show(this, "An error occurred, could not save the file.\n\n" + ex.Message);
                }
            }
        }

        /// <summary>
        /// method to populate the department field
        /// </summary>
        private void PopulateDepartments()
        {
            // Go through each value...
            foreach (KeyValuePair<int, string> kvp in departments.DepartmentList)
            {
                // Add each one to the combobox
                cmbDepartment.Items.Add(kvp.Value);
            }
        }

        /// <summary>
        /// Event if the user tries to change the department name
        /// </summary>
        private void cmbDepartment_SelectionChangeCommitted(object sender, EventArgs e)
        {
            // If the combo box changes and does not match the original index number...
            if (cmbDepartment.SelectedIndex != comboIndex)
            {
                // Let the user know that changing the box will change important information
                DialogResult result = MessageBox.Show(this, "You are about to change a value that will require updating the SKU assignment.\n\nAre you sure you want to continue?", "WARNING", MessageBoxButtons.OKCancel);

                // If they cancel...
                if (result == DialogResult.Cancel)
                {
                    // Set the index of the combobox back to origin
                    cmbDepartment.SelectedIndex = comboIndex;
                }
                // Otherwise...
                else if (result == DialogResult.OK)
                {
                    // Go through department list...
                    foreach (KeyValuePair<int, string> kvp in departments.DepartmentList)
                    {
                        // If the value equals the item string...
                        if (kvp.Value == cmbDepartment.SelectedItem.ToString())
                        {
                            // set the textbox to the new number
                            txtDepartmentNumber.Text = kvp.Key.ToString();
                        }
                    }

                    // Declare and initialize SKU object
                    StockKeeper stock = new StockKeeper();

                    // Get the department number
                    int.TryParse(txtDepartmentNumber.Text, out int departmentNumber);

                    // Generate a new SKU based on the new department chosen
                    txtSku.Text = (stock.GenerateSKU(departmentNumber, _inventory)).ToString();
                }
            }
        }
    }
}

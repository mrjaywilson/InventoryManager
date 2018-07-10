using System;
using System.IO;
using System.Collections.Generic;
using System.Reflection;
using System.Windows.Forms;
using Microsoft.Office.Interop.Word;

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
    /// <summary>
    /// Class Declaration
    /// </summary>
    class FileManager
    {
        /// <summary>
        /// Declare variables
        /// </summary>
        readonly string fileString = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "data.csv");
        private Inventory _inventory;

        /// <summary>
        /// Declare members
        /// </summary>
        public string FileName { get; set; }
        public string[] FileContents { get; set; }

        /// <summary>
        /// Empty Constructor for general useage
        /// </summary>
        public FileManager()
        {
            // Empty
        }

        /// <summary>
        /// Constructor
        /// </summary>
        public FileManager (Inventory inventory)
        {
            // Set the inventory
            _inventory = inventory;

            // Get the inventory
            GetInventory(fileString);
        }

        /// <summary>
        /// Method to get the inventory
        /// </summary>
        /// <param name="fileString">String to the file.</param>
        public void GetInventory(string fileString)
        {
            try
            {
                // Get all lines from the data file and put in array of strings
                FileContents = File.ReadAllLines(fileString);

                // Iterate through the contents of the file...
                foreach (string item in FileContents)
                {
                    // Each of the strings by comma
                    string[] splitString = item.Split(',');
                    
                    // Set the department and name variables from thearray
                    string department = splitString[0];
                    string name = splitString[1];

                    // Set the sku variable from the string
                    long.TryParse(splitString[2], out long sku);

                    // Set the description variable from the string
                    string description = splitString[3];

                    // Set variables for the qty and price
                    int.TryParse(splitString[4], out int qty);
                    int.TryParse(splitString[5], out int price);

                    // Create a new item and add to the inventory
                    _inventory.AddItem(new Item(
                        department, name, sku, description, qty, price));
                }
            }
            catch (Exception ex)
            {
                // If any error arises, let user know.
                System.Windows.Forms.MessageBox.Show("Error: " + ex.Message);
            }
        }

        // Method to save inventory
        public void SaveInventory()
        {
            // Declare and initialize list to hold the data strings
            List<string> outputFile = new List<string>();

            // Write all lines to the file
            try
            {
                // Iterate through the inventory (data) list
                foreach (Item item in _inventory)
                {
                    // Add each item to the list
                    outputFile.Add(
                        item.department + "," +
                        item.name + "," +
                        item.sku + "," +
                        item.description + "," +
                        item.count + "," +
                        item.price + ",");
                }

                // Write the list to the data (CSV) file
                File.WriteAllLines(fileString, outputFile.ToArray());

                // Let user know the data was saved
                System.Windows.Forms.MessageBox.Show("Data Saved!");
            }
            catch (Exception ex)
            {
                // If an error occuress, warn the user
                System.Windows.Forms.MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        /// <summary>
        /// Method to save the Purchase Order
        /// </summary>
        /// <param name="document">Reference to open word document.</param>
        public void SaveFile(Document document)
        {
            // Declare and initialize Object
            SaveFileDialog saveFile = new SaveFileDialog();

            // Default save file name
            saveFile.FileName = 
                "Purchase_Order_" +
                DateTime.Now.Month.ToString() +
                DateTime.Now.Day.ToString() +
                DateTime.Now.Year.ToString() +
                ".docx";

            // Dialog document filter
            saveFile.Filter = "DOCX Files (*.docx)|*.docx|All Files (*.*)|*.*";

            // If the user clicks okay, go ahead and save the file
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                // Save the file of the reference document
                document.SaveAs2(saveFile.FileName);
            }
        }
    }
}

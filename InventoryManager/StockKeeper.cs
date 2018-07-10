// Namespace Declaration
using System;

/*
 *      Program:        Milestone 4
 *      File:           StockKeeper.cs
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
    class StockKeeper
    {
        /// <summary>
        /// Generate a new SKU for a new product.
        /// </summary>
        /// <param name="departmentNumber">Assign the specific department.</param>
        /// <param name="categoryNumber">Assign the specific category.</param>
        /// <param name="inventory">Supply an inventory of type <Item> to check sku against.</Item></param>
        /// <returns></returns>
        public long GenerateSKU(long departmentNumber, Inventory inventory)
        {
            // Setup number to return with corect department number and category number
            long generatedNumber = departmentNumber * 10000;

            // Generate a random Product ID
            long productID = (long)(new Random().Next(1, 9999));

            // Create temperary SKU to check against current inventory items
            long tempNumber = (generatedNumber + productID);

            // Iterate through inventory to find number
            for (int i = 0; i < inventory.Count; i++)
            {
                // If number found...
                if (inventory.GetItem(i).sku == tempNumber)
                {
                    // Assign new number and reset for-loop
                    productID = (long)(new Random().Next(1, 9999));
                    tempNumber = generatedNumber + productID;
                    i = 0;
                }
            }

            // If checks pass, assign new number
            generatedNumber = tempNumber;

            // Output new SKU
            return generatedNumber;
        }
    }
}
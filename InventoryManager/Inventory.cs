// Namespace Inclusion
using System.Collections;
using System.Collections.Generic;

/*
 *      Program:        Milestone 4
 *      File:           Inventory.cs
 *      Description:    Handles Inventory Management.
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
    public class Inventory : IEnumerable
    {
        /// <summary>
        /// Enum to handle search criteria to determine where to search
        /// </summary>
        public enum SearchType
        {
            Name,
            Description,
            Department,
            All
        }

        /// <summary>
        /// Declare and initialize the inventory list.
        /// </summary>
        private List<Item> _inventory = new List<Item>();

        /// <summary>
        /// Fields
        /// </summary>
        public int Count => ((ICollection<Item>)_inventory).Count;
        public bool IsReadOnly => ((ICollection<Item>)_inventory).IsReadOnly;

        /// <summary>
        /// Constructor that simply creates a new inventory.
        /// </summary>
        public Inventory()
        {
            // Empty
        }

        /// <summary>
        /// Constructor that places items in the inventory.
        /// </summary>
        /// <param name="items"></param>
        public Inventory(List<Item> items)
        {
            // For each item in the parameter 'items'...
            foreach (Item i in items)
            {
                // Add the item
                _inventory.Add(i);
            }
        }

        /// <summary>
        /// Return the IEnumerator
        /// </summary>
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        /// <summary>
        /// Return new Enumerator with _inventory.
        /// </summary>
        InventoryEnum GetEnumerator()
        {
            return new InventoryEnum(_inventory);
        }

        /// <summary>
        /// Adds an item to the inventory.
        /// </summary>
        /// <param name="item">Product to add.</param>
        public void AddItem(Item item)
        {
            // Add item, but if the item already exists, do not add it.
            _inventory.Add(item);
        }

        /// <summary>
        /// Method to remove item via element number.
        /// </summary>
        /// <param name="index">Product to remove at specific index.</param>
        public void RemoveItem(int index)
        {
            // Even though there is only one item in the inventory,
            // allow user to specift the element to remove by index.
            _inventory.RemoveAt(index);
        }

        /// <summary>
        /// Remove item via item object.
        /// </summary>
        /// <param name="item">Product to remove.</param>
        public bool RemoveItem(Item item)
        {
            if (_inventory.IndexOf(item) > 0)
            {
                // Becuase there is only ever one instance of an item in the inventory
                // we can safely remove the first instance of the item.
                _inventory.Remove(item);
                return true;
            }
            else
            {
                // MessageBox.Show("Item does not exist");
                return false;
            }
        }

        /// <summary>
        /// Method to restock the given item with the 
        /// amount specified.
        /// </summary>
        /// <param name="item">The item to be restocked.</param>
        /// <param name="quantity">Amount to increase stock.</param>
        public void RestockItem(Item item, int quantity)
        {
            // Get index od item.
            int index = _inventory.IndexOf(item);

            if (index >= 0)
            {
                // Add to the quantity
                _inventory[index].count += quantity;
            }
            else
            {
                // If item does not exist, add it.
                this.AddItem(item);
            }
        }



        /// <summary>
        /// Displays all items in the inventory.
        /// </summary>
        public void DisplayItems()
        {
            foreach (Item item in _inventory)
            {
                // Display the contents to the console
                System.Console.WriteLine(item.ToString());
            }
        }

        /// <summary>
        /// Method to find an item by searchTerms and return array of indexes
        /// of possible matches.
        /// <param name="searchTerm">Term to search.</param>
        /// <param name="searchType">Type of search to perform.</param>
        /// <returns></returns>
        public Inventory FindItemsBySearchType(string searchTerm, SearchType searchType)
        {
            // Declare and initialize variables
            Inventory inventory = new Inventory();
            List<Item> items = null;

            // Determine which search to use
            switch (searchType)
            {
                // Name search
                case SearchType.Name:
                    items = _inventory.FindAll(item => item.name.ToLower().Contains(searchTerm.ToLower()));
                    break;

                // Description Search
                case SearchType.Description:
                    items = _inventory.FindAll(item => item.description.ToLower().Contains(searchTerm.ToLower()));
                    break;

                // Department Search
                case SearchType.Department:
                    items = _inventory.FindAll(item => item.department.ToLower().Contains(searchTerm.ToLower()));
                    break;
            }

            foreach (Item item in items)
            {
                // Add all the indexes of each item found
                inventory.AddItem(item);
            }

            // Return the list of indexes.
            return inventory;
        }

        /// <summary>
        /// Method to find item by SKU, returns index
        /// </summary>
        /// <returns></returns>
        public Inventory FindItemBySKU(long sku)
        {
            // Return the index of the sku item
            Inventory inventory = new Inventory();

            inventory.AddItem(_inventory.Find(item => item.sku == sku));

            return inventory;
        }

        /// <summary>
        /// Search by high and low price.
        /// </summary>
        /// <param name="minPrice">Minimum price to search.</param>
        /// <param name="maxPrice">Maximum price to search.</param>
        public int[] FindItemByPriceRange(double minPrice, double maxPrice)
        {

            // Declare and initialize variables.
            // Need to multiply by 100 to get coin value since
            // he item stores the value in cents and the user will input
            // value in dollars and cents
            int min = (int)(minPrice * 100);
            int max = (int)(maxPrice * 100);
            List<int> inventory = new List<int>();

            foreach (Item item in _inventory)
            {
                // if the item is either higher than the min (inclusive)
                // or lower than the maximum (inclusive)
                if (item.price >= min && item.price <= max)
                {
                    // Add the index of each item found to the list.
                    inventory.Add(_inventory.IndexOf(item));
                }
            }

            // Return the list of indexes.
            return inventory.ToArray();
        }

        /// <summary>
        /// Return all indexes of items with a quantity less
        /// than provided.
        /// </summary>
        /// <param name="minCount">Minimum count to search.</param>
        /// <param name="maxCount">Maximum count to search.</param>
        public int[] FindItemByCount(int minCount, int maxCount)
        {
            // Declare and initialize variables.
            List<int> inventory = new List<int>();

            foreach (Item item in _inventory)
            {
                // If the item count is either higher than the min (inclusive)
                // and lower than the maximum (inclusive)
                if (item.count >= minCount && item.count <= maxCount)
                {
                    // Add the index of each item found
                    inventory.Add(_inventory.IndexOf(item));
                }
            }

            // Return the list of indexes.
            return inventory.ToArray();
        }

        /// <summary>
        /// Method to get an item from the list by the element/position number
        /// </summary>
        /// <param name="index">Element number to return.</param>
        public Item GetItem(int index)
        {
            // Return item by given index number.
            return _inventory[index];
        }

        public int IndexOf(long SKU)
        {
            //inventory.AddItem(_inventory.Find(item => item.sku == sku));

            return _inventory.FindIndex(item => item.sku == SKU);
        }

        /// <summary>
        /// Clear the Inventory.
        /// This remains private to restrict access to ensure list is not accidentally purged.
        /// </summary>
        private void Clear()
        {
            // Clear the inventory item.
            _inventory.Clear();
        }
    }
}

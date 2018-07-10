// Namespace Inclusion
using System;
using System.Collections;
using System.Collections.Generic;

/*
 *      Program:        Milestone 4
 *      File:           InventoryEnum.cs
 *      Description:    Handles enumeration for the Inventory (list) object.
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
    public class InventoryEnum : IEnumerator
    {
        /// <summary>
        /// Declare and initialize
        /// </summary>
        private List<Item> _inventory; // Note: not initialized yet
        private int index = -1;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="items">List of items</param>
        public InventoryEnum(List<Item> items)
        {
            // Initialize objecct
            _inventory = items;
        }

        /// <summary>
        /// Property to get Current element
        /// </summary>
        object IEnumerator.Current => Current;

        /// <summary>
        /// Get the current element at the current index
        /// </summary>
        public Item Current
        {
            get
            {
                try
                {
                    // Return element at index
                    return _inventory[index];
                }
                catch (IndexOutOfRangeException)
                {
                    // Index out of range, throw this error
                    throw new InvalidOperationException();
                }
            }
        }

        /// <summary>
        /// Method to advance the enumerator to the next position (index)
        /// </summary>
        /// <returns></returns>
        public bool MoveNext()
        {
            //index;
            // Advance the index and also return false if index bigger than
            // number of elements in the list
            return (++index < _inventory.Count);
        }

        /// <summary>
        /// Reset the index to initial position.
        /// </summary>
        public void Reset()
        {
            // Reset to postion just before first element
            index = -1;
        }
    }
}

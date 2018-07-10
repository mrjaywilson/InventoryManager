/*
 *      Program:        Milestone 4
 *      File:           Item.cs
 *      Description:    Handles item object.
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
    public class Item
    {
        /// <summary>
        /// Class Members.
        /// </summary>
        public long sku { get; set; }
        public int count { get; set; }
        public int price { get; set; }
        public string name { get; set; }
        public string department { get; set; }
        public string description { get; set; }

        /// <summary>
        /// Constructor to create an Item.
        /// </summary>
        /// <param name="department">
        ///     Department in which the item is sold. Note, when library for
        ///     departments and categories is defined, department will no longer
        ///     be a settable item within the constructor as it will draw the
        ///     department from the SKU as defined below.
        /// </param>
        /// <param name="name">Name of the product.</param>
        /// <param name="sku">
        ///     SKU identifies three things about the product:
        ///     
        ///         Example: 1234567
        ///     
        ///         First set of three numbers:     Department Number (and name)
        ///         Second set of four Numbers:     Unique Item ID
        /// </param>
        /// <param name="description">Description of the product.</param>
        /// <param name="count">Quantity of items on hand.</param>
        /// <param name="price">Cost of each item in cents.</param>
        public Item(string department, string name, long sku,
            string description, int count, int price)
        {
            this.department = department;
            this.name = name;
            this.sku = sku;
            this.description = description;
            this.count = count;
            this.price = price;
        }

        /// <summary>
        /// Override ToString() for testing.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            // Return a new string for testing.
            return "Inventory Item: " + department + ", " +
                name + ", " + sku + ", " + description + ", " +
                count + ", " + price;
        }

        /// <summary>
        /// Shallow Copy Item object.
        /// </summary>
        /// <returns></returns>
        public Item Copy()
        {
            // return a copy of the item object
            return (Item)MemberwiseClone();
        }
    }
}
// namespace Inclusion
using System.Collections.Generic;

/*
 *      Program:        Milestone 4
 *      File:           Departments.cs
 *      Description:    Handles the list of departments.
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
    public class Departments
    {
        /// <summary>
        /// property declaration
        /// </summary>
        public List<KeyValuePair<int, string>> DepartmentList { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        public Departments()
        {
            // Add departments to the department list
            DepartmentList = new List<KeyValuePair<int, string>>
            {
                // Grocery Goods
                new KeyValuePair<int, string>(101, "Bread"),
                new KeyValuePair<int, string>(111, "Cereal"),
                new KeyValuePair<int, string>(121, "Noodles"),
                new KeyValuePair<int, string>(131, "Dairy"),
                new KeyValuePair<int, string>(141, "Meat"),
                new KeyValuePair<int, string>(151, "Frozen"),
                new KeyValuePair<int, string>(161, "Refrigerated"),
                new KeyValuePair<int, string>(171, "Soft Drinks"),
                new KeyValuePair<int, string>(181, "Deli"),
                new KeyValuePair<int, string>(191, "Alcohol"),
                new KeyValuePair<int, string>(199, "Other Grocery"),

                // Articles
                new KeyValuePair<int, string>(201, "Girl's Wear"),
                new KeyValuePair<int, string>(202, "Boy's Wear"),
                new KeyValuePair<int, string>(203, "Baby's Wear"),
                new KeyValuePair<int, string>(204, "Teen's Wear"),
                new KeyValuePair<int, string>(205, "Plus Teen's Wear"),
                new KeyValuePair<int, string>(209, "Men's Wear"),
                new KeyValuePair<int, string>(221, "Plus Men's Wear"),
                new KeyValuePair<int, string>(229, "Women's Wear"),
                new KeyValuePair<int, string>(231, "Plus Women's Wear"),
                new KeyValuePair<int, string>(239, "Girl's Shoes"),
                new KeyValuePair<int, string>(249, "Women's Jewelry"),
                new KeyValuePair<int, string>(250, "Men's Jewelry"),
                new KeyValuePair<int, string>(255, "Women's Watches"),
                new KeyValuePair<int, string>(261, "Men's Watches"),
                new KeyValuePair<int, string>(271, "Boy's Shoes"),
                new KeyValuePair<int, string>(275, "Women's Shoes"),
                new KeyValuePair<int, string>(281, "Men's Shoes"),
                new KeyValuePair<int, string>(299, "Other Articles"),

                // Home Goods
                new KeyValuePair<int, string>(501, "Livingroom"),
                new KeyValuePair<int, string>(502, "Bathroom"),
                new KeyValuePair<int, string>(507, "Kitchenware"),
                new KeyValuePair<int, string>(510, "Bedroom"),
                new KeyValuePair<int, string>(515, "Kid's Bedroom"),
                new KeyValuePair<int, string>(530, "Gardenware"),
                new KeyValuePair<int, string>(599, "Other Home Goods"),

                // General Electronics
                new KeyValuePair<int, string>(702, "Televisions"),
                new KeyValuePair<int, string>(711, "Video Games"),
                new KeyValuePair<int, string>(714, "Game Consoles"),
                new KeyValuePair<int, string>(719, "Laptops"),
                new KeyValuePair<int, string>(725, "Cell Phones"),
                new KeyValuePair<int, string>(747, "Movies"),
                new KeyValuePair<int, string>(764, "Books"),
                new KeyValuePair<int, string>(783, "Music"),
                new KeyValuePair<int, string>(799, "Other Electronics"),

                // Toys
                new KeyValuePair<int, string>(805, "Dolls"),
                new KeyValuePair<int, string>(806, "Action Figures"),
                new KeyValuePair<int, string>(810, "Puzzles"),
                new KeyValuePair<int, string>(817, "Legos"),
                new KeyValuePair<int, string>(899, "Other Toys"),

                // Sporting Goods
                new KeyValuePair<int, string>(902, "Bike"),
                new KeyValuePair<int, string>(905, "Yoga"),
                new KeyValuePair<int, string>(910, "Basketball"),
                new KeyValuePair<int, string>(911, "Football"),
                new KeyValuePair<int, string>(912, "Hockey"),
                new KeyValuePair<int, string>(945, "Swim"),
                new KeyValuePair<int, string>(950, "Outdoor Games"),
                new KeyValuePair<int, string>(999, "Other Sporting Goods"),

                // Personal Care
                new KeyValuePair<int, string>(401, "Medicine"),
                new KeyValuePair<int, string>(405, "health"),
                new KeyValuePair<int, string>(445, "Oral Products"),
                new KeyValuePair<int, string>(499, "Other Personal Care"),

                // Seasonal Items
                new KeyValuePair<int, string>(301, "Christmas"),
                new KeyValuePair<int, string>(305, "Easter"),
                new KeyValuePair<int, string>(330, "Halloween"),
                new KeyValuePair<int, string>(399, "Other Seasonal")
            };
        }
    }
}
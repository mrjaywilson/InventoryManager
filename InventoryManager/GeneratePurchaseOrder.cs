// Namespace inclusion
using Microsoft.Office.Interop.Word;
using System;
using System.Windows.Forms;

/*
 *      Program:        Milestone 5
 *      File:           GeneratePurchaseOrder.cs
 *      Description:    Generates a purchase order for ordering new stock.
 *      Author:         Jay Wilson
 *      Class:          CST-117
 *      Date:           July 8, 2018
 */

/// <summary>
/// Namespace Declaration
/// </summary>
namespace InventoryManager
{
    /// <summary>
    /// Class Declaration
    /// </summary>
    class GeneratePurchaseOrder
    {
        /// <summary>
        /// Method to generate purchase order from restock list.
        /// </summary>
        /// <param name="replenishmentList">Pass in restock inventory.</param>
        public void GeneratePO(Inventory replenishmentList)
        {
            try
            {
                // Create and instance for word app
                Microsoft.Office.Interop.Word.Application winword = new Microsoft.Office.Interop.Word.Application();

                // Set animation status for winword
                winword.ShowAnimation = false;

                // Set statuf for word application to be visible or not
                winword.Visible = false;

                // Create a missing variable for missing value
                object missing = System.Reflection.Missing.Value;

                // Create a new document
                Document document =
                    winword.Documents.Add(
                        ref missing, ref missing, ref missing, ref missing);

                // Add header into the document
                foreach (Section section in document.Sections)
                {
                    // Get the Header range and set the details
                    Range headerRange = section.Headers[WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;
                    headerRange.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;
                    headerRange.Font.Name = "Arial";
                    headerRange.Font.ColorIndex = WdColorIndex.wdBlue;

                    // Add Paragraph Containing the application name
                    Paragraph headerTitle = headerRange.Paragraphs.Add(ref missing);
                    headerTitle.Range.Font.Size = 14;
                    headerTitle.Range.Text = "INVENTORY MANAGER";
                    headerTitle.Range.InsertParagraphAfter();

                    // Add paragraph to header containing the address of the company
                    Paragraph headerAddress = headerRange.Paragraphs.Add(ref missing);
                    headerAddress.Range.Font.Size = 8;
                    headerAddress.Range.Text = "213 Ground St., Irvine, Ca 92612";
                    headerAddress.Range.InsertParagraphAfter();

                }

                // Set the font of the main document
                document.Content.SetRange(0, 0);
                document.Content.Paragraphs.LineSpacingRule = WdLineSpacing.wdLineSpaceSingle;
                document.Content.Paragraphs.SpaceAfter = 0;
                document.Content.Font.Name = "Tahoma";
                document.Content.Font.Size = 10;

                // Insert the address block
                document.Content.Text = Environment.NewLine
                    + Environment.NewLine
                    + "Purchase Order For:"
                    + Environment.NewLine
                    + "\tProduct Distributors, Inc."
                    + Environment.NewLine
                    + "\t11223 Air St."
                    + Environment.NewLine
                    + "\tWestminster" + ", " + "CA" + " " + "92683"
                    + Environment.NewLine
                    + Environment.NewLine
                    + Environment.NewLine;



                // Add Paragraph with the name of the document
                Paragraph para1 = document.Content.Paragraphs.Add(ref missing);
                para1.Range.Font.Size = 24;
                para1.Range.Text = "Purchase Order Details\n";
                para1.Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;
                para1.Range.InsertParagraphAfter();

                // Create a table and add all the items that we plan to order for restocking the inventory
                Table firstTable = document.Tables.Add(para1.Range, replenishmentList.Count, 4, ref missing, ref missing);
                int index = 0;
                int currentQty = 0;
                double totalCost = 0;

                firstTable.Borders.Enable = 1;
                foreach (Row row in firstTable.Rows)
                {
                    foreach (Cell cell in row.Cells)
                    {
                        if (cell.RowIndex == 1)
                        {
                            if (cell.ColumnIndex == 1)
                            {
                                cell.Range.Text = "Product Name";
                            }
                            else if (cell.ColumnIndex == 2)
                            {
                                cell.Range.Text = "SKU Number";
                            }
                            else if (cell.ColumnIndex == 3)
                            {
                                cell.Range.Text = "Quantity";
                            }
                            else if (cell.ColumnIndex == 4)
                            {
                                cell.Range.Text = "Price";
                            }
                            cell.Range.Font.Bold = 1;

                            // Formatting the table
                            cell.Range.Font.Name = "Tahoma";
                            cell.Range.Font.Size = 10;
                            cell.Shading.BackgroundPatternColor = WdColor.wdColorGray25;

                            // center alignment for the header cells
                            cell.VerticalAlignment = WdCellVerticalAlignment.wdCellAlignVerticalCenter;
                            cell.Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;
                        }

                        // Enter the data into the cells
                        else
                        {
                            switch (cell.ColumnIndex)
                            {
                                case 1: // Product Name
                                    cell.PreferredWidth = 100;
                                    cell.Range.Text = replenishmentList.GetItem(index - 1).name;
                                    cell.VerticalAlignment = WdCellVerticalAlignment.wdCellAlignVerticalCenter;
                                    cell.Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;
                                    break;
                                case 2: // Product SKU
                                    cell.Range.Text = replenishmentList.GetItem(index - 1).sku.ToString();
                                    cell.VerticalAlignment = WdCellVerticalAlignment.wdCellAlignVerticalCenter;
                                    cell.Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;
                                    break;
                                case 3: // Product Quantity
                                    cell.Range.Text = replenishmentList.GetItem(index - 1).count.ToString();
                                    cell.VerticalAlignment = WdCellVerticalAlignment.wdCellAlignVerticalCenter;
                                    cell.Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;
                                    break;
                                case 4: // Product cost after wholesale discount
                                    double currentCost = ((((replenishmentList.GetItem(index - 1).price * .67) / 100.00)) * replenishmentList.GetItem(index - 1).count);
                                    totalCost += currentCost;
                                    cell.Range.Text = String.Format("{0:0.00}", currentCost);
                                    cell.VerticalAlignment = WdCellVerticalAlignment.wdCellAlignVerticalCenter;
                                    cell.Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphRight;
                                    break;
                            }
                        }
                    }
                    // Update the index number
                    index++;
                }

                //// Add Total amount to the end of the document
                Paragraph para2 = document.Content.Paragraphs.Add(ref missing);
                para2.Range.Text = Environment.NewLine + "Total: $" + String.Format("{0:0.00}", totalCost);
                para2.Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphRight;
                para2.Range.InsertParagraphAfter();

                // Add signature Field
                Paragraph para3 = document.Content.Paragraphs.Add(ref missing);
                para3.Range.Text = Environment.NewLine + Environment.NewLine + "Signature of Agent Authorization: ___________________________";
                para3.Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphRight;
                para3.Range.InsertParagraphAfter();

                // Add special text at the bottom of the email in light gray (fine print).
                // This the terms and conditions of sale.
                Paragraph para4 = document.Content.Paragraphs.Add(ref missing);
                para4.Range.Font.ColorIndex = WdColorIndex.wdGray25;
                para4.Range.Text = Environment.NewLine
                    + Environment.NewLine
                    + Environment.NewLine
                    + "ACCEPTANCE AND TERMS AND CONDITIONS: Seller accepts this Order and any amendments by signing the acceptance copy of the Order and returning it to Purchaser promptly. Even without such written acknowledgment, Seller's full or partial performance under this Order will constitute acceptance of these Terms. By acceptance of this Order, Seller agrees to be bound by, and to comply with all these Terms, which include any supplements to it, and all specifications and other documents referred to in this Order. These Terms apply to everything listed in this Order and constitute Purchaser's offer to Seller, which Purchaser may revoke at any time prior to Seller’s acceptance. This Order is not an acceptance by Purchaser of any offer to sell, any quotation, or any proposal. Reference in this Order to any such offer to sell, quotation, or proposal will not constitute a modification of any of these Terms. Terms and conditions different from or in addition to these Terms, whether contained in any acknowledgment of this Order, or with delivery of any goods or services under this Order, or otherwise, will not be binding on Purchaser, whether or not they would materially alter this Order, and Purchaser hereby rejects them. These Terms may be modified only by a written document signed by duly authorized representatives of Purchaser and Seller.";
                para4.Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphJustify;
             
                // Create FileManager object
                FileManager fileManager = new FileManager();

                // Save the file
                fileManager.SaveFile(document);

                // Clean up
                document.Close(ref missing, ref missing, ref missing);
                document = null;
                winword.Quit(ref missing, ref missing, ref missing);
                winword = null;

                // Let the user know all went well
                MessageBox.Show("Purchase Order Generated Successfully!");
            }
            catch (Exception ex)
            {
                // Show error if something went wrong
                MessageBox.Show("Error(" + ex.InnerException.ToString() + "): " + ex.Message);
            }
        }
    }
}

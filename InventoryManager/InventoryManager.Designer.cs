namespace InventoryManager
{
    partial class InventoryManager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSaveInventory = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rbByDepartment = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.rbByDescription = new System.Windows.Forms.RadioButton();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.rbBySku = new System.Windows.Forms.RadioButton();
            this.btnSearch = new System.Windows.Forms.Button();
            this.rbByName = new System.Windows.Forms.RadioButton();
            this.btnViewInventory = new System.Windows.Forms.Button();
            this.btnRestockItems = new System.Windows.Forms.Button();
            this.lvInventory = new System.Windows.Forms.ListView();
            this.chDepartment = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chSKU = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chDescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chQty = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chCost = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnRemoveItem = new System.Windows.Forms.Button();
            this.btnEditItem = new System.Windows.Forms.Button();
            this.btnNewItem = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(906, 84);
            this.panel1.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImage = global::InventoryManager.Properties.Resources.exit;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(869, 4);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(32, 35);
            this.btnExit.TabIndex = 1;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 42.25F);
            this.lblTitle.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblTitle.Location = new System.Drawing.Point(-1, -1);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(906, 84);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "INVENTORY MANAGER";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblTitle_MouseDown);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.btnSaveInventory);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.btnViewInventory);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 84);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(184, 298);
            this.panel2.TabIndex = 1;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            // 
            // btnSaveInventory
            // 
            this.btnSaveInventory.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MidnightBlue;
            this.btnSaveInventory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSaveInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveInventory.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveInventory.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnSaveInventory.Location = new System.Drawing.Point(11, 56);
            this.btnSaveInventory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSaveInventory.Name = "btnSaveInventory";
            this.btnSaveInventory.Size = new System.Drawing.Size(160, 30);
            this.btnSaveInventory.TabIndex = 15;
            this.btnSaveInventory.Text = "Save Inventory";
            this.btnSaveInventory.UseVisualStyleBackColor = true;
            this.btnSaveInventory.Click += new System.EventHandler(this.btnSaveInventory_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.rbByDepartment);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.rbByDescription);
            this.panel3.Controls.Add(this.txtSearch);
            this.panel3.Controls.Add(this.rbBySku);
            this.panel3.Controls.Add(this.btnSearch);
            this.panel3.Controls.Add(this.rbByName);
            this.panel3.Location = new System.Drawing.Point(11, 98);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(161, 186);
            this.panel3.TabIndex = 14;
            this.panel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseDown);
            // 
            // rbByDepartment
            // 
            this.rbByDepartment.AutoSize = true;
            this.rbByDepartment.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbByDepartment.ForeColor = System.Drawing.Color.DodgerBlue;
            this.rbByDepartment.Location = new System.Drawing.Point(9, 152);
            this.rbByDepartment.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbByDepartment.Name = "rbByDepartment";
            this.rbByDepartment.Size = new System.Drawing.Size(103, 19);
            this.rbByDepartment.TabIndex = 6;
            this.rbByDepartment.Text = "Department";
            this.rbByDepartment.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(7, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "Search";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rbByDescription
            // 
            this.rbByDescription.AutoSize = true;
            this.rbByDescription.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbByDescription.ForeColor = System.Drawing.Color.DodgerBlue;
            this.rbByDescription.Location = new System.Drawing.Point(9, 123);
            this.rbByDescription.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbByDescription.Name = "rbByDescription";
            this.rbByDescription.Size = new System.Drawing.Size(101, 19);
            this.rbByDescription.TabIndex = 4;
            this.rbByDescription.Text = "Description";
            this.rbByDescription.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.SystemColors.InfoText;
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.DodgerBlue;
            this.txtSearch.Location = new System.Drawing.Point(7, 30);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(102, 23);
            this.txtSearch.TabIndex = 0;
            // 
            // rbBySku
            // 
            this.rbBySku.AutoSize = true;
            this.rbBySku.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbBySku.ForeColor = System.Drawing.Color.DodgerBlue;
            this.rbBySku.Location = new System.Drawing.Point(9, 93);
            this.rbBySku.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbBySku.Name = "rbBySku";
            this.rbBySku.Size = new System.Drawing.Size(109, 19);
            this.rbBySku.TabIndex = 3;
            this.rbBySku.Text = "SKU Number";
            this.rbBySku.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MidnightBlue;
            this.btnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnSearch.Location = new System.Drawing.Point(115, 30);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(0);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(40, 27);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "GO";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // rbByName
            // 
            this.rbByName.AutoSize = true;
            this.rbByName.Checked = true;
            this.rbByName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbByName.ForeColor = System.Drawing.Color.DodgerBlue;
            this.rbByName.Location = new System.Drawing.Point(9, 64);
            this.rbByName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbByName.Name = "rbByName";
            this.rbByName.Size = new System.Drawing.Size(118, 19);
            this.rbByName.TabIndex = 2;
            this.rbByName.TabStop = true;
            this.rbByName.Text = "Product Name";
            this.rbByName.UseVisualStyleBackColor = true;
            // 
            // btnViewInventory
            // 
            this.btnViewInventory.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MidnightBlue;
            this.btnViewInventory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnViewInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewInventory.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewInventory.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnViewInventory.Location = new System.Drawing.Point(12, 17);
            this.btnViewInventory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnViewInventory.Name = "btnViewInventory";
            this.btnViewInventory.Size = new System.Drawing.Size(160, 30);
            this.btnViewInventory.TabIndex = 3;
            this.btnViewInventory.Text = "Refresh Inventory";
            this.btnViewInventory.UseVisualStyleBackColor = true;
            this.btnViewInventory.Click += new System.EventHandler(this.btnViewInventory_Click);
            // 
            // btnRestockItems
            // 
            this.btnRestockItems.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MidnightBlue;
            this.btnRestockItems.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnRestockItems.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestockItems.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestockItems.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnRestockItems.Location = new System.Drawing.Point(197, 339);
            this.btnRestockItems.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRestockItems.Name = "btnRestockItems";
            this.btnRestockItems.Size = new System.Drawing.Size(160, 31);
            this.btnRestockItems.TabIndex = 7;
            this.btnRestockItems.Text = "Replenish Inventory";
            this.btnRestockItems.UseVisualStyleBackColor = true;
            this.btnRestockItems.Click += new System.EventHandler(this.btnRestockItems_Click);
            // 
            // lvInventory
            // 
            this.lvInventory.BackColor = System.Drawing.SystemColors.MenuText;
            this.lvInventory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvInventory.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chDepartment,
            this.chName,
            this.chSKU,
            this.chDescription,
            this.chQty,
            this.chCost});
            this.lvInventory.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvInventory.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lvInventory.FullRowSelect = true;
            this.lvInventory.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvInventory.Location = new System.Drawing.Point(197, 100);
            this.lvInventory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lvInventory.MultiSelect = false;
            this.lvInventory.Name = "lvInventory";
            this.lvInventory.Size = new System.Drawing.Size(697, 227);
            this.lvInventory.TabIndex = 4;
            this.lvInventory.UseCompatibleStateImageBehavior = false;
            this.lvInventory.View = System.Windows.Forms.View.Details;
            // 
            // chDepartment
            // 
            this.chDepartment.Text = "Department";
            this.chDepartment.Width = 100;
            // 
            // chName
            // 
            this.chName.Text = "Name";
            this.chName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chName.Width = 75;
            // 
            // chSKU
            // 
            this.chSKU.Text = "SKU#";
            this.chSKU.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chSKU.Width = 75;
            // 
            // chDescription
            // 
            this.chDescription.Text = "Description";
            this.chDescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chDescription.Width = 132;
            // 
            // chQty
            // 
            this.chQty.Text = "QTY";
            this.chQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chQty.Width = 41;
            // 
            // chCost
            // 
            this.chCost.Text = "Cost";
            this.chCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnRemoveItem
            // 
            this.btnRemoveItem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MidnightBlue;
            this.btnRemoveItem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnRemoveItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveItem.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveItem.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnRemoveItem.Location = new System.Drawing.Point(610, 339);
            this.btnRemoveItem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRemoveItem.Name = "btnRemoveItem";
            this.btnRemoveItem.Size = new System.Drawing.Size(84, 28);
            this.btnRemoveItem.TabIndex = 13;
            this.btnRemoveItem.Text = "Remove Item";
            this.btnRemoveItem.UseVisualStyleBackColor = true;
            this.btnRemoveItem.Click += new System.EventHandler(this.btnRemoveItem_Click);
            // 
            // btnEditItem
            // 
            this.btnEditItem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MidnightBlue;
            this.btnEditItem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnEditItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditItem.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditItem.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnEditItem.Location = new System.Drawing.Point(710, 339);
            this.btnEditItem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEditItem.Name = "btnEditItem";
            this.btnEditItem.Size = new System.Drawing.Size(84, 28);
            this.btnEditItem.TabIndex = 12;
            this.btnEditItem.Text = "Edit Item";
            this.btnEditItem.UseVisualStyleBackColor = true;
            this.btnEditItem.Click += new System.EventHandler(this.btnEditItem_Click);
            // 
            // btnNewItem
            // 
            this.btnNewItem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MidnightBlue;
            this.btnNewItem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnNewItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewItem.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewItem.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnNewItem.Location = new System.Drawing.Point(810, 339);
            this.btnNewItem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNewItem.Name = "btnNewItem";
            this.btnNewItem.Size = new System.Drawing.Size(84, 28);
            this.btnNewItem.TabIndex = 11;
            this.btnNewItem.Text = "New item";
            this.btnNewItem.UseVisualStyleBackColor = true;
            this.btnNewItem.Click += new System.EventHandler(this.btnNewItem_Click);
            // 
            // InventoryManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(906, 382);
            this.Controls.Add(this.btnRemoveItem);
            this.Controls.Add(this.btnRestockItems);
            this.Controls.Add(this.btnEditItem);
            this.Controls.Add(this.btnNewItem);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lvInventory);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "InventoryManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InventoryManager";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.InventoryManager_MouseDown);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbByDescription;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.RadioButton rbBySku;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.RadioButton rbByName;
        private System.Windows.Forms.Button btnRestockItems;
        private System.Windows.Forms.Button btnViewInventory;
        private System.Windows.Forms.ListView lvInventory;
        private System.Windows.Forms.ColumnHeader chDepartment;
        private System.Windows.Forms.ColumnHeader chName;
        private System.Windows.Forms.ColumnHeader chSKU;
        private System.Windows.Forms.ColumnHeader chDescription;
        private System.Windows.Forms.ColumnHeader chQty;
        private System.Windows.Forms.ColumnHeader chCost;
        private System.Windows.Forms.Button btnRemoveItem;
        private System.Windows.Forms.Button btnEditItem;
        private System.Windows.Forms.Button btnNewItem;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.RadioButton rbByDepartment;
        private System.Windows.Forms.Button btnSaveInventory;
    }
}


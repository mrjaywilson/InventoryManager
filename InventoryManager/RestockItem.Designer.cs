namespace InventoryManager
{
    partial class RestockItem
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
            this.grpTitle = new System.Windows.Forms.GroupBox();
            this.lvRestockList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.btnGeneratePurchaseOrder = new System.Windows.Forms.Button();
            this.btnRestock = new System.Windows.Forms.Button();
            this.lvItemList = new System.Windows.Forms.ListView();
            this.chItemName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chSku = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chQty = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnRemoveItem = new System.Windows.Forms.Button();
            this.grpTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpTitle
            // 
            this.grpTitle.BackColor = System.Drawing.Color.Black;
            this.grpTitle.Controls.Add(this.lvRestockList);
            this.grpTitle.Controls.Add(this.label2);
            this.grpTitle.Controls.Add(this.txtQty);
            this.grpTitle.Controls.Add(this.btnGeneratePurchaseOrder);
            this.grpTitle.Controls.Add(this.btnRestock);
            this.grpTitle.Controls.Add(this.lvItemList);
            this.grpTitle.Controls.Add(this.btnCancel);
            this.grpTitle.Controls.Add(this.btnRemoveItem);
            this.grpTitle.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpTitle.ForeColor = System.Drawing.Color.DodgerBlue;
            this.grpTitle.Location = new System.Drawing.Point(3, 2);
            this.grpTitle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpTitle.Name = "grpTitle";
            this.grpTitle.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpTitle.Size = new System.Drawing.Size(759, 267);
            this.grpTitle.TabIndex = 21;
            this.grpTitle.TabStop = false;
            this.grpTitle.Text = "RESTOCK ITEMS";
            // 
            // lvRestockList
            // 
            this.lvRestockList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvRestockList.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvRestockList.FullRowSelect = true;
            this.lvRestockList.HideSelection = false;
            this.lvRestockList.Location = new System.Drawing.Point(461, 31);
            this.lvRestockList.MultiSelect = false;
            this.lvRestockList.Name = "lvRestockList";
            this.lvRestockList.Size = new System.Drawing.Size(290, 188);
            this.lvRestockList.TabIndex = 27;
            this.lvRestockList.UseCompatibleStateImageBehavior = false;
            this.lvRestockList.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Item Name";
            this.columnHeader1.Width = 123;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "SKU";
            this.columnHeader2.Width = 77;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Quantity";
            this.columnHeader3.Width = 68;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(305, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 47);
            this.label2.TabIndex = 26;
            this.label2.Text = "Restock\r\nQTY";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtQty
            // 
            this.txtQty.BackColor = System.Drawing.SystemColors.InfoText;
            this.txtQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQty.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQty.ForeColor = System.Drawing.Color.DodgerBlue;
            this.txtQty.Location = new System.Drawing.Point(305, 82);
            this.txtQty.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(150, 23);
            this.txtQty.TabIndex = 25;
            this.txtQty.Text = "0";
            this.txtQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnGeneratePurchaseOrder
            // 
            this.btnGeneratePurchaseOrder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MidnightBlue;
            this.btnGeneratePurchaseOrder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnGeneratePurchaseOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGeneratePurchaseOrder.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGeneratePurchaseOrder.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnGeneratePurchaseOrder.Location = new System.Drawing.Point(559, 226);
            this.btnGeneratePurchaseOrder.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGeneratePurchaseOrder.Name = "btnGeneratePurchaseOrder";
            this.btnGeneratePurchaseOrder.Size = new System.Drawing.Size(192, 30);
            this.btnGeneratePurchaseOrder.TabIndex = 23;
            this.btnGeneratePurchaseOrder.Text = "Generate Purchase Order";
            this.btnGeneratePurchaseOrder.UseVisualStyleBackColor = true;
            this.btnGeneratePurchaseOrder.Click += new System.EventHandler(this.btnComplete_Click);
            // 
            // btnRestock
            // 
            this.btnRestock.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MidnightBlue;
            this.btnRestock.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnRestock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestock.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestock.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnRestock.Location = new System.Drawing.Point(305, 151);
            this.btnRestock.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRestock.Name = "btnRestock";
            this.btnRestock.Size = new System.Drawing.Size(150, 30);
            this.btnRestock.TabIndex = 21;
            this.btnRestock.Text = "Restock Item >";
            this.btnRestock.UseVisualStyleBackColor = true;
            this.btnRestock.Click += new System.EventHandler(this.btnRestock_Click);
            // 
            // lvItemList
            // 
            this.lvItemList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chItemName,
            this.chSku,
            this.chQty});
            this.lvItemList.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvItemList.FullRowSelect = true;
            this.lvItemList.HideSelection = false;
            this.lvItemList.Location = new System.Drawing.Point(9, 31);
            this.lvItemList.MultiSelect = false;
            this.lvItemList.Name = "lvItemList";
            this.lvItemList.Size = new System.Drawing.Size(290, 188);
            this.lvItemList.TabIndex = 20;
            this.lvItemList.UseCompatibleStateImageBehavior = false;
            this.lvItemList.View = System.Windows.Forms.View.Details;
            // 
            // chItemName
            // 
            this.chItemName.Text = "Item Name";
            this.chItemName.Width = 123;
            // 
            // chSku
            // 
            this.chSku.Text = "SKU";
            this.chSku.Width = 77;
            // 
            // chQty
            // 
            this.chQty.Text = "Quantity";
            this.chQty.Width = 68;
            // 
            // btnCancel
            // 
            this.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MidnightBlue;
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnCancel.Location = new System.Drawing.Point(461, 226);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(92, 30);
            this.btnCancel.TabIndex = 19;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnRemoveItem
            // 
            this.btnRemoveItem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MidnightBlue;
            this.btnRemoveItem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnRemoveItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveItem.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveItem.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnRemoveItem.Location = new System.Drawing.Point(305, 189);
            this.btnRemoveItem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRemoveItem.Name = "btnRemoveItem";
            this.btnRemoveItem.Size = new System.Drawing.Size(150, 30);
            this.btnRemoveItem.TabIndex = 18;
            this.btnRemoveItem.Text = "< Remove Item";
            this.btnRemoveItem.UseVisualStyleBackColor = true;
            this.btnRemoveItem.Click += new System.EventHandler(this.btnRemoveItem_Click);
            // 
            // RestockItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(766, 271);
            this.Controls.Add(this.grpTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RestockItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Restock Item";
            this.TransparencyKey = System.Drawing.Color.Yellow;
            this.grpTitle.ResumeLayout(false);
            this.grpTitle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpTitle;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnRemoveItem;
        private System.Windows.Forms.Button btnGeneratePurchaseOrder;
        private System.Windows.Forms.Button btnRestock;
        private System.Windows.Forms.ListView lvItemList;
        private System.Windows.Forms.ColumnHeader chItemName;
        private System.Windows.Forms.ColumnHeader chQty;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColumnHeader chSku;
        private System.Windows.Forms.ListView lvRestockList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}
namespace inventory
{
    partial class inventory_changes
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label iDLabel;
            System.Windows.Forms.Label barcodeLabel;
            System.Windows.Forms.Label productNameLabel;
            System.Windows.Forms.Label priceLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(inventory_changes));
            this.database2DataSet = new inventory.Database2DataSet();
            this.inventoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inventoryTableAdapter = new inventory.Database2DataSetTableAdapters.inventoryTableAdapter();
            this.tableAdapterManager = new inventory.Database2DataSetTableAdapters.TableAdapterManager();
            this.inventoryBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.inventoryBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.iDTextBox = new System.Windows.Forms.TextBox();
            this.barcodeTextBox = new System.Windows.Forms.TextBox();
            this.productNameTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.IDBox = new System.Windows.Forms.ListBox();
            this.BarcodeBox = new System.Windows.Forms.ListBox();
            this.NameBox = new System.Windows.Forms.ListBox();
            this.priceBox = new System.Windows.Forms.ListBox();
            iDLabel = new System.Windows.Forms.Label();
            barcodeLabel = new System.Windows.Forms.Label();
            productNameLabel = new System.Windows.Forms.Label();
            priceLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.database2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingNavigator)).BeginInit();
            this.inventoryBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            iDLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            iDLabel.Location = new System.Drawing.Point(12, 91);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(37, 25);
            iDLabel.TabIndex = 1;
            iDLabel.Text = "ID:";
            // 
            // barcodeLabel
            // 
            barcodeLabel.AutoSize = true;
            barcodeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            barcodeLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            barcodeLabel.Location = new System.Drawing.Point(12, 127);
            barcodeLabel.Name = "barcodeLabel";
            barcodeLabel.Size = new System.Drawing.Size(91, 25);
            barcodeLabel.TabIndex = 3;
            barcodeLabel.Text = "Barcode:";
            // 
            // productNameLabel
            // 
            productNameLabel.AutoSize = true;
            productNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            productNameLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            productNameLabel.Location = new System.Drawing.Point(12, 165);
            productNameLabel.Name = "productNameLabel";
            productNameLabel.Size = new System.Drawing.Size(142, 25);
            productNameLabel.TabIndex = 5;
            productNameLabel.Text = "Product Name:";
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            priceLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            priceLabel.Location = new System.Drawing.Point(12, 203);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new System.Drawing.Size(62, 25);
            priceLabel.TabIndex = 7;
            priceLabel.Text = "Price:";
            // 
            // database2DataSet
            // 
            this.database2DataSet.DataSetName = "Database2DataSet";
            this.database2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // inventoryBindingSource
            // 
            this.inventoryBindingSource.DataMember = "inventory";
            this.inventoryBindingSource.DataSource = this.database2DataSet;
            // 
            // inventoryTableAdapter
            // 
            this.inventoryTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.inventoryTableAdapter = this.inventoryTableAdapter;
            this.tableAdapterManager.UpdateOrder = inventory.Database2DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // inventoryBindingNavigator
            // 
            this.inventoryBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.inventoryBindingNavigator.BindingSource = this.inventoryBindingSource;
            this.inventoryBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.inventoryBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.inventoryBindingNavigator.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.inventoryBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.inventoryBindingNavigatorSaveItem});
            this.inventoryBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.inventoryBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.inventoryBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.inventoryBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.inventoryBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.inventoryBindingNavigator.Name = "inventoryBindingNavigator";
            this.inventoryBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.inventoryBindingNavigator.Size = new System.Drawing.Size(1148, 31);
            this.inventoryBindingNavigator.TabIndex = 0;
            this.inventoryBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 28);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(58, 28);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 28);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 28);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 28);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // inventoryBindingNavigatorSaveItem
            // 
            this.inventoryBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.inventoryBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("inventoryBindingNavigatorSaveItem.Image")));
            this.inventoryBindingNavigatorSaveItem.Name = "inventoryBindingNavigatorSaveItem";
            this.inventoryBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 28);
            this.inventoryBindingNavigatorSaveItem.Text = "Save Data";
            this.inventoryBindingNavigatorSaveItem.Click += new System.EventHandler(this.inventoryBindingNavigatorSaveItem_Click);
            // 
            // iDTextBox
            // 
            this.iDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.iDTextBox.Location = new System.Drawing.Point(192, 86);
            this.iDTextBox.Name = "iDTextBox";
            this.iDTextBox.Size = new System.Drawing.Size(299, 30);
            this.iDTextBox.TabIndex = 2;
            // 
            // barcodeTextBox
            // 
            this.barcodeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.barcodeTextBox.Location = new System.Drawing.Point(192, 122);
            this.barcodeTextBox.Name = "barcodeTextBox";
            this.barcodeTextBox.Size = new System.Drawing.Size(299, 30);
            this.barcodeTextBox.TabIndex = 4;
            // 
            // productNameTextBox
            // 
            this.productNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.productNameTextBox.Location = new System.Drawing.Point(192, 160);
            this.productNameTextBox.Name = "productNameTextBox";
            this.productNameTextBox.Size = new System.Drawing.Size(299, 30);
            this.productNameTextBox.TabIndex = 6;
            // 
            // priceTextBox
            // 
            this.priceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.priceTextBox.Location = new System.Drawing.Point(192, 196);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(299, 30);
            this.priceTextBox.TabIndex = 8;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.button5.Location = new System.Drawing.Point(1004, 306);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(132, 29);
            this.button5.TabIndex = 9;
            this.button5.Text = "EXIT";
            this.button5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // IDBox
            // 
            this.IDBox.DataSource = this.inventoryBindingSource;
            this.IDBox.DisplayMember = "ID";
            this.IDBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.IDBox.FormattingEnabled = true;
            this.IDBox.ItemHeight = 25;
            this.IDBox.Location = new System.Drawing.Point(497, 46);
            this.IDBox.Name = "IDBox";
            this.IDBox.Size = new System.Drawing.Size(130, 254);
            this.IDBox.TabIndex = 20;
            // 
            // BarcodeBox
            // 
            this.BarcodeBox.DataSource = this.inventoryBindingSource;
            this.BarcodeBox.DisplayMember = "Barcode";
            this.BarcodeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.BarcodeBox.FormattingEnabled = true;
            this.BarcodeBox.ItemHeight = 25;
            this.BarcodeBox.Location = new System.Drawing.Point(633, 46);
            this.BarcodeBox.Name = "BarcodeBox";
            this.BarcodeBox.Size = new System.Drawing.Size(132, 254);
            this.BarcodeBox.TabIndex = 21;
            // 
            // NameBox
            // 
            this.NameBox.DataSource = this.inventoryBindingSource;
            this.NameBox.DisplayMember = "ProductName";
            this.NameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.NameBox.FormattingEnabled = true;
            this.NameBox.ItemHeight = 25;
            this.NameBox.Location = new System.Drawing.Point(771, 46);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(194, 254);
            this.NameBox.TabIndex = 22;
            // 
            // priceBox
            // 
            this.priceBox.DataSource = this.inventoryBindingSource;
            this.priceBox.DisplayMember = "Price";
            this.priceBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.priceBox.FormattingEnabled = true;
            this.priceBox.ItemHeight = 25;
            this.priceBox.Location = new System.Drawing.Point(971, 46);
            this.priceBox.Name = "priceBox";
            this.priceBox.Size = new System.Drawing.Size(165, 254);
            this.priceBox.TabIndex = 23;
            // 
            // inventory_changes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1148, 347);
            this.Controls.Add(this.priceBox);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.BarcodeBox);
            this.Controls.Add(this.IDBox);
            this.Controls.Add(this.button5);
            this.Controls.Add(iDLabel);
            this.Controls.Add(this.iDTextBox);
            this.Controls.Add(barcodeLabel);
            this.Controls.Add(this.barcodeTextBox);
            this.Controls.Add(productNameLabel);
            this.Controls.Add(this.productNameTextBox);
            this.Controls.Add(priceLabel);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.inventoryBindingNavigator);
            this.Name = "inventory_changes";
            this.Text = "inventory_changes";
            this.Load += new System.EventHandler(this.inventory_changes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.database2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingNavigator)).EndInit();
            this.inventoryBindingNavigator.ResumeLayout(false);
            this.inventoryBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Database2DataSet database2DataSet;
        private System.Windows.Forms.BindingSource inventoryBindingSource;
        private Database2DataSetTableAdapters.inventoryTableAdapter inventoryTableAdapter;
        private Database2DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator inventoryBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton inventoryBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox iDTextBox;
        private System.Windows.Forms.TextBox barcodeTextBox;
        private System.Windows.Forms.TextBox productNameTextBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ListBox IDBox;
        private System.Windows.Forms.ListBox BarcodeBox;
        private System.Windows.Forms.ListBox NameBox;
        private System.Windows.Forms.ListBox priceBox;
    }
}
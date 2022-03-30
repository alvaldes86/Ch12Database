namespace Ch12Database
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            System.Windows.Forms.Label invNumberLabel;
            System.Windows.Forms.Label titleLabel;
            System.Windows.Forms.Label artistLabel;
            System.Windows.Forms.Label priceLabel;
            System.Windows.Forms.Label quantityLabel;
            System.Windows.Forms.Label genreIdLabel;
            this.cDInventory_20171_CDInventory = new Ch12Database.CDInventory_20171_CDInventory();
            this.cDInventoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cDInventoryTableAdapter = new Ch12Database.CDInventory_20171_CDInventoryTableAdapters.CDInventoryTableAdapter();
            this.tableAdapterManager = new Ch12Database.CDInventory_20171_CDInventoryTableAdapters.TableAdapterManager();
            this.cDInventoryBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.cDInventoryBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.invNumberLabel1 = new System.Windows.Forms.Label();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.artistTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.genreIdTextBox = new System.Windows.Forms.TextBox();
            invNumberLabel = new System.Windows.Forms.Label();
            titleLabel = new System.Windows.Forms.Label();
            artistLabel = new System.Windows.Forms.Label();
            priceLabel = new System.Windows.Forms.Label();
            quantityLabel = new System.Windows.Forms.Label();
            genreIdLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cDInventory_20171_CDInventory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cDInventoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cDInventoryBindingNavigator)).BeginInit();
            this.cDInventoryBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // cDInventory_20171_CDInventory
            // 
            this.cDInventory_20171_CDInventory.DataSetName = "CDInventory_20171_CDInventory";
            this.cDInventory_20171_CDInventory.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cDInventoryBindingSource
            // 
            this.cDInventoryBindingSource.DataMember = "CDInventory";
            this.cDInventoryBindingSource.DataSource = this.cDInventory_20171_CDInventory;
            // 
            // cDInventoryTableAdapter
            // 
            this.cDInventoryTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CDInventoryTableAdapter = this.cDInventoryTableAdapter;
            this.tableAdapterManager.UpdateOrder = Ch12Database.CDInventory_20171_CDInventoryTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // cDInventoryBindingNavigator
            // 
            this.cDInventoryBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.cDInventoryBindingNavigator.BindingSource = this.cDInventoryBindingSource;
            this.cDInventoryBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.cDInventoryBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.cDInventoryBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cDInventoryBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.cDInventoryBindingNavigatorSaveItem});
            this.cDInventoryBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.cDInventoryBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.cDInventoryBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.cDInventoryBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.cDInventoryBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.cDInventoryBindingNavigator.Name = "cDInventoryBindingNavigator";
            this.cDInventoryBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.cDInventoryBindingNavigator.Size = new System.Drawing.Size(800, 27);
            this.cDInventoryBindingNavigator.TabIndex = 0;
            this.cDInventoryBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 20);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // cDInventoryBindingNavigatorSaveItem
            // 
            this.cDInventoryBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cDInventoryBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("cDInventoryBindingNavigatorSaveItem.Image")));
            this.cDInventoryBindingNavigatorSaveItem.Name = "cDInventoryBindingNavigatorSaveItem";
            this.cDInventoryBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.cDInventoryBindingNavigatorSaveItem.Text = "Save Data";
            this.cDInventoryBindingNavigatorSaveItem.Click += new System.EventHandler(this.cDInventoryBindingNavigatorSaveItem_Click);
            // 
            // invNumberLabel
            // 
            invNumberLabel.AutoSize = true;
            invNumberLabel.Location = new System.Drawing.Point(37, 69);
            invNumberLabel.Name = "invNumberLabel";
            invNumberLabel.Size = new System.Drawing.Size(78, 16);
            invNumberLabel.TabIndex = 1;
            invNumberLabel.Text = "Inv Number:";
            // 
            // invNumberLabel1
            // 
            this.invNumberLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cDInventoryBindingSource, "InvNumber", true));
            this.invNumberLabel1.Location = new System.Drawing.Point(121, 69);
            this.invNumberLabel1.Name = "invNumberLabel1";
            this.invNumberLabel1.Size = new System.Drawing.Size(100, 23);
            this.invNumberLabel1.TabIndex = 2;
            this.invNumberLabel1.Text = "label1";
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Location = new System.Drawing.Point(37, 98);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new System.Drawing.Size(36, 16);
            titleLabel.TabIndex = 3;
            titleLabel.Text = "Title:";
            // 
            // titleTextBox
            // 
            this.titleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cDInventoryBindingSource, "Title", true));
            this.titleTextBox.Location = new System.Drawing.Point(121, 95);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(100, 22);
            this.titleTextBox.TabIndex = 4;
            // 
            // artistLabel
            // 
            artistLabel.AutoSize = true;
            artistLabel.Location = new System.Drawing.Point(37, 126);
            artistLabel.Name = "artistLabel";
            artistLabel.Size = new System.Drawing.Size(39, 16);
            artistLabel.TabIndex = 5;
            artistLabel.Text = "Artist:";
            // 
            // artistTextBox
            // 
            this.artistTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cDInventoryBindingSource, "Artist", true));
            this.artistTextBox.Location = new System.Drawing.Point(121, 123);
            this.artistTextBox.Name = "artistTextBox";
            this.artistTextBox.Size = new System.Drawing.Size(100, 22);
            this.artistTextBox.TabIndex = 6;
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Location = new System.Drawing.Point(37, 154);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new System.Drawing.Size(41, 16);
            priceLabel.TabIndex = 7;
            priceLabel.Text = "Price:";
            // 
            // priceTextBox
            // 
            this.priceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cDInventoryBindingSource, "Price", true));
            this.priceTextBox.Location = new System.Drawing.Point(121, 151);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(100, 22);
            this.priceTextBox.TabIndex = 8;
            // 
            // quantityLabel
            // 
            quantityLabel.AutoSize = true;
            quantityLabel.Location = new System.Drawing.Point(37, 182);
            quantityLabel.Name = "quantityLabel";
            quantityLabel.Size = new System.Drawing.Size(58, 16);
            quantityLabel.TabIndex = 9;
            quantityLabel.Text = "Quantity:";
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cDInventoryBindingSource, "Quantity", true));
            this.quantityTextBox.Location = new System.Drawing.Point(121, 179);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(100, 22);
            this.quantityTextBox.TabIndex = 10;
            // 
            // genreIdLabel
            // 
            genreIdLabel.AutoSize = true;
            genreIdLabel.Location = new System.Drawing.Point(37, 210);
            genreIdLabel.Name = "genreIdLabel";
            genreIdLabel.Size = new System.Drawing.Size(61, 16);
            genreIdLabel.TabIndex = 11;
            genreIdLabel.Text = "Genre Id:";
            // 
            // genreIdTextBox
            // 
            this.genreIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cDInventoryBindingSource, "GenreId", true));
            this.genreIdTextBox.Location = new System.Drawing.Point(121, 207);
            this.genreIdTextBox.Name = "genreIdTextBox";
            this.genreIdTextBox.Size = new System.Drawing.Size(100, 22);
            this.genreIdTextBox.TabIndex = 12;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(invNumberLabel);
            this.Controls.Add(this.invNumberLabel1);
            this.Controls.Add(titleLabel);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(artistLabel);
            this.Controls.Add(this.artistTextBox);
            this.Controls.Add(priceLabel);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(quantityLabel);
            this.Controls.Add(this.quantityTextBox);
            this.Controls.Add(genreIdLabel);
            this.Controls.Add(this.genreIdTextBox);
            this.Controls.Add(this.cDInventoryBindingNavigator);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cDInventory_20171_CDInventory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cDInventoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cDInventoryBindingNavigator)).EndInit();
            this.cDInventoryBindingNavigator.ResumeLayout(false);
            this.cDInventoryBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CDInventory_20171_CDInventory cDInventory_20171_CDInventory;
        private System.Windows.Forms.BindingSource cDInventoryBindingSource;
        private CDInventory_20171_CDInventoryTableAdapters.CDInventoryTableAdapter cDInventoryTableAdapter;
        private CDInventory_20171_CDInventoryTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator cDInventoryBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton cDInventoryBindingNavigatorSaveItem;
        private System.Windows.Forms.Label invNumberLabel1;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.TextBox artistTextBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.TextBox genreIdTextBox;
    }
}
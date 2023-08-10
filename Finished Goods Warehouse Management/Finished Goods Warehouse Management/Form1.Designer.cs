using System.Windows.Forms;

namespace Finished_Goods_Warehouse_Management
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.WarehouseOverview = new System.Windows.Forms.TabPage();
            this.Orders = new System.Windows.Forms.TabPage();
            this.RefreshOrders = new System.Windows.Forms.Button();
            this.OrderDataGridView = new System.Windows.Forms.DataGridView();
            this.OrderID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductTypeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.options_OD = new System.Windows.Forms.DataGridViewButtonColumn();
            this.IncomingGoods = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.StatusComboBox = new System.Windows.Forms.ComboBox();
            this.IncomingGoodsRefresh = new System.Windows.Forms.Button();
            this.IncomingOrdersDataGridView = new System.Windows.Forms.DataGridView();
            this.ProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StorageLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MessageBoxGroup = new System.Windows.Forms.GroupBox();
            this.MessageBox_IncomingGoods = new System.Windows.Forms.ListView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.GeneratePickList = new System.Windows.Forms.ToolStripMenuItem();
            this.SendForPackaging = new System.Windows.Forms.ToolStripMenuItem();
            this.SendForShipping = new System.Windows.Forms.ToolStripMenuItem();
            this.ProductMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.AssignStorageLocation = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.Orders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrderDataGridView)).BeginInit();
            this.IncomingGoods.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IncomingOrdersDataGridView)).BeginInit();
            this.MessageBoxGroup.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.ProductMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tabControl1);
            this.splitContainer1.Panel1.Cursor = System.Windows.Forms.Cursors.HSplit;
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint_1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.MessageBoxGroup);
            this.splitContainer1.Panel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.splitContainer1.Size = new System.Drawing.Size(842, 457);
            this.splitContainer1.SplitterDistance = 270;
            this.splitContainer1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.WarehouseOverview);
            this.tabControl1.Controls.Add(this.Orders);
            this.tabControl1.Controls.Add(this.IncomingGoods);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(842, 267);
            this.tabControl1.TabIndex = 0;
            // 
            // WarehouseOverview
            // 
            this.WarehouseOverview.Cursor = System.Windows.Forms.Cursors.Default;
            this.WarehouseOverview.Location = new System.Drawing.Point(4, 22);
            this.WarehouseOverview.Name = "WarehouseOverview";
            this.WarehouseOverview.Padding = new System.Windows.Forms.Padding(3);
            this.WarehouseOverview.Size = new System.Drawing.Size(834, 241);
            this.WarehouseOverview.TabIndex = 0;
            this.WarehouseOverview.Text = "Warehouse Overview";
            this.WarehouseOverview.UseVisualStyleBackColor = true;
            // 
            // Orders
            // 
            this.Orders.Controls.Add(this.RefreshOrders);
            this.Orders.Controls.Add(this.OrderDataGridView);
            this.Orders.Cursor = System.Windows.Forms.Cursors.Default;
            this.Orders.Location = new System.Drawing.Point(4, 22);
            this.Orders.Name = "Orders";
            this.Orders.Padding = new System.Windows.Forms.Padding(3);
            this.Orders.Size = new System.Drawing.Size(834, 241);
            this.Orders.TabIndex = 1;
            this.Orders.Text = "Orders";
            this.Orders.UseVisualStyleBackColor = true;
            // 
            // RefreshOrders
            // 
            this.RefreshOrders.Location = new System.Drawing.Point(756, 3);
            this.RefreshOrders.Name = "RefreshOrders";
            this.RefreshOrders.Size = new System.Drawing.Size(75, 23);
            this.RefreshOrders.TabIndex = 2;
            this.RefreshOrders.Text = "Refresh";
            this.RefreshOrders.UseVisualStyleBackColor = true;
            this.RefreshOrders.Click += new System.EventHandler(this.RefreshOrders_Click);
            // 
            // OrderDataGridView
            // 
            this.OrderDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OrderDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrderDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OrderID,
            this.CustomerID,
            this.ProductTypeID,
            this.Quantity,
            this.Date,
            this.DueDate,
            this.Status,
            this.options_OD});
            this.OrderDataGridView.Location = new System.Drawing.Point(3, 32);
            this.OrderDataGridView.Name = "OrderDataGridView";
            this.OrderDataGridView.ReadOnly = true;
            this.OrderDataGridView.Size = new System.Drawing.Size(828, 206);
            this.OrderDataGridView.TabIndex = 1;
            this.OrderDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OrderDataGridView_CellClick);
            this.OrderDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OrderDataGridView_CellContentClick);
            this.OrderDataGridView.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OrderDataGridView_CellContentDoubleClick);
            // 
            // OrderID
            // 
            this.OrderID.HeaderText = "Order ID";
            this.OrderID.Name = "OrderID";
            this.OrderID.ReadOnly = true;
            // 
            // CustomerID
            // 
            this.CustomerID.HeaderText = "Customer ID";
            this.CustomerID.Name = "CustomerID";
            this.CustomerID.ReadOnly = true;
            // 
            // ProductTypeID
            // 
            this.ProductTypeID.HeaderText = "Product Type ID";
            this.ProductTypeID.Name = "ProductTypeID";
            this.ProductTypeID.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // DueDate
            // 
            this.DueDate.HeaderText = "Due Date";
            this.DueDate.Name = "DueDate";
            this.DueDate.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // options_OD
            // 
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            this.options_OD.DefaultCellStyle = dataGridViewCellStyle9;
            this.options_OD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.options_OD.HeaderText = "";
            this.options_OD.MinimumWidth = 6;
            this.options_OD.Name = "options_OD";
            this.options_OD.ReadOnly = true;
            this.options_OD.Text = "...";
            this.options_OD.UseColumnTextForButtonValue = true;
            // 
            // IncomingGoods
            // 
            this.IncomingGoods.Controls.Add(this.label1);
            this.IncomingGoods.Controls.Add(this.StatusComboBox);
            this.IncomingGoods.Controls.Add(this.IncomingGoodsRefresh);
            this.IncomingGoods.Controls.Add(this.IncomingOrdersDataGridView);
            this.IncomingGoods.Cursor = System.Windows.Forms.Cursors.Default;
            this.IncomingGoods.Location = new System.Drawing.Point(4, 22);
            this.IncomingGoods.Name = "IncomingGoods";
            this.IncomingGoods.Padding = new System.Windows.Forms.Padding(3);
            this.IncomingGoods.Size = new System.Drawing.Size(834, 241);
            this.IncomingGoods.TabIndex = 2;
            this.IncomingGoods.Text = "Incoming Goods";
            this.IncomingGoods.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Status:";
            // 
            // StatusComboBox
            // 
            this.StatusComboBox.FormattingEnabled = true;
            this.StatusComboBox.Items.AddRange(new object[] {
            "Consumable",
            "Blocked",
            "Consumed"});
            this.StatusComboBox.Location = new System.Drawing.Point(54, 6);
            this.StatusComboBox.Name = "StatusComboBox";
            this.StatusComboBox.Size = new System.Drawing.Size(121, 21);
            this.StatusComboBox.TabIndex = 2;
            // 
            // IncomingGoodsRefresh
            // 
            this.IncomingGoodsRefresh.Location = new System.Drawing.Point(366, 6);
            this.IncomingGoodsRefresh.Name = "IncomingGoodsRefresh";
            this.IncomingGoodsRefresh.Size = new System.Drawing.Size(75, 23);
            this.IncomingGoodsRefresh.TabIndex = 1;
            this.IncomingGoodsRefresh.Text = "Refresh";
            this.IncomingGoodsRefresh.UseVisualStyleBackColor = true;
            this.IncomingGoodsRefresh.Click += new System.EventHandler(this.IncomingGoodsRefresh_Click);
            // 
            // IncomingOrdersDataGridView
            // 
            this.IncomingOrdersDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.IncomingOrdersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.IncomingOrdersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductID,
            this.TypeID,
            this.StorageLocation,
            this.ProductStatus});
            this.IncomingOrdersDataGridView.Location = new System.Drawing.Point(0, 29);
            this.IncomingOrdersDataGridView.Name = "IncomingOrdersDataGridView";
            this.IncomingOrdersDataGridView.Size = new System.Drawing.Size(441, 212);
            this.IncomingOrdersDataGridView.TabIndex = 0;
            this.IncomingOrdersDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.IncomingOrdersDataGridView_CellContentClick);
            this.IncomingOrdersDataGridView.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.IncomingOrdersDataGridView_CellContentDoubleClick);
            // 
            // ProductID
            // 
            this.ProductID.HeaderText = "Product ID";
            this.ProductID.Name = "ProductID";
            this.ProductID.ReadOnly = true;
            // 
            // TypeID
            // 
            this.TypeID.HeaderText = "TypeID";
            this.TypeID.Name = "TypeID";
            this.TypeID.ReadOnly = true;
            // 
            // StorageLocation
            // 
            this.StorageLocation.HeaderText = "Storage Location";
            this.StorageLocation.Name = "StorageLocation";
            this.StorageLocation.ReadOnly = true;
            // 
            // ProductStatus
            // 
            this.ProductStatus.HeaderText = "Status";
            this.ProductStatus.Name = "ProductStatus";
            this.ProductStatus.ReadOnly = true;
            // 
            // MessageBoxGroup
            // 
            this.MessageBoxGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MessageBoxGroup.Controls.Add(this.MessageBox_IncomingGoods);
            this.MessageBoxGroup.Location = new System.Drawing.Point(4, 3);
            this.MessageBoxGroup.Name = "MessageBoxGroup";
            this.MessageBoxGroup.Size = new System.Drawing.Size(834, 177);
            this.MessageBoxGroup.TabIndex = 0;
            this.MessageBoxGroup.TabStop = false;
            this.MessageBoxGroup.Text = "Message Box";
            // 
            // MessageBox_IncomingGoods
            // 
            this.MessageBox_IncomingGoods.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MessageBox_IncomingGoods.HideSelection = false;
            this.MessageBox_IncomingGoods.Location = new System.Drawing.Point(8, 19);
            this.MessageBox_IncomingGoods.Name = "MessageBox_IncomingGoods";
            this.MessageBox_IncomingGoods.Size = new System.Drawing.Size(818, 149);
            this.MessageBox_IncomingGoods.TabIndex = 0;
            this.MessageBox_IncomingGoods.UseCompatibleStateImageBehavior = false;
            this.MessageBox_IncomingGoods.View = System.Windows.Forms.View.List;
            this.MessageBox_IncomingGoods.SelectedIndexChanged += new System.EventHandler(this.MessageBox_IncomingGoods_SelectedIndexChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.GeneratePickList,
            this.SendForPackaging,
            this.SendForShipping});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(177, 70);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // GeneratePickList
            // 
            this.GeneratePickList.Enabled = false;
            this.GeneratePickList.Name = "GeneratePickList";
            this.GeneratePickList.Size = new System.Drawing.Size(176, 22);
            this.GeneratePickList.Text = "Generate PickList";
            this.GeneratePickList.Click += new System.EventHandler(this.GeneratePickList_Click);
            // 
            // SendForPackaging
            // 
            this.SendForPackaging.Enabled = false;
            this.SendForPackaging.Name = "SendForPackaging";
            this.SendForPackaging.Size = new System.Drawing.Size(176, 22);
            this.SendForPackaging.Text = "Send for Packaging";
            this.SendForPackaging.Click += new System.EventHandler(this.SendForPackaging_Click);
            // 
            // SendForShipping
            // 
            this.SendForShipping.Enabled = false;
            this.SendForShipping.Name = "SendForShipping";
            this.SendForShipping.Size = new System.Drawing.Size(176, 22);
            this.SendForShipping.Text = "Send for Shipping";
            this.SendForShipping.Click += new System.EventHandler(this.SendForShipping_Click);
            // 
            // ProductMenuStrip
            // 
            this.ProductMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AssignStorageLocation});
            this.ProductMenuStrip.Name = "ProductMenuStrip";
            this.ProductMenuStrip.Size = new System.Drawing.Size(202, 26);
            this.ProductMenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.ProductMenuStrip_Opening);
            // 
            // AssignStorageLocation
            // 
            this.AssignStorageLocation.Name = "AssignStorageLocation";
            this.AssignStorageLocation.Size = new System.Drawing.Size(201, 22);
            this.AssignStorageLocation.Text = "Assign Storage Location";
            this.AssignStorageLocation.Click += new System.EventHandler(this.AssignStorageLocation_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(842, 457);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Finished Goods Warehouse Management";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.Orders.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.OrderDataGridView)).EndInit();
            this.IncomingGoods.ResumeLayout(false);
            this.IncomingGoods.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IncomingOrdersDataGridView)).EndInit();
            this.MessageBoxGroup.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ProductMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private SplitContainer splitContainer1;
        private TabControl tabControl1;
        private TabPage WarehouseOverview;
        private TabPage Orders;
        private TabPage IncomingGoods;
        private Button RefreshOrders;
        private DataGridView OrderDataGridView;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem GeneratePickList;
        private ToolStripMenuItem SendForPackaging;
        private ToolStripMenuItem SendForShipping;
        private DataGridView IncomingOrdersDataGridView;
        private Button IncomingGoodsRefresh;
        private Label label1;
        private ComboBox StatusComboBox;
        private DataGridViewTextBoxColumn ProductID;
        private DataGridViewTextBoxColumn TypeID;
        private DataGridViewTextBoxColumn StorageLocation;
        private DataGridViewTextBoxColumn ProductStatus;
        private ContextMenuStrip ProductMenuStrip;
        private ToolStripMenuItem AssignStorageLocation;
        private GroupBox MessageBoxGroup;
        private ListView MessageBox_IncomingGoods;
        private DataGridViewTextBoxColumn OrderID;
        private DataGridViewTextBoxColumn CustomerID;
        private DataGridViewTextBoxColumn ProductTypeID;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn Date;
        private DataGridViewTextBoxColumn DueDate;
        private DataGridViewTextBoxColumn Status;
        private DataGridViewButtonColumn options_OD;
    }
}


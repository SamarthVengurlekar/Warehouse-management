namespace Finished_Goods_Warehouse_Management
{
    partial class PickList
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
            this.SendToForwardPicking = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PickListIdLabel = new System.Windows.Forms.Label();
            this.PickListGroupBox = new System.Windows.Forms.GroupBox();
            this.PickListDataGridView = new System.Windows.Forms.DataGridView();
            this.Sl_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StorageLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.create_pdf = new System.Windows.Forms.Button();
            this.PickListGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PickListDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // SendToForwardPicking
            // 
            this.SendToForwardPicking.Location = new System.Drawing.Point(238, 226);
            this.SendToForwardPicking.Name = "SendToForwardPicking";
            this.SendToForwardPicking.Size = new System.Drawing.Size(166, 23);
            this.SendToForwardPicking.TabIndex = 1;
            this.SendToForwardPicking.Text = "Proceed to Forward Picking";
            this.SendToForwardPicking.UseVisualStyleBackColor = true;
            this.SendToForwardPicking.Click += new System.EventHandler(this.SendToForwardPicking_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(33, 252);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(371, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "After clicking the button, Products will be blocked and sent for foward picking";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Picklist ID: ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // PickListIdLabel
            // 
            this.PickListIdLabel.AutoSize = true;
            this.PickListIdLabel.Location = new System.Drawing.Point(98, 13);
            this.PickListIdLabel.Name = "PickListIdLabel";
            this.PickListIdLabel.Size = new System.Drawing.Size(0, 13);
            this.PickListIdLabel.TabIndex = 4;
            // 
            // PickListGroupBox
            // 
            this.PickListGroupBox.Controls.Add(this.PickListDataGridView);
            this.PickListGroupBox.Location = new System.Drawing.Point(27, 41);
            this.PickListGroupBox.Name = "PickListGroupBox";
            this.PickListGroupBox.Size = new System.Drawing.Size(377, 169);
            this.PickListGroupBox.TabIndex = 5;
            this.PickListGroupBox.TabStop = false;
            this.PickListGroupBox.Text = "Picklist";
            // 
            // PickListDataGridView
            // 
            this.PickListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PickListDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Sl_no,
            this.ProductID,
            this.StorageLocation});
            this.PickListDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PickListDataGridView.Location = new System.Drawing.Point(3, 16);
            this.PickListDataGridView.Name = "PickListDataGridView";
            this.PickListDataGridView.Size = new System.Drawing.Size(371, 150);
            this.PickListDataGridView.TabIndex = 0;
            // 
            // Sl_no
            // 
            this.Sl_no.HeaderText = "Sl.no";
            this.Sl_no.Name = "Sl_no";
            this.Sl_no.ReadOnly = true;
            // 
            // ProductID
            // 
            this.ProductID.HeaderText = "Product ID";
            this.ProductID.Name = "ProductID";
            this.ProductID.ReadOnly = true;
            // 
            // StorageLocation
            // 
            this.StorageLocation.HeaderText = "Storage Location";
            this.StorageLocation.Name = "StorageLocation";
            this.StorageLocation.ReadOnly = true;
            // 
            // create_pdf
            // 
            this.create_pdf.Location = new System.Drawing.Point(27, 226);
            this.create_pdf.Name = "create_pdf";
            this.create_pdf.Size = new System.Drawing.Size(75, 23);
            this.create_pdf.TabIndex = 6;
            this.create_pdf.Text = "Create PDF";
            this.create_pdf.UseVisualStyleBackColor = true;
            this.create_pdf.Click += new System.EventHandler(this.create_pdf_Click);
            // 
            // PickList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 279);
            this.Controls.Add(this.create_pdf);
            this.Controls.Add(this.PickListGroupBox);
            this.Controls.Add(this.PickListIdLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SendToForwardPicking);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "PickList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PickList";
            this.Load += new System.EventHandler(this.PickList_Load);
            this.PickListGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PickListDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button SendToForwardPicking;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label PickListIdLabel;
        private System.Windows.Forms.GroupBox PickListGroupBox;
        private System.Windows.Forms.DataGridView PickListDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sl_no;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn StorageLocation;
        private System.Windows.Forms.Button create_pdf;
    }
}
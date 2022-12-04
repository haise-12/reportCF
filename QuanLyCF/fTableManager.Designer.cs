namespace QuanLyCF
{
    partial class fTableManager
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinTàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinCáNhânToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LogOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lsvBill = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel3 = new System.Windows.Forms.Panel();
            this.txbTotalPrice = new System.Windows.Forms.TextBox();
            this.nmDiscount = new System.Windows.Forms.NumericUpDown();
            this.bntDiscount = new System.Windows.Forms.Button();
            this.bntCheckOut = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.nmBeverageCount = new System.Windows.Forms.NumericUpDown();
            this.bntAddBeverage = new System.Windows.Forms.Button();
            this.cbBeverage = new System.Windows.Forms.ComboBox();
            this.cbCatagory = new System.Windows.Forms.ComboBox();
            this.flpTable = new System.Windows.Forms.FlowLayoutPanel();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmDiscount)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmBeverageCount)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.AliceBlue;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminToolStripMenuItem,
            this.thôngTinTàiKhoảnToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1505, 40);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(97, 38);
            this.adminToolStripMenuItem.Text = "Admin";
            this.adminToolStripMenuItem.Click += new System.EventHandler(this.adminToolStripMenuItem_Click);
            // 
            // thôngTinTàiKhoảnToolStripMenuItem
            // 
            this.thôngTinTàiKhoảnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinCáNhânToolStripMenuItem,
            this.LogOutToolStripMenuItem});
            this.thôngTinTàiKhoảnToolStripMenuItem.Name = "thôngTinTàiKhoảnToolStripMenuItem";
            this.thôngTinTàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(237, 38);
            this.thôngTinTàiKhoảnToolStripMenuItem.Text = "Thông tin tài khoản";
            // 
            // thôngTinCáNhânToolStripMenuItem
            // 
            this.thôngTinCáNhânToolStripMenuItem.Name = "thôngTinCáNhânToolStripMenuItem";
            this.thôngTinCáNhânToolStripMenuItem.Size = new System.Drawing.Size(309, 38);
            this.thôngTinCáNhânToolStripMenuItem.Text = "Thông tin cá nhân";
            this.thôngTinCáNhânToolStripMenuItem.Click += new System.EventHandler(this.thôngTinCáNhânToolStripMenuItem_Click);
            // 
            // LogOutToolStripMenuItem
            // 
            this.LogOutToolStripMenuItem.Name = "LogOutToolStripMenuItem";
            this.LogOutToolStripMenuItem.Size = new System.Drawing.Size(309, 38);
            this.LogOutToolStripMenuItem.Text = "Đăng xuất";
            this.LogOutToolStripMenuItem.Click += new System.EventHandler(this.LogOutToolStripMenuItem_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lsvBill);
            this.panel2.Location = new System.Drawing.Point(65, 57);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(877, 363);
            this.panel2.TabIndex = 2;
            // 
            // lsvBill
            // 
            this.lsvBill.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.lsvBill.BackColor = System.Drawing.Color.AliceBlue;
            this.lsvBill.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lsvBill.Location = new System.Drawing.Point(3, 5);
            this.lsvBill.Name = "lsvBill";
            this.lsvBill.Size = new System.Drawing.Size(871, 355);
            this.lsvBill.TabIndex = 0;
            this.lsvBill.TileSize = new System.Drawing.Size(200, 54);
            this.lsvBill.UseCompatibleStateImageBehavior = false;
            this.lsvBill.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tên món";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Số lượng";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Giá";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Thành tiền";
            this.columnHeader4.Width = 120;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txbTotalPrice);
            this.panel3.Controls.Add(this.nmDiscount);
            this.panel3.Controls.Add(this.bntDiscount);
            this.panel3.Controls.Add(this.bntCheckOut);
            this.panel3.Location = new System.Drawing.Point(951, 235);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(498, 194);
            this.panel3.TabIndex = 3;
            // 
            // txbTotalPrice
            // 
            this.txbTotalPrice.BackColor = System.Drawing.Color.AliceBlue;
            this.txbTotalPrice.Font = new System.Drawing.Font("Arial", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTotalPrice.ForeColor = System.Drawing.Color.Maroon;
            this.txbTotalPrice.Location = new System.Drawing.Point(18, 31);
            this.txbTotalPrice.Name = "txbTotalPrice";
            this.txbTotalPrice.ReadOnly = true;
            this.txbTotalPrice.Size = new System.Drawing.Size(263, 50);
            this.txbTotalPrice.TabIndex = 7;
            this.txbTotalPrice.Text = "0";
            this.txbTotalPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nmDiscount
            // 
            this.nmDiscount.BackColor = System.Drawing.Color.AliceBlue;
            this.nmDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmDiscount.Location = new System.Drawing.Point(170, 103);
            this.nmDiscount.Name = "nmDiscount";
            this.nmDiscount.Size = new System.Drawing.Size(111, 38);
            this.nmDiscount.TabIndex = 4;
            this.nmDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bntDiscount
            // 
            this.bntDiscount.BackColor = System.Drawing.Color.AliceBlue;
            this.bntDiscount.Location = new System.Drawing.Point(18, 105);
            this.bntDiscount.Name = "bntDiscount";
            this.bntDiscount.Size = new System.Drawing.Size(132, 38);
            this.bntDiscount.TabIndex = 5;
            this.bntDiscount.Text = "Giảm giá";
            this.bntDiscount.UseVisualStyleBackColor = false;
            // 
            // bntCheckOut
            // 
            this.bntCheckOut.BackColor = System.Drawing.Color.AliceBlue;
            this.bntCheckOut.Location = new System.Drawing.Point(318, 31);
            this.bntCheckOut.Name = "bntCheckOut";
            this.bntCheckOut.Size = new System.Drawing.Size(152, 110);
            this.bntCheckOut.TabIndex = 4;
            this.bntCheckOut.Text = "Thanh toán";
            this.bntCheckOut.UseVisualStyleBackColor = false;
            this.bntCheckOut.Click += new System.EventHandler(this.bntCheckOut_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.nmBeverageCount);
            this.panel4.Controls.Add(this.bntAddBeverage);
            this.panel4.Controls.Add(this.cbBeverage);
            this.panel4.Controls.Add(this.cbCatagory);
            this.panel4.Location = new System.Drawing.Point(948, 57);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(501, 154);
            this.panel4.TabIndex = 4;
            // 
            // nmBeverageCount
            // 
            this.nmBeverageCount.BackColor = System.Drawing.Color.AliceBlue;
            this.nmBeverageCount.Location = new System.Drawing.Point(342, 95);
            this.nmBeverageCount.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nmBeverageCount.Name = "nmBeverageCount";
            this.nmBeverageCount.Size = new System.Drawing.Size(120, 31);
            this.nmBeverageCount.TabIndex = 3;
            this.nmBeverageCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nmBeverageCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // bntAddBeverage
            // 
            this.bntAddBeverage.BackColor = System.Drawing.Color.AliceBlue;
            this.bntAddBeverage.Location = new System.Drawing.Point(342, 8);
            this.bntAddBeverage.Name = "bntAddBeverage";
            this.bntAddBeverage.Size = new System.Drawing.Size(131, 81);
            this.bntAddBeverage.TabIndex = 2;
            this.bntAddBeverage.Text = "Thêm món";
            this.bntAddBeverage.UseVisualStyleBackColor = false;
            this.bntAddBeverage.Click += new System.EventHandler(this.bntAddBeverage_Click);
            // 
            // cbBeverage
            // 
            this.cbBeverage.BackColor = System.Drawing.Color.AliceBlue;
            this.cbBeverage.FormattingEnabled = true;
            this.cbBeverage.Location = new System.Drawing.Point(3, 64);
            this.cbBeverage.Name = "cbBeverage";
            this.cbBeverage.Size = new System.Drawing.Size(314, 33);
            this.cbBeverage.TabIndex = 1;
            // 
            // cbCatagory
            // 
            this.cbCatagory.BackColor = System.Drawing.Color.AliceBlue;
            this.cbCatagory.FormattingEnabled = true;
            this.cbCatagory.Location = new System.Drawing.Point(3, 16);
            this.cbCatagory.Name = "cbCatagory";
            this.cbCatagory.Size = new System.Drawing.Size(314, 33);
            this.cbCatagory.TabIndex = 0;
            this.cbCatagory.SelectedIndexChanged += new System.EventHandler(this.cbCategory_SelectedIndexChanged);
            // 
            // flpTable
            // 
            this.flpTable.AutoScroll = true;
            this.flpTable.Location = new System.Drawing.Point(65, 456);
            this.flpTable.Name = "flpTable";
            this.flpTable.Size = new System.Drawing.Size(1381, 482);
            this.flpTable.TabIndex = 5;
            // 
            // fTableManager
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1505, 981);
            this.Controls.Add(this.flpTable);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.menuStrip1);
            this.Name = "fTableManager";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần Mềm Quản lý Cafe";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmDiscount)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nmBeverageCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinTàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinCáNhânToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LogOutToolStripMenuItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.NumericUpDown nmDiscount;
        private System.Windows.Forms.Button bntDiscount;
        private System.Windows.Forms.Button bntCheckOut;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.NumericUpDown nmBeverageCount;
        private System.Windows.Forms.Button bntAddBeverage;
        private System.Windows.Forms.ComboBox cbBeverage;
        private System.Windows.Forms.ComboBox cbCatagory;
        private System.Windows.Forms.FlowLayoutPanel flpTable;
        private System.Windows.Forms.ListView lsvBill;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.TextBox txbTotalPrice;
    }
}
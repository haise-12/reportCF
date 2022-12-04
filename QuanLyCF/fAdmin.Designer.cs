namespace QuanLyCF
{
    partial class fAdmin
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
            this.tpAccount = new System.Windows.Forms.TabPage();
            this.panel23 = new System.Windows.Forms.Panel();
            this.btnResetPass = new System.Windows.Forms.Button();
            this.panel25 = new System.Windows.Forms.Panel();
            this.nmAccType = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.panel26 = new System.Windows.Forms.Panel();
            this.txbAccDisplay = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.panel27 = new System.Windows.Forms.Panel();
            this.txbAccName = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.panel28 = new System.Windows.Forms.Panel();
            this.btnShowAcc = new System.Windows.Forms.Button();
            this.btnUpdateAcc = new System.Windows.Forms.Button();
            this.btnDeleteAcc = new System.Windows.Forms.Button();
            this.btnAddAcc = new System.Windows.Forms.Button();
            this.panel29 = new System.Windows.Forms.Panel();
            this.dtgvAccount = new System.Windows.Forms.DataGridView();
            this.tpBeverage = new System.Windows.Forms.TabPage();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txbSearchBeverageName = new System.Windows.Forms.TextBox();
            this.btnSearchBeverage = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dtgvBeverage = new System.Windows.Forms.DataGridView();
            this.panel10 = new System.Windows.Forms.Panel();
            this.nmBeveragePrice = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.cbBeverageCategory = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.txbBeverageName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.txbBeverageId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnShowBeverage = new System.Windows.Forms.Button();
            this.btnUpdateBeverage = new System.Windows.Forms.Button();
            this.btnDeleteBeverage = new System.Windows.Forms.Button();
            this.btnAddBeverage = new System.Windows.Forms.Button();
            this.tpBill = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnViewBill = new System.Windows.Forms.Button();
            this.dtpkToDate = new System.Windows.Forms.DateTimePicker();
            this.dtpkFromDate = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtgvBill = new System.Windows.Forms.DataGridView();
            this.tcAdmin = new System.Windows.Forms.TabControl();
            this.tpAccount.SuspendLayout();
            this.panel23.SuspendLayout();
            this.panel25.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmAccType)).BeginInit();
            this.panel26.SuspendLayout();
            this.panel27.SuspendLayout();
            this.panel28.SuspendLayout();
            this.panel29.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAccount)).BeginInit();
            this.tpBeverage.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBeverage)).BeginInit();
            this.panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmBeveragePrice)).BeginInit();
            this.panel9.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tpBill.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBill)).BeginInit();
            this.tcAdmin.SuspendLayout();
            this.SuspendLayout();
            // 
            // tpAccount
            // 
            this.tpAccount.Controls.Add(this.panel23);
            this.tpAccount.Controls.Add(this.panel28);
            this.tpAccount.Controls.Add(this.panel29);
            this.tpAccount.Location = new System.Drawing.Point(8, 39);
            this.tpAccount.Name = "tpAccount";
            this.tpAccount.Padding = new System.Windows.Forms.Padding(3);
            this.tpAccount.Size = new System.Drawing.Size(1488, 902);
            this.tpAccount.TabIndex = 4;
            this.tpAccount.Text = "Tài khoản";
            this.tpAccount.UseVisualStyleBackColor = true;
            // 
            // panel23
            // 
            this.panel23.Controls.Add(this.btnResetPass);
            this.panel23.Controls.Add(this.panel25);
            this.panel23.Controls.Add(this.panel26);
            this.panel23.Controls.Add(this.panel27);
            this.panel23.Location = new System.Drawing.Point(627, 111);
            this.panel23.Name = "panel23";
            this.panel23.Size = new System.Drawing.Size(855, 785);
            this.panel23.TabIndex = 4;
            // 
            // btnResetPass
            // 
            this.btnResetPass.Location = new System.Drawing.Point(294, 583);
            this.btnResetPass.Name = "btnResetPass";
            this.btnResetPass.Size = new System.Drawing.Size(208, 74);
            this.btnResetPass.TabIndex = 4;
            this.btnResetPass.Text = "Đặt lại mật khẩu";
            this.btnResetPass.UseVisualStyleBackColor = true;
            this.btnResetPass.Click += new System.EventHandler(this.btnResetPass_Click);
            // 
            // panel25
            // 
            this.panel25.Controls.Add(this.nmAccType);
            this.panel25.Controls.Add(this.label11);
            this.panel25.Location = new System.Drawing.Point(135, 392);
            this.panel25.Name = "panel25";
            this.panel25.Size = new System.Drawing.Size(580, 103);
            this.panel25.TabIndex = 3;
            // 
            // nmAccType
            // 
            this.nmAccType.Location = new System.Drawing.Point(230, 40);
            this.nmAccType.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmAccType.Name = "nmAccType";
            this.nmAccType.Size = new System.Drawing.Size(96, 31);
            this.nmAccType.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(13, 40);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(211, 32);
            this.label11.TabIndex = 0;
            this.label11.Text = "Loại tài khoản:";
            // 
            // panel26
            // 
            this.panel26.Controls.Add(this.txbAccDisplay);
            this.panel26.Controls.Add(this.label12);
            this.panel26.Location = new System.Drawing.Point(135, 237);
            this.panel26.Name = "panel26";
            this.panel26.Size = new System.Drawing.Size(580, 103);
            this.panel26.TabIndex = 2;
            // 
            // txbAccDisplay
            // 
            this.txbAccDisplay.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbAccDisplay.Location = new System.Drawing.Point(223, 30);
            this.txbAccDisplay.Name = "txbAccDisplay";
            this.txbAccDisplay.Size = new System.Drawing.Size(301, 39);
            this.txbAccDisplay.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(13, 34);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(182, 32);
            this.label12.TabIndex = 0;
            this.label12.Text = "Tên hiển thị:";
            // 
            // panel27
            // 
            this.panel27.Controls.Add(this.txbAccName);
            this.panel27.Controls.Add(this.label13);
            this.panel27.Location = new System.Drawing.Point(135, 99);
            this.panel27.Name = "panel27";
            this.panel27.Size = new System.Drawing.Size(580, 85);
            this.panel27.TabIndex = 1;
            // 
            // txbAccName
            // 
            this.txbAccName.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbAccName.Location = new System.Drawing.Point(223, 22);
            this.txbAccName.Name = "txbAccName";
            this.txbAccName.Size = new System.Drawing.Size(301, 39);
            this.txbAccName.TabIndex = 1;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(13, 22);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(204, 32);
            this.label13.TabIndex = 0;
            this.label13.Text = "Tên tài khoản:";
            // 
            // panel28
            // 
            this.panel28.Controls.Add(this.btnShowAcc);
            this.panel28.Controls.Add(this.btnUpdateAcc);
            this.panel28.Controls.Add(this.btnDeleteAcc);
            this.panel28.Controls.Add(this.btnAddAcc);
            this.panel28.Location = new System.Drawing.Point(15, 6);
            this.panel28.Name = "panel28";
            this.panel28.Size = new System.Drawing.Size(592, 99);
            this.panel28.TabIndex = 5;
            // 
            // btnShowAcc
            // 
            this.btnShowAcc.Location = new System.Drawing.Point(428, 13);
            this.btnShowAcc.Name = "btnShowAcc";
            this.btnShowAcc.Size = new System.Drawing.Size(121, 74);
            this.btnShowAcc.TabIndex = 3;
            this.btnShowAcc.Text = "Xem";
            this.btnShowAcc.UseVisualStyleBackColor = true;
            this.btnShowAcc.Click += new System.EventHandler(this.btnShowAcc_Click);
            // 
            // btnUpdateAcc
            // 
            this.btnUpdateAcc.Location = new System.Drawing.Point(285, 13);
            this.btnUpdateAcc.Name = "btnUpdateAcc";
            this.btnUpdateAcc.Size = new System.Drawing.Size(121, 74);
            this.btnUpdateAcc.TabIndex = 2;
            this.btnUpdateAcc.Text = "Sửa";
            this.btnUpdateAcc.UseVisualStyleBackColor = true;
            this.btnUpdateAcc.Click += new System.EventHandler(this.btnUpdateAcc_Click);
            // 
            // btnDeleteAcc
            // 
            this.btnDeleteAcc.Location = new System.Drawing.Point(151, 13);
            this.btnDeleteAcc.Name = "btnDeleteAcc";
            this.btnDeleteAcc.Size = new System.Drawing.Size(118, 74);
            this.btnDeleteAcc.TabIndex = 1;
            this.btnDeleteAcc.Text = "Xóa";
            this.btnDeleteAcc.UseVisualStyleBackColor = true;
            this.btnDeleteAcc.Click += new System.EventHandler(this.btnDeleteAcc_Click);
            // 
            // btnAddAcc
            // 
            this.btnAddAcc.Location = new System.Drawing.Point(18, 13);
            this.btnAddAcc.Name = "btnAddAcc";
            this.btnAddAcc.Size = new System.Drawing.Size(118, 74);
            this.btnAddAcc.TabIndex = 0;
            this.btnAddAcc.Text = "Thêm";
            this.btnAddAcc.UseVisualStyleBackColor = true;
            this.btnAddAcc.Click += new System.EventHandler(this.btnAddAcc_Click);
            // 
            // panel29
            // 
            this.panel29.Controls.Add(this.dtgvAccount);
            this.panel29.Location = new System.Drawing.Point(3, 111);
            this.panel29.Name = "panel29";
            this.panel29.Size = new System.Drawing.Size(604, 785);
            this.panel29.TabIndex = 3;
            // 
            // dtgvAccount
            // 
            this.dtgvAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvAccount.Location = new System.Drawing.Point(3, 3);
            this.dtgvAccount.Name = "dtgvAccount";
            this.dtgvAccount.RowTemplate.Height = 33;
            this.dtgvAccount.Size = new System.Drawing.Size(598, 779);
            this.dtgvAccount.TabIndex = 0;
            // 
            // tpBeverage
            // 
            this.tpBeverage.Controls.Add(this.panel6);
            this.tpBeverage.Controls.Add(this.panel5);
            this.tpBeverage.Controls.Add(this.panel4);
            this.tpBeverage.Location = new System.Drawing.Point(8, 39);
            this.tpBeverage.Name = "tpBeverage";
            this.tpBeverage.Padding = new System.Windows.Forms.Padding(3);
            this.tpBeverage.Size = new System.Drawing.Size(1488, 902);
            this.tpBeverage.TabIndex = 1;
            this.tpBeverage.Text = "Đồ uống";
            this.tpBeverage.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.txbSearchBeverageName);
            this.panel6.Controls.Add(this.btnSearchBeverage);
            this.panel6.Location = new System.Drawing.Point(6, 6);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(555, 95);
            this.panel6.TabIndex = 2;
            // 
            // txbSearchBeverageName
            // 
            this.txbSearchBeverageName.Location = new System.Drawing.Point(9, 31);
            this.txbSearchBeverageName.Name = "txbSearchBeverageName";
            this.txbSearchBeverageName.Size = new System.Drawing.Size(395, 31);
            this.txbSearchBeverageName.TabIndex = 5;
            // 
            // btnSearchBeverage
            // 
            this.btnSearchBeverage.Location = new System.Drawing.Point(426, 9);
            this.btnSearchBeverage.Name = "btnSearchBeverage";
            this.btnSearchBeverage.Size = new System.Drawing.Size(121, 74);
            this.btnSearchBeverage.TabIndex = 4;
            this.btnSearchBeverage.Text = "Tìm";
            this.btnSearchBeverage.UseVisualStyleBackColor = true;
            this.btnSearchBeverage.Click += new System.EventHandler(this.btnSearchBeverage_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.dtgvBeverage);
            this.panel5.Controls.Add(this.panel10);
            this.panel5.Controls.Add(this.panel9);
            this.panel5.Controls.Add(this.panel8);
            this.panel5.Controls.Add(this.panel7);
            this.panel5.Location = new System.Drawing.Point(3, 107);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1479, 795);
            this.panel5.TabIndex = 1;
            // 
            // dtgvBeverage
            // 
            this.dtgvBeverage.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvBeverage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvBeverage.Location = new System.Drawing.Point(28, 76);
            this.dtgvBeverage.Name = "dtgvBeverage";
            this.dtgvBeverage.RowTemplate.Height = 33;
            this.dtgvBeverage.Size = new System.Drawing.Size(1422, 701);
            this.dtgvBeverage.TabIndex = 0;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.nmBeveragePrice);
            this.panel10.Controls.Add(this.label3);
            this.panel10.Location = new System.Drawing.Point(1157, 10);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(307, 60);
            this.panel10.TabIndex = 4;
            // 
            // nmBeveragePrice
            // 
            this.nmBeveragePrice.Location = new System.Drawing.Point(82, 17);
            this.nmBeveragePrice.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.nmBeveragePrice.Name = "nmBeveragePrice";
            this.nmBeveragePrice.Size = new System.Drawing.Size(199, 31);
            this.nmBeveragePrice.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Giá:";
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.cbBeverageCategory);
            this.panel9.Controls.Add(this.label2);
            this.panel9.Location = new System.Drawing.Point(797, 10);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(354, 60);
            this.panel9.TabIndex = 3;
            // 
            // cbBeverageCategory
            // 
            this.cbBeverageCategory.FormattingEnabled = true;
            this.cbBeverageCategory.Location = new System.Drawing.Point(129, 11);
            this.cbBeverageCategory.Name = "cbBeverageCategory";
            this.cbBeverageCategory.Size = new System.Drawing.Size(195, 33);
            this.cbBeverageCategory.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Danh mục:";
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.txbBeverageName);
            this.panel8.Controls.Add(this.label4);
            this.panel8.Location = new System.Drawing.Point(315, 10);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(476, 60);
            this.panel8.TabIndex = 2;
            // 
            // txbBeverageName
            // 
            this.txbBeverageName.Font = new System.Drawing.Font("Arial", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbBeverageName.Location = new System.Drawing.Point(120, 10);
            this.txbBeverageName.Name = "txbBeverageName";
            this.txbBeverageName.Size = new System.Drawing.Size(342, 32);
            this.txbBeverageName.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tên món:";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.txbBeverageId);
            this.panel7.Controls.Add(this.label1);
            this.panel7.Location = new System.Drawing.Point(42, 10);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(243, 60);
            this.panel7.TabIndex = 1;
            // 
            // txbBeverageId
            // 
            this.txbBeverageId.Font = new System.Drawing.Font("Arial", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbBeverageId.Location = new System.Drawing.Point(57, 10);
            this.txbBeverageId.Name = "txbBeverageId";
            this.txbBeverageId.ReadOnly = true;
            this.txbBeverageId.Size = new System.Drawing.Size(169, 32);
            this.txbBeverageId.TabIndex = 1;
            this.txbBeverageId.TextChanged += new System.EventHandler(this.txbBeverageId_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnShowBeverage);
            this.panel4.Controls.Add(this.btnUpdateBeverage);
            this.panel4.Controls.Add(this.btnDeleteBeverage);
            this.panel4.Controls.Add(this.btnAddBeverage);
            this.panel4.Location = new System.Drawing.Point(624, 6);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(829, 95);
            this.panel4.TabIndex = 1;
            // 
            // btnShowBeverage
            // 
            this.btnShowBeverage.Location = new System.Drawing.Point(561, 9);
            this.btnShowBeverage.Name = "btnShowBeverage";
            this.btnShowBeverage.Size = new System.Drawing.Size(121, 74);
            this.btnShowBeverage.TabIndex = 3;
            this.btnShowBeverage.Text = "Xem";
            this.btnShowBeverage.UseVisualStyleBackColor = true;
            this.btnShowBeverage.Click += new System.EventHandler(this.btnShowBeverage_Click);
            // 
            // btnUpdateBeverage
            // 
            this.btnUpdateBeverage.Location = new System.Drawing.Point(414, 9);
            this.btnUpdateBeverage.Name = "btnUpdateBeverage";
            this.btnUpdateBeverage.Size = new System.Drawing.Size(121, 74);
            this.btnUpdateBeverage.TabIndex = 2;
            this.btnUpdateBeverage.Text = "Sửa";
            this.btnUpdateBeverage.UseVisualStyleBackColor = true;
            this.btnUpdateBeverage.Click += new System.EventHandler(this.btnUpdateBeverage_Click);
            // 
            // btnDeleteBeverage
            // 
            this.btnDeleteBeverage.Location = new System.Drawing.Point(280, 9);
            this.btnDeleteBeverage.Name = "btnDeleteBeverage";
            this.btnDeleteBeverage.Size = new System.Drawing.Size(118, 74);
            this.btnDeleteBeverage.TabIndex = 1;
            this.btnDeleteBeverage.Text = "Xóa";
            this.btnDeleteBeverage.UseVisualStyleBackColor = true;
            this.btnDeleteBeverage.Click += new System.EventHandler(this.btnDeleteBeverage_Click);
            // 
            // btnAddBeverage
            // 
            this.btnAddBeverage.Location = new System.Drawing.Point(147, 9);
            this.btnAddBeverage.Name = "btnAddBeverage";
            this.btnAddBeverage.Size = new System.Drawing.Size(118, 74);
            this.btnAddBeverage.TabIndex = 0;
            this.btnAddBeverage.Text = "Thêm";
            this.btnAddBeverage.UseVisualStyleBackColor = true;
            this.btnAddBeverage.Click += new System.EventHandler(this.btnAddBeverage_Click);
            // 
            // tpBill
            // 
            this.tpBill.BackColor = System.Drawing.SystemColors.Control;
            this.tpBill.Controls.Add(this.panel2);
            this.tpBill.Controls.Add(this.panel1);
            this.tpBill.Location = new System.Drawing.Point(8, 39);
            this.tpBill.Name = "tpBill";
            this.tpBill.Padding = new System.Windows.Forms.Padding(3);
            this.tpBill.Size = new System.Drawing.Size(1488, 902);
            this.tpBill.TabIndex = 0;
            this.tpBill.Text = "Doanh thu";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.btnViewBill);
            this.panel2.Controls.Add(this.dtpkToDate);
            this.panel2.Controls.Add(this.dtpkFromDate);
            this.panel2.Location = new System.Drawing.Point(23, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1459, 44);
            this.panel2.TabIndex = 1;
            // 
            // btnViewBill
            // 
            this.btnViewBill.BackColor = System.Drawing.Color.AliceBlue;
            this.btnViewBill.Location = new System.Drawing.Point(663, 5);
            this.btnViewBill.Name = "btnViewBill";
            this.btnViewBill.Size = new System.Drawing.Size(143, 37);
            this.btnViewBill.TabIndex = 2;
            this.btnViewBill.Text = "Thống kê";
            this.btnViewBill.UseVisualStyleBackColor = false;
            this.btnViewBill.Click += new System.EventHandler(this.btnViewBill_Click);
            // 
            // dtpkToDate
            // 
            this.dtpkToDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpkToDate.CalendarMonthBackground = System.Drawing.Color.AliceBlue;
            this.dtpkToDate.Location = new System.Drawing.Point(995, 5);
            this.dtpkToDate.Name = "dtpkToDate";
            this.dtpkToDate.Size = new System.Drawing.Size(337, 31);
            this.dtpkToDate.TabIndex = 1;
            // 
            // dtpkFromDate
            // 
            this.dtpkFromDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpkFromDate.CalendarMonthBackground = System.Drawing.Color.AliceBlue;
            this.dtpkFromDate.Location = new System.Drawing.Point(91, 6);
            this.dtpkFromDate.Name = "dtpkFromDate";
            this.dtpkFromDate.Size = new System.Drawing.Size(327, 31);
            this.dtpkFromDate.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtgvBill);
            this.panel1.Location = new System.Drawing.Point(23, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1462, 843);
            this.panel1.TabIndex = 0;
            // 
            // dtgvBill
            // 
            this.dtgvBill.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvBill.Location = new System.Drawing.Point(3, 3);
            this.dtgvBill.Name = "dtgvBill";
            this.dtgvBill.RowTemplate.Height = 33;
            this.dtgvBill.Size = new System.Drawing.Size(1456, 837);
            this.dtgvBill.TabIndex = 0;
            // 
            // tcAdmin
            // 
            this.tcAdmin.Controls.Add(this.tpBill);
            this.tcAdmin.Controls.Add(this.tpBeverage);
            this.tcAdmin.Controls.Add(this.tpAccount);
            this.tcAdmin.Location = new System.Drawing.Point(12, 12);
            this.tcAdmin.Name = "tcAdmin";
            this.tcAdmin.SelectedIndex = 0;
            this.tcAdmin.Size = new System.Drawing.Size(1504, 949);
            this.tcAdmin.TabIndex = 0;
            // 
            // fAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1519, 973);
            this.Controls.Add(this.tcAdmin);
            this.Name = "fAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.tpAccount.ResumeLayout(false);
            this.panel23.ResumeLayout(false);
            this.panel25.ResumeLayout(false);
            this.panel25.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmAccType)).EndInit();
            this.panel26.ResumeLayout(false);
            this.panel26.PerformLayout();
            this.panel27.ResumeLayout(false);
            this.panel27.PerformLayout();
            this.panel28.ResumeLayout(false);
            this.panel29.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAccount)).EndInit();
            this.tpBeverage.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBeverage)).EndInit();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmBeveragePrice)).EndInit();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.tpBill.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBill)).EndInit();
            this.tcAdmin.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tpAccount;
        private System.Windows.Forms.Panel panel23;
        private System.Windows.Forms.Button btnResetPass;
        private System.Windows.Forms.Panel panel25;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel26;
        private System.Windows.Forms.TextBox txbAccDisplay;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel27;
        private System.Windows.Forms.TextBox txbAccName;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel28;
        private System.Windows.Forms.Button btnShowAcc;
        private System.Windows.Forms.Button btnUpdateAcc;
        private System.Windows.Forms.Button btnDeleteAcc;
        private System.Windows.Forms.Button btnAddAcc;
        private System.Windows.Forms.Panel panel29;
        private System.Windows.Forms.DataGridView dtgvAccount;
        private System.Windows.Forms.TabPage tpBeverage;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txbSearchBeverageName;
        private System.Windows.Forms.Button btnSearchBeverage;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView dtgvBeverage;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.NumericUpDown nmBeveragePrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.ComboBox cbBeverageCategory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TextBox txbBeverageName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox txbBeverageId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnShowBeverage;
        private System.Windows.Forms.Button btnUpdateBeverage;
        private System.Windows.Forms.Button btnDeleteBeverage;
        private System.Windows.Forms.Button btnAddBeverage;
        private System.Windows.Forms.TabPage tpBill;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnViewBill;
        private System.Windows.Forms.DateTimePicker dtpkToDate;
        private System.Windows.Forms.DateTimePicker dtpkFromDate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dtgvBill;
        private System.Windows.Forms.TabControl tcAdmin;
        private System.Windows.Forms.NumericUpDown nmAccType;

    }
}
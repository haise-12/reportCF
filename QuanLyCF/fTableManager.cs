using QuanLyCF.DAO;
using QuanLyCF.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCF
{
    public partial class fTableManager : Form
    {
        private Account loginAccount;

        public Account LoginAccount
        {
            get { return loginAccount; }
            set { loginAccount = value;
            ChangeAccount(loginAccount.Type);
            }
        }
        public fTableManager(Account acc)
        {
            InitializeComponent();

            this.LoginAccount = acc;
            LoadTable();
            LoadCatagory();
        }



        #region Method
        void loadTable()
        {

        }

        #endregion

        void ChangeAccount(int type)
        {
            adminToolStripMenuItem.Enabled = type == 1;
            thôngTinTàiKhoảnToolStripMenuItem.Text += "("+ loginAccount.DisplayName+")";
        }
        void LoadTable()
        {
            flpTable.Controls.Clear();
            List<Table> tableList = TableDAO.Instance.LoadTableList();

            foreach (Table item in tableList)
            {
                Button btn = new Button() {Width = 120, Height = 120};
                btn.Text = item.Name + Environment.NewLine + item.Status;
                btn.Click += btn_Click;
                btn.Tag = item;

                switch (item.Status)
                {
                    case "Trống":
                        btn.BackColor = Color.LightGreen;
                        break;
                    case "Có người":
                        btn.BackColor = Color.OrangeRed;
                        break;
                }
          
                flpTable.Controls.Add(btn);
            }

        }

        void ShowBill(int id)
        {
            lsvBill.Items.Clear();
            List<QuanLyCF.DTO.Menu> listBillInfo = MenuDAO.Instance.GetListMenuByTable(id);
            float totalPirce = 0;
            foreach(QuanLyCF.DTO.Menu item in listBillInfo)
            {
                ListViewItem lsvItem = new ListViewItem(item.BeverageName.ToString());
                lsvItem.SubItems.Add(item.QTY.ToString());
                lsvItem.SubItems.Add(item.Price.ToString());
                lsvItem.SubItems.Add(item.TotalPrice.ToString());
                totalPirce += item.TotalPrice;

                lsvBill.Items.Add(lsvItem);
            }
            
            CultureInfo culture = new CultureInfo("vi-VN");
            Thread.CurrentThread.CurrentCulture = culture;
            txbTotalPrice.Text = totalPirce.ToString("c",culture);

        }

        void LoadCatagory()
        {
            List<Category> listCatagory = CategoryDAO.Instance.GetListCategory();
            cbCatagory.DataSource = listCatagory;
            cbCatagory.DisplayMember = "name";
        }

        void LoadBeverageByCatagory(int id)
        {
            List<Beverage> listBeverage = BeverageDAO.Instance.GetBeverageByCategory(id);
            cbBeverage.DataSource = listBeverage;
            cbBeverage.DisplayMember = "name";
          


        }

        #region Events

        void btn_Click(object sender, EventArgs e)
        {
            int tableID = ((sender as Button).Tag as Table).ID;
            lsvBill.Tag = (sender as Button).Tag;
            ShowBill(tableID);
            LoadTable();
        }


        private void LogOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void thôngTinCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAccountProfile f = new fAccountProfile(LoginAccount);
            f.UpdateAccount += f_UpdateAccount;
            f.ShowDialog();
        }

        void f_UpdateAccount(object sender, AccountEvent e)
        {
            thôngTinTàiKhoảnToolStripMenuItem.Text = "Thông tin tài khoản (" + e.Acc.DisplayName + ")";
        }



        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAdmin f = new fAdmin();
            f.loginAccount = LoginAccount;
            f.InsertBeverage += f_InsertBeverage;
            f.DeleteBeverage += f_DeleteBeverage;
            f.UpdateBeverage += f_UpdateBeverage;
            f.ShowDialog();
        }

        void f_UpdateBeverage(object sender, EventArgs e)
        {
            LoadBeverageByCatagory((cbCatagory.SelectedItem as Category).ID);
            ShowBill((lsvBill.Tag as Table).ID);


        }

        void f_DeleteBeverage(object sender, EventArgs e)
        {
            LoadBeverageByCatagory((cbCatagory.SelectedItem as Category).ID);
            ShowBill((lsvBill.Tag as Table).ID);
            LoadTable();
        }

        void f_InsertBeverage(object sender, EventArgs e)
        {
            LoadBeverageByCatagory((cbCatagory.SelectedItem as Category).ID);
            ShowBill((lsvBill.Tag as Table).ID);
        }
        

        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id=0;

            ComboBox cb = sender as ComboBox;
            if (cb.SelectedItem == null)
                return;

            Category selected = cb.SelectedItem as Category;
            id = selected.ID;

            LoadBeverageByCatagory(id);
            
         }

        private void bntAddBeverage_Click(object sender, EventArgs e)
        {

            Table table = lsvBill.Tag as Table;

            if (table == null)
            {
                MessageBox.Show("Bạn chưa chọn bàn!");
                return;
            }

            int idBill = BillDAO.Instance.GetUnCheckBillByTableID(table.ID);
            int qty = (int)nmBeverageCount.Value;

            int idBeverage =(cbBeverage.SelectedItem as Beverage).ID;
            if(idBill ==-1)
            {
                if (qty > 0)
                {
                    BillDAO.Instance.InsertBill(table.ID);
                    BillInfoDAO.Instance.InsertBillInfo(BillDAO.Instance.GetMaxIDBILL(), idBeverage, qty);
                }
                

            }
            else
            {
                BillInfoDAO.Instance.InsertBillInfo(idBill, idBeverage, qty);
            }
            ShowBill(table.ID);
            LoadTable();

        }

        private void bntCheckOut_Click(object sender, EventArgs e)
        {
            Table table = lsvBill.Tag as Table;
            int idBill = BillDAO.Instance.GetUnCheckBillByTableID(table.ID);
            int discount = (int)nmDiscount.Value;
            double totalPrice = Convert.ToDouble(txbTotalPrice.Text.Split(',')[0]);
            double finalTotal = totalPrice - (totalPrice/100)*discount;

           
            if ( idBill != -1)
            {
                if (MessageBox.Show(string.Format("Bạn có chắc thanh toán hóa đơn cho bàn {0}\nTổng hóa đơn: {1}\nBạn được giảm {2}% hóa đơn\nSố tiền cần thành toán:{3} ", table.Name, totalPrice, discount,finalTotal), "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    BillDAO.Instance.CheckOut(idBill, discount,(float)finalTotal);
                    ShowBill(table.ID);
                    LoadTable();
                }
            }

        }










        #endregion


     
      





    }
}

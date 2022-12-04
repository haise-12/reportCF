using QuanLyCF.DAO;
using QuanLyCF.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCF
{
    public partial class fAdmin : Form
    {

        BindingSource beverageList = new BindingSource();
        BindingSource accountList = new BindingSource();

        public Account loginAccount;
        public fAdmin()
        {
            InitializeComponent();
            Load();
            AddBeverageBinding();
            AddAccountBinding();
        }

      

        #region Method

        void Load()
        {
            dtgvBeverage.DataSource = beverageList;
            dtgvAccount.DataSource = accountList;   

            LoadDateTimePickerBill();
            LoadListBillByDate(dtpkFromDate.Value, dtpkToDate.Value);
            LoadListBeverage();
            LoadAccount();
            LoadCategoryIntoCombox(cbBeverageCategory);
        }

        void AddAccountBinding()
        {
            txbAccName.DataBindings.Add(new Binding("Text", dtgvAccount.DataSource, "Tài khoản", true, DataSourceUpdateMode.Never));
            txbAccDisplay.DataBindings.Add(new Binding("Text", dtgvAccount.DataSource, "Tên hiển thị", true, DataSourceUpdateMode.Never));
            nmAccType.DataBindings.Add(new Binding("Value", dtgvAccount.DataSource, "Loại", true, DataSourceUpdateMode.Never));
        }

        void AddBeverageBinding()
        {
            txbBeverageName.DataBindings.Add(new Binding("Text", dtgvBeverage.DataSource, "Tên món", true, DataSourceUpdateMode.Never));
            txbBeverageId.DataBindings.Add(new Binding("Text", dtgvBeverage.DataSource, "Mã", true, DataSourceUpdateMode.Never));
            nmBeveragePrice.DataBindings.Add(new Binding("Value", dtgvBeverage.DataSource, "Giá", true, DataSourceUpdateMode.Never));
        }

        void LoadAccount()
        {
            accountList.DataSource = AccountDAO.Instance.GetListAccount();
        }


        void LoadListBeverage()
        {
            beverageList.DataSource = BeverageDAO.Instance.GetListBeverage();
        }

        public void LoadListBillByDate(DateTime checkIn, DateTime checkOut)
        {
            dtgvBill.DataSource = BillDAO.Instance.GetListBillByDate(checkIn, checkOut);
        }

        public void LoadDateTimePickerBill()
        {
            DateTime today = DateTime.Now;
            dtpkFromDate.Value = new DateTime(today.Year, today.Month, 1);
            dtpkToDate.Value = dtpkFromDate.Value.AddMonths(1).AddDays(-1);
            
        }

        void LoadCategoryIntoCombox(ComboBox cb)
        {
            cb.DataSource = CategoryDAO.Instance.GetListCategory();
            cb.DisplayMember = "Name";
            cb.ValueMember = "Id";
        }

     

        private void txbBeverageId_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (dtgvBeverage.SelectedCells.Count > 0)
                {
                    int id = (int)dtgvBeverage.SelectedCells[0].OwningRow.Cells["CategoryID1"].Value;
                    Category cate = CategoryDAO.Instance.GetCategoryById(id);
                    cbBeverageCategory.SelectedValue = cate;

                    int index = -1;
                    int i = 0;
                    foreach (Category item in cbBeverageCategory.Items)
                    {
                        if (item.ID == cate.ID)
                        {
                            index = i;
                            break;
                        }
                        i++;
                    }
                    cbBeverageCategory.SelectedIndex = index;
                }

            }
            catch { }
        }

        List<Beverage> SearchBeveByName(string name)
        {
            List<Beverage> listBeverage = BeverageDAO.Instance.SearchBeveByName(name);
            

            return listBeverage;
        }


        void AddAccount(string name, string displayName, int type)
        {
            if (AccountDAO.Instance.InsertAccount(name, displayName, type))
            {
                MessageBox.Show("Thêm tài khoản thành công");
            }
            else
            {
                MessageBox.Show("Thêm tài khoản thất bại");
            }
            LoadAccount();
        }

        void EditAccount(string name, string displayName, int type)
        {
            if (AccountDAO.Instance.UpdateAccount(name, displayName, type))
            {
                MessageBox.Show("Cập nhật tài khoản thành công");
            }
            else
            {
                MessageBox.Show("Cập nhật tài khoản thất bại");
            }
            LoadAccount();
        }

        void DeleteAccount(string name)
        {
            if (loginAccount.UserName.Equals(name))
            {
                MessageBox.Show("Vui lòng không xóa tài khoản hiện tại");
                return;
            }
            if (AccountDAO.Instance.DeleteAccount(name))
            {
                MessageBox.Show("Xóa tài khoản thành công");
            }
            else
            {
                MessageBox.Show("Xóa tài khoản thất bại");
            }
            LoadAccount();
        }

        void ResetPass(string userName)
        {
            if (AccountDAO.Instance.ResetAccount(userName))
            {
                MessageBox.Show("Đặt lại mật khẩu thành công");
            }
            else
            {
                MessageBox.Show("Đặt lại mật khẩu thất bại");
            }
            LoadAccount();
        }

        #endregion










        #region Events

        private void btnResetPass_Click(object sender, EventArgs e)
        {
            string userName = txbAccName.Text;

            ResetPass(userName);
        }

        private void btnShowAcc_Click(object sender, EventArgs e)
        {
            LoadAccount();
        }

        private void btnAddAcc_Click(object sender, EventArgs e)
        {
            string userName = txbAccName.Text;
            string displayName = txbAccDisplay.Text;
            int type = (int)nmAccType.Value;

            AddAccount(userName, displayName, type);

        }

        private void btnDeleteAcc_Click(object sender, EventArgs e)
        {
            string userName = txbAccName.Text;

            DeleteAccount(userName);
        }

        private void btnUpdateAcc_Click(object sender, EventArgs e)
        {
            string userName = txbAccName.Text;
            string displayName = txbAccDisplay.Text;
            int type = (int)nmAccType.Value;

            EditAccount(userName, displayName, type);

        }



        private void btnSearchBeverage_Click(object sender, EventArgs e)
        {
           beverageList.DataSource = SearchBeveByName(txbSearchBeverageName.Text);
        }
        private void btnViewBill_Click(object sender, EventArgs e)
        {
            LoadListBillByDate(dtpkFromDate.Value, dtpkToDate.Value);
        }

        private void btnShowBeverage_Click(object sender, EventArgs e)
        {
            LoadListBeverage();
        }


        private void btnAddBeverage_Click(object sender, EventArgs e)
        {
            string name = txbBeverageName.Text;
            int id = (cbBeverageCategory.SelectedItem as Category).ID;
            float price = (float)nmBeveragePrice.Value;

            if (BeverageDAO.Instance.InsertBeverage(name,id,price))
            {
                MessageBox.Show("Thêm món thành công");
                LoadListBeverage();
                if (insertBeverage != null)
                    insertBeverage(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Có lỗi khi thêm món");
            }

        }

        private void btnUpdateBeverage_Click(object sender, EventArgs e)
        {
            string name = txbBeverageName.Text;
            int id = (cbBeverageCategory.SelectedItem as Category).ID;
            float price = (float)nmBeveragePrice.Value;
            int idBeverage = Convert.ToInt32(txbBeverageId.Text);
            if (BeverageDAO.Instance.UpdateBeverage(idBeverage, name, id, price))
            {
                MessageBox.Show("Sửa món thành công");
                LoadListBeverage();
                if (updateBeverage != null)
                    updateBeverage(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Có lỗi khi sửa món");
            }
        }


            private void btnDeleteBeverage_Click(object sender, EventArgs e)
        {
            int idBeverage = Convert.ToInt32(txbBeverageId.Text);
            if (BeverageDAO.Instance.DeleteBeverage(idBeverage))
            {
                MessageBox.Show("Xóa món thành công");
                LoadListBeverage();
                if (deleteBeverage != null)
                    deleteBeverage(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Có lỗi khi xóa món");
            }
        }

            private event EventHandler insertBeverage;
            public event EventHandler InsertBeverage
            {
                add { insertBeverage += value;}
                remove { insertBeverage -= value; }
            }

            private event EventHandler deleteBeverage;
            public event EventHandler DeleteBeverage
            {
                add { deleteBeverage += value; }
                remove { deleteBeverage -= value; }
            }   
        
            private event EventHandler updateBeverage;
            public event EventHandler UpdateBeverage
            {
                add { updateBeverage += value; }
                remove { updateBeverage -= value; }
            }


          
           


          

        #endregion

           

          
          

         

    

      

    

    
        
   

   

     
       

    
       
    }
}

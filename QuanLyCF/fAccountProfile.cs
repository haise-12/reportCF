using QuanLyCF.DAO;
using QuanLyCF.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCF
{
    public partial class fAccountProfile : Form
    {
        private Account loginAccount;

        public Account LoginAccount
        {
            get { return loginAccount; }
            set
            {
                loginAccount = value;
                ChangeAccount(loginAccount);
            }
        }

        public fAccountProfile(Account acc)
        {
            InitializeComponent();
            LoginAccount = acc;
        }

       
        public void ChangeAccount(Account acc)
        {
            txbUserName.Text = LoginAccount.UserName;
            txbDisplayName.Text = LoginAccount.DisplayName;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void UpdateAccountInfo()
        {
            string displayName = txbDisplayName.Text;
            string passWord = txbPassWord.Text;
            string newPass = txbNewPass.Text;
            string reEnterPass = txbReEnterPass.Text;
            string userName = txbUserName.Text;

            if(!newPass.Equals(reEnterPass))
            {
                MessageBox.Show("Mật khẩu xác nhận không khớp!!!");
            }
            else
            {
                byte[] temp = ASCIIEncoding.ASCII.GetBytes(newPass);
                byte[] hasData = new MD5CryptoServiceProvider().ComputeHash(temp);

                string hasNewPass = "";

                foreach (byte item in hasData)
                {
                    hasNewPass += item;
                }


                byte[] tempPassCurrent = ASCIIEncoding.ASCII.GetBytes(passWord);
                byte[] hasDataCurrent = new MD5CryptoServiceProvider().ComputeHash(tempPassCurrent);

                string hasCurrentPass = "";

                foreach (byte item in hasDataCurrent)
                {
                    hasCurrentPass += item;
                }
                if (AccountDAO.Instance.UpdateAccount(userName, displayName, hasCurrentPass, hasNewPass))
                {
                    MessageBox.Show("Cập nhập thành công");
                    if (updateAccount != null)
                        updateAccount(this, new AccountEvent(AccountDAO.Instance.GetAccByUserName(userName)));  
                }
                else
                    MessageBox.Show("Vui lòng điền đúng mật khẩu");

            }

        }
        private event EventHandler<AccountEvent> updateAccount;
        public event EventHandler<AccountEvent> UpdateAccount
        {
            add {updateAccount += value; }
            remove{updateAccount -= value;}
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateAccountInfo();
        }
    }

    public class AccountEvent : EventArgs
    {
        private Account acc;

        public Account Acc
        {
            get { return acc; }
            set { acc = value; }
        }

        public AccountEvent(Account acc)
        {
            this.acc = acc; 
        }

        
    }
}

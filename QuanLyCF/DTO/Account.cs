using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCF.DTO
{
    public class Account
    {
        private string userName;
        private string passWord;
        private string displayName;
        private int type;

        public Account(string userName, string displayName, int type, string passWord=null)
        {
            this.userName = userName;
            this.passWord = passWord;
            this.displayName = displayName;
            this.type = type;
        }

        public Account(DataRow row)
        {
            this.userName = row["userName"].ToString();
            this.passWord = row["passWord"].ToString();
            this.displayName = row["displayName"].ToString();
            this.type = (int)row["type"];
        }










        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }
       

        public string PassWord
        {
            get { return passWord; }
            set { passWord = value; }
        }
        

        public string DisplayName
        {
            get { return displayName; }
            set { displayName = value; }
        }
       

        public int Type
        {
            get { return type; }
            set { type = value; }
        }


    }
}

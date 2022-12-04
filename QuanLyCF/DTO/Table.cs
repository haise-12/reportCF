using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCF.DTO
{
    public class Table
    {
        private string name;
        private int iD;
        private string status;

        public static int tableWidth =100;
        public static int tableHeight = 100;


        public Table() { }

        public Table(int id, string name, string status)
        {
            this.ID = id;
            this.Name = name;
            this.Status = status;
        }

        public Table(DataRow row)
        {
            this.ID = (int)row["id"];
            this.Name = row["name"].ToString();
            this.Status = row["status"].ToString();

        }
        public string Name
        {
          get { return name; }
          set { name = value; }
        }

        public string Status
        {
            get { return status; }
            set { status = value; }
        }

        public int ID   
        {
            get { return iD; }
            set { iD = value; }
        }

        
    }
}

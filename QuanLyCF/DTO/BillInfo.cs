using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCF.DTO
{
    public class BillInfo
    {
        private int iD;
        private int billID;
        private int BeverageID;

       
        private int qTY;



        public BillInfo(int id, int billID, int BeverageID, int qTY)
        {
            this.iD = id;
            this.billID = billID;
            this.BeverageID = BeverageID;
            this.qTY = qTY;
        }

        public BillInfo(DataRow row)
        {
            this.iD = (int)row["id"];
            this.billID = (int)row["BillId"];
            this.BeverageID = (int)row["BeverageId"];
            this.qTY = (int)row["qty"];
        }




        public int ID
        {
            get { return iD; }
            set { iD = value; }
        }
        public int BillID
        {
            get { return billID; }
            set { billID = value; }
        }
       
        public int QTY
        {
            get { return qTY; }
            set { qTY = value; }
        }
        public int BeverageID1
        {
            get { return BeverageID; }
            set { BeverageID = value; }
        }
    }
}

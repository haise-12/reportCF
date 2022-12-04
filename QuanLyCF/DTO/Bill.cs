using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCF.DTO
{
    public class Bill
    {
        private int iD;
        private DateTime? dateCheckIn;
        private DateTime? dateCheckOut;
        private int status;
        private int discount;

    
   

        public Bill(int id, DateTime? dateCheckIn, DateTime? dateCheckOut, int status, int discount=0)
        {
            this.ID = id;
            this.DateCheckIn = dateCheckIn;
            this.DateCheckOut = dateCheckOut;
            this.Status = status;
            this.Discount = discount;
        }

        public Bill(DataRow row)
        {
            this.ID = (int)row["id"];
            this.DateCheckIn = (DateTime?)row["checkIn"];
            var dataCheckOutTemp = row["checkOut"];
            if (dataCheckOutTemp.ToString() != "")
                this.DateCheckOut = (DateTime?) dataCheckOutTemp;
            this.Status = (int)row["status"];
           // if (row["discout"].ToString() != "")
            this.Discount = (int)row["discount"];
        }


        public int ID
        {
            get { return iD; }
            set { iD = value; }
        }
        public DateTime? DateCheckIn
        {
            get { return dateCheckIn; }
            set { dateCheckIn = value; }
        }
        public DateTime? DateCheckOut
        {
            get { return dateCheckOut; }
            set { dateCheckOut = value;}
        }
             public int Status
        {
            get { return status; }
            set { status = value; }
        }
             public int Discount
             {
                 get { return discount; }
                 set { discount = value; }
             }

    }
}

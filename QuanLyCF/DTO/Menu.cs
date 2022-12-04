using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCF.DTO
{
    public class Menu
    {
        private string beverageName;
        private int qTY;
        private float price;
        private float totalPrice;

        public Menu(string beverageName, int qTY, float price, float totalPrice =0)
        {
            this.beverageName = beverageName;
            this.qTY = qTY;
            this.price = price;
            this.totalPrice = totalPrice;

        }

        public Menu(DataRow row)
        {
            this.beverageName = row["name"].ToString();
            this.qTY = (int)row["qty"];
            this.price = (float)Convert.ToDouble(row["price"].ToString());
            this.totalPrice = (float)Convert.ToDouble(row["totalPrice"].ToString());

        }






        public int QTY
        {
            get { return qTY; }
            set { qTY = value; }
        }
        public string BeverageName
        {
            get { return beverageName; }
            set { beverageName = value; }
        }
        public float Price
        {
            get { return price; }
            set { price = value; }
        }
        public float TotalPrice
        {
            get { return totalPrice; }
            set { totalPrice = value; }
        }
    }
}

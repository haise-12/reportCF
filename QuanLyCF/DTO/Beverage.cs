using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCF.DTO
{
    public class Beverage
    {
        private int iD;
        private string name;
        private int CategoryID;
        private float price;

        public Beverage(int id, string name, int CategoryId, float price)
        {
            this.iD = id;
            this.name = name;
            this.CategoryID1 = CategoryId;
            this.price = price;
        }

        public Beverage(DataRow row)
        {
            this.iD = (int)row["id"];
            this.name = row["name"].ToString();
            this.CategoryID1 = (int)row["CategoryId"];
            this.price = (float)Convert.ToDouble(row["price"].ToString());
        }
      


        public int ID
        {
            get { return iD; }
            set { iD = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int CategoryID1
        {
            get { return CategoryID; }
            set { CategoryID = value; }
        }

        public float Price
        {
            get { return price; }
            set { price = value; }
        }



    }
}

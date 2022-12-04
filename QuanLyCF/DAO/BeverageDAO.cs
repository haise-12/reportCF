
using QuanLyCF.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCF.DAO
{
    class BeverageDAO
    {

        private static BeverageDAO instance;

        public static BeverageDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new BeverageDAO();
                return BeverageDAO.instance; }
            private set { BeverageDAO.instance = value; }
        }


        private BeverageDAO() { }


        public List<Beverage> GetBeverageByCategory(int id)
        {
            List<Beverage> listBeverage = new List<Beverage>();

            DataTable data = DataProvider.Instance.ExecuteQuery("SElECT * FROM Beverage WHERE CategoryId =" + id);


            foreach(DataRow item in data.Rows)
            {
                Beverage beverage = new Beverage(item);
                listBeverage.Add(beverage);
                
            }
            return listBeverage;
        }

        //public List<Beverage> GetListBeverage()
        //{
        //    List<Beverage> listBeverage = new List<Beverage>();
        //    string query = "SELECT * FROM Beverage";
        //    DataTable data = DataProvider.Instance.ExecuteQuery(query);


        //    foreach (DataRow item in data.Rows)
        //    {
        //        Beverage beverage = new Beverage(item);
        //        listBeverage.Add(beverage);

        //    }
        //    return listBeverage;
        //}


        public DataTable GetListBeverage()
        {
            return DataProvider.Instance.ExecuteQuery("P_GetListBeverage");
        }


       
        public List<Beverage> SearchBeveByName(string name)
        {
            List<Beverage> listBeverage = new List<Beverage>();
            string query = string.Format("SElECT * FROM Beverage WHERE name LIKE N'%{0}%'", name);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);


            foreach (DataRow item in data.Rows)
            {
                Beverage beverage = new Beverage(item);
                listBeverage.Add(beverage);

            }
            return listBeverage;

        }


        public bool InsertBeverage(string name, int id, float price)
        {
            string query = string.Format("INSERT INTO Beverage(name,CategoryId,price) VALUES(N'{0}', {1}, {2})", name, id, price);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;

        }

        public bool UpdateBeverage(int idBeverage, string name, int id, float price)
        {
            string query = string.Format("UPDATE Beverage SET name =N'{0}', CategoryId = {1}, price ={2} WHERE id ={3}", name, id, price, idBeverage);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;

        }

        public bool DeleteBeverage(int idBeverage)
        {
            BillInfoDAO.Instance.DeleteBillInfoByIdBeverage(idBeverage);
            string query = ("DELETE Beverage WHERE id =" +idBeverage);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
    }   
}

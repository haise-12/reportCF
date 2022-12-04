using QuanLyCF.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCF.DAO
{
    public class BillDAO
    {
        private static BillDAO instance;

        public static BillDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new BillDAO();
                return BillDAO.instance; }
            private set { BillDAO.instance = value; }
        }


        public BillDAO() { }


        public int GetUnCheckBillByTableID(int id)//true ->id bill, false -1
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM Bill WHERE TableCFId =" + id + " AND status = 0");
            if (data.Rows.Count > 0)
            {
                Bill bill = new Bill(data.Rows[0]);
                return bill.ID;
            }
            return -1;
        }

        public void InsertBill(int id)
        {
            DataProvider.Instance.ExecuteNonQuery("p_InsertBill @idTable", new object[] { id });
        }
        

        public int GetMaxIDBILL()
        {
            return (int)DataProvider.Instance.ExecuteScalar("SELECT MAX(id) FROM Bill");
        }

        public void CheckOut(int id, int discount, float totalPrice)
        {
            string query = "UPDATE Bill SET totalPrice = "+totalPrice+", checkOut = GETDATE(), status = 1," + "discount = " + discount + "WHERE id =" + id;    
            DataProvider.Instance.ExecuteNonQuery(query);
        }

        public DataTable GetListBillByDate(DateTime checkIn, DateTime checkOut)
        {
            return DataProvider.Instance.ExecuteQuery("P_GetListBillByDate @checkIn , @checkOut", new object[] { checkIn, checkOut });
        }


    }
}

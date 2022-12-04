using QuanLyCF.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCF.DAO
{
    public class BillInfoDAO
    {
        private static BillInfoDAO instance;

        public static BillInfoDAO Instance
        {
            get { if(instance ==null)
                    instance = new BillInfoDAO();
                return BillInfoDAO.instance; }
            private set { BillInfoDAO.instance = value; }
        }

        public BillInfoDAO() { }

        public List<BillInfo> GetListBillInfo(int id)
        {
            List<BillInfo> listBillInfo = new List<BillInfo>();
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM BillInfo WHERE billId = " + id);

            foreach (DataRow item in data.Rows)
            {
                BillInfo info = new BillInfo(item);
                listBillInfo.Add(info);
            }
            return listBillInfo;
        }

        public void InsertBillInfo(int BillId, int BeverageId, int qty)
        {
            DataProvider.Instance.ExecuteNonQuery("P_InsertBillInfo @BillId , @BeverageId , @qty ", new object[] { BillId,BeverageId,qty });
        }


        public void DeleteBillInfoByIdBeverage(int id)
        {
            DataProvider.Instance.ExecuteQuery("DELETE BillInfo WHERE BeverageId ="  + id);
        }




    }
}

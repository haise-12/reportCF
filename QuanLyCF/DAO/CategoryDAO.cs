using QuanLyCF.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCF.DAO
{
    public class CategoryDAO
    {
        private static CategoryDAO instance;

        public static CategoryDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new CategoryDAO();
                return CategoryDAO.instance;
            }
            private set { CategoryDAO.instance = value; }
        }


        private CategoryDAO() { }



        public List<Category> GetListCategory()
        {
            List<Category> listCatagory = new List<Category>();


            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM Category ");

            foreach (DataRow item in data.Rows)
            {
                Category catagory = new Category(item);
                listCatagory.Add(catagory);
            }

            return listCatagory;
        }

        public Category GetCategoryById(int id)
        {
            Category category = null;
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM Category WHERE id =" + id);

            foreach (DataRow item in data.Rows)
            {
                Category catagory = new Category(item);
                return catagory;
            }
            return category;
        }
    }
}
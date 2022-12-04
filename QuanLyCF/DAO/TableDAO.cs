﻿using QuanLyCF.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCF.DAO
{
    public class TableDAO
    {
        private static TableDAO instance;
       

        public static TableDAO Instance
        {
            get { if (instance == null) 
                      instance = new TableDAO();
                return TableDAO.instance; 
                }
            private set { TableDAO.instance = value; }
        }

        private TableDAO() { }


        public List<Table> LoadTableList()
        {
            List<Table> tableList = new List<Table>();

            DataTable data = DataProvider.Instance.ExecuteQuery("P_GetTableList");

            foreach (DataRow item in data.Rows)
            {
                Table table = new Table(item);
                tableList.Add(table);
            }

            return tableList;

        }


       
    }
}

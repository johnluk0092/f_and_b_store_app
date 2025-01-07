using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using QL_CAFE.DTO;

namespace QL_CAFE.DAO
{
    public class TableDAO
    {
        private static TableDAO instance;

        public static TableDAO Instance
        {
            get { if (instance == null) instance = new TableDAO(); return TableDAO.instance; }
            private set { TableDAO.instance = value; }
        }

        public static int TableWidth = 90;
        public static int TableHeight = 90;

        private TableDAO() { }

        public void SwitchTable(int id1, int id2)
        {
            DataProvider.Instance.ExecuteQuery("USP_SwitchTabel @idTable1 , @idTabel2", new object[] { id1, id2 });
        }
        public List<QL_CAFE.DTO.Table> LoadTableList()
        {
            List<QL_CAFE.DTO.Table> tableList = new List<QL_CAFE.DTO.Table>();

            DataTable data = DataProvider.Instance.ExecuteQuery("USP_GetTableList");

            foreach (DataRow item in data.Rows)
            {
                QL_CAFE.DTO.Table table = new QL_CAFE.DTO.Table(item);
                tableList.Add(table);
            }

            return tableList;
        }

        
        public bool InsertTableName(string name)
        {
            string query = string.Format("INSERT dbo.TableFood ( name )VALUES  ( N'{0}')", name);
            int result = DataProvider.Instance.ExecuteNoneQuery(query);

            return result > 0;
        }

        public bool UpdateTableName(string name, string id)
        {
            string query = string.Format("UPDATE dbo.TableFood SET name = N'{0}' WHERE id = '{1}'", name, id);
            int result = DataProvider.Instance.ExecuteNoneQuery(query);

            return result > 0;
        }

        public bool DeleteTableName(string id)
        {
            string query = string.Format("UPDATE dbo.TableFood SET status = N'Đã xóa' WHERE id = '{0}'", id);
            int result = DataProvider.Instance.ExecuteNoneQuery(query);

            return result > 0;
        }
        

        public DataTable GetTable()
        {
            return DataProvider.Instance.ExecuteQuery("SELECT * FROM TableFood;");
        }
    }
}


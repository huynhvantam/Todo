using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace Todo.DAL
{
    public class BaseRepository
    {
        protected IDbConnection con;
        public BaseRepository()
        {
            string connectString = @"Data Source=DESKTOP-12J6D6C\SQLEXPRESS;Initial Catalog=Todo;Integrated Security=True";
            //string connectString = @"Data Source=H-AITD202003001\SQLEXPRESS;Initial Catalog=Todo;Integrated Security=True";
            con = new SqlConnection(connectString);
        }

    }
}

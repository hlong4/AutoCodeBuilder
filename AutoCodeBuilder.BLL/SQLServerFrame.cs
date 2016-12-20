using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace AutoCodeBuilder.BLL
{
    /// <summary>
    /// SQLServer数据库取数据结构框架
    /// </summary>
    public class SQLServerFrame
    {
        public static string connString = "";
        public string ConnString
        {
            get 
            {
                if (connString == "")
                {
                    throw new Exception("ConnString未设置");
                }
                return connString;
            }
            set { connString = value; }
        }

        /// <summary>
        /// 获取局域网内的所有数据库服务器名称
        /// </summary>
        /// <returns>服务器名称数组</returns>
        public List<string> GetSqlServerNames()
        {
            DataTable dataSources = SqlClientFactory.Instance.CreateDataSourceEnumerator().GetDataSources();

            DataColumn column = dataSources.Columns["InstanceName"];
            DataColumn column2 = dataSources.Columns["ServerName"];

            DataRowCollection rows = dataSources.Rows;
            List<string> Serverlist = new List<string>();
            string array = string.Empty;
            for (int i = 0; i < rows.Count; i++)
            {
                string str2 = rows[i][column2] as string;
                string str = rows[i][column] as string;
                if (((str == null) || (str.Length == 0)) || ("MSSQLSERVER" == str))
                {
                    array = str2;
                }
                else
                {
                    array = str2 + @"/" + str;
                }

                Serverlist.Add(array);
            }

            Serverlist.Sort();

            return Serverlist;
        }

        /// <summary>
        /// 查询sql中的非系统库
        /// </summary>
        /// <param name="connection"></param>
        /// <returns></returns>
        public List<string> databaseList(string connection)
        {
            List<string> getCataList = new List<string>();
            string cmdStirng = "select name from sys.databases where database_id > 4";
            SqlConnection connect = new SqlConnection(connection);
            SqlCommand cmd = new SqlCommand(cmdStirng, connect);
            try
            {
                if (connect.State == ConnectionState.Closed)
                {
                    connect.Open();
                    IDataReader dr = cmd.ExecuteReader();
                    getCataList.Clear();
                    while (dr.Read())
                    {
                        getCataList.Add(dr["name"].ToString());
                    }
                    dr.Close();
                }

            }
            catch (SqlException e)
            {
                //MessageBox.Show(e.Message);
            }
            finally
            {
                if (connect != null && connect.State == ConnectionState.Open)
                {
                    connect.Dispose();
                }
            }
            return getCataList;
        }

        /// <summary>
        /// 获取表名
        /// </summary>
        /// <param name="connection"></param>
        /// <returns></returns>
        public DataTable GetTables(string connection)
        {
            DataTable dt = null;
            SqlConnection objConnetion = new SqlConnection(connection);
            try
            {
                if (objConnetion.State == ConnectionState.Closed)
                {
                    objConnetion.Open();
                    dt = objConnetion.GetSchema("Tables");
                    //foreach (DataRow row in objTable.Rows)
                    //{
                    //    tablelist.Add(new { name = row[2].ToString() });
                    //}
                    //tablelist.OrderBy();
                }
            }
            catch
            {

            }
            finally
            {
                if (objConnetion != null && objConnetion.State == ConnectionState.Closed)
                {
                    objConnetion.Dispose();
                }

            }
            return dt;
        }

        /// <summary>
        /// 获取字段
        /// </summary>
        /// <param name="connection"></param>
        /// <param name="TableName"></param>
        /// <returns></returns>
        public DataSet GetColumnField(string connection, string TableName)
        {
            string sql = "Select Name FROM SysColumns Where id=Object_Id('" + TableName + "')";
            SqlConnection conn = new SqlConnection(connection);
            DataSet ds = Common.SqlHelper.ExecuteDataset(conn, CommandType.Text, sql);
            return ds;
        }

        public DataSet GetColumnField2(string connection, string TableName)
        {
            string sql = "select column_name,data_type from information_schema.columns where table_name = '" + TableName + "' ";
            SqlConnection conn = new SqlConnection(connection);
            DataSet ds = Common.SqlHelper.ExecuteDataset(conn, CommandType.Text, sql);
            return ds;
        }

        /// <summary>
        /// 获取存储过程名称列表
        /// </summary>
        /// <param name="connection"></param>
        /// <returns></returns>
        public List<string> GetProcedureList(string connection)
        {
            List<string> list = new List<string>();
            string cmdStirng = "select * from dbo.sysobjects where OBJECTPROPERTY(id, N'IsProcedure') = 1 order by name";
            SqlConnection connect = new SqlConnection(connection);
            SqlCommand cmd = new SqlCommand(cmdStirng, connect);
            try
            {
                if (connect.State == ConnectionState.Closed)
                {
                    connect.Open();
                    IDataReader dr = cmd.ExecuteReader();
                    list.Clear();
                    while (dr.Read())
                    {
                        list.Add(dr["name"].ToString());
                    }
                    dr.Close();
                }

            }
            catch (SqlException e)
            {
                //MessageBox.Show(e.Message);
            }
            finally
            {
                if (connect != null && connect.State == ConnectionState.Open)
                {
                    connect.Dispose();
                }
            }
            return list;
        }

        ///// <summary>
        ///// 获取存储过程参数列表
        ///// </summary>
        ///// <param name="connection"></param>
        ///// <param name="TableName"></param>
        ///// <returns></returns>
        //public DataSet GetParameterOfProcedure(string connection, string procedureName)
        //{
        //    StringBuilder sb = new StringBuilder();
        //    sb.Append("select * from syscolumns where ID in");
        //    sb.Append(" (SELECT id FROM sysobjects as a");
        //    sb.Append(" WHERE OBJECTPROPERTY(id, N'IsProcedure') = 1");
        //    sb.Append(" and id = object_id(N'[dbo].[" + procedureName + "]'))");
        //    SqlConnection conn = new SqlConnection(connection);
        //    DataSet ds = SqlHelper.ExecuteDataset(conn, CommandType.Text, sb.ToString());
        //    return ds;
        //}

        public List<ProcedureParameter> GetParameterOfProcedure(string connection, string procedureName)
        {
            SqlConnection conn = new SqlConnection(connection);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = procedureName;
            cmd.CommandType = CommandType.StoredProcedure;
            List<ProcedureParameter> list = new List<ProcedureParameter>();
            
            try
            {
                conn.Open();
                SqlCommandBuilder.DeriveParameters(cmd);
                foreach (SqlParameter var in cmd.Parameters)
                {
                    if (cmd.Parameters.IndexOf(var) == 0)
                    {
                        continue;//Skip return value
                    }
                    list.Add(new ProcedureParameter { Param = var.ParameterName, Type = var.DbType, Direction = var.Direction });
                    //list.Add((String.Format("Param: {0}{1}Type: {2}{1}Direction: {3}",
                    //   var.ParameterName,
                    //   Environment.NewLine,
                    //   var.SqlDbType.ToString(),
                    //   var.Direction.ToString())));
                }
            }
            finally
            {
                conn.Close();
            }
            return list;
        }


    }
}

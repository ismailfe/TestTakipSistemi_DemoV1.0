//22.09.2017 ID
// Derleme yapılmaktadır. Çalışma Devam edecek.
// Version: 1.0.2

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace TestTakipSistemi_Demo
{
   public class DB
    {
       public string ConnectionString;
       public bool ConnectionOK;
       public string SQL_Dizin;

       public SqlConnection SQLConnect()
        {
            SqlConnection Connection = new SqlConnection(SQL_Dizin);
            
            if(Connection.State != System.Data.ConnectionState.Open)
            {
                try
                {
                    Connection.Open();
                    ConnectionOK = true;
                }
                catch 
                {
                    Connection.Close();
                    ConnectionOK = false;
                }

            }
            return Connection;
        }

       public bool Sql_Read(string TableName, string[]TableData, string[] ReadData, int Count)
        {
            SqlCommand SqlCmd = new SqlCommand("Select * From " + TableName, SQLConnect());

            if (ConnectionOK)
            {
                SqlDataReader DataRead = SqlCmd.ExecuteReader();
                try
                {
                    while (DataRead.Read())
                        for (int i = 0; i < Count; i++)
                        {
                            ReadData[i] = DataRead[TableData[i]].ToString();
                        }
                    DataRead.Close();
                    return true;
                }
                catch
                {
                    DataRead.Close();
                    return false;
                }
            }
            else
            { return false; }
        }

       public bool Sql_DeleteValue(string TableName, string TableData, string DeleteValue)
        {
            SqlCommand SqlCmd = new SqlCommand();
            SqlCmd.Connection = SQLConnect();
            SqlCmd.CommandText = "Delete From " + TableName + "Where " + TableData + "= '" + DeleteValue + "'";

            try
            {
                SqlCmd.ExecuteNonQuery();
                return true;
            }
            catch 
            {
                return false;
    
            }


        }

// RESREVE
        //public string SQL_Table;
        //public string SQL_Target_Column;

        //public SqlConnection SqlConnect   = new SqlConnection("@" + SQL_Dizin); // SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=TofasTestTakipV1.0.0;Integrated Security=True");
        //public SqlCommand SqlCmd          = new SqlCommand();

















    }
}

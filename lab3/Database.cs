using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using Npgsql;
using System.Data.SqlClient;

namespace WebApplication_lr3
{
    public enum Status
    {
        ConnectionOpen,
        ConnectionClosed,
        ConnectionNotInitialized,
        EmptyResult
    }
    public static class Database
    {
        static private Status connectionstatus = Status.ConnectionNotInitialized;
        static public Status ConnectionStatus
        {
            get { return connectionstatus; }
            set { connectionstatus = value; }
        }
        static private NpgsqlConnection Connection;

        public static void OpenConnection()
        {
            if ((ConnectionStatus == Status.ConnectionNotInitialized) || (ConnectionStatus == Status.ConnectionClosed))
            {
                Connection = new NpgsqlConnection("Server=localhost;Username=postgres;Password=123;Database=telephone_directory;");
                Connection.Open();
                ConnectionStatus = Status.ConnectionOpen;
            }
        }
        public static void CloseConnection()
        {
            if (ConnectionStatus == Status.ConnectionOpen)
            {
                Connection.Close();
                ConnectionStatus = Status.ConnectionClosed;
            }
        }
        public static DataTable Request(string sql)
        {
            if (ConnectionStatus != Status.ConnectionOpen)
            {
                Database.OpenConnection();
            }
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(sql, Connection);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }
        public static void Execute(string sql)
        {
            if (ConnectionStatus != Status.ConnectionOpen)
            {
                Database.OpenConnection();
            }
            NpgsqlCommand command = new NpgsqlCommand(sql, Connection);
            command.ExecuteNonQuery();
        }
    }
}

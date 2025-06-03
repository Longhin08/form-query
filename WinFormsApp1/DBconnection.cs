using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    class DBconnection
    {
        public DBconnection(string host,  string port, string username, string password, string database)
        {
            Host = host;
            Port = port;
            Username = username;
            Password = password;
            DataBase = database;
        }

        public string ConnectionString;
        public string Host { get; }
        public string Port { get; }
        public string Username { get; }
        public string Password { get; }
        public string DataBase { get; }

        public void CreateConnection()
        {
            ConnectionString = $"Host={Host};Port={Port};Username={Username};Password={Password};Database={DataBase}";
        }
    };

}


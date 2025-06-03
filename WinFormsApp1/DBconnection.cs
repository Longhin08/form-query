using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    class DBconnection
    {

        public string ConnectionString;
        public string Host { get; set; }
        public string Port { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string DataBase { get; set; }

        public void CreateConnection()
        {
            ConnectionString = $"Host={Host};Port={Port};Username={Username};Password={Password};Database={DataBase}";
        }
    };

}


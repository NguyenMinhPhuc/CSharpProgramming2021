using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryClass.DatabaseType
{
    public class DatabaseFactory : IDatabaseFactory
    {
        IDatabaseConnect database;

        public IDatabaseConnect Database { get => database; set => database = value; }

        public void CreateDatabaseType(TypeDatabase typeDatabase)
        {
            switch (typeDatabase)
            {
                case TypeDatabase.INI:
                    Database = new DatabaseConnectINI();
                    break;
                case TypeDatabase.TEXT:
                    Database = new DatabaseConnectText();
                    break;
                case TypeDatabase.BINARY:
                    Database = new DatabaseConnectBinary();
                    break;
                case TypeDatabase.MSSQL:
                    break;
                default:
                    break;
            }
        }
    }
}

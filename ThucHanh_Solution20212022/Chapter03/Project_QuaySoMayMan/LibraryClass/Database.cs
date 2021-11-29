using LibraryClass.DatabaseType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryClass
{
   public class Database
    {
        DatabaseFactory databaseFactory;
        TypeDatabase typeDatabase;

        public Database(TypeDatabase typeDatabase)
        {
            this.typeDatabase=typeDatabase;
            DatabaseFactory = new DatabaseFactory();
            DatabaseFactory.CreateDatabaseType(typeDatabase);
           
        }

        public DatabaseFactory DatabaseFactory { get => databaseFactory; set => databaseFactory = value; }
    }
}

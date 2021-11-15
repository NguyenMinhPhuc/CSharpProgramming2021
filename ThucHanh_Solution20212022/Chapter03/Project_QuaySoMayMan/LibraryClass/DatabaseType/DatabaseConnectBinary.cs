using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryClass.DatabaseType
{
   public class DatabaseConnectBinary : IDatabaseConnect
    {
        public List<string> ReadFile(string path)
        {
            throw new NotImplementedException();
        }

        public void WriteToFile(string path, List<string> vs)
        {
            throw new NotImplementedException();
        }
    }
}

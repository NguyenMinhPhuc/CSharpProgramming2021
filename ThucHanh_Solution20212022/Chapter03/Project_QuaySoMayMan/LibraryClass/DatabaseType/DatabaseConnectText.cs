using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryClass.DatabaseType
{
    internal class DatabaseConnectText : IDatabaseConnect
    {
        public List<string> ReadFile(string path)
        {
            List<string> list = new List<string>();
            using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                using (StreamReader sr = new StreamReader(fs))
                {
                    string line = string.Empty;
                    while ((line = sr.ReadLine()) != null)
                    {
                        if (!string.IsNullOrEmpty(line))
                        {
                            list.Add(line);
                        }
                    }
                }
            }
            return list;
        }

        public void WriteToFile(string path, List<string> vs)
        {
            throw new NotImplementedException();
        }
    }
}

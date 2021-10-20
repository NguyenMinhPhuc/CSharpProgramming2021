using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project20210913_Login.Data
{
  public  class Function
    {
        int idFunction;
        string nameFunction;
        string aliasFunction;

        public int IdFunction { get => idFunction; set => idFunction = value; }
        public string NameFunction { get => nameFunction; set => nameFunction = value; }
        public string AliasFunction { get => aliasFunction; set => aliasFunction = value; }
    }
}

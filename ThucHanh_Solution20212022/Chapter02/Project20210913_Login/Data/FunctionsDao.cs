using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project20210913_Login.Data
{
    public class FunctionsDao
    {
        public List<Function> functions;
        public FunctionsDao()
        {
            functions = new List<Function>()
            {
                new Function(){IdFunction=1,NameFunction="Changed password", AliasFunction="Frm_ChangedPassword"},

                new Function(){IdFunction=2,NameFunction="User Manager", AliasFunction="Frm_Users_Main"},
                 
                new Function(){IdFunction=2, NameFunction="Permission", AliasFunction="Frm_Permissions_Main"}

            };
        }
        //co the viet phuong thuc doc va ghi du lieu tu file ini giong user.
    }
}

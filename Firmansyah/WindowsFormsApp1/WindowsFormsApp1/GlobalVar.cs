using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    static class GlobalVar
    {
    
        private static string _user = "";
        private static string _pass = "";

        public static string user
            {
                get { return _user; }
                set { _user = value; }
            }
        public static string pass
        {
            get { return _pass; }
            set { _pass = value; }
        }
    }
}

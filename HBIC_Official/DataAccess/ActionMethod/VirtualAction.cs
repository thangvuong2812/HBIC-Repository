using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.ActionMethod
{
    public class VirtualAction
    {
        private static VirtualAction instance;
        public static VirtualAction GetInstance()
        {
            if (instance == null)
                instance = new VirtualAction();
            return instance;
        }

        public bool CheckLogin(string userName, string passWord)
        {
            if (userName == "admin@gmail.com" && passWord == "123")
                return true;
            return false;
        }
    }
}

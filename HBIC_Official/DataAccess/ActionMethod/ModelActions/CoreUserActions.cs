using DataAccess.HBICModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.ActionMethod.ModelActions
{
    public class CoreUserActions
    {
        private HBIC_DBContext context = null;
        public CoreUserActions()
        {
            context = new HBIC_DBContext();
        }



    }
}

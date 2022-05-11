using System;
using System.Collections.Generic;
using System.Text;
using BLL.iClasses;
using DAL.DaliClasses;

namespace BLL.Classes
{
  public  class BllMaterialsForTool: IBllMaterialForTool
    {
        IDalMaterialForTool dal;
        public BllMaterialsForTool(IDalMaterialForTool p)
        {
            dal = p;
        }
    }
}

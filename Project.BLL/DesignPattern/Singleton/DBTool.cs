using Project.DAL.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.DesignPattern.Singleton
{
    public class DBTool
    {
        public DBTool()
        {

        }
        static MyContext _dbIntance;
        public static MyContext DBInstance
        {
            get
            {
                if (_dbIntance == null)_dbIntance = new MyContext();
                return _dbIntance;
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Common;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remainder
{
    public class DataBase
    {
        public static DbContext DbContext = new DbContext(ConfigurationManager.ConnectionStrings["MyDbContext"].ConnectionString);
        public static DbConnection Connection
        {
            get { return DbContext.Database.Connection; }
        }
    }
}

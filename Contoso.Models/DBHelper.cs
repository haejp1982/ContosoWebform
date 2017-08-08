using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Threading.Tasks;



namespace Contoso.Data
{
    class DBHelper
    {
        public static string GetConnection()
        {
            return ConfigurationManager.ConnectionString[ContosoDB].ConectionString;
        }
    }
}

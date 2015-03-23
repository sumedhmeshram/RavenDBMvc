using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Configuration;
using Insight.Database;

namespace RavenDb.DataAccess.ConnectionHelper
{
   public class ConnectionHelper
    {
       public static  IDbConnection Connection
       {
           get
           {
               return ConfigurationManager.ConnectionStrings["CS_Connection_String"].Connection();
           }
       }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Insight.Database;

namespace RavenDb.DataAccess.Sql.Customer
{
    [Sql(Schema="dbo")]    
   public interface ICustomer
    {
        List<CustomerResult> CustomerReadAll();
    }
}

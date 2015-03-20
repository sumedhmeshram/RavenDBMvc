using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RavenDb.Utils
{
    public class ExcelUtility
    {

        //should take an object and create the excel
        public string DefaultFileName
        {
            get
            {
                return "SampleData_" + DateTime.Now.ToString("yyyy-MM-dd--hh-mm-ss");
            }
        }

        public static void CreateExcel(object data,string filename = null)
        { 
          
        }
    }
}

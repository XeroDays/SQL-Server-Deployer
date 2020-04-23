using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_Installer.Controllers
{
    class sysController
    {
        public static List<string> getQueriesFromSQLFile(string[] sqlData)
	    {
            //test
            if (sqlData.Length > 0 && sqlData[0].Split(' ')[0] == "USE")
            {
                sqlData[0] = "";
            }

            List<string> queries = new List<string>();
            string sql = "";
            foreach (string line in sqlData)
            {
                

                if (line=="GO")
                {
                    queries.Add(sql);
                    sql = "";
                }
                else
                {
                    if (line.Length>0 && line[0]!='/')
                    {
                        sql += " "+line;
                    }
                }
            }

            return queries;
	    }
         
        public static string getPCName()
        {
            string pcName = Environment.MachineName; 
            return pcName;
        }
    }
}

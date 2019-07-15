using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectDataLayer;
using Models;
using System.Data;

namespace Business
{
    public class resort
    {
        public static List<ResortInfo> GetIndividualResortInfo()
        {
            ResortInfo IndivResort = new ResortInfo();
            var IndivResortList = new List<ResortInfo>();


            DataSet ResortReport = new DataSet();
            ResortReport = resortdata.GetResortUsingDB();

            if (ResortReport.Tables.Count > 0)
            {
                IndivResortList = ResortReport.Tables[0].AsEnumerable().Select(m => new ResortInfo
                {
                    Name = Convert.ToString(m["Name"]),
                    Country = Convert.ToString(m["Country"]),
                    ContactNumber = Convert.ToString(m["ContactNumber"])
                }).ToList();
            }

            return IndivResortList;
        }
    }
}

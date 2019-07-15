using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace ProjectDataLayer
{
    public class resortdata
    {
        public static DataSet GetResortUsingDB()
        {
            SqlConnection cnn;
            string sql = null;
            SqlCommand command;
            SqlDataReader dataReader;

            DataTable dt = new DataTable();
            DataSet resorttable = new DataSet();

            var cs = ConfigurationManager.ConnectionStrings["ResortConnection"].ConnectionString;
            cnn = new SqlConnection(cs);
            sql = "Select * from Resort";

            cnn.Open();
            command = new SqlCommand(sql, cnn);
            dataReader = command.ExecuteReader();
            dt.Load(dataReader);
            resorttable.Tables.Add(dt);
            dataReader.Close();
            command.Dispose();
            cnn.Close();

            return resorttable;

        }
        public static DataSet GetResortDataWithOutDB()
        {

            DataSet ResortReport = new DataSet();
            ResortReport.DataSetName = "Resort";
            DataTable dt = new DataTable("BasicInformation");
            dt.Clear();
            dt.Columns.Add(new DataColumn("Name", typeof(string)));
            dt.Columns.Add(new DataColumn("Country", typeof(string)));
            dt.Columns.Add(new DataColumn("ContactNumber", typeof(string)));

            DataRow dr = dt.NewRow();
            dr["Name"] = "Boston Hotel";
            dr["Country"] = "US";
            dr["ContactNumber"] = "+10000000000";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr["Name"] = "New York Resort";
            dr["Country"] = "US";
            dr["ContactNumber"] = "+19999999999";
            dt.Rows.Add(dr);




            ResortReport.Tables.Add(dt);

            return ResortReport;
        }

    }

    
}

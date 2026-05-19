using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Xml;
using System.IO;
using System.Xml.Serialization;
using System.Xml.XPath;
using System.Configuration;
/*
 * CCCSQLConnect
 * Created: 12-27-2025
 * Author : Wayne Rudnick
 * Purpose: The purpose if this program is to provide Enterprise Justice database access
 */
namespace CCCSQLConnect 
{
    public class CCCConn
    {
        public string realm = "";

        SqlConnection cccCon;
 
        public void SetRealm(string sRealm)
        {
            realm = sRealm;
        }

        public string GetRealm()
        {
            return realm;
        }
        public void SetConn()
        {
            switch (realm)
            {
                case "TEST4":
                    SqlConnection sqlCaseConnTEST4 = new SqlConnection(Properties.Settings.Default.JusticeTEST4);
                    cccCon = sqlCaseConnTEST4;
                    break;
                case "TST4U":
                    SqlConnection sqlCaseConnTST4U = new SqlConnection(Properties.Settings.Default.JusticeTST4U);
                    cccCon = sqlCaseConnTST4U;
                    break;
                case "TEST8":
                    SqlConnection sqlCaseConnTEST8 = new SqlConnection(Properties.Settings.Default.JusticeTEST8);
                    cccCon = sqlCaseConnTEST8;
                    break;
                case "TST8U":
                    SqlConnection sqlCaseConnTST8 = new SqlConnection(Properties.Settings.Default.JusticeTST8U);
                    cccCon = sqlCaseConnTST8;
                    break;
                case "TEST12":
                    SqlConnection sqlCaseConnTEST12 = new SqlConnection(Properties.Settings.Default.JusticeTEST12);
                    cccCon = sqlCaseConnTEST12;
                    break;
                case "STAGE":
                    SqlConnection sqlCaseConnSTAGE = new SqlConnection(Properties.Settings.Default.JusticeSTAGE);
                    cccCon = sqlCaseConnSTAGE;
                    break;
                case "PROD":
                    SqlConnection sqlCaseConnPROD = new SqlConnection(Properties.Settings.Default.JusticePROD);
                    cccCon = sqlCaseConnPROD;
                    break;
                case "PRODU":
                    SqlConnection sqlCaseConnPRODU = new SqlConnection(Properties.Settings.Default.JusticePRODU);
                    cccCon = sqlCaseConnPRODU;
                    break;
                case "PRODL":
                    SqlConnection sqlCaseConnPRODL = new SqlConnection(Properties.Settings.Default.JusticePRODL);
                    cccCon = sqlCaseConnPRODL;
                    break;
            }
            cccCon.Open();
        }

        public SqlConnection GetConn()
        {
            return cccCon;
        }
        public void CloseConn()
        {
            cccCon.Close();
            cccCon.Dispose();
        }

    }
}

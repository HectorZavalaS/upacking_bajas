using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace upacking_bajas.Class
{
    public class conn
    {
        public string connection(string dato)
        {
            string connetionString="";
            SqlConnection cnn;
            
            switch (dato)
            {
                case "Jpacking":
                    string server = "192.168.3.13";
                    string database = "jpacking";
                    string user = "root";
                    string password = "S3m4dm1n2017!";
                    string port = "3306";
                    string sslM = "none";
                    string connString = String.Format("server={0};port={1};user id={2}; password={3}; database={4}; SslMode={5};Allow Zero Datetime=True", server, port, user, password, database, sslM);

                    return connString;

                default:
                    
                    
                    connetionString = @"Data Source=192.168.3.28\SIIXSEMSQL2016;Initial Catalog=" + dato + ";User ID=dmoreno;Password=Dm0r3n0!";
                    cnn = new SqlConnection(connetionString);
                    return connetionString;
            }
        }
    }
}
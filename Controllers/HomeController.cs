using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using upacking_bajas.Class;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Drawing;
using System.Security.Cryptography;
using System.Text;

namespace upacking_bajas.Controllers
{
    public class HomeController : Controller
    {
        conn connection = new conn();
        private SqlConnection con;
        private SqlDataReader dr;
        private SqlConnection con2;
        private SqlDataReader dr2;
        private SqlCommand com;
        public ActionResult Index()
        {
            
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Verificar(datos datos)
        {
            MD5 md5 = MD5CryptoServiceProvider.Create();
            ASCIIEncoding encoding = new ASCIIEncoding();
            StringBuilder sb = new StringBuilder();
            if (datos.se_name != null && datos.se_pass != null)
            {
                byte[] stream = md5.ComputeHash(encoding.GetBytes(datos.se_pass));
                for (int i = 0; i < stream.Length; i++) sb.AppendFormat("{0:x2}", stream[i]);
                datos data;
                List<datos> list = new List<datos>();
                string sql = "";

                sql = "SELECT TOP (1000) [se_id_user],[se_name],[se_pass],[se_id_rol] FROM [siixsem_main_db].[dbo].[siixsem_users_t]  where se_name='" + datos.se_name + "'";

                conn c = new conn();
                string conexion = c.connection("siixsem_main_db");

                con = new SqlConnection(conexion);
                SqlCommand commandDatabase = new SqlCommand(sql, con);
                con.Open();
                dr = commandDatabase.ExecuteReader();
                if (dr.Read())
                {
                    data = new datos();
                    data.se_id_user = dr["se_id_user"].ToString();
                    data.se_name = dr["se_name"].ToString();
                    data.se_pass = dr["se_pass"].ToString();
                    Session["se_id_user"] = dr["se_id_user"].ToString();
                    Session["se_name"] = dr["se_name"].ToString();
                    Session["se_pass"] = dr["se_pass"].ToString();
                    con.Close();
                    //   return Json("ok",JsonRequestBehavior.AllowGet);
                    return View("Home/About");
                }
                else
                {
                    con.Close();
                    ViewBag.error = "Error en Nick o Password";
                    return Json("error", JsonRequestBehavior.AllowGet);
                }
            }
            else
                return Json("error", JsonRequestBehavior.AllowGet);
        }

    }
}
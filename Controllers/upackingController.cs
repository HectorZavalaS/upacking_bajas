using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.SqlClient;
using System.Windows.Forms;
using upacking_bajas.Class;
using System.Collections;
using System.Linq.Expressions;

namespace upacking_bajas.Controllers
{
    public class upackingController : Controller
    {
        // GET: upacking
        private SqlConnection con;
        private SqlDataReader dr;
        private SqlConnection con2;
        private SqlDataReader dr2;
        private SqlCommand com;
        public ActionResult Index()
        {
            
            return View();
        }


        public JsonResult getModels()
        {
            var result = obtenerDatos();
            return Json(result, JsonRequestBehavior.AllowGet);
        }

        public List<datos> obtenerDatos()
        {
            datos dato;
            List<datos> lista = new List<datos>();
            string query = "EXEC  [dbo].[getModels] ";

            conn c = new conn();
            string conexion = c.connection("siixsem_upacking_config_db");
            con = new SqlConnection(conexion);
            SqlCommand commandDatabase = new SqlCommand(query, con);
            con.Open();
            dr = commandDatabase.ExecuteReader();
            while (dr.Read())
            {
                dato = new datos();
                dato.se_id = dr["id_model"].ToString();
                dato.se_description = dr["description"].ToString();
                lista.Add(dato);
            }
            con.Close();
            return lista;
        }

        public JsonResult get_information(datos data)
        {
            List<datos> lista = new List<datos>();

            lista = obtenerDatos(data);
                int n = lista.Count();
                if (n == 0)
                {
                    data.message = "No se encontraron registros";
                    lista.Add(data);
                    return Json(lista, JsonRequestBehavior.AllowGet);
                }

                return Json(lista, JsonRequestBehavior.AllowGet);
            
        }

        public List<datos> obtenerDatos(datos data)
        {
            
            datos dato;
            List<datos> lista = new List<datos>();
            try { 
                string se_table = get_table(data);
                string query = "";

                switch (data.se_type)
                { 
                    case "cover":
                        query = "SELECT  * FROM " + se_table + " where   se_serial_pcb in (" + data.se_serial + ") or se_serial_cover in ("+data.se_serial+ ") and se_status='A' ";
                        break;
                    case "packing":
                        query = "SELECT  * FROM " + se_table + " where  se_status='A' and se_serial in (" + data.se_serial + ") ";
                        break;
                }
                conn c = new conn();
                
                string conexion = c.connection("siixsem_upacking_data_db");
                con = new SqlConnection(conexion);
                SqlCommand commandDatabase = new SqlCommand(query, con);
                con.Open();
                dr = commandDatabase.ExecuteReader();
                while (dr.Read())
                {
                    dato = new datos();
                    dato.se_id = dr["se_id"].ToString();
                    switch (data.se_type)
                    {

                        case "cover":
                            dato.se_serial = dr["se_serial_pcb"].ToString();
                            dato.se_serial_cover = dr["se_serial_cover"].ToString();
                            dato.se_id_prod_line = dr["se_id_line"].ToString();
                            dato.se_name_line = get_name_line(dato);
                            dato.se_type = "cover";
                            break;
                        case "packing":
                            dato.se_serial = dr["se_serial"].ToString();
                            dato.se_box_no = dr["se_box_no"].ToString(); 
                            dato.se_status = dr["se_status"].ToString();
                            dato.se_julian_date = dr["se_julian_date"].ToString();
                            dato.se_id_prod_line = dr["se_id_prod_line"].ToString();
                            dato.se_name_line= get_name_line(dato);
                            dato.se_box_id = dr["se_box_id"].ToString();
                            dato.se_dj_group = dr["se_dj_group"].ToString();
                            dato.se_type = "packing";
                            break;
                    }
                    dato.se_status = dr["se_status"].ToString();
                    dato.se_create_date = dr["se_create_date"].ToString();
                    dato.se_delete_date = dr["se_delete_date"].ToString();
                    dato.se_table = se_table;
                    lista.Add(dato);
                }
                con.Close();
                data.message = lista.Count.ToString();
                return lista;
            }
            catch (Exception ex) 
            {
                data.message= ex.ToString();
                lista.Add (data);
                return lista; 
            }

}

        public List<datos> obtenerDatosCajaCompleta(string se_model, string se_box_no,string se_julian_date, string se_type)
        {

            datos dato;
           
            List<datos> lista = new List<datos>();
            //try { 
            //string se_table = get_table(dato);
            string query = "";

            //switch (data.se_type)
            //{
            //    //case "cover":
            //    //    query = "SELECT  * FROM " + se_table + " where  se_status='A' and se_serial_pcb in (" + data.se_serial + ") or se_serial_cover in (" + data.se_serial + ") ";
            //    //    break;
            //    case "packing":
                    query = "SELECT  * FROM " + se_model + " where  se_status='A' and se_box_no ='" + se_box_no + "' and  se_julian_date ='" + se_julian_date + "' ";
            //        break;
            //}
            conn c = new conn();

            string conexion = c.connection("siixsem_upacking_data_db");
            con = new SqlConnection(conexion);
            SqlCommand commandDatabase = new SqlCommand(query, con);
            con.Open();
            dr = commandDatabase.ExecuteReader();
            while (dr.Read())
            {
                dato = new datos();
                dato.se_id = dr["se_id"].ToString();
                switch (se_type)
                {
                    case "cover":
                        dato.se_serial = dr["se_serial_pcb"].ToString();
                        dato.se_serial_cover = dr["se_serial_cover"].ToString();
                        dato.se_id_prod_line = dr["se_id_line"].ToString();
                        dato.se_name_line = get_name_line(dato);
                        dato.se_type = "cover";
                        break;
                    case "packing":
                        dato.se_serial = dr["se_serial"].ToString();
                        dato.se_box_no = dr["se_box_no"].ToString();
                        dato.se_status = dr["se_status"].ToString();
                        dato.se_julian_date = dr["se_julian_date"].ToString();
                        dato.se_id_prod_line = dr["se_id_prod_line"].ToString();
                        dato.se_name_line = get_name_line(dato);
                        dato.se_box_id = dr["se_box_id"].ToString();
                        dato.se_dj_group = dr["se_dj_group"].ToString();
                        dato.se_type = "packing";
                        break;
                }
                dato.se_status = dr["se_status"].ToString();
                dato.se_create_date = dr["se_create_date"].ToString();
                dato.se_delete_date = dr["se_delete_date"].ToString();
                lista.Add(dato);
            }
            con.Close();
            return lista;

        }

        public string get_table(datos data)
        {
            try
            {
                datos dato;
                string query = "";
                string type = "";
                switch (data.se_type)
                {
                    case "cover":
                        type = "COV";
                        query = "EXEC  [dbo].[getCovTable] @idFatherModel =" + data.se_model;
                        break;
                    case "packing":
                        type = "PACK";
                        query = "EXEC  [dbo].[getPackingTable] @idFatherModel =" + data.se_model;
                        break;
                }
                conn c = new conn();
                string conexion = c.connection("siixsem_upacking_config_db");
                con = new SqlConnection(conexion);
                SqlCommand commandDatabase = new SqlCommand(query, con);
                con.Open();
                dr = commandDatabase.ExecuteReader();
                while (dr.Read())
                {
                    dato = new datos();
                    dato.se_table = dr["TBL" + type].ToString();
                    con.Close();
                    return dato.se_table;
                }
                return "";
            }
            catch(Exception e) {
                data.message = e.ToString();
                return data.message;
            }
        }

        public string get_name_line(datos data)
        {
            datos dato;
            string query = "SELECT * FROM [siixsem_lines_t] where se_id='" + data.se_id_prod_line + "'";
            
            conn c = new conn();
            string conexion = c.connection("siixsem_upacking_config_db");
            con2 = new SqlConnection(conexion);
            SqlCommand commandDatabase = new SqlCommand(query, con2);
            con2.Open();
            dr2 = commandDatabase.ExecuteReader();
            while (dr2.Read())
            {
                dato = new datos();
                dato.se_name_line = dr2["se_description"].ToString();
                con2.Close();
                return dato.se_name_line;
            }
            return "";
        }

        public JsonResult update_estaatus(datos data)
        {
            List<datos> lista = new List<datos>();
            var result="";

            string validacion= UserValidation(data);
            if (validacion == "No se encontro usuario") {
                return Json(validacion, JsonRequestBehavior.AllowGet);
            } else {

                lista = obtenerDatos(data);
                if (data.se_down_type == "caja")
                {
                    foreach (var d in lista)
                    {
                        d.se_down_type = "caja";
                        d.se_name = validacion;
                        d.se_motivo = data.se_motivo;
                        result = update_data(d);
                        baja_user(d);
                    }
                    return Json(result, JsonRequestBehavior.AllowGet);
                }
                else
                {
                    foreach (var d in lista)
                    {
                        d.se_down_type = "serial";
                        d.se_name = validacion;
                        d.se_motivo = data.se_motivo;
                        result = update_data(d);
                        baja_user(d);
                    }
                    return Json(result, JsonRequestBehavior.AllowGet);
                }
            }
            
            
        }
        public string update_data(datos data) {
            datos dato;
            string query = "";
            //string se_table = get_table(data);
            switch (data.se_type)
            {

                case "cover":
                     query = "UPDATE "+ data.se_table + " SET [se_status] = 'D' , se_delete_date =GETDATE() WHERE  se_serial_pcb in ('" + data.se_serial + "') or  se_serial_cover in ('" + data.se_serial + "')";

                    break;
                case "packing":
                    if (data.se_down_type=="serial") {
                        query = "UPDATE " + data.se_table + " SET [se_status] = 'D' , se_delete_date =GETDATE() WHERE  se_serial in ('" + data.se_serial + "')";
                    }
                    else { 
                        query = "UPDATE "+ data.se_table + " SET [se_status] = 'D' , se_delete_date =GETDATE() WHERE  se_julian_date in (" + data.se_julian_date + ") and  se_box_no in (" + data.se_box_no + ")";
                    }
                     
                    break;
            }
            
            conn c = new conn();
            string conexion = c.connection("siixsem_upacking_data_db");
            con = new SqlConnection(conexion);
            SqlCommand commandDatabase = new SqlCommand(query, con);
            con.Open();
            dr = commandDatabase.ExecuteReader();
            con.Close();
            switch (data.se_type)
            {

                case "cover":
                    return "Se dio de baja serial con éxito";
                case "packing":
                    if (data.se_down_type == "serial")
                    {
                        return "Se dio de baja serial con éxito";
                    }
                    else
                    {
                        return "Se dio de baja la caja completa con éxito";
                    }
            }

            return "Se dio de baja con éxito";
        }

        public string UserValidation(datos data)
        {
            datos dato;
            string query = "";
            //string se_table = get_table(data);
            
            query = "SELECT TOP (1000) [se_id_user],[se_name],[se_pass],[se_id_rol] FROM [siixsem_main_db].[dbo].[siixsem_users_t]  where se_id_rol=20 and se_name='" + data.se_name+"'";

            conn c = new conn();
            string conexion = c.connection("siixsem_upacking_config_db");
            con = new SqlConnection(conexion);
            SqlCommand commandDatabase = new SqlCommand(query, con);
            con.Open();
            dr = commandDatabase.ExecuteReader();
            

            while (dr.Read())
            {
                dato = new datos();
                dato.se_id_user = dr["se_id_user"].ToString();
                dato.se_name = dr["se_name"].ToString();
                con.Close();
                return dato.se_name;
            }
                return "No se encontro usuario";
        }


        public string baja_user(datos data)
        {
            datos dato;
            string query = "";
            //string se_table = get_table(data);

            query = "INSERT INTO [dbo].[siixsem_casualty_log] ([se_id_user] , [se_id_model] , [se_type] , [se_comments],[se_serial]) VALUES ('" + data.se_name + "','" + data.se_table + "','" + data.se_type + "','" + data.se_motivo + "','" + data.se_serial + "')";


            conn c = new conn();
            string conexion = c.connection("siixsem_upacking_config_db");
            con = new SqlConnection(conexion);
            SqlCommand commandDatabase = new SqlCommand(query, con);
            con.Open();
            dr = commandDatabase.ExecuteReader();
            con.Close();

            return "Se registro información";
        }
        // GET: upacking/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: upacking/Create
        public ActionResult Create()
        {
            return View();
        }

        //// POST: upacking/Create
        //[HttpPost]
        //public ActionResult Create(FormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add insert logic here

        //        return RedirectToAction("Index");
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        // GET: upacking/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        //// POST: upacking/Edit/5
        //[HttpPost]
        //public ActionResult Edit(int id, FormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add update logic here

        //        return RedirectToAction("Index");
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        // GET: upacking/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        //// POST: upacking/Delete/5
        //[HttpPost]
        //public ActionResult Delete(int id, FormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add delete logic here

        //        return RedirectToAction("Index");
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
    }
}

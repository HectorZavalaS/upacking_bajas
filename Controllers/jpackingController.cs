using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using upacking_bajas.Class;

namespace upacking_bajas.Controllers
{
    public class jpackingController : Controller
    {
        private SqlConnection con;
        private SqlDataReader dr;


        private MySqlConnector.MySqlConnection conmysql;
        private MySqlConnector.MySqlDataReader drmysql;
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult get_informationSIT(datos data)
        {
            List<datos> lista = new List<datos>();
            switch (data.se_model)
            {
                case "siixsem_sit_minivolt_2020":
                    lista = obtenerDatosJpacking(data);
                    break;

                case "siixsem_sit_partial_2020":
                    lista = obtenerDatosJpacking(data);
                    break;

                default:
                    lista = obtenerDatosSQLSRVR(data);
                    break;
            }
            int n = lista.Count();
            if (n == 0)
            {
                data.message = "No se encontraron registros";
                lista.Add(data);
                return Json(lista, JsonRequestBehavior.AllowGet);
            }

            return Json(lista, JsonRequestBehavior.AllowGet);

        }

        public List<datos> obtenerDatosSQLSRVR(datos data)
        {

            datos dato;
            List<datos> lista = new List<datos>();
            string query = ""; ;
            string conexion = "";
            try
            {
                query = "SELECT  * FROM " + data.se_table + " where  status='N' and serial in (" + data.se_serial + ") ";
                
                conn c = new conn();
                
                conexion = c.connection("Ship");
                con = new SqlConnection(conexion);
                SqlCommand commandDatabase = new SqlCommand(query, con);
                con.Open();
                dr = commandDatabase.ExecuteReader();
                
                
                while (dr.Read())
                {
                    dato = new datos();
                    dato.se_serial = dr["serial"].ToString();
                    dato.se_box_no = dr["c_no"].ToString();
                    dato.se_julian_date = dr["julian_date"].ToString();
                    dato.se_status = dr["status"].ToString();
                    dato.se_table = data.se_table;
                    lista.Add(dato);
                }
                con.Close();
                data.message = lista.Count.ToString();
                return lista;
            }
            catch (Exception ex)
            {
                data.message = ex.ToString();
                lista.Add(data);
                return lista;
            }

        }


        public List<datos> obtenerDatosJpacking(datos data)
        {

            datos dato;
            List<datos> lista = new List<datos>();
            try
            {
                string query = "SELECT serial, julian_date, c_no, status FROM jpacking."+data.se_table+"  where  status='N' and serial in (" + data.se_serial + ") ";
                conn c = new conn();
                string  conexion = c.connection("Jpacking");
                conmysql = new MySqlConnector.MySqlConnection(conexion);
                MySqlConnector.MySqlCommand commandDatabase = new MySqlConnector.MySqlCommand(query, conmysql);
                conmysql.Open();
                drmysql = commandDatabase.ExecuteReader();

                while (drmysql.Read())
                {
                    dato = new datos();
                    dato.se_serial = drmysql["serial"].ToString();
                    dato.se_box_no = drmysql["c_no"].ToString();
                    dato.se_julian_date = drmysql["julian_date"].ToString();
                    dato.se_status = drmysql["status"].ToString();
                    dato.se_table = data.se_table;
                    lista.Add(dato);
                }
                conmysql.Close();
                data.message = lista.Count.ToString();
                return lista;
            }
            catch (Exception ex)
            {
                data.message = ex.ToString();
                lista.Add(data);
                return lista;
            }

        }

        public JsonResult update_statusSIT(datos data)
        {
            List<datos> lista = new List<datos>();
            var result = "";
            switch (data.se_table)
            {
                case "siixsem_sit_minivolt_2020":
                    lista = obtenerDatosJpacking(data);

                    if (data.se_down_type == "caja")
                    {
                        foreach (var d in lista)
                        {
                            d.se_down_type = "caja";
                            result = update_dataJpacking(d);
                        }
                        return Json(result, JsonRequestBehavior.AllowGet);
                    }
                    else
                    {
                        foreach (var d in lista)
                        {
                            d.se_down_type = "serial";
                            d.se_table = data.se_table;
                            result = update_dataJpacking(d);
                        }
                        return Json(result, JsonRequestBehavior.AllowGet);
                    }
                case "siixsem_sit_partial_2020":
                    lista = obtenerDatosJpacking(data);

                    if (data.se_down_type == "caja")
                    {
                        foreach (var d in lista)
                        {
                            d.se_down_type = "caja";
                            result = update_dataJpacking(d);
                        }
                        return Json(result, JsonRequestBehavior.AllowGet);
                    }
                    else
                    {
                        foreach (var d in lista)
                        {
                            d.se_down_type = "serial";
                            d.se_table = data.se_table;
                            result = update_dataJpacking(d);
                        }
                        return Json(result, JsonRequestBehavior.AllowGet);
                    }

                default:
                    lista = obtenerDatosSQLSRVR(data);
                    if (data.se_down_type == "caja")
                    {
                        foreach (var d in lista)
                        {
                            d.se_down_type = "caja";
                            result = update_data(d);
                        }
                        return Json(result, JsonRequestBehavior.AllowGet);
                    }
                    else
                    {
                        foreach (var d in lista)
                        {
                            d.se_down_type = "serial";
                            d.se_table = data.se_table;
                            result = update_data(d);
                        }
                        return Json(result, JsonRequestBehavior.AllowGet);
                    }

            }
        }
        public string update_data(datos data)
        {
            datos dato;
            string query = "";
            //string se_table = get_table(data);
          
                    if (data.se_down_type == "serial")
                    {
                        query = "UPDATE " + data.se_table  + " SET [status] = 'D'  WHERE  serial in ('" + data.se_serial + "')";
                    }
                    else
                    {
                        query = "UPDATE " + data.se_table + " SET [status] = 'D'  WHERE  julian_date in (" + data.se_julian_date + ") and  c_no in (" + data.se_box_no + ")";
                    }
            conn c = new conn();
            string conexion = c.connection("Ship");
            con = new SqlConnection(conexion);
            SqlCommand commandDatabase = new SqlCommand(query, con);
            con.Open();
            dr = commandDatabase.ExecuteReader();
            con.Close();
           
                    if (data.se_down_type == "serial")
                    {
                        return "Se dio de baja serial con éxito";
                    }
                    else
                    {
                        return "Se dio de baja la caja completa con éxito";
                    }
            
        }


        public string update_dataJpacking(datos data)
        {
            datos dato;
            string query = "";
            //string se_table = get_table(data);

            if (data.se_down_type == "serial")
            {
                query = "UPDATE " + data.se_table  + " SET status = 'D'  WHERE  serial in ('" + data.se_serial + "')";
            }
            else
            {
                query = "UPDATE " + data.se_table  + " SET status = 'D'  WHERE  julian_date in (" + data.se_julian_date + ") and  c_no in (" + data.se_box_no + ")";
            }
            conn c = new conn();
            string conexion = c.connection("Jpacking");
            conmysql = new MySqlConnector.MySqlConnection(conexion);
            MySqlConnector.MySqlCommand commandDatabase = new MySqlConnector.MySqlCommand(query, conmysql);
            conmysql.Open();
            drmysql = commandDatabase.ExecuteReader();
            conmysql.Close();

            if (data.se_down_type == "serial")
            {
                return "Se dio de baja serial con éxito";
            }
            else
            {
                return "Se dio de baja la caja completa con éxito";
            }

        }

        // GET: jpacking/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: jpacking/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: jpacking/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: jpacking/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: jpacking/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: jpacking/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: jpacking/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}

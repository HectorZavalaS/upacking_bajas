using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace upacking_bajas.Class
{
    public class datos
    {
        public string se_type { get; set; }
        public string se_id { get; set; }
        public string se_description { get; set; }
        public string se_model { get; set; }
        public string se_table { get; set; }
        public string se_serial  { get; set; }
        public string se_serial_cover { get; set; }
        public string se_box_no { get; set; }
        public string se_julian_date { get; set; }
        public string se_status { get; set; }
        public string se_create_date { get; set; }
        public string se_id_prod_line { get; set; }
        public string se_name_line { get; set; }
        public string se_down_type { get; set; }
        public string se_box_id { get; set; }
        public string se_delete_date { get; set; }
        public string se_dj_group { get; set; }
        public string message { get; set; }
        public List<datos> lista_completa { get; set; }

        public string se_id_user { get; set; }
        public string se_name { get; set; }
        public string se_pass { get; set; }
        public string se_motivo { get; set; }


    }
}
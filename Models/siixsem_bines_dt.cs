//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace upacking_bajas.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class siixsem_bines_dt
    {
        public int se_id { get; set; }
        public int se_id_model { get; set; }
        public int se_id_flx { get; set; }
        public int se_id_color { get; set; }
        public int se_id_volt { get; set; }
        public bool se_active { get; set; }
        public int se_start_pos_flux { get; set; }
        public int se_end_pos_flux { get; set; }
        public int se_start_pos_color { get; set; }
        public int se_end_pos_color { get; set; }
        public int se_start_pos_volt { get; set; }
        public int se_end_pos_volt { get; set; }
        public bool se_must_print_flx { get; set; }
        public bool se_must_print_color { get; set; }
        public bool se_must_print_volt { get; set; }
    
        public virtual siixsem_colors_t siixsem_colors_t { get; set; }
        public virtual siixsem_flux_t siixsem_flux_t { get; set; }
        public virtual siixsem_models_t siixsem_models_t { get; set; }
        public virtual siixsem_voltages_t siixsem_voltages_t { get; set; }
    }
}

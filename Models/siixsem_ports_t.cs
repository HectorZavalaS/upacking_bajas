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
    
    public partial class siixsem_ports_t
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public siixsem_ports_t()
        {
            this.siixsem_labels_path = new HashSet<siixsem_labels_path>();
        }
    
        public int se_id { get; set; }
        public int se_port { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<siixsem_labels_path> siixsem_labels_path { get; set; }
    }
}

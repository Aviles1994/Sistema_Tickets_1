//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sistema_Tickets.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Modulos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Modulos()
        {
            this.Pantallas = new HashSet<Pantallas>();
        }
    
        public int ID_Modulo { get; set; }
        public string Nombre_Modulo { get; set; }
        public int Numero_de_Pantallas { get; set; }
        public string Descripcion_Modulo { get; set; }
        public int ID_Sistema { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Pantallas> Pantallas { get; set; }
        public virtual Sistema Sistema { get; set; }
    }
}

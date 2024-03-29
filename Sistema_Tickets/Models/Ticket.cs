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
    
    public partial class Ticket
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Ticket()
        {
            this.Historial_Ticket = new HashSet<Historial_Ticket>();
            this.Solucion = new HashSet<Solucion>();
        }
    
        public int ID_Ticket { get; set; }
        public System.DateTime Fecha_Inicio { get; set; }
        public System.TimeSpan Hora_Inicio { get; set; }
        public Nullable<System.TimeSpan> Duracion { get; set; }
        public string Version_Usuario { get; set; }
        public string Nombre_Problema { get; set; }
        public string Descripcion_Problema { get; set; }
        public string Imagen { get; set; }
        public Nullable<System.DateTime> Fecha_Fin { get; set; }
        public Nullable<System.TimeSpan> Hora_Fin { get; set; }
        public int ID_Pantalla { get; set; }
        public int ID_Usuario_Cliente { get; set; }
        public int ID_Medio_de_Contacto { get; set; }
        public int ID_Servicio { get; set; }
        public int ID_Estado { get; set; }
        public int ID_Prioridad { get; set; }
    
        public virtual Estado Estado { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Historial_Ticket> Historial_Ticket { get; set; }
        public virtual Medio_de_Contacto Medio_de_Contacto { get; set; }
        public virtual Pantallas Pantallas { get; set; }
        public virtual Prioridad Prioridad { get; set; }
        public virtual Servicio Servicio { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Solucion> Solucion { get; set; }
        public virtual Usuario_Cliente Usuario_Cliente { get; set; }
    }
}

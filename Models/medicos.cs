//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClinicaMVC.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class medicos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public medicos()
        {
            this.consultas = new HashSet<consultas>();
        }
    
        public int IdMedico { get; set; }
        public string Nombre { get; set; }
        public int IdEspecialidad { get; set; }
        public string IdUsuario { get; set; }
        public string Foto { get; set; }
    
        public virtual AspNetUsers AspNetUsers { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<consultas> consultas { get; set; }
        public virtual especialidades especialidades { get; set; }
    }
}

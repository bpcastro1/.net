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
    
    public partial class consultas
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public consultas()
        {
            this.recetas = new HashSet<recetas>();
        }
    
        public int IdConsulta { get; set; }
        public int IdMedico { get; set; }
        public int IdPaciente { get; set; }
        public System.DateTime FechaConsulta { get; set; }
        public System.TimeSpan HI { get; set; }
        public System.TimeSpan HF { get; set; }
        public string Diagnostico { get; set; }
    
        public virtual pacientes pacientes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<recetas> recetas { get; set; }
        public virtual medicos medicos { get; set; }
    }
}

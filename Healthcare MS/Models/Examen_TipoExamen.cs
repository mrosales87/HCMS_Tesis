//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Healthcare_MS.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Examen_TipoExamen
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Examen_TipoExamen()
        {
            this.ResultadoExamen = new HashSet<ResultadoExamen>();
        }
    
        public int id { get; set; }
        public int fk_IdAgendaExamen { get; set; }
        public int fk_IdTipoExamen { get; set; }
    
        public virtual AgendaExamen AgendaExamen { get; set; }
        public virtual TipoExamen TipoExamen { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ResultadoExamen> ResultadoExamen { get; set; }
    }
}

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
    
    public partial class ExamenAnulado
    {
        public int Id { get; set; }
        public int fk_IdAgendaExamen { get; set; }
        public System.DateTime FechaAnulacion { get; set; }
        public string Motivo { get; set; }
        public Nullable<int> fk_IdRol_IdPersona { get; set; }
    
        public virtual AgendaExamen AgendaExamen { get; set; }
    }
}

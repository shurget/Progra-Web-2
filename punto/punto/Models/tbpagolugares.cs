//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace punto.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbpagolugares
    {
        public int idlugarpagos { get; set; }
        public Nullable<int> idpago { get; set; }
        public Nullable<int> idlugares { get; set; }
        public Nullable<System.DateTime> fecha { get; set; }
        public System.DateTime fechacreacion { get; set; }
        public System.DateTime fechamodificacion { get; set; }
        public Nullable<int> estado { get; set; }
    
        public virtual tblugares tblugares { get; set; }
        public virtual tbpago tbpago { get; set; }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UnitTestProject1
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbusuario
    {
        public tbusuario()
        {
            this.tbvotousuario = new HashSet<tbvotousuario>();
        }
    
        public long idusuario { get; set; }
        public string login { get; set; }
        public string pass { get; set; }
        public string fid { get; set; }
        public string femail { get; set; }
        public string fullname { get; set; }
        public Nullable<decimal> gid { get; set; }
        public string gemail { get; set; }
        public System.DateTime creado { get; set; }
        public System.DateTime fechacreacion { get; set; }
        public System.DateTime fechamodificacion { get; set; }
        public Nullable<int> estado { get; set; }
    
        public virtual tbpersona tbpersona { get; set; }
        public virtual ICollection<tbvotousuario> tbvotousuario { get; set; }
    }
}

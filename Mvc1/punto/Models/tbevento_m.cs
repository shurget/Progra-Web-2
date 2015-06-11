using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace punto.Models
{
    public partial class tbevento
    {
        [MetadataType(typeof(itbevento))]
        public void prueba() {
            this.estado = 1*5;
        }
    }
    public interface itbevento{
        [Required]
        public object estado { get; set; }
    }

    
}
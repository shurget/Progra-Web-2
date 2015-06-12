using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace punto.Controllers
{
    public class borraController : Controller
    {
        //
        // GET: /borra/

        public ActionResult Index()
        {
            punto.Models.puntoencuentroEntities bd = new Models.puntoencuentroEntities();
            punto.Models.tbevento n = new Models.tbevento();
            n.estado = 1;
            n.titulo = "h";
            bd.tbevento.Add(n);
            if (bd.GetValidationErrors().Count() > 0)
            { 
                
            }
            try
            {
                
                if (bd.SaveChanges() == 1)
                {
                    // correcto
                }
                else
                {
                    //errores en informacion
                }
            }
            catch { 
                
            }
            ViewBag.otro = "uno";
            return View();
        }
        
    }
}

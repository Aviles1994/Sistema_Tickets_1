using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sistema_Tickets.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Login() {
            return View();
        }

        public ActionResult Enter(string Nombre_Usuario_Login, string contraseña)
        {
            try
            {
                return Content("1");
            }
            catch (Exception ex)
            {
                return Content("Ocurrio un error"+ex.Message);
            }

        }
    }
}
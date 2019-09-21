using BlindComn.Models;
using BlindComnBusiness;
using BlindConmEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlindComn.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult EfetuarLogin(LoginModel model)
        {
            UsuarioBusiness business = new UsuarioBusiness();
            Usuario usuario = new Usuario
            {
                Racf = model.Usuario.Racf,
                Senha = model.Usuario.Senha
            };

            business.ListarUsuarios(usuario);
            return View();
        }
    }
}
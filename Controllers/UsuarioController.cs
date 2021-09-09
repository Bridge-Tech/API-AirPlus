using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace api_AirPlus.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuarioController: ControllerBase
    {
        [HttpPost] //http://localhost:5000/usuario
        public Models.TUsuario Cadastrar(Models.TUsuario usuario)
        {
            Models.apiDbAirplusContext ctx = new Models.apiDbAirplusContext();
            ctx.TUsuario.Add(usuario);
            ctx.SaveChanges();

            return usuario;
        }
    }
}
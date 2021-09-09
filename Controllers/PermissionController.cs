using System;
using System.Linq;
using System.Collections;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace api_AirPlus.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PermissionController : ControllerBase
    {
        [HttpPost] // http://localhost:5000/permission
        public Models.TPermission Cadastrar(Models.TPermission permission)
        {
            Models.apiDbAirplusContext ctx = new Models.apiDbAirplusContext();
            ctx.TPermission.Add(permission);
            ctx.SaveChanges();

            return permission;
        }

        [HttpGet] // http://localhost:5000/permission
        public List<Models.TPermission> Listar()
        {
            Models.apiDbAirplusContext ctx = new Models.apiDbAirplusContext();
            List<Models.TPermission> lstPermissions = ctx.TPermission.ToList();

            return lstPermissions;
        }

        [HttpGet("consultar")] // http://localhost:5000/permission/consultar?disponivel=true
        public List<Models.TPermission> Consultar(bool disponivel)
        {
            Models.apiDbAirplusContext ctx = new Models.apiDbAirplusContext();
            List<Models.TPermission> lstPermissions = ctx.TPermission.Where(x => x.BtDisponivel == disponivel).ToList();

            return lstPermissions;
        }
    }
}
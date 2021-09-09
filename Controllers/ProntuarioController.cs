using System;
using System.Linq;
using System.Collections;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace api_AirPlus.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProntuarioController : ControllerBase
    {
        [HttpPost] // http://localhost:5000/prontuario
        public Models.TProntuario Cadastrar(Models.TProntuario prontuario)
        {
            Models.apiDbAirplusContext ctx = new Models.apiDbAirplusContext();
            ctx.TProntuario.Add(prontuario);
            ctx.SaveChanges();

            return prontuario;
        }

        [HttpGet] // http://localhost:5000/prontuario
        public List<Models.TProntuario> Listar(string nome)
        {
            Models.apiDbAirplusContext ctx = new Models.apiDbAirplusContext();
            List<Models.TProntuario> lstProntuarios = ctx.TProntuario.ToList();

            return lstProntuarios;
        }

        [HttpGet("consultar")] // http://localhost:5000/prontuario/consultar?nome=Thales da Silva
        public List<Models.TProntuario> ConsultarPorNome(string nome)
        {
            Models.apiDbAirplusContext ctx = new Models.apiDbAirplusContext();
            List<Models.TProntuario> lstProntuarios = ctx.TProntuario.Where(x => x.NmPaciente == nome).ToList();

            return lstProntuarios;
        }
    }
}
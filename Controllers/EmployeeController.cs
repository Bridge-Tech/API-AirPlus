using System;
using System.Linq;
using System.Collections;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace api_AirPlus.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmployeeController : ControllerBase
    {
        [HttpPost] //http://localhost:5000/employee
        public Models.TEmployee Cadastrar(Models.TEmployee employee)
        {
            Models.apiDbAirplusContext ctx = new Models.apiDbAirplusContext();
            ctx.TEmployee.Add(employee);
            ctx.SaveChanges();

            return employee;
        }

        [HttpGet] //http://localhost:5000/employee
        public List<Models.TEmployee> Listar()
        {
            Models.apiDbAirplusContext ctx = new Models.apiDbAirplusContext();
            List<Models.TEmployee> lstEmployees = ctx.TEmployee.ToList();

            return lstEmployees;
        }

        [HttpGet("consultar")] //http://localhost:5000/employee/consultar?sexo=masculino
        public List<Models.TEmployee> Consultar(string sexo)
        {
            Models.apiDbAirplusContext ctx = new Models.apiDbAirplusContext();
            List<Models.TEmployee> lstEmployees = ctx.TEmployee.Where(x => x.DsSexo == sexo).ToList();

            return lstEmployees;
        }

        [HttpPut] //http://localhost:5000/employee
        public void Alterar(Models.TEmployee employee)
        {
            Models.apiDbAirplusContext ctx = new Models.apiDbAirplusContext();
            Models.TEmployee atual = ctx.TEmployee.First(x => x.IdEmployee == employee.IdEmployee);
            atual.VlIdade = employee.VlIdade;
            atual.NmCity = employee.NmCity;
            atual.NmState = employee.NmState;
            atual.NmRua = employee.NmRua;
            atual.NrPhone = employee.NrPhone;

            ctx.SaveChanges();
        }

        [HttpPut("idade")] //http://localhost:5000/employee/idade
        public void AlterarIdade(Models.TEmployee employee)
        {
            Models.apiDbAirplusContext ctx = new Models.apiDbAirplusContext();
            Models.TEmployee atual = ctx.TEmployee.First(x => x.IdEmployee == employee.IdEmployee);
            atual.VlIdade = employee.VlIdade;

            ctx.SaveChanges();
        }

        [HttpDelete] //http://localhost:5000/employee
        public void Remover(Models.TEmployee employee)
        {
            Models.apiDbAirplusContext ctx = new Models.apiDbAirplusContext();
            Models.TEmployee atual = ctx.TEmployee.First(x => x.IdEmployee == employee.IdEmployee);
            ctx.TEmployee.Remove(atual);

            ctx.SaveChanges();
        }

        [HttpDelete("sexo")] //http://localhost:5000/employee/sexo
        public void RemoverPorSexo(Models.TEmployee employee)
        {
            Models.apiDbAirplusContext ctx = new Models.apiDbAirplusContext();
            List<Models.TEmployee> lstEmployees = ctx.TEmployee.Where(x => x.DsSexo == employee.DsSexo).ToList();
            ctx.TEmployee.RemoveRange(lstEmployees);

            ctx.SaveChanges();
        }
    }
}
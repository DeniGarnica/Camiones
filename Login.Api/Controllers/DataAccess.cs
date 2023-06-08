using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using System.Data.SqlClient;
using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Login.Api.Data;

namespace Login.Api.Controllers
{
    public class DataAccess
    {
        [Route("api/[controller]")]
        [ApiController]
        public class HorariosController : ControllerBase
        {
            private readonly ApplicationDbContext context;
            public HorariosController(ApplicationDbContext context)
            {
                this.context = context;
            }

            [HttpPost]
            public async Task<ActionResult<Camion>> RegistrarCamion(Camion camion)
            {
                context.Add(camion);
                await context.SaveChangesAsync();
                return camion;
            }

            [HttpGet]
            public async Task<ActionResult<List<DateTime>>> ObtenerHora()
            {
                List<DateTime> horasSalida = await context.Camiones_ida.Select(c => c.Hora_camion).ToListAsync();
                return horasSalida;
            }
        }
    }
}

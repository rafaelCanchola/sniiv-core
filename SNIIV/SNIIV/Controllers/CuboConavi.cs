using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SNIIV.Models;
using SNIIV.Data;

namespace SNIIV.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CuboConavi : ControllerBase
    {
       
        private readonly ApplicationDbContext _context;

        public CuboConavi(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Get(int anio)
        {
            IEnumerable<cubo_conavi_bak> ccb = _context.cubo_conavi_bak.ToList().Where(p => p.anio.Equals(anio));
            var hey = ccb.GroupBy(x => new { x.id_modalidad , x.id_programa_presupuestal}).Select(x =>
            new { x.Key,
                acciones = x.Sum(t => t.acciones),
                año = x.First().anio,
                modalidad = _context.c_subprograma_sniiv.ToList().Where(t => t.id == x.First().id_modalidad).First().descripcion,
                monto= x.Sum(t => t.monto),
                programa_presupuestal= _context.c_programa_presupuestal.ToList().Where(t => t.id == x.First().id_programa_presupuestal).First().descripcion }).ToList();
            
            return Ok(hey);
        }


    }

}

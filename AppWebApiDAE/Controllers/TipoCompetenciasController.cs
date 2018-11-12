using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using AppWebApiDAE.Data;
using AppWebApiDAE.Models;
using Microsoft.EntityFrameworkCore;

namespace AppWebApiDAE.Controllers
{
    [Route("api/tipoCompetencias")]
    [ApiController]
    public class TipoCompetenciasController : ControllerBase
    {
        private DbTecContext _context;

        public TipoCompetenciasController(DbTecContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<List<Eva_cat_tipo_competencia>> GetCompetencias()
        {
            return _context.eva_Cat_Tipo_Competencia.
                Include(s => s.Competencias).
                ThenInclude(competencia => competencia.Conocimientos).
                ToList();

        }

        // GET: api/TipoCompetencias/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/TipoCompetencias
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/TipoCompetencias/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

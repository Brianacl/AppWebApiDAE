using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using AppWebApiDAE.Models;
using AppWebApiDAE.Data;
using System.Diagnostics;
using Microsoft.EntityFrameworkCore;

namespace AppWebApiDAE.Controllers
{
    [Route("api/edificios")]
    [ApiController]
    public class EdificiosController : ControllerBase
    {
        private readonly DbTecContext _context;

        public EdificiosController(DbTecContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<List<Eva_cat_edificios>> GetAllEdificios()
        {
            var edificios = _context.eva_Cat_Edificios.Include(
                s => s.Espacios).ToList();

            return edificios;
            //return _context.eva_Cat_Edificios.ToList();
        }

        [HttpGet("{id}", Name = "GetEdificio")]
        public ActionResult<Eva_cat_edificios> GetById(Int16 id)
        {
            var edificio = _context.eva_Cat_Edificios.Find(id);
            if(edificio == null)
            {
                return NotFound();
            }
            return edificio;
        }

        [HttpPost]
        public IActionResult Create(Eva_cat_edificios edificio)
        {
            _context.eva_Cat_Edificios.Add(edificio);
            _context.SaveChanges();

            return CreatedAtRoute("GetEdificio", new { id = edificio.IdEdificio}, edificio);
        }//Fin Create

        [HttpPut("{id}")]
        public IActionResult Update(Int16 id, Eva_cat_edificios edificio)
        {

            var edificioEncontrado = _context.eva_Cat_Edificios.Find(id);
            if(edificioEncontrado == null)
            {
                return NotFound();
            }

            edificioEncontrado.Alias = edificio.Alias;
            edificioEncontrado.DesEdificio = edificio.DesEdificio;
            edificioEncontrado.Prioridad = edificio.Prioridad;
            edificioEncontrado.Clave = edificio.Clave;
            edificioEncontrado.FechaUltMod = edificio.FechaUltMod;
            edificioEncontrado.FechaReg = edificio.FechaReg;
            edificioEncontrado.UsuarioReg = edificio.UsuarioReg;
            edificioEncontrado.UsuarioMod = edificio.UsuarioMod;
            edificioEncontrado.Activo = edificio.Activo;
            edificioEncontrado.Borrado = edificio.Borrado;

            _context.eva_Cat_Edificios.Update(edificioEncontrado);
            _context.SaveChanges();
            return NoContent();
        }//Fin UPDATE
       
        [HttpDelete("{id}")]
        public IActionResult Delete(Int16 id)
        {
            var edificioSeleccionado = _context.eva_Cat_Edificios.Find(id);
            if(edificioSeleccionado == null)
            {
                return NotFound();
            }

            _context.eva_Cat_Edificios.Remove(edificioSeleccionado);
            _context.SaveChanges();
            return NoContent();
        }

    }
}
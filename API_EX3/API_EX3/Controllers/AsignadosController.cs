using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using API_EX3.Models;

namespace API_EX3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AsignadosController : ControllerBase
    {
        private readonly APIContext _context;

        public AsignadosController(APIContext context)
        {
            _context = context;
        }

        // GET: api/Asignados
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Asignado>>> GetAsignados()
        {
            return await _context.Asignados.ToListAsync();
        }

        // GET: api/Asignados/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Asignado>> GetAsignado(int id)
        {
            var asignado = await _context.Asignados.FindAsync(id);

            if (asignado == null)
            {
                return NotFound();
            }

            return asignado;
        }

        // PUT: api/Asignados/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAsignado(int id, Asignado asignado)
        {
            if (id != asignado.Proyecto)
            {
                return BadRequest();
            }

            _context.Entry(asignado).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AsignadoExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Asignados
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Asignado>> PostAsignado(Asignado asignado)
        {
            _context.Asignados.Add(asignado);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAsignado", new { id = asignado.Proyecto }, asignado);
        }

        // DELETE: api/Asignados/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Asignado>> DeleteAsignado(int id)
        {
            var asignado = await _context.Asignados.FindAsync(id);
            if (asignado == null)
            {
                return NotFound();
            }

            _context.Asignados.Remove(asignado);
            await _context.SaveChangesAsync();

            return asignado;
        }

        private bool AsignadoExists(int id)
        {
            return _context.Asignados.Any(e => e.Proyecto == id);
        }
    }
}

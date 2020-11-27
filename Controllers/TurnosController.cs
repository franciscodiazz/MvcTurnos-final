using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MvcTurnos.Data;
using MvcTurnos.Models;

namespace MvcTurnos.Controllers
{
    public class TurnosController : Controller
    {
        private const bool V = false;
        private readonly MvcTurnoContext _context;

        public TurnosController(MvcTurnoContext context)
        {
            _context = context;
        }


        // GET: Turnos
        public async Task<IActionResult> Index(string searchString, Turno turno, string eliminar)

        {
            var usuarioAux = _context.Usuario.ToList();

            var auxCedula = from m in _context.Turno
                            select m;

            if (!String.IsNullOrEmpty(searchString))
            {
                auxCedula = auxCedula.Where(s => s.UsuarioId == searchString);
            }

            if (eliminar != "1")
            {
                ViewBag.action = 0;
                return View(await auxCedula.ToListAsync());//retornar true

            }
            else
            {
                ViewBag.action = 1;
                return View(await auxCedula.ToListAsync());
            }
        }

        // GET: Turnos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var turno = await _context.Turno
                .FirstOrDefaultAsync(m => m.Id == id);
            if (turno == null)
            {
                return NotFound();
            }

            return View(turno);
        }

        // GET: Turnos/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Turnos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<object> Create([Bind("Id,Asunto,Hora,Fecha,UsuarioId")] Turno turno)
        {
            if (ModelState.IsValid)
            {
                var usuarioAux = _context.Usuario.ToList();
                bool existe = false;
                foreach (Usuario usuario in usuarioAux)
                {
                    if (usuario.Cedula == turno.UsuarioId)
                    {
                        existe = true;
                        break;
                    }


                }

                if (existe)
                {
                    var turnos = _context.Turno.ToList();
                    var existeTurno = false;

                    foreach (Turno turnoAux in turnos)
                    {
                        if (turnoAux.Fecha == turno.Fecha && turnoAux.Hora == turno.Hora)
                        {
                            existeTurno = true;
                            break;
                        }
                    }

                    if (!existeTurno)
                    {
                        _context.Add(turno);
                        await _context.SaveChangesAsync();
                        ViewData["Message"] = "Turno registrado";
                        return RedirectToAction("Index", "Home");
                    }
                    else
                    {
                        ModelState.AddModelError("", "Ya existe el turno en la hora ");
                    }
                }
                else
                {
                    ModelState.AddModelError("", "La cedula no existe, registra tus datos antes de pedir un turno.");
                }
            }
            return View();
        }

        // GET: Turnos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var turno = await _context.Turno.FindAsync(id);
            if (turno == null)
            {
                return NotFound();
            }
            return View(turno);
        }

        // POST: Turnos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Asunto,Hora,Fecha,UsuarioId")] Turno turno)
        {
            if (id != turno.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(turno);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TurnoExists(turno.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Create", "Turnos");

            }
            return View(turno);
        }

        // GET: Turnos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var turno = await _context.Turno
                .FirstOrDefaultAsync(m => m.Id == id);
            if (turno == null)
            {
                return NotFound();
            }

            return View(turno);
        }

        // POST: Turnos/Delete/5
        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {

            var turno = await _context.Turno.FindAsync(id);
            _context.Turno.Remove(turno);
            await _context.SaveChangesAsync();

            return Ok();

        }

        private bool TurnoExists(int id)
        {
            return _context.Turno.Any(e => e.Id == id);
        }
    }
}

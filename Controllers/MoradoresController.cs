using Microsoft.AspNetCore.Mvc;
using Arpagen.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Authentication;
using System.Security.Claims;


namespace Arpagen.Controllers
{
    //[Authorize (Roles ="Admin")]
    public class MoradoresController : Controller
     {

        private readonly AppDbContext _context;

        public MoradoresController(AppDbContext context)
        {
            _context = context;

        }



        //Index
        public async Task<IActionResult> Index()
        {
            var dados = await _context.Moradores.ToListAsync();
            
            return View(dados);
        }

        public IActionResult Create() 
        {
            return View();
        }

        [HttpPost]

        public async Task<IActionResult> Create(Morador morador) 
        {
            if(ModelState.IsValid) 
            {
                _context.Moradores.Add(morador);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");

            }
            return View();
        
        }

        //Edit

        public async Task<IActionResult> Edit(int? id)
        {
            if(id == null)
                return NotFound();

            var dados = await _context.Moradores.FindAsync(id);

            if (dados == null)
                return NotFound();
            
            return View(dados);

        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, Morador morador)
        {
            if (id != morador.Id)
                return NotFound();

            if (ModelState.IsValid)
            {
                _context.Moradores.Update(morador);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View();
        }

        // Details
        
        public async Task<IActionResult> Details(int? id)
        {
            if(id == null)
                return NotFound();


            var dados = await _context.Moradores.FindAsync(id);
            
            if (dados == null)

                return NotFound() ;
            
            return View(dados);

        }

        //Delete

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
                return NotFound();

            var dados = await _context.Moradores.FindAsync(id);

            if (dados == null)
                return NotFound();

            return View(dados);
        }

        [HttpPost, ActionName("Delete")]

        public async Task<IActionResult> DeleteConfirmed(int? id)
        {
            if (id == null)
                return NotFound();

            var dados = await _context.Moradores.FindAsync(id);

            if (dados == null)
                return NotFound() ;

            _context.Moradores.Remove(dados);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }
    }

}

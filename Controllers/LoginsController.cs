using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Arpagen.Models;
using Microsoft.AspNetCore.Authentication;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;

namespace Arpagen.Controllers
{
    public class LoginsController : Controller
    {
        private readonly AppDbContext _context;

        public LoginsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Logins
        public async Task<IActionResult> Index()
        {
              return View(await _context.Logins.ToListAsync());
        }

      
       
        public IActionResult AccessDenied()
        {
            return View();

        }
      
        public IActionResult Logar()
        {
            return View();  
        }

        [HttpPost]
     
        public async Task<IActionResult> Logar(Login Login)
        {
            var dados = await _context.Logins
                .FindAsync(Login.Id);

            if(dados == null)
            {
                ViewBag.Message = "Usuário e/ ou Senha invalidas!";
                return View();
            }

            bool senhaok = BCrypt.Net.BCrypt.Verify(Login.Senha,dados.Senha);

            if (senhaok)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, dados.Nome),
                    new Claim(ClaimTypes.NameIdentifier, dados.Id.ToString()),
                    new Claim(ClaimTypes.Role,dados.Perfil.ToString())
                };

                var loginIdentity = new ClaimsIdentity(claims, "Login");
                ClaimsPrincipal principal = new ClaimsPrincipal (loginIdentity);

                var props = new AuthenticationProperties
                {
                    AllowRefresh = true,
                    ExpiresUtc = DateTime.UtcNow.ToLocalTime().AddHours(1),
                    IsPersistent = true,
                };
                await HttpContext.SignInAsync(principal, props);

                return Redirect("/");
            }
            else
            {
                ViewBag.Message = "Usuário e/ou Inválidos!";
            }

            return View();
        }

        
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            return RedirectToAction("Login", "Logar");
        }
       
    
        // GET: Logins/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Logins == null)
            {
                return NotFound();
            }

            var login = await _context.Logins
                .FirstOrDefaultAsync(m => m.Id == id);
            if (login == null)
            {
                return NotFound();
            }

            return View(login);
        }

        // GET: Logins/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Logins/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nome,Senha,Perfil")] Login Login)
        {
            if (ModelState.IsValid)
            {
                Login.Senha = BCrypt.Net.BCrypt.HashPassword(Login.Senha);
                _context.Add(Login);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(Login);
        }

        // GET: Logins/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Logins == null)
            {
                return NotFound();
            }

            var login = await _context.Logins.FindAsync(id);
            if (login == null)
            {
                return NotFound();
            }
            return View(login);
        }

        // POST: Logins/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nome,Senha,Perfil")] Login login)
        {
            if (id != login.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    login.Senha = BCrypt.Net.BCrypt.HashPassword(login.Senha);
                    _context.Update(login);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LoginExists(login.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(login);
        }

        // GET: Logins/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Logins == null)
            {
                return NotFound();
            }

            var login = await _context.Logins
                .FirstOrDefaultAsync(m => m.Id == id);
            if (login == null)
            {
                return NotFound();
            }

            return View(login);
        }

        // POST: Logins/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Logins == null)
            {
                return Problem("Entity set 'AppDbContext.Logins'  is null.");
            }
            var login = await _context.Logins.FindAsync(id);
            if (login != null)
            {
                _context.Logins.Remove(login);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LoginExists(int id)
        {
          return _context.Logins.Any(e => e.Id == id);
        }
    }
}

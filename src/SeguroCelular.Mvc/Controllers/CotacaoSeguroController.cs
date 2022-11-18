using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SeguroCelular.Mvc.Config;
using SeguroCelular.Mvc.Models;
using SeguroCelular.Mvc.Models.Data;
using SeguroCelular.Mvc.Models.Enums;

namespace SeguroCelular.Mvc.Controllers
{
    public class CotacaoSeguroController : Controller
    {
        private readonly AppDbContext _context;

        public CotacaoSeguroController(AppDbContext context)
        {
            _context = context;
        }

        // GET: CotacaoSeguro
        public async Task<IActionResult> Index()
        {
            var appDbContext = _context.Cotacoes.Include(c => c.User);
            return View(await appDbContext.ToListAsync());
        }

        // GET: CotacaoSeguro/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cotacaoSeguro = await _context.Cotacoes
                .Include(c => c.User)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (cotacaoSeguro == null)
            {
                return NotFound();
            }

            return View(cotacaoSeguro);
        }

        // GET: CotacaoSeguro/Create
        public IActionResult Create()
        {
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Email");
            return View();
        }

        // POST: CotacaoSeguro/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,ModeloCelular,Valor,ValorCotacao,UserId")] CotacaoSeguro cotacaoSeguro)
        {
            var email = User.GetUserEmail();
            var usuario = await _context.Users
                .FirstOrDefaultAsync(m => m.Email == email);

            if (ModelState.IsValid)
            {
                cotacaoSeguro.UserId = usuario.Id;              
                cotacaoSeguro.ValorCotacao = GerarValorCotacao(cotacaoSeguro.Valor);
                _context.Add(cotacaoSeguro);               
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Email", cotacaoSeguro.UserId);
            return View(cotacaoSeguro);
        }

        // GET: CotacaoSeguro/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cotacaoSeguro = await _context.Cotacoes.FindAsync(id);
            if (cotacaoSeguro == null)
            {
                return NotFound();
            }
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Email", cotacaoSeguro.UserId);
            return View(cotacaoSeguro);
        }

        // POST: CotacaoSeguro/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ModeloCelular,Valor,ValorCotacao,UserId")] CotacaoSeguro cotacaoSeguro)
        {
            if (id != cotacaoSeguro.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cotacaoSeguro);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CotacaoSeguroExists(cotacaoSeguro.Id))
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
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Email", cotacaoSeguro.UserId);
            return View(cotacaoSeguro);
        }

        // GET: CotacaoSeguro/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cotacaoSeguro = await _context.Cotacoes
                .Include(c => c.User)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (cotacaoSeguro == null)
            {
                return NotFound();
            }

            return View(cotacaoSeguro);
        }

        // POST: CotacaoSeguro/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var cotacaoSeguro = await _context.Cotacoes.FindAsync(id);
            _context.Cotacoes.Remove(cotacaoSeguro);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CotacaoSeguroExists(int id)
        {
            return _context.Cotacoes.Any(e => e.Id == id);
        }

        private static int GerarValorCotacao(EValoresCelular valor)
        {
            int cotacao = 0;
            switch (valor)
            {
                case EValoresCelular.Ate500:
                    cotacao = 10;
                    break;
                case EValoresCelular.De501a1000:
                    cotacao = 20;
                    break;
                case EValoresCelular.De1001a2000:
                    cotacao = 30;
                    break;
                case EValoresCelular.De2001a3000:
                    cotacao = 40;
                    break;
                case EValoresCelular.De3001a4000:
                    cotacao = 50;
                    break;
                case EValoresCelular.De4001a5000:
                    cotacao = 60;
                    break;
                case EValoresCelular.Acima5000:
                    cotacao = 100;
                    break;
                default:
                    cotacao = 0;
                    break;
            }
            return cotacao;
        }
    }
}

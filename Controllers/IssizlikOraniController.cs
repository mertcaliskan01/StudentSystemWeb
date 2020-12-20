using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using StudentSystemWeb.Data;
using StudentSystemWeb.Models;

namespace StudentSystemWeb.Controllers
{
    public class IssizlikOraniController : Controller
    {
        private readonly ApplicationDbContext _context;

        public IssizlikOraniController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: IssizlikOrani
        public async Task<IActionResult> Index()
        {
            return View(await _context.IssizlikOraniTablo1.ToListAsync());
        }

        // GET: IssizlikOrani/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var issizlikOrani = await _context.IssizlikOraniTablo1
                .FirstOrDefaultAsync(m => m.Id == id);
            if (issizlikOrani == null)
            {
                return NotFound();
            }

            return View(issizlikOrani);
        }

        // GET: IssizlikOrani/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: IssizlikOrani/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Toplam1,Toplam2,Erkek1,Erkek2,Kadın1,Kadın2,ToplamOran1,ToplamOran2,ErkekOran1,ErkekOran2,KadınOran1,KadınOran2,Aciklama")] IssizlikOrani issizlikOrani)
        {
            if (ModelState.IsValid)
            {
                _context.Add(issizlikOrani);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(issizlikOrani);
        }

        // GET: IssizlikOrani/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var issizlikOrani = await _context.IssizlikOraniTablo1.FindAsync(id);
            if (issizlikOrani == null)
            {
                return NotFound();
            }
            return View(issizlikOrani);
        }

        // POST: IssizlikOrani/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Toplam1,Toplam2,Erkek1,Erkek2,Kadın1,Kadın2,ToplamOran1,ToplamOran2,ErkekOran1,ErkekOran2,KadınOran1,KadınOran2,Aciklama")] IssizlikOrani issizlikOrani)
        {
            if (id != issizlikOrani.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(issizlikOrani);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!IssizlikOraniExists(issizlikOrani.Id))
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
            return View(issizlikOrani);
        }

        // GET: IssizlikOrani/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var issizlikOrani = await _context.IssizlikOraniTablo1
                .FirstOrDefaultAsync(m => m.Id == id);
            if (issizlikOrani == null)
            {
                return NotFound();
            }

            return View(issizlikOrani);
        }

        // POST: IssizlikOrani/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var issizlikOrani = await _context.IssizlikOraniTablo1.FindAsync(id);
            _context.IssizlikOraniTablo1.Remove(issizlikOrani);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool IssizlikOraniExists(int id)
        {
            return _context.IssizlikOraniTablo1.Any(e => e.Id == id);
        }
    }
}

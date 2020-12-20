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
            return View(await _context.IssizlikOraniTablo1.ToListAsync());

            //return View(issizlikOrani);
        }
    }
}

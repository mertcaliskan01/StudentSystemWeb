using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Protocols;
using StudentSystemWeb.Data;
using StudentSystemWeb.Models;

namespace StudentSystemWeb.Controllers
{
    public class TitlesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TitlesController(ApplicationDbContext context)
        {
            _context = context;
        }


        // GET: Titles
        public async Task<IActionResult> Index()
        {
            var titles = _context.Titles.Where(b => b.IsAnaBaslik == true).ToListAsync();
            return View(await titles);
        }

        // GET: Titles/Details/5
        public async Task<IActionResult> Details(String url)
        {
            return Redirect("http://localhost:64256/IssizlikOrani/" + url);
        }

        public async Task<IActionResult> SubTitles(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var title = _context.Titles.Where(b => b.AnaBaslikId == id).ToListAsync();

            if (title == null)
            {
                return NotFound();
            }

            return View(await title);
        }        


        public async Task<IActionResult> Download(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }else if (id == 13)
            {
                WebClient webClient = new WebClient();
                webClient.DownloadFile("http://localhost:64256/Dosyalar/IssizlikOrani.xls", @"C:\Users\MERT\Desktop\tuikProject\StudentSystemWeb\Dosyalar\IssizlikOrani.xls");
            }
            else
            {
                Console.WriteLine("Id null error");
            }

            var titles = _context.Titles.Where(b => b.IsAnaBaslik == true).ToListAsync();
            return View(await titles);
        }



    }
}

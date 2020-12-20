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

        public async Task<IActionResult> Details(int? id, string searchString)
        {
            //ViewData["Acıklama"]     =   sortOrder != null ? "Acıklama" : "";
            //ViewData["Toplam2019"] = sortOrder != null ? "Toplam2019" : "";
            //ViewData["Toplam2020"] = sortOrder != null ? "Toplam2020" : "";
            //ViewData["Erkek2019"] = sortOrder != null ? "Erkek2019" : "";
            //ViewData["Erkek2020"] = sortOrder != null ? "Erkek2020" : "";
            //ViewData["Kadın2019"] = sortOrder != null ? "Kadın2019" : "";
            //ViewData["Kadın2020"] = sortOrder != null ? "Kadın2020" : "";
            //ViewData["ToplamOran2019"] = sortOrder != null ? "ToplamOran2019" : "";
            //ViewData["ToplamOran2020"] = sortOrder != null ? "ToplamOran2020" : "";
            //ViewData["ErkekOran2019"] = sortOrder != null ? "ErkekOran2019" : "";
            //ViewData["ErkekOran2020"] = sortOrder != null ? "ErkekOran2020" : "";
            //ViewData["KadınOran2019"] = sortOrder != null ? "KadınOran2019" : "";
            //ViewData["KadınOran2020"] = sortOrder != null ? "KadınOran2020" : "";
            ViewData["CurrentFilter"] = searchString;

            var issizlikOrani = from s in _context.IssizlikOraniTablo1 select s;
            if (!String.IsNullOrEmpty(searchString))
            {
                issizlikOrani = issizlikOrani.Where(s => s.Aciklama.Contains(searchString)
                                           || s.Toplam1.ToString().Contains(searchString)
                                           || s.Toplam2.ToString().Contains(searchString)
                                           || s.Erkek1.ToString().Contains(searchString)
                                           || s.Erkek2.ToString().Contains(searchString)
                                           || s.Kadın1.ToString().Contains(searchString)
                                           || s.Kadın2.ToString().Contains(searchString)
                                           || s.ToplamOran1.ToString().Contains(searchString)
                                           || s.ToplamOran2.ToString().Contains(searchString)
                                           || s.ErkekOran1.ToString().Contains(searchString)
                                           || s.ErkekOran2.ToString().Contains(searchString)
                                           || s.KadınOran1.ToString().Contains(searchString)
                                           || s.KadınOran2.ToString().Contains(searchString));
            }
            //switch (sortOrder)
            //{
            //    case "Açıklama":
            //        issizlikOrani = issizlikOrani.OrderByDescending(s => s.Aciklama);
            //        break;
            //    case "Toplam2019":
            //        issizlikOrani = issizlikOrani.OrderBy(s => s.Toplam1);
            //        break;
            //    case "Toplam2020":
            //        issizlikOrani = issizlikOrani.OrderByDescending(s => s.Toplam2);
            //        break;
            //    case "Erkek2019":
            //        issizlikOrani = issizlikOrani.OrderByDescending(s => s.Erkek1);
            //        break;
            //    case "Erkek2020":
            //        issizlikOrani = issizlikOrani.OrderByDescending(s => s.Erkek2);
            //        break;
            //    case "Kadın2019":
            //        issizlikOrani = issizlikOrani.OrderByDescending(s => s.Kadın1);
            //        break;
            //    case "Kadın2020":
            //        issizlikOrani = issizlikOrani.OrderByDescending(s => s.Kadın2);
            //        break;
            //    case "ToplamOran2019":
            //        issizlikOrani = issizlikOrani.OrderByDescending(s => s.ToplamOran1);
            //        break;
            //    case "ToplamOran2020":
            //        issizlikOrani = issizlikOrani.OrderByDescending(s => s.ToplamOran2);
            //        break;
            //    case "ErkekOran2019":
            //        issizlikOrani = issizlikOrani.OrderByDescending(s => s.ErkekOran1);
            //        break;
            //    case "ErkekOran2020":
            //        issizlikOrani = issizlikOrani.OrderByDescending(s => s.ErkekOran2);
            //        break;
            //    case "KadınOran2019":
            //        issizlikOrani = issizlikOrani.OrderByDescending(s => s.KadınOran1);
            //        break;
            //    case "KadınOran2020":
            //        issizlikOrani = issizlikOrani.OrderByDescending(s => s.KadınOran2);
            //        break;
            //    default:
            //        issizlikOrani = issizlikOrani.OrderBy(s => s.Aciklama);
            //        break;
            //}
            return View(await issizlikOrani.AsNoTracking().ToListAsync());
        }


        // GET: IssizlikOrani/Details/5
        //public async Task<IActionResult> Details(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var issizlikOrani = await _context.IssizlikOraniTablo1
        //        .FirstOrDefaultAsync(m => m.Id == id);
        //    if (issizlikOrani == null)
        //    {
        //        return NotFound();
        //    }
        //    return View(await _context.IssizlikOraniTablo1.ToListAsync());

        //    //return View(issizlikOrani);
        //}
    }
}

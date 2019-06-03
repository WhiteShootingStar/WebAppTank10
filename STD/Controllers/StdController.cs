using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using STD.Models;

namespace STD.Controllers
{
    public class StdController : Controller
    {
        private readonly StdDbContext dbContext;
        public StdController(StdDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public IActionResult Index()
        {
            return View(dbContext.Stds.ToList());
        }
        //public IActionResult Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var movie = dbContext.Stds
        //         .FirstOrDefault(m => m.Id == id);
        //    if (movie == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(movie);
        //}
        // [HttpPost,ActionName("Index")]
        public IActionResult Delete(int? id)
        {
            var student = dbContext.Stds.Find(id);
            dbContext.Stds.Remove(student);
            dbContext.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        // [HttpPost]
        public IActionResult Add()
        {
            ViewBag.list = dbContext.Stds.Select(p => p.Studies).Distinct().ToList();
            return View();
        }
        [HttpPost]
        public IActionResult AddToDb(Std std)
        {
            if (std.FirstName != null && std.LastName != null && std.Studies != null)
            {
                dbContext.Stds.Add(std);
                dbContext.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            else return RedirectToAction(nameof(Add));

        }
    }
}
using BugTrackerApp.Data.Repository;
using BugTrackerApp.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTrackerApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly IBugRepo _repo;

        public HomeController(IBugRepo bugRepo)
        {
            _repo = bugRepo;
        }

        public IActionResult Index()
        {
            var bug = _repo.GetAllBugs();
            return View(bug);
        }

        public IActionResult Details(int id)
        {
            var bug = _repo.GetBug(id);
            return View(bug);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Bug bug)
        {
            if(ModelState.IsValid)
            {
                _repo.Add(bug);
                _repo.Save();
                return RedirectToAction("Index");
            }
            return View();
        }
        [HttpGet]
        public IActionResult Update(Bug update)
        {
            if(ModelState.IsValid)
            {
                _repo.Update(update);
                _repo.Save();
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return View();
            }
        }
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var bug = _repo.Delete(id);
            return View(bug);
        }
    }
}

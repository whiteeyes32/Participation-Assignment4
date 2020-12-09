using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Participation4.Models;

namespace Participation4.Controllers
{
    public class ClubController : Controller
    {
        ClubRepository clubRepo = new ClubRepository();
        public ActionResult Index()
        {
            return View("Index", clubRepo.getAllClubs());
        }

        // GET: ClubController/Details/5
        public ActionResult Details(int id)
        {
            return View("Details", clubRepo.getOneClub(id));
        }

        // GET: ClubController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ClubController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ClubController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ClubController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ClubController/Delete/5
        public ActionResult Delete(int id)
        {
            return View("Delete", clubRepo.getOneClub(id));
        }
        public ActionResult ConfirmDelete(int id)
        {
            clubRepo.deleteCLub(id);
            return View("Index", clubRepo.getAllClubs());
        }

        // POST: ClubController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}

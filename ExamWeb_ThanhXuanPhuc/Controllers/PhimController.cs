using ExamWeb_ThanhXuanPhuc.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamWeb_ThanhXuanPhuc.Controllers
{
    public class PhimController : Controller
    {
        private readonly AppDbContext _db;
        public PhimController(AppDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            var phimList = _db.Phims.ToList();
            return View(phimList);
        }
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(Phim phim)
        {
            if (ModelState.IsValid)
            {
                _db.Phims.Add(phim);
                _db.SaveChanges();

                TempData["success"] = "Inserted success";
                return RedirectToAction("Index");
            }
            return View(phim);
        }
        public IActionResult Update(int id)
        {
            var phim = _db.Phims.Find(id);
            if (phim == null)
            {
                return NotFound();
            }
            return View(phim);
        }
        [HttpPost]
        public IActionResult Update(Phim phim)
        {
            if (ModelState.IsValid)
            {
                var existsPhim = _db.Phims.Find(phim.Id);
                if (existsPhim == null)
                {
                    return NotFound();
                }
                existsPhim.TuaDe = phim.TuaDe;
                existsPhim.DienVien = phim.DienVien;
                existsPhim.TrongNuoc = phim.TrongNuoc;
                existsPhim.GiaVe = phim.GiaVe;
                existsPhim.ThoiLuong = phim.ThoiLuong;
                
                _db.SaveChanges();

                TempData["success"] = "Updated success";
                return RedirectToAction("Index");
            }
            return View(phim);
        }
        public IActionResult Delete(int id)
        {
            var phim = _db.Phims.Find(id);
            if (phim == null)
            {
                return NotFound();
            }
            return View(phim);
        }
        [HttpPost]
        public IActionResult DeleteConfirmed(int id)
        {
            if (ModelState.IsValid)
            {
                var existsPhim = _db.Phims.Find(id);
                if (existsPhim == null)
                {
                    return NotFound();
                }
                _db.Phims.Remove(existsPhim);
                _db.SaveChanges();

                TempData["success"] = "Deleted success";
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}

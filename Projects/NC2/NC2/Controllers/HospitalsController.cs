using System;
using System.Linq;
using CRUD.Data;
using CRUD.Models;
using Microsoft.AspNetCore.Mvc;

namespace CRUD.Controllers
{
    public class HospitalsController : Controller
    {
        private readonly CRUDContext _context;
        public HospitalsController(CRUDContext Context)
        {
            this._context = Context;
        }
        // GET: /<Controller>/
        public IActionResult Index()
        {
            var HospitalsList = _context.Hospitals.ToList();
            return View(HospitalsList);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateHospital(Hospitals Hospitals)
        {
            _context.Hospitals.Add(Hospitals);
            _context.SaveChanges();
            return RedirectToAction("index", "Hospitals");
        }

        public ActionResult Update(int id)
        {
            return View(_context.Hospitals.Where(s => s.HospitalId == id).First());
        }
        [HttpPost]
        public ActionResult UpdateHospital(Hospitals Hospital)
        {
            Hospitals D = _context.Hospitals.Where
                          (s => s.HospitalId == Hospital.HospitalId).First();
            D.HospitalName = Hospital.HospitalName;
            D.DecisionMaker = Hospital.DecisionMaker;
            D.Email = Hospital.Email;
            D.Phone = Hospital.Phone;
            D.Password = Hospital.Password;
            D.Services = Hospital.Services;
            _context.SaveChanges();
            return RedirectToAction("index", "Hospitals");
        }
    }
}

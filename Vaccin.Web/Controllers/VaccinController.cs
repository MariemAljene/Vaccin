
using ApplicationCore.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Vaccin.Web.Controllers
{
    public class VaccinController : Controller
    {
        // GET: VaccinController
        IVaccinService vaccinService; 
        ICentreService centreService;
        public VaccinController(ICentreService centreService ,IVaccinService vaccinService)
        {
            this.centreService = centreService;
            this.vaccinService = vaccinService;

        }
        public ActionResult Index()
        { foreach( var item in vaccinService.GetAll())
            {
                item.Validite=vaccinService.ValiditeVaccin(item);
            }
            return View(vaccinService.GetAll().OrderByDescending(v=>v.DateValidite));
        }

        // GET: VaccinController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: VaccinController/Create
        public ActionResult Create()
        {
            ViewBag.CentreVaccination = new SelectList(centreService.GetAll(), "CentreVaccinationId", "ResponsableCentre");
            return View();
        }

        // POST: VaccinController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ApplicationCore.Domain.Vaccin collection)
        {
            try
            {
                vaccinService.Add(collection);
                vaccinService.Commit();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: VaccinController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: VaccinController/Edit/5
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

        // GET: VaccinController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: VaccinController/Delete/5
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

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TpDojo.Business;
using TpDojo.Dal.Entities;
using TpDojo.Web.Models;

namespace TpDojo.Web.Controllers
{
    public class ArtMartialController : Controller
    {
        private readonly ArtMartialService artMartialService;

        public ArtMartialController(ArtMartialService artMartialService)
        {
            this.artMartialService = artMartialService;
        }

        // GET: ArtMartialController
        public async Task<IActionResult> Index()
        {
            var artMartiauxDto = await this.artMartialService.GetArtMartiauxAsync();
            var artMartiauxViewModel = ArtMartialViewModel.FromArtMartiaux(artMartiauxDto);
            return this.View(artMartiauxViewModel);
        }

        // GET: ArtMartialController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ArtMartialController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ArtMartialController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ArtMartialViewModel artMartial)
        {
            if (this.ModelState.IsValid)
            {
                await this.artMartialService.AddArtMartialAsync(ArtMartialViewModel.ToArtMartialDto(artMartial));
                return this.RedirectToAction(nameof(Index));
            }
            return this.View(artMartial);
        }

        // GET: ArtMartialController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ArtMartialController/Edit/5
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

        // GET: ArtMartialController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ArtMartialController/Delete/5
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

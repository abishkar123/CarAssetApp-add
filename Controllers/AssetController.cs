using CarAssetApp.Models;
using CarAssetApp.Services;
using Microsoft.AspNetCore.Mvc;

namespace CarAssetApp.Controllers
{
    public class AssetController : Controller
    {
        private readonly AssetService _assetService;

        public AssetController(AssetService assetService)
        {
            _assetService = assetService;
        }

        public IActionResult Index()
        {
            var assets = _assetService.Get();
            return View(assets);
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Asset asset)
        {
            if (!ModelState.IsValid)
            {
                return View(asset);
            }
            _assetService.Create(asset);
            return RedirectToAction(nameof(Index));
        }
    }
}

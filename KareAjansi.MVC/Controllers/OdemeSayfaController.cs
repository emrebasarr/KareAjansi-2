using Microsoft.AspNetCore.Mvc;

namespace KareAjansi.MVC.Controllers
{
    public class OdemeSayfaController : Controller
    {
        public IActionResult OdemeSayfaListe()
        {
            return View();
        }

        public IActionResult OdemeSayfaEkle()
        {
            return View();
        }
    }
}
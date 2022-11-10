using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
    public class ZdravoSveteController : Controller
    {
        // 
        // GET: /ZdravoSvete/
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Pozdrav(string ime, int brojPojava = 1)
        {
            ViewData["Poruka"] = "Zdravo " + ime;
            ViewData["BrojPojava"] = brojPojava;

            return View();
        }

        // 
        // GET: /ZdravoSvete/DobroDosli/ 
        public string Dobrodosli()
        {
            return "Ovo je metod za akciju dobrodošlice (DobroDosli)...";
        }

        // 
        // GET: /ZdravoSvete/DobroDosli2/ 
        // Requires using System.Text.Encodings.Web;
        public string Dobrodosli2(string ime, int brojPokusaja = 1)
        {
            return HtmlEncoder.Default.Encode($"Doborodosli, {ime}, broj pokusaja je: {brojPokusaja}");
        }

        // 
        // GET: /ZdravoSvete/DobroDosli3/ 
        // Requires using System.Text.Encodings.Web;
        public string Dobrodosli3(string ime, int ID = 1)
        {
            return HtmlEncoder.Default.Encode($"Dobrodosli {ime}, broj pokusaja je: {ID}");
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
    public class ZdravoSveteController : Controller
    {
        // 
        // GET: /ZdravoSvete/
        public string Index()
        {
            return "Ovo je metod za podrazumevanu akciju...";
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
            return HtmlEncoder.Default.Encode($"Hello {ime}, broj pokusaja je: {brojPokusaja}");
        }

    }
}

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
    }
}

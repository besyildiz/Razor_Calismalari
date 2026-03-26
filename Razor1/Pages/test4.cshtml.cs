using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Security.Cryptography;

namespace Razor1.Pages
{
    public class test4Model : PageModel
    {        
        /*
        bool mantik;

        mantik=false;
        mantik=true;
        mantik=false;
 
        const bool mantik2=false;


        */   
        public bool mantik { get; set; }
        public bool GirisYaptiMi { get; set; }
     // nedne public? çünkü html sayfasındanki Model'den erişebileyim
        public void OnGet()
        {
            GirisYaptiMi = true; // false yapıp denet

        }
    }
}

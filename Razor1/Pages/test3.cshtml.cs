using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Razor1.Pages
{
    public class test3Model : PageModel
    {
        [BindProperty]
        public string Isim2 { get; set; }
        public string Sonuc { get; set; }


        public void OnPost()
        {
            Sonuc = "Merhaba " + Isim2;
        }
    }
}

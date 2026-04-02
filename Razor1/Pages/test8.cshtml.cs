using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Razor1.Pages.Models;

namespace Razor1.Pages
{
    public class test8Model : PageModel
    {

        public string isim { get; set; }
        public Student Ogrenci { get; set; }

        public void OnGet()
        {
            Ogrenci = new Student 
            { Ad = "İsmail",
                Ortalama = 99, 
                Yas = 18 , uyrugu="Türk"
            };
        }
    }
}

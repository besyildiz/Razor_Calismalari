using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Razor1.Pages.Models;

namespace Razor1.Pages
{
    public class test9Model : PageModel
    {

        public Student Ogrenci { get; set; }

        public void OnGet()
        {
            Ogrenci = new Student
            {
                Ad = "Abdulhalim",
                Soyad = "Muhammed Ali"
            };

        }
    }
}

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Razor1.Pages
{
    public class test1Model : PageModel
    {
        public string Mesaj { get; set; }
      
        // string Mesaj;
        public void OnGet()
        {
            Mesaj = "Merhaba, şu an server zamanı: " + DateTime.Now.ToString();
        }

    }
}

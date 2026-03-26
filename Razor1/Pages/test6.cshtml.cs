using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Razor1.Pages
{
    public class test6Model : PageModel
    {
        public List<string> Isimler { get; set; }
        public void OnGet()
        {
             
           Isimler = new List<string> {  };
        
        
        }
    }
}

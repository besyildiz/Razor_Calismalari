using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Razor1.Pages
{

    /*
     * 
     * 
     * Razor Pages'te form inputları için genelde OnPost parametreli de yazılabilir:

public void OnPost(int sayi1, int sayi2)
{
    toplam = sayi1 + sayi2;
}

Bu durumda [BindProperty] kullanmana gerek kalmaz.

    */



    public class razor3_EtkinlikModel : PageModel
    {
        [BindProperty]
        public int? sayi1 { get; set; }
        [BindProperty]
        public  int? sayi2 { get; set; }
        public int? toplam { get; set; }
        public void OnPost()
        {
            toplam = sayi1 + sayi2;
        }
    }
}

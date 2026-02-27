using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Razor1.Pages
{
    public class razor3_Etkinlik2Model : PageModel
    {
        public string mesaj { get; set; }
        public void OnPost(int yas)
        {
            if (yas >= 18)
            {
                mesaj = "Reşitsin";
            }
            else
            {
                mesaj = "Reşit değilsin";
            }
        }
    }
}

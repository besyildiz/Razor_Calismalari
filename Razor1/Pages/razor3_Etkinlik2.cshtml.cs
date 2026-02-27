using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Razor1.Pages
{
    public class razor3_Etkinlik2Model : PageModel
    {
        string mesaj = null;
        public void OnPost(int yas)
        {
            if (yas>=18)
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

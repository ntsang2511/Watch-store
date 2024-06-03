using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Watch_Store.Pages.Cart
{
    public class IndexModel : PageModel
    {
        public void OnGet(string Image, string Price )
        {
            ViewData["Image"] = Image;
            ViewData["Price"] = Price;
        }
    }
}

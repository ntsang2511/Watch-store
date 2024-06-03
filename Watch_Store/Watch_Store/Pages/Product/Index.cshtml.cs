using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Watch_Store.Pages.Product
{
    public class IndexModel : PageModel
    {
        public IActionResult OnGet(string imagePath,string description, string price)
        {
            ViewData["ImagePath"] =  imagePath;
            ViewData["Description"] =  description;
            ViewData["Price"] =  price;
            return Page();
        }
    }
}

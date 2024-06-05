using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Watch_Store.Data;
using Watch_Store.Models;

namespace Watch_Store.Pages.Admin
{
    public class DetailsModel : PageModel
    {
        private readonly Watch_Store.Data.Watch_StoreContext _context;

        public DetailsModel(Watch_Store.Data.Watch_StoreContext context)
        {
            _context = context;
        }

        public Watch_Store.Models.Product Product { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Product.FirstOrDefaultAsync(m => m.ProductId == id);
            if (product == null)
            {
                return NotFound();
            }
            else
            {
                Product = product;
            }
            return Page();
        }
    }
}

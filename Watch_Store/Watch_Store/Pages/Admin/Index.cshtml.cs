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
    public class IndexModel : PageModel
    {
        private readonly Watch_Store.Data.Watch_StoreContext _context;

        public IndexModel(Watch_Store.Data.Watch_StoreContext context)
        {
            _context = context;
        }

        public IList<Watch_Store.Models.Product> Product { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Product = await _context.Product.ToListAsync();
        }
    }
}

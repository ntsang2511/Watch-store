using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
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
        [BindProperty(SupportsGet = true)]
        public string? SearchString { get; set; }

        public SelectList? Categories { get; set; }

        [BindProperty(SupportsGet = true)]
        public string? ProductCategories { get; set; }
        public async Task OnGetAsync()
        {
            //Product = await _context.Product.ToListAsync();
            //var movies = from m in _context.Product
            //             select m;
            //if (!string.IsNullOrEmpty(SearchString))
            //{
            //    movies = movies.Where(s => s.Name.Contains(SearchString));
            //}

            //Product = await movies.ToListAsync();

            IQueryable<string> categoryQuery = from m in _context.Product
                                            orderby m.Category
                                            select m.Category;

            var products = from m in _context.Product
                         select m;

            if (!string.IsNullOrEmpty(SearchString))
            {
                products = products.Where(s => s.Name.Contains(SearchString));
            }

            if (!string.IsNullOrEmpty(ProductCategories))
            {
                products = products.Where(x => x.Category == ProductCategories);
            }
            Categories = new SelectList(await categoryQuery.Distinct().ToListAsync());
            Product = await products.ToListAsync();
        }
    }
}

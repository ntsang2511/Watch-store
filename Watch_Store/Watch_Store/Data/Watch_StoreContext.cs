using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Watch_Store.Models;

namespace Watch_Store.Data
{
    public class Watch_StoreContext : DbContext
    {
        public Watch_StoreContext (DbContextOptions<Watch_StoreContext> options)
            : base(options)
        {
        }

        public DbSet<Watch_Store.Models.Product> Product { get; set; } = default!;
    }
}

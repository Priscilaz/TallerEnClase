using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PriscilaZuniga_Web_CodeFirst.Models;

    public class WebCF_DbContext : DbContext
    {
        public WebCF_DbContext (DbContextOptions<WebCF_DbContext> options)
            : base(options)
        {
        }

        public DbSet<PriscilaZuniga_Web_CodeFirst.Models.Burger> Burger { get; set; } = default!;
        public DbSet<PriscilaZuniga_Web_CodeFirst.Models.Promo> Promo { get; set; } = default!;
}

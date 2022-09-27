using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Phramacy.src.Model
{
    public class AppIdentityDbContex : IdentityDbContext<IdentityUser>
    {
        //public DbSet<Product> Products { get;set ;}
        //public DbSet<Category> Categories { get; set; }
        public AppIdentityDbContex(DbContextOptions<AppIdentityDbContex> options)
            : base(options) { }
    }
}


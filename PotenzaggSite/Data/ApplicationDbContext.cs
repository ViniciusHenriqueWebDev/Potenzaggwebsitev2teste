using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PotenzaggSite.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PotenzaggSite.Data
{
    public class ApplicationDbContext : DbContext
    {
       

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        
        public DbSet<Usuario> Usuarios { get; set; }

        
        public DbSet<PotenzaggSite.Models.Embaixador> Embaixador { get; set; }


    }
}

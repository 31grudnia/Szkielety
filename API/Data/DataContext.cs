using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class DataContext : DbContext //definicje tablic
    {
       public DataContext(DbContextOptions options) : base(options)
        {
             
        }


        public DbSet<AppUser> Users { get; set; }

        public DbSet<CenaProduktuE> CenyProduktow { get; set; }

       public DbSet<WynagrodzenieE> Wynagrodzenia { get; set; }

        
        
    
    }
}
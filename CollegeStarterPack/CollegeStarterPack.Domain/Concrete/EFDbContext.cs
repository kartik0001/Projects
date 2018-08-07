using CollegeStarterPack.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeStarterPack.Domain.Concrete
{
   public class EFDbContext:DbContext
    {
            public DbSet<Slider> Sliders { get; set; }
            
            public DbSet<Product> Products { get; set; }

        public DbSet<ShippingDetail> ShippingDetails { get; set; }

    }
}

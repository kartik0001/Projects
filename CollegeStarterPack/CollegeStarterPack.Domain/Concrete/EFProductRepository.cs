using CollegeStarterPack.Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CollegeStarterPack.Domain.Entity;

namespace CollegeStarterPack.Domain.Concrete
{
    public class EFProductRepository : IProductRepository
    {
        public readonly EFDbContext context = new EFDbContext();
        public IEnumerable<Product> Products
        {
            get
            {
                return context.Products;
            }
        }
    }
}

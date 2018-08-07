using CollegeStarterPack.Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CollegeStarterPack.Domain.Entity;

namespace CollegeStarterPack.Domain.Concrete
{
   public class EFSliderRepository:ISliderRepository
    {
        public readonly EFDbContext context = new EFDbContext();

        public IEnumerable<Slider> Sliders
        {
            get
            {
                 return context.Sliders;
            }
        }
    }
}

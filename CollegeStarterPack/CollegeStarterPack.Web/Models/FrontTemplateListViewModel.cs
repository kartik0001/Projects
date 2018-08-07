using CollegeStarterPack.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CollegeStarterPack.Web.Models
{
    public class FrontTemplateListViewModel
    {
        public IEnumerable<Slider> Sliders { get; set; }
        public IEnumerable<Product> Products { get; set; }
    }
}
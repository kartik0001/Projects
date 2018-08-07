using CollegeStarterPack.Domain.Abstract;
using CollegeStarterPack.Domain.Concrete;
using CollegeStarterPack.Domain.Entity;
using CollegeStarterPack.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CollegeStarterPack.Web.Controllers
{
    public class HomeController : Controller
    {
        public EFDbContext context = new EFDbContext();
        public ISliderRepository sliderrepository;
        public IProductRepository productrepository;

        public HomeController(ISliderRepository sliderrepo,IProductRepository productrepo)
        {
            sliderrepository = sliderrepo;
            productrepository = productrepo;
        }
        public ActionResult Index()
        {
            FrontTemplateListViewModel model = new FrontTemplateListViewModel()
            {
                Sliders = sliderrepository.Sliders.OrderByDescending(s => s.SId),
                Products = productrepository.Products.OrderBy(p => p.ProductId)

            };

            return View(model);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
       
    }
}
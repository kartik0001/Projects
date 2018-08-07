using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeStarterPack.Domain.Entity
{
   public class Slider
    {
        [Key]
        public int SId { get; set; }
        public string SImageUrl { get; set; }
        public string STitle { get; set; }
        public string SDescription { get; set; }
    }
}

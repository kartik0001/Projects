using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeStarterPack.Domain.Entity
{
   public class ShippingDetail
    {
        [Key]
        public int ShippingId { get; set; }
        [Required(ErrorMessage = "Please Enter a Name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please Enter First Address Line")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Please Enter Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please Enter College Name")]
        public string College { get; set; }
        [Required(ErrorMessage = "Please Enter College Name")]
        public string MobileNo { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ECommerce.Areas.Admin.Models
{
    public class LoginViewModel
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public bool RememberMe { get; set; }

        [Display(Name = "Thành Phố")]
        public int ProvinceID { get; set; }

        [Display(Name = "Quận")]
        public int DistrictID { get; set; }

        [Display(Name = "Phường")]
        public int PrecinctID { get; set; }
    }
}
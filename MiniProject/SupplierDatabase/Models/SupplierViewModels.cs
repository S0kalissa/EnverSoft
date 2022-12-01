using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SupplierDatabase.Models
{
    public class SupplierViewModel
    {
        [Display(Name = "Code")]
        public int Code { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [Required]
        [StringLength(10, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 10)]
        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }
    }
}

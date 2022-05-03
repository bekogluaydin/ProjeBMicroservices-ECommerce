using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Course.Web.Models.Catalogs
{
    public class FeatureViewModel
    {
        [Display(Name = "Kurs Süresi")]
        [Required]
        public int Duration { get; set; }
    }
}

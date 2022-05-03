using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Course.Web.Models.Catalogs
{
    public class CourseCreateInput
    {
        [Display(Name="Kurs Adı")]
        [Required]
        public string Name { get; set; }

        [Display(Name = "Kurs Fiyatı")]
        [Required]
        public decimal Price { get; set; }

        [Display(Name = "Kurs Açıklama")]
        [Required]
        public string Description { get; set; }

        [Display(Name = "Kurs Fotoğraf")]
        public string Picture { get; set; }

        public string UserId { get; set; }

        public FeatureViewModel Feature { get; set; }

        [Display(Name = "Kurs  Kategori")]
        [Required]
        public string CategoryId { get; set; }

        [Display(Name = "Kurs  Fotoğraf")]
        public IFormFile PhotoFormFile { get; set; }
    }
}

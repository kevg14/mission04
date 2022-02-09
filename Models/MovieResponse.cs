using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace mission04.Models
{
    public class MovieResponse
    {
        [Key]
        [Required]

        public int MovieId { get; set; }

        public Category category { get; set; }

        [Required(ErrorMessage = "Input a category")]
        public int CategoryId { get; set; }

        [Required(ErrorMessage = "Input a title")]
        public string title { get; set; }

        [Required(ErrorMessage = "Input a Year")]
        public int year { get; set; }

        [Required(ErrorMessage = "Input a Director")]
        public string director { get; set; }

        [Required(ErrorMessage = "Input a rating")]
        public string rating { get; set; }

        public bool edited { get; set; }

        public string lent { get; set; }
        [MaxLength(25)]
        public string note { get; set; }


    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;
using TechJobsPersistent.Models;

namespace TechJobsPersistent.ViewModels
{
    public class AddEmployerViewModel
    {
        public AddEmployerViewModel(Employer employer)
        {
            Employer = employer;
        }

        [Required(ErrorMessage = "Name is required")]
        public int NameId { get; set; }

        [Required(ErrorMessage = "Location is required")]
        public int LocationId { get; set; }

        public Employer Employer { get; set; }


    }
}

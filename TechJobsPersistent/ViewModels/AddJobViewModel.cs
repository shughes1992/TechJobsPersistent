using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;
using TechJobsPersistent.Models;


namespace TechJobsPersistent.ViewModels

{
    //Should have Properties for ALL employers and skills in the Database

    public class AddJobViewModel
    {
        internal IEnumerable<string> selectedSkills;

        [Required(ErrorMessage = "Job is required")]
        public int JobId { get; set; }

        [Required(ErrorMessage = "Employer is required")]
        public int EmployerId { get; set; }
        public string Name { get; set; }
        public List<SelectListItem> Employers { get; set; }
        public List<Skill> Skills { get; set; }

        //properties for selected employer's ID


        public AddJobViewModel(List<Employer> employers, List<Skill> skills)
        {
            this.Skills = skills;
            this.Employers = new List<SelectListItem>();

            foreach (Employer employer in employers)
            {
                Employers.Add(new SelectListItem
                {
                    Value = employer.Id.ToString(),
                    Text = employer.Name
                });
            }

            Skills = skills;
        }




        public AddJobViewModel()
        {

        }


        //Should have Properties for:
        //--*ALL employers * ALL skills- in the Databas
        //properties for job's name
        //list of ALL employers as : SelectListItem

    }
}


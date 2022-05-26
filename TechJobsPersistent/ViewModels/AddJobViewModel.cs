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
        public string Name { get; set; }
        public int EmployerId { get; set; }
        public List<SelectListItem> Employers { get; set; }
        public List<Skill> AllSkills { get; set; }

        //properties for selected employer's ID

        public AddJobViewModel() { }

        public AddJobViewModel(List<Employer> employers)
        {

        }
        //Should have Properties for:
        //--*ALL employers * ALL skills- in the Databas
        //properties for job's name
        //list of ALL employers as : SelectListItem

    }
}


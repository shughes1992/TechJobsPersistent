using System;
namespace TechJobsPersistent.Models
{
    public class JobSkill
    {
        public int JobId { get; set; }
        public Job Job { get; set; }

        public int SkillId { get; set; }
        public Skill Skill { get; set; }

        public JobSkill()
        {
        }
    }
}

//a model to take job / skill id & join them togthere
//pairing of the 2
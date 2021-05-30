using System;
using System.Collections.Generic;

#nullable disable

namespace MedievalGameApi.Models
{
    public partial class Skill
    {
        public Skill()
        {
            PlayerSkills = new HashSet<PlayerSkill>();
        }

        public int SkillId { get; set; }
        public string SkillName { get; set; }
        public string SkillDescription { get; set; }

        public virtual ICollection<PlayerSkill> PlayerSkills { get; set; }
    }
}

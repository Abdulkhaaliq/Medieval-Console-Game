using System;
using System.Collections.Generic;

#nullable disable

namespace MedievalGameApi.Models
{
    public partial class PlayerSkill
    {
        public int LinkPlayerSkillId { get; set; }
        public int SkillId { get; set; }
        public int PlayerId { get; set; }

        public virtual Player1 Player { get; set; }
        public virtual Skill Skill { get; set; }
    }
}

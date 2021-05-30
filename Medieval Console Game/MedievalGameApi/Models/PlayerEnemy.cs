using System;
using System.Collections.Generic;

#nullable disable

namespace MedievalGameApi.Models
{
    public partial class PlayerEnemy
    {
        public int LinkPlayerEnemy { get; set; }
        public int EnemyId { get; set; }
        public int PlayerId { get; set; }

        public virtual Enemy Enemy { get; set; }
        public virtual Player1 Player { get; set; }
    }
}

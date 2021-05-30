using System;
using System.Collections.Generic;

#nullable disable

namespace MedievalGameApi.Models
{
    public partial class Enemy
    {
        public Enemy()
        {
            PlayerEnemies = new HashSet<PlayerEnemy>();
        }

        public int EnemyId { get; set; }
        public string EnemyName { get; set; }
        public string EnemyDescription { get; set; }
        public int EnemyLevel { get; set; }

        public virtual ICollection<PlayerEnemy> PlayerEnemies { get; set; }
    }
}

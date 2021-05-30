using System;
using System.Collections.Generic;

#nullable disable

namespace MedievalGameApi.Models
{
    public partial class Player1
    {
        public Player1()
        {
            PlayerEnemies = new HashSet<PlayerEnemy>();
            PlayerItems = new HashSet<PlayerItem>();
            PlayerJobs = new HashSet<PlayerJob>();
            PlayerSkills = new HashSet<PlayerSkill>();
            PlayerWallets = new HashSet<PlayerWallet>();
        }

        public int PlayerId { get; set; }
        public string PlayerName { get; set; }
        public int PlayerLevel { get; set; }

        public virtual ICollection<PlayerEnemy> PlayerEnemies { get; set; }
        public virtual ICollection<PlayerItem> PlayerItems { get; set; }
        public virtual ICollection<PlayerJob> PlayerJobs { get; set; }
        public virtual ICollection<PlayerSkill> PlayerSkills { get; set; }
        public virtual ICollection<PlayerWallet> PlayerWallets { get; set; }
    }
}

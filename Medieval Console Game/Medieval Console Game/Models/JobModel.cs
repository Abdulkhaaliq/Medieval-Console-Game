using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medieval_Console_Game.Models
{
    public class JobModel
    {
        public int JobId { get; set; }
        public string JobName { get; set; }
        public string JobDescription { get; set; }
        public int Wage { get; set; }
        public DateTime DateJoined { get; set; }
        public DateTime DateTerminated { get; set; }
    }
}

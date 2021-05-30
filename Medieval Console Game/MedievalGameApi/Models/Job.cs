using System;
using System.Collections.Generic;

#nullable disable

namespace MedievalGameApi.Models
{
    public partial class Job
    {
        public Job()
        {
            PlayerJobs = new HashSet<PlayerJob>();
        }

        public int JobId { get; set; }
        public string JobName { get; set; }
        public string JobDescription { get; set; }
        public int Wage { get; set; }
        public DateTime? DateJoined { get; set; }
        public DateTime? DateTerminated { get; set; }

        public virtual ICollection<PlayerJob> PlayerJobs { get; set; }
    }
}

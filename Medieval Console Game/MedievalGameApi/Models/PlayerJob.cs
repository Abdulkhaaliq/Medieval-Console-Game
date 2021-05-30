using System;
using System.Collections.Generic;

#nullable disable

namespace MedievalGameApi.Models
{
    public partial class PlayerJob
    {
        public int LinkPlayerJobId { get; set; }
        public int JobId { get; set; }
        public int PlayerId { get; set; }

        public virtual Job Job { get; set; }
        public virtual Player1 Player { get; set; }
    }
}

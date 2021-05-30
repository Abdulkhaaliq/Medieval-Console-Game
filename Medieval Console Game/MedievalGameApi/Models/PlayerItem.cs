using System;
using System.Collections.Generic;

#nullable disable

namespace MedievalGameApi.Models
{
    public partial class PlayerItem
    {
        public int LinkPlayerItemId { get; set; }
        public int ItemId { get; set; }
        public int PlayerId { get; set; }

        public virtual Item Item { get; set; }
        public virtual Player1 Player { get; set; }
    }
}

using System;
using System.Collections.Generic;

#nullable disable

namespace MedievalGameApi.Models
{
    public partial class Item
    {
        public Item()
        {
            PlayerItems = new HashSet<PlayerItem>();
        }

        public int ItemId { get; set; }
        public string ItemName { get; set; }
        public string ItemDescription { get; set; }
        public int ItemPrice { get; set; }

        public virtual ICollection<PlayerItem> PlayerItems { get; set; }
    }
}

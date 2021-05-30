using System;
using System.Collections.Generic;

#nullable disable

namespace MedievalGameApi.Models
{
    public partial class PlayerWallet
    {
        public int WalletId { get; set; }
        public int PlayerId { get; set; }
        public int WalletAmount { get; set; }

        public virtual Player1 Player { get; set; }
    }
}

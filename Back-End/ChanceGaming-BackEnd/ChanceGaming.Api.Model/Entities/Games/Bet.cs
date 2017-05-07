using ChanceGaming.Api.Model.Entities.Users;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChanceGaming.Api.Model.Entities.Games
{
    public class Bet
    {
        public Client PlacedBy { get; set; }
        public decimal Amount { get; set; } = 0;
        public DateTime PlacmentDate { get; set; } = DateTime.UtcNow;
    }
}

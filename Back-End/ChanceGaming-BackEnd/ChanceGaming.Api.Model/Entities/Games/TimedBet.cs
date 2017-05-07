using ChanceGaming.Api.Model.Entities.Users;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using ChanceGaming.Api.Core.Exceptions;

namespace ChanceGaming.Api.Model.Entities.Games
{
    public class TimedBet : Game
    {
        public Client Owner { get; set; }
        public bool IsOpen { get; set; } = true;

        #region Computed Properties
        public decimal StartingAmount
        {
            get
            {
                return _startingAmount;
            }
        }

        public short Multiplyer
        {
            get
            {
                return _multiplyer;
            }
        }

        public decimal TargetAmount
        {
            get
            {
                return _startingAmount * _multiplyer;
            }
        }

        public decimal BetAmount
        {
            get
            {
                return (TargetAmount / _numberOfBets);
            }
        }

        #endregion

        private List<Bet> _placedBets { get; set; } = new List<Bet>();
        private decimal _startingAmount { get; set; } = 0;
        private short _multiplyer { get; set; } = 0;
        private short _numberOfBets { get; set; } = 0;

        public TimedBet(decimal StartingAmount,short Multiplyer, short NumberOfBets)
        {
            _startingAmount = StartingAmount;
            _multiplyer = Multiplyer;
            _numberOfBets = NumberOfBets;
        }
        
        public void PlaceBet(Bet NewBet)
        {
            if (_startingAmount <= 0 || _multiplyer <= 0 || _numberOfBets <= 0)
                throw new BusinessException("One of the following values has not been set. [Starting Amount, Multiplyer, Number of Bets]");

            if (_placedBets.Any(x => x.PlacedBy.Username == NewBet.PlacedBy.Username))
                throw new BusinessException("Only one bet per user is allowed.");

            if (NewBet.Amount != BetAmount)
                throw new BusinessException($"Invalid bet amount {NewBet.Amount} amount should be {BetAmount}");
            
            _placedBets.Add(NewBet);

            if (ShouldCloseBet())
                IsOpen = false;
        }

        private bool ShouldCloseBet()
        {
            var betsTotalAmount = _placedBets.Sum(x => x.Amount);

            return (betsTotalAmount >= TargetAmount);
        }
    }
}

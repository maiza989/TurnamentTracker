﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TournamentTrackerLibaray.Models
{
    /// <summary>
    /// Prepersent one prize 
    /// </summary>
    public class PrizeModel
    {
        /// <summary>
        /// Represent a unique identifier to the prize model.
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Repersent the price number. Ex: 1,2,3,4.
        /// </summary>
        public int PlaceNumber { get; set; }
        /// <summary>
        /// Repersent the prize name. EX 1st, 2nd, Winner, Champion, first runner, second runner
        /// </summary>
        public string PlaceName { get; set; }
        /// <summary>
        /// Repersent the prize amount for that particular placement
        /// </summary>
        public decimal PrizeAmount { get; set; }
        /// <summary>
        /// Repersnet the prize percentage for the winner
        /// </summary>
        public double PrizePercentage { get; set; }

        public PrizeModel()
        {

        }

        public PrizeModel(string placeName, string placeNumber, string prizeAmount, string prizePercentage)
        {
            PlaceName = placeName;

            int placeNumberValue = 0;
            int.TryParse(placeNumber, out placeNumberValue);
            PlaceNumber = placeNumberValue;

            decimal prizeAmountValue = 0;
            decimal.TryParse(prizeAmount, out prizeAmountValue);
            PrizeAmount = prizeAmountValue;

            double prizePercentageValue = 0;
            double.TryParse(prizePercentage, out prizePercentageValue);
            PrizePercentage = prizePercentageValue;

        }

    }
}

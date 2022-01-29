using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CDTRacker.Models
{
    public class CD
    {
        private const int MONTHS_PER_YEAR = 12;
        private const int COMPOUNDING_TERM = 365;

        public string Bank { get; set; }
        public int Term { get; set; } //months
        public double Rate { get; set; }

        [DataType(DataType.Date)]
        public DateTime? PurchaseDate { get; set; }
        public double DepositAmount { get; set; }

        //methods


        public DateTime? MaturityDate()
        {
            DateTime maturityDate = PurchaseDate.Value.AddMonths(Term);
            return maturityDate;
        }

        public double ValueAtMaturity()
        {
            double years = Term / MONTHS_PER_YEAR;
            double baseMaturity = (1 + (Rate / COMPOUNDING_TERM));
            double powerMaturity = COMPOUNDING_TERM * years;
            double valueAtMaturity = DepositAmount * Math.Pow(baseMaturity, powerMaturity);
            return valueAtMaturity;
        }
    }
}

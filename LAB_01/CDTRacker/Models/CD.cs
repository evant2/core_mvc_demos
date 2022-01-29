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

        [Required(ErrorMessage = "Please enter a bank name")]
        public string Bank { get; set; }
        
        [Required(ErrorMessage = "Please enter an investment term")]
        public int Term { get; set; } //months
        
        [Required(ErrorMessage = "Please enter a desired interest rate")]
        public double Rate { get; set; }
        
        [Required(ErrorMessage = "Please enter a purchase date")]
        [DataType(DataType.Date)]
        public DateTime? PurchaseDate { get; set; }
        
        [Required(ErrorMessage = "Please enter a deposit amount")]
        public double DepositAmount { get; set; }

        //methods
        public string FormatDate(DateTime? date)
        {
            string formatDate = $"{date:d}";
            return formatDate;
        }

        public string FormatAmount(double amount)
        {
            string formatAmount = $"{amount:c}";
            return formatAmount;
        }
        
        public DateTime? MaturityDate()
        {
            DateTime maturityDate = PurchaseDate.Value.AddMonths(Term);
            return maturityDate;
        }

        public double ValueAtMaturity()
        {
            double calculatedRate = Rate / 100;
            double years = Term / MONTHS_PER_YEAR;
            double baseMaturity = (1 + (calculatedRate / COMPOUNDING_TERM));
            double powerMaturity = COMPOUNDING_TERM * years;
            double valueAtMaturity = DepositAmount * Math.Pow(baseMaturity, powerMaturity);
            return valueAtMaturity;
        }
    }
}

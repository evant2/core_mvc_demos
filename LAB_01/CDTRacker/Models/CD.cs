using System;
using System.Collections.Generic;
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
        public DateTime? PurchaseDate { get; set; }
        public decimal DepositAmount { get; set; }

        //methods
        public DateTime? MaturityDate()
        {
            DateTime maturityDate = PurchaseDate.Value.AddMonths(Term);
            return maturityDate;
        }

        public double ValueAtMaturity()
        {
            return 0.0;
        }
    }
}

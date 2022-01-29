using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CDTRacker.Models
{
    public class CDRepo
    {
        private static List<CD> cdEntries = new List<CD>();

        public static IEnumerable<CD> CDEntries
        {
            get
            {
                return cdEntries;
            }
        }

        public static void AddCD(CD cd)
        {
            cdEntries.Add(cd);
        }
    }
}

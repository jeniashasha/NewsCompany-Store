using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsCompany
{
     internal static class NewspaperCalculator
    {
        public static int numberOfChars = 0;
        internal static int CalcNumberOfChars(Newspaper newspaper)
        {
            return numberOfChars++;
        }
    }
}

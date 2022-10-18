using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

   public class DateCalculators
    {

        public static int CalculateDaysBetweenDates(DateTime startDate, DateTime endDate)
        {
            int numDays = 0;
            while (startDate < endDate)
            {
                numDays++;
                startDate = startDate.AddDays(1);
            }
            return numDays;
        }
    }
      

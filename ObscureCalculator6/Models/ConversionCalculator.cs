using Microsoft.Ajax.Utilities;
using System;
using System.Linq;

namespace ObscureCalculator6.Models
{
    public class ConversionCalculator
    {
        public int Fortnight;
        public double Furlong;
        public int StonesThrow;

        public ConversionCalculator()
        {
            Fortnight = 14;
            Furlong = 8;
            StonesThrow = 51;
        }

        public int CalculateFortnight(int days)
        {
            return days / Fortnight;
        }

        public double CalculateFurlong(double miles)
        {
            return miles * Furlong;
        }

        public int CalculateStonesThrow(int feet)
        {
            return feet / StonesThrow;
        }

 
   public static string TextTransformer(string x)
        {
            if (x.IsNullOrWhiteSpace())
            {
                return x;
            }
            return x + "_";
        }

        public Boolean IsPalendrome(string y)
        {
            if (string.IsNullOrEmpty(y) || string.IsNullOrWhiteSpace(y) || y.Length <= 1)
            {
                return false;
            }
            else
            {

                char[] array = y.ToCharArray();
                Array.Reverse(array);
                string reverse = "";
                foreach (char tempChar in array)
                {
                    reverse += tempChar;
                }
                reverse = reverse.ToUpper();
                return reverse.Equals(y.ToUpper());
            }
        }
 

        // I only trust him as far as I can throw him: Trust Calculate Method
        // Based on projected person weight, thrower weight, wind resistance 
        // and the throwee's consent to be thrown.
        public double CalculateTrust(int projectilePersonWeight, int perpetratorWeight,
            double windResistance, bool consentToBeThrown, Technique technique)
        {
            #region
            if (technique == null)
            {
                throw new ArgumentNullException(nameof(technique));
            }
            else if (projectilePersonWeight <= 0)
            {
                throw new ArgumentException("Avoid divide by zero", "projectilePersonWeight");
            }
            double trustInFeet;

            #endregion

            if (perpetratorWeight > projectilePersonWeight)
            {
                trustInFeet = (perpetratorWeight / projectilePersonWeight) * 8;
                if (consentToBeThrown)
                {
                    trustInFeet += 2;
                }
                else
                {
                    trustInFeet -= 2;
                }
            }
            else
            {
                trustInFeet = (perpetratorWeight / projectilePersonWeight) * 5;
                if (consentToBeThrown)
                {
                    trustInFeet += 2;
                }
                else
                {
                    trustInFeet -= 3;
                }
            }

            //Subtract wind resistance
            trustInFeet -= windResistance;

            trustInFeet = technique.ThrowTechnique == "curling" ? trustInFeet + technique.Success : trustInFeet;

            return trustInFeet;
        }

    }
}

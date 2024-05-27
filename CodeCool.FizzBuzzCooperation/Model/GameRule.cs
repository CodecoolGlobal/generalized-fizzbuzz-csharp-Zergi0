using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeCool.FizzBuzzCooperation.Model
{
    public record GameRule(Operator? Op, string returnString, int[] divisors) : IComparable<GameRule>
    {
        public GameRule(string returnString, int divisor) :this(null,returnString, new int[] { divisor })
        {

        }

        public int CompareTo(GameRule other)
        {
            if (other == null)
            {
                return 1;
            }

            int result = other.divisors.Length.CompareTo(divisors.Length);
            if (result != 0)
            {
                return result;
            }
            result = string.Compare(returnString, other.returnString, StringComparison.Ordinal);
            if (result != 0)
            {
                return result;
            }


            return 0; 
        }
    }
}

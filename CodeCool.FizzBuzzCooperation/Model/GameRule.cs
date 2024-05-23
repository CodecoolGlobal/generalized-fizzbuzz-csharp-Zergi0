using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeCool.FizzBuzzCooperation.Model
{
    public record GameRule(string returnString,IEnumerable<int> divisors)
    {

        public GameRule(Operator operators, string returnString, params int[] divisors) : this(
            returnString,createDivisors(operators,divisors)
            )
        {
            
        }

        public GameRule(string returnString, int divisor) :this(returnString, new List<int>(divisor))
        {

        }

        static private IEnumerable<int> createDivisors(Operator operators, int[] divisors) 
        {
            if(operators == Operator.And)
            {
                int temp = divisors[0];
                for (int i = 1; i < divisors.Length; i++)
                {
                    temp *= divisors[i];
                }
                return new List<int>(temp);
            } else if(operators == Operator.Or)
            {
                return divisors;
            }
            return divisors;

        }
    }
}

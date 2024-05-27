using CodeCool.FizzBuzzCooperation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeCool.FizzBuzzCooperation.Service.Division
{
    public class DivisionService : IDivisionService
    {
        public bool CanDivide(int number, Operator? op, params int[] divisors)
        {
            if (Operator.And == op)
            {
                bool canDivideWithAll = true;
                foreach (int divisor in divisors)
                {
                    if (!CanDivide(number, divisor))
                    {
                        canDivideWithAll = false;
                    }
                }
                return canDivideWithAll;
            }
            if (Operator.Or == op)
            {
                foreach (var divisor in divisors)
                {
                    if (CanDivide(number, divisor))
                    {
                        return true;
                    }
                }
            }
            if (op == null)
            {

                return number % divisors[0] == 0;
            }
            return false;
        }

        public bool CanDivide(int number, int divisor)
        {
            return number % divisor == 0;
        }
    }
}

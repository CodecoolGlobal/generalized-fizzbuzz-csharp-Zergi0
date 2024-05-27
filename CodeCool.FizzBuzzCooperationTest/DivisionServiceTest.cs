using CodeCool.FizzBuzzCooperation.Model;
using CodeCool.FizzBuzzCooperation.Service.Division;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeCool.FizzBuzzCooperationTest
{
    internal class DivisionServiceTest
    {
        private readonly IDivisionService _divisionService = new DivisionService();


        [TestCase(10, 2,ExpectedResult = true)]
        [TestCase(15, 11,ExpectedResult = false)]
        [TestCase(15, 3,ExpectedResult = true)]
        [TestCase(5, 5,ExpectedResult = true)]

        public bool divideOne(int number, int divisor)
        {
            return _divisionService.CanDivide(number,divisor);
        }

        [TestCase(15, Operator.And, new[] {3,5}, ExpectedResult = true)]
        [TestCase(15, Operator.Or, new[] {2,5}, ExpectedResult = true)]
        [TestCase(15, Operator.Or, new[] {2,8}, ExpectedResult = false)]
        [TestCase(15, Operator.And, new[] {2,5}, ExpectedResult = false)]
        public bool divideByMore(int number,Operator op, int[] divisors)
        {
            return _divisionService.CanDivide(number,op,divisors);
        }
    }
}

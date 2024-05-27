using CodeCool.FizzBuzzCooperation.Model;
using CodeCool.FizzBuzzCooperation.Service.Division;
using CodeCool.FizzBuzzCooperation.Service.Game;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeCool.FizzBuzzCooperationTest
{
    internal class GameServiceTest
    {
        private IGameService gameService;
        private GameSpecification gameSpecification;

        [SetUp]
        public void setUp()
        {
            gameService = new GameService(new DivisionService());
            gameSpecification = new GameSpecification(
                new SortedList<GameRule, string> { { new(Operator.And, "FizzBuzz", new[] { 3, 5 }), "FizzBuzz" },
                    { new(null, "Fizz", new[] { 3 }), "Fizz"  },
                    { new(null, "Buzz", new[] { 5 }), "Buzz"  }}) ;

        }

        [TestCase(1, ExpectedResult = "1")]
        [TestCase(3, ExpectedResult = "Fizz")]
        [TestCase(6, ExpectedResult = "Fizz")]
        [TestCase(5, ExpectedResult = "Buzz")]
        [TestCase(15, ExpectedResult = "FizzBuzz")]
        [TestCase(16, ExpectedResult = "16")]
        public string runPlay(int number)
        {
            return gameService.Play(number, gameSpecification);
        }
    }
}

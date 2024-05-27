using CodeCool.FizzBuzzCooperation.Model;
using CodeCool.FizzBuzzCooperation.Service.Division;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeCool.FizzBuzzCooperation.Service.Game
{
    public class GameService : IGameService
    {

        private IDivisionService divisionService;
        public GameService(IDivisionService divisionService)
        {
            this.divisionService = divisionService;
        }
        public string Play(int number, GameSpecification spec)
        {
            foreach (var rule in spec.rules.Keys)
            {
                if (divisionService.CanDivide(number, rule.Op, rule.divisors)){
                    return rule.returnString;
                }
            }
            return number.ToString();
        }
    }
}

using CodeCool.FizzBuzzCooperation.Model;

namespace CodeCool.FizzBuzzCooperation.Service.Game;

public interface IGameService
{
    string Play(int number, GameSpecification spec);
}

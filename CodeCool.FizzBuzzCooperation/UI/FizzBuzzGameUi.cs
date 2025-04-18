using CodeCool.FizzBuzzCooperation.Model;
using CodeCool.FizzBuzzCooperation.Service.Game;

namespace CodeCool.FizzBuzzCooperation.UI;

public class FizzBuzzGameUi
{
    private readonly IGameService _gameService;

    public FizzBuzzGameUi(IGameService gameService)
    {
        _gameService = gameService;
    }

    public void Run()
    {
        int number = GetNumber();
        GameSpecification spec = CreateGameSpecification();

        string result = _gameService.Play(number, spec);
        Console.WriteLine(result);
    }

    private GameSpecification CreateGameSpecification()
    {
        return new GameSpecification(
                new SortedList<GameRule, string> { { new(Operator.And, "FizzBuzz", new[] { 3, 5 }), "FizzBuzz" },
                    { new(null, "Fizz", new[] { 3 }), "Fizz"  },
                    { new(null, "Buzz", new[] { 5 }), "Buzz"  }});
    }

    private int GetNumber()
    {
        string? input = null;
        int number;
        Console.WriteLine("Provide a number to FizzBuzz: ");

        while (!Int32.TryParse(input, out number))
        {
            if (input != null)
            {
                Console.WriteLine("Invalid number!");
            }

            input = Console.ReadLine();
        }

        return number;
    }
}

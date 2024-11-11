using CodeCool.FizzBuzzCooperation.Model;
using CodeCool.FizzBuzzCooperation.Service.Division;
using CodeCool.FizzBuzzCooperation.Service.Game;
using CodeCool.FizzBuzzCooperation.UI;


IDivisionService divisionService = new DivisionService();
IGameService gameService = new GameService(divisionService);


var ui = new FizzBuzzGameUi(gameService);

ui.Run();

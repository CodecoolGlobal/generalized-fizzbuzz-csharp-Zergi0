using CodeCool.FizzBuzzCooperation.Service.Division;
using CodeCool.FizzBuzzCooperation.Service.Game;
using CodeCool.FizzBuzzCooperation.UI;


IDivisionService divisionService = null;
IGameService gameService = null;

var ui = new FizzBuzzGameUi(gameService);

ui.Run();

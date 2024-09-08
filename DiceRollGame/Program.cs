using DiceRollGame.Game;

Random random = new Random();
var dice = new Dice(random);
var guessingGame = new GuessingGame(dice);

GameResult gameResult = guessingGame.Play();

guessingGame.PrintResult(gameResult);

Console.ReadKey();


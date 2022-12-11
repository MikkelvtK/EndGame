// See https://aka.ms/new-console-template for more information
using EndGame;
using EndGame.Characters;
using EndGame.Helpers;
using EndGame.Players;

Party heroes = new(new ComputerPlayer());
heroes.Members.Add(new TrueProgrammer(Helpers.GetName()));

Party monsters = new(new ComputerPlayer());
monsters.Members.Add(new Skeleton());

Game game = new(heroes, monsters);
game.Run();

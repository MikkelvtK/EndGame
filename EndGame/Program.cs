// See https://aka.ms/new-console-template for more information

using EndGame;

Party heroes = new();
heroes.Members.Add(new TrueProgrammer(Helpers.GetName()));

Party monsters = new();
monsters.Members.Add(new Skeleton());

Game game = new(heroes, monsters);
game.Run();

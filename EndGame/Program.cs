// See https://aka.ms/new-console-template for more information
using EndGame.Characters;
using EndGame.Helpers;
using EndGame.Parties;
using EndGame.Players;

var playerHeroes = new ComputerPlayer();
var playerMonsters = new ComputerPlayer();

var heroes = new Party(playerHeroes);
heroes.Members.Add(new TrueProgrammer(Helpers.GetName()));

var monsters = new List<Party>();
monsters.Add(new MonsterParty(playerMonsters, 1));
monsters.Add(new MonsterParty(playerMonsters, 2));

var battleSystem = new BattleSystem(heroes, monsters);

var game = new Game(battleSystem);
game.Run();

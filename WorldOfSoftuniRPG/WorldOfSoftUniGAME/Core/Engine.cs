namespace WorldOfSoftuniRPG.Core
{
    using System;
    using System.Collections.Generic;
    using System.Threading;
    using CustomExceptions;
    using Enumerations;
    using Models.Fields;
    using Models.Helper;
    using Models.Players;

    public class Engine
    {
        public static void ExitGame(ExitGameReason reason)
        {
            switch (reason)
            {
                case ExitGameReason.ExitCommand:
                    Console.WriteLine("Good Bye.");
                    break;
                case ExitGameReason.PlayerDie:
                    for (int i = 0; i < i+1; i++)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("     You Die. Game Over!     You Die. Game Over!     You Die. Game Over!");
                    }
                    break;
                case ExitGameReason.PlayerWinTheGame:
                    for (int i = 0; i < 10; i++)
                    {
                        Thread.Sleep(300);
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        Console.WriteLine("Congratulations! You Win.  Congratulations! You Win.  Congratulations! You Win.");
                    }
                    break;
            }
            Game.IsGameRunning = false;
        }

        public void CommandHandler(string line)
        {
            string[] lineSplit = line.Split(' ');
            string comand = lineSplit[0].ToLower();
            
            switch (comand)
            {
                case Constants.BattleFieldCommand:
                    this.GenerateEnemies();

                    Console.WriteLine(BattleField.PrintBattleField());
                    break;
                case Constants.AttackCommand:
                    if (lineSplit.Length < 2 || lineSplit[1] == string.Empty)
                    {
                        throw new InputException("Cannot attack the air.");
                    }

                    string target = lineSplit[1];

                    switch (target)
                    {
                        case Constants.GhoulCommand:                          
                            Field.Hero.AttackEnemy(lineSplit[1]);
                            break;
                        case Constants.HydraCommand:
                            Field.Hero.AttackEnemy(lineSplit[1]);
                            break;
                        case Constants.SupremusCommand:
                            Field.Hero.AttackEnemy(lineSplit[1]);
                            break;
                        case Constants.RotfaceCommand:
                            Field.Hero.AttackEnemy(lineSplit[1]);
                            break;
                        case Constants.LichkingCommand:
                            Field.Hero.AttackEnemy(lineSplit[1]);
                            break;
                        case Constants.DeathwingCommand:
                            Field.Hero.AttackEnemy(lineSplit[1]);
                            break;
                        default:
                            throw new InvalidEnemyException("Cannot find requested enemy.");
                    }

                    break;                
                case Constants.InfoCommand:
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.WriteLine(Field.PrintHero());
                    break;
                case Constants.MarketFieldCommand:
                    MarketField market = new MarketField();
                    market.PrintAllItemTypes();
                    market.ReadCommand();
                    break;
                case Constants.ClearCommand:
                    Console.Clear();
                    break;
                case Constants.HelpCommand:
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Helper.DrawAllCommands();
                    break;
                case Constants.ExitCommand:
                    ExitGame(ExitGameReason.ExitCommand);
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    throw new InputException("Invalid command.");
            }
        }

       

        private void GenerateEnemies()
        {
            Validator.CheckIfHeroExist(Field.Hero);
            BattleField.Enemies = new List<Enemy>();
            bool isAllEnemiesAreKilled = true;

            if (BattleField.AttackedEnemies[EnemyType.Ghoul] < 3)
            {
                BattleField.Enemies.Add(EnemyFactory.Enemy(EnemyType.Ghoul));
                isAllEnemiesAreKilled = false;
            }

            if (BattleField.AttackedEnemies[EnemyType.Hydra] < 3)
            {
                BattleField.Enemies.Add(EnemyFactory.Enemy(EnemyType.Hydra));
                isAllEnemiesAreKilled = false;
            }

            if (BattleField.AttackedEnemies[EnemyType.Supremus] < 3)
            {
                BattleField.Enemies.Add(EnemyFactory.Enemy(EnemyType.Supremus));
                isAllEnemiesAreKilled = false;
            }

            if (BattleField.AttackedEnemies[EnemyType.Rotface] < 3)
            {
                BattleField.Enemies.Add(EnemyFactory.Enemy(EnemyType.Rotface));
                isAllEnemiesAreKilled = false;
            }

            if (BattleField.AttackedEnemies[EnemyType.Lichking] < 3)
            {
                BattleField.Enemies.Add(EnemyFactory.Enemy(EnemyType.Lichking));
                isAllEnemiesAreKilled = false;
            }

            if (isAllEnemiesAreKilled)
            {
                BattleField.Enemies.Add(EnemyFactory.Enemy(EnemyType.Deathwing));
            }
        }
    }
}
namespace WorldOfSoftuniRPG.Models.Players
{
    using CustomExceptions;
    using Enumerations;

    public static class EnemyFactory
    {
        public static Enemy Enemy(EnemyType type)
        {
            switch (type)
            {
                case EnemyType.Ghoul:
                    return new Enemy(140, 80, 50, EnemyType.Ghoul, 200);
                case EnemyType.Hydra:
                    return new Enemy(430, 400, 60, EnemyType.Hydra, 1000);
                case EnemyType.Supremus:
                    return new Enemy(600, 500, 75, EnemyType.Supremus, 2000);
                case EnemyType.Rotface:
                    return new Enemy(730, 680, 85, EnemyType.Rotface, 3000);
                case EnemyType.Lichking:
                    return new Enemy(870, 830, 100, EnemyType.Lichking, 4000);
                case EnemyType.Deathwing:
                    return new Enemy(100000, 100000, 1000, EnemyType.Deathwing, 10000);
                default:
                    throw new InputException("Invalid enemy type");
            }
        }
    }
}

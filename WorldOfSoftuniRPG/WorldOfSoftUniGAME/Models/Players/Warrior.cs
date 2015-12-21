namespace WorldOfSoftuniRPG.Models.Players
{
    internal class Warrior : Hero
    {
        private const int StartAttack = 90; 
        private const int StartDefence = 150; 
        private const int StartHealth = 100; 

        public Warrior()
            : base(StartAttack, StartDefence, StartHealth)
        {   
        }
    }
}
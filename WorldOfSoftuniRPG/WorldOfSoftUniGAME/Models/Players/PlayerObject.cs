namespace WorldOfSoftuniRPG.Models.Players
{
    using Interafaces;

    public abstract class PlayerObject : IAttack, IDefence, IUnit
    {
        private int attack;
        private int defence;
        private int health;

        protected PlayerObject(int attack, int defence, int health)
        {
            this.Attack = attack;
            this.Defence = defence;
            this.Health = health;
        }

        public int Attack
        {
            get
            {
                return this.attack;
            }

            set
            {
                if (value < 0)
                {
                    this.attack = 0;
                }
                else
                {
                    this.attack = value;
                }
            }
        }

        public int Defence
        {
            get
            {
                return this.defence;
            }

            set
            {
                if (value < 0)
                {
                    this.defence = 0;
                }
                else
                {
                    this.defence = value;
                }
            }
        }

        public int Health
        {
            get
            {
                return this.health;
            }

            set
            {
                if (value < 0)
                {
                    this.health = 0;
                }
                else
                {
                    this.health = value;
                }
            }
        }

        public abstract int GetAttackDemage();
    }
}
namespace WorldOfSoftuniRPG.Models.Players
{
    using System;

    using Enumerations;
    using Fields;
    using Interafaces;
    using Items.AttackItems;
    using Items.DefenseItems;   

    public class Enemy : PlayerObject, IDrop
    {
        private const int DropExpirience = 100;

        public Enemy(int attack, int defence, int health, EnemyType enemyType, int gold)
            : base(attack, defence, health)
        {
            this.EnemyType = enemyType;
            this.Gold = gold;
        }

        public int Expirience
        {
            get { return Enemy.DropExpirience; }
        }

        public EnemyType EnemyType { get; set; }

        public int Gold { get; set; }

        public IItem DropRandomItem()
        {
            Random rnd = new Random();
            int itemNumber = rnd.Next(1, 7);
            IItem itemForDrop;
            switch (this.EnemyType)
            {
                case EnemyType.Ghoul:
                    switch (itemNumber)
                    {
                        case 1:
                            itemForDrop = new Belt();
                            break;
                        case 2:
                            itemForDrop = new Boots();
                            break;
                        case 3:
                            itemForDrop = new Chest();
                            break;
                        case 4:
                            itemForDrop = new Helmet();
                            break;
                        case 5:
                            itemForDrop = new Pants();
                            break;
                        case 6:
                            itemForDrop = new Sword();
                            break;
                        default:
                            itemForDrop = null;
                            break;                        
                    }

                    break;
                case EnemyType.Hydra:
                    switch (itemNumber)
                    {
                        case 1:
                            itemForDrop = new Belt(ItemType.Uncommon);
                            break;
                        case 2:
                            itemForDrop = new Boots(ItemType.Uncommon);
                            break;
                        case 3:
                            itemForDrop = new Chest(ItemType.Uncommon);
                            break;
                        case 4:
                            itemForDrop = new Helmet(ItemType.Uncommon);
                            break;
                        case 5:
                            itemForDrop = new Pants(ItemType.Uncommon);
                            break;
                        case 6:
                            itemForDrop = new Sword(ItemType.Uncommon);
                            break;
                        default:
                            itemForDrop = null;
                            break;
                    }

                    break;
                case EnemyType.Supremus:
                    switch (itemNumber)
                    {
                        case 1:
                            itemForDrop = new Belt(ItemType.Rare);
                            break;
                        case 2:
                            itemForDrop = new Boots(ItemType.Rare);
                            break;
                        case 3:
                            itemForDrop = new Chest(ItemType.Rare);
                            break;
                        case 4:
                            itemForDrop = new Helmet(ItemType.Rare);
                            break;
                        case 5:
                            itemForDrop = new Pants(ItemType.Rare);
                            break;
                        case 6:
                            itemForDrop = new Sword(ItemType.Rare);
                            break;
                        default:
                            itemForDrop = null;
                            break;
                    }

                    break;
                case EnemyType.Rotface:
                    switch (itemNumber)
                    {
                        case 1:
                            itemForDrop = new Belt(ItemType.Magic);
                            break;
                        case 2:
                            itemForDrop = new Boots(ItemType.Magic);
                            break;
                        case 3:
                            itemForDrop = new Chest(ItemType.Magic);
                            break;
                        case 4:
                            itemForDrop = new Helmet(ItemType.Magic);
                            break;
                        case 5:
                            itemForDrop = new Pants(ItemType.Magic);
                            break;
                        case 6:
                            itemForDrop = new Sword(ItemType.Magic);
                            break;
                        default:
                            itemForDrop = null;
                            break;
                    }

                    break;
                case EnemyType.LichKing:
                    switch (itemNumber)
                    {
                        case 1:
                            itemForDrop = new Belt(ItemType.Legendary);
                            break;
                        case 2:
                            itemForDrop = new Boots(ItemType.Legendary);
                            break;
                        case 3:
                            itemForDrop = new Chest(ItemType.Legendary);
                            break;
                        case 4:
                            itemForDrop = new Helmet(ItemType.Legendary);
                            break;
                        case 5:
                            itemForDrop = new Pants(ItemType.Legendary);
                            break;
                        case 6:
                            itemForDrop = new Sword(ItemType.Legendary);
                            break;
                        default:
                            itemForDrop = null;
                            break;
                    }

                    break;
                case EnemyType.Deathwing:
                    itemForDrop = new Sword(ItemType.Legendary);
                    break;
                default:
                    itemForDrop = null;
                    break;
            }

            return itemForDrop;
        }

        public override int GetAttackDemage()
        {
            int damage = this.Attack - Field.Hero.Defence;
            if (damage < 0)
            {
                damage = 10;
            }

            return damage;
        }

        public override string ToString()
        {
            const int MaxCellSize = 13;
            var enemiestLeft = 3 - BattleField.AttackedEnemies[this.EnemyType];

            string outputEnemyType = this.EnemyType.ToString();
            string outputGold = this.Gold.ToString();
            string outputAttack = this.Attack.ToString();
            string outputDefence = this.Defence.ToString();
            string outputHealth = this.Health.ToString();
            string outputEnemiesLeft = string.Empty;

            if (this.EnemyType != EnemyType.Deathwing)
            {
                outputEnemiesLeft = enemiestLeft.ToString();
            }
            else
            {
                outputEnemiesLeft = "1";
            }

            return string.Format(
                "{0}{1}{2}{3}{4}{5}",
                outputEnemyType.PadRight(MaxCellSize, ' '),
                outputGold.PadRight(MaxCellSize, ' '),
                outputAttack.PadRight(MaxCellSize, ' '),
                outputDefence.PadRight(MaxCellSize, ' '),
                outputHealth.PadRight(MaxCellSize, ' '),
                outputEnemiesLeft);
        }
    }
}
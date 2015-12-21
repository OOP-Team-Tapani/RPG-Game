namespace WorldOfSoftuniRPG.CustomExceptions
{
    using System;

    public class InvalidEnemyException : Exception
    {
        public InvalidEnemyException(string message)
            : base(message)
        {
        }

        public override string Message
        {
            get {
                Console.ForegroundColor = ConsoleColor.Red;
                return base.Message + " Try another enemy.";
                
            }
        }
    }
}

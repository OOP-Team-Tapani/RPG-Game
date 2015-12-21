namespace WorldOfSoftuniRPG.CustomExceptions
{
    using System;

    public class InputException : Exception
    {
        public InputException(string message)
            : base(message)
        {
        }

        public override string Message
        {
            get
            {
                Console.ForegroundColor = ConsoleColor.Red;
                return base.Message + " Try again.";
            ;}
        }
    }
}

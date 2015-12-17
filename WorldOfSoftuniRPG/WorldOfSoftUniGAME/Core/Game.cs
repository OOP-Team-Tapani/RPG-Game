namespace WorldOfSoftuniRPG.Core
{
    using System;
    using System.Threading;
    using CustomExceptions;
    using System.Media;

    public struct Game
    {
        public static bool IsGameRunning = true;
        private Thread thread;
        private Engine engine;

        public void Start()
        {
            if (this.thread == null)
            {
                this.engine = new Engine();
                this.thread = new Thread(this.Run);
                this.thread.Start();
            }
        }

        public void Stop()
        {
            if (this.thread != null)
            {
                this.thread.Abort();
            }
        }

        private void Run()
        {
            int tick = 0;
            while (IsGameRunning)
            {
                try
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    this.engine.CommandHandler(Console.ReadLine());
                }
                catch (InputException e)
                {
                    Console.Error.WriteLine(e.Message);
                }
                catch (InvalidEnemyException e)
                {
                    Console.Error.WriteLine(e.Message);
                }
                catch (ApplicationException e)
                {
                    Console.Error.WriteLine(e.Message);
                }
                catch (ArgumentOutOfRangeException e)
                {
                    Console.Error.WriteLine(e.Message);
                }
                catch (ArgumentNullException e)
                {
                    Console.Error.WriteLine(e.Message);
                }
                catch (Exception e)
                {
                    Console.Error.WriteLine(e.Message);
                }
            }
        }
    }
}
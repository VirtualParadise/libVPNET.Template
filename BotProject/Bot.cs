using System;
using VP;

namespace BotProject
{
    class Bot
    {
        public static Instance BotInstance;

        static void Main(string[] args)
        {
            if (args.Length < 2)
            {
                Console.WriteLine("Two arguments required: \"<username>\" <password>");
                return;
            }

            BotInstance = new Instance();

            BotInstance.Chat            += (i, m) => Console.WriteLine("User {0} said: {1}", m.Name, m.Message);
            BotInstance.Avatars.Clicked += (i, c) => Console.WriteLine("User #{0} clicked #{1}", c.SourceSession, c.TargetSession);

            BotInstance
                .Login(args[0], args[1], "Bot")
                .Enter("Blizzard")
                .Say("Hello, virtual world!");

            Console.WriteLine("Instance has logged in, pumping messages...");
            while (true)
                BotInstance.Pump();
        }
    }
}
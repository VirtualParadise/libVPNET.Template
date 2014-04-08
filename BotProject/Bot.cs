using System;
using System.Configuration;
using VP;

namespace BotProject
{
    class Bot
    {
        public static Instance BotInstance;

        static void Main(string[] args)
        {
            // Instance setup
            BotInstance  = new Instance();
            var username = ConfigurationManager.AppSettings["Username"];
            var password = ConfigurationManager.AppSettings["Password"];

            // Event setup
            BotInstance.Chat            += (i, m) => Console.WriteLine("User {0} said: {1}", m.Name, m.Message);
            BotInstance.Avatars.Clicked += (i, c) => Console.WriteLine("User #{0} clicked #{1}", c.SourceSession, c.TargetSession);

            BotInstance
                .Login(username, password, "Bot")
                .Enter("Blizzard")
                .Say("Hello, virtual world!");

            Console.WriteLine("Instance has logged in, pumping messages...");
            while (true)
                BotInstance.Pump();
        }
    }
}
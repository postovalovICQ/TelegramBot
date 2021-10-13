using System;
using Telegram.Bot;

namespace _2
{
    class Program
    {
        static TelegramBotClient Bot;
        static void Main(string[] args)
        {
            Bot = new TelegramBotClient("2001810665:AAGLIWEHkLhoqBYble3IT6me80KTw5M0e70");
            Bot.OnMessage += BotOnMessageReceived;
            
            var me = Bot.GetMeAsync().Result;
            Console.WriteLine(me.FirstName);

            Bot.StartReceiving();

            Console.ReadLine();
            Bot.StoReceiving();
        }
        private static void BotOnMessageReceived(object sender, Telegram.Bot.Args.MessageEventArgs e)
        {
            var message = e.Message;
            string name = $"{ message.From.FirstName} { message.From.LastName}";
            Console.WriteLine($"{name} отправил сообщение '{message.Text}'");
        }
    }
}

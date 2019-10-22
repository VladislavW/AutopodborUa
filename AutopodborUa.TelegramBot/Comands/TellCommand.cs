using System;
using System.Collections.Generic;
using System.Text;
using Telegram.Bot;
using Telegram.Bot.Types;

namespace AutopodborUa.TelegramBot.Comands
{
    public class TellCommand : Command
    {
        public override string Name => "tell";

        public override void Execute(Message message, TelegramBotClient client)
        {
            var chatId = message.Chat.Id;
            //TODO: Command logic -_-

            client.SendTextMessageAsync(chatId, "It`s a test bot about cars");
        }
    }
}

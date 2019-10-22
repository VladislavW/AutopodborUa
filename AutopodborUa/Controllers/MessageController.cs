using AutopodborUa.TelegramBot;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Telegram.Bot.Types;

namespace AutopodborUa.Api.Controllers
{
    public class MessageController : ControllerBase
    {
        [Route(@"api/message/update")] //webhook uri part
        public async Task<OkResult> Update([FromBody]Update update)
        {
            var commands = Bot.Commands;
            var message = update.Message;
            var client = await Bot.Get();

            foreach (var command in commands)
            {
                if (command.Contains(message.Text.ToLowerInvariant()))
                {
                    command.Execute(message, client);
                    break;
                }
            }

            return Ok();
        }
    }
}

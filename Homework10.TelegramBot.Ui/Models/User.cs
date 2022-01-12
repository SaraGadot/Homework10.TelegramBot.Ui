using Telegram.Bot.Types;

namespace Homework10.TelegramBot.Ui.Models;
internal class User
{
    public ChatId ChatId;
    public string Name;
    public override string ToString()
    {
        return Name;
    }
}



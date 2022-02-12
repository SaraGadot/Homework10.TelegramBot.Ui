using Telegram.Bot.Types;

namespace Homework10.TelegramBot.Ui.Models;
internal class User
{
    public ChatId ChatId { get; init; }
    public string Name { get; init; }

    public override string ToString()
    {
        return Name;
    }
}



using Homework10.TelegramBot.Ui.Models;

namespace Homework10.TelegramBot.Ui.Interfaces;

internal interface IBotStorage
{
    void AddUser(User user);
    void AddMessage(Message message);

}


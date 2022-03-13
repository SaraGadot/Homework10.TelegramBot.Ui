using Homework10.TelegramBot.Ui.Interfaces;
using Homework10.TelegramBot.Ui.Models;
using System.Collections.ObjectModel;

namespace Homework10.TelegramBot.Ui;
internal class UserStorage: IBotStorage
{
    public readonly ObservableCollection<User> Users = new ObservableCollection<User>();
    public readonly ObservableCollection<Message> Messages = new ObservableCollection<Message>();
    private readonly IMainWindow _mainWindow;

    public UserStorage(IMainWindow mainWindow)
    {
        _mainWindow = mainWindow;
    }

    public void AddUser(User user)
    {
        _mainWindow.Dispatcher.Invoke(() =>
            {
                if (!Users.Any(_user => _user.Name == user.Name))
                {
                    Users.Add(user);
                }
            });
    }

    public void AddMessage(Message message)
    {
        _mainWindow.Dispatcher.Invoke(() => Messages.Add(message));
    }


}


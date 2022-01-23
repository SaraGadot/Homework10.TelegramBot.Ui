using Homework10.TelegramBot.Ui.Models;
using System.Collections.ObjectModel;

namespace Homework10.TelegramBot.Ui;
internal class UserStorage
{
    public readonly ObservableCollection<User> Users = new ObservableCollection<User>();
    public readonly ObservableCollection<Message> Messages = new ObservableCollection<Message>();
    private readonly MainWindow _mainWindow;

    public UserStorage(MainWindow mainWindow)
    {
        _mainWindow = mainWindow;
    }

    public void AddUser(User user)
    {
        _mainWindow.Dispatcher.Invoke(() => Users.Add(user));
    }

    public void AddMessage(Message message)
    {
        _mainWindow.Dispatcher.Invoke(() => Messages.Add(message));
    }


}


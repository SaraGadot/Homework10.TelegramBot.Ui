using System.Windows.Threading;

namespace Homework10.TelegramBot.Ui.Interfaces;

internal interface IMainWindow
{
    Dispatcher Dispatcher { get; }
}


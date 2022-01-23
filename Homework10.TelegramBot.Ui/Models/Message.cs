namespace Homework10.TelegramBot.Ui.Models;
internal class Message
{
    public string Text;
    public User From;
    public User To;
    public DateTime Date;
    public override string ToString()
    {
        return Text;
    }
}


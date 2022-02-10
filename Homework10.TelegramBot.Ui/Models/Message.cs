namespace Homework10.TelegramBot.Ui.Models;
internal class Message
{
    public string Text { get; init; }
    public User From { get; init; }
    public User To { get; init; }
    public DateTime Date { get; init; } = DateTime.UtcNow;

    public override string ToString()
    {
        return Text;
    }
}


namespace Homework10.TelegramBot.Ui.Models;
internal class Message
{
    public string Text { get; init; }
    public User From { get; init; }
    public DateTime Date { get; init; } = DateTime.UtcNow;
    public MessageDirection Direction { get; init; }
    
    public override string ToString()
    {
        return Text;
    }

}
enum MessageDirection
{
    Send,
    Receive,
}

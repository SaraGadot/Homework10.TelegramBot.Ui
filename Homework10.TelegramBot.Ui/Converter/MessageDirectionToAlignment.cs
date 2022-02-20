using Homework10.TelegramBot.Ui.Models;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace Homework10.TelegramBot.Ui.Converter;

public class MessageDirectionToAlignment : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        var direction = (MessageDirection)value;
        if (direction == MessageDirection.Send)
        {
            return HorizontalAlignment.Right;
        }
        else
        {
            return HorizontalAlignment.Left;
        }
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}


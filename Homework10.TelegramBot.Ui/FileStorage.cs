using System.IO;
using System.Linq;

namespace Homework10.TelegramBot.Ui;

internal class FileStorage
{
    public void SaveFile(string fileName, byte[] data)
    {
        var dir = "Files";
        if (!Directory.Exists(dir))
        {
            Directory.CreateDirectory(dir);
        }
        var filePath = Path.Combine(dir, Path.GetFileName(fileName));
        File.WriteAllBytes(filePath, data);
    }

    public byte[]? LoadFile(string fileName)
    {
        var filePath = Path.Combine("Files", fileName);
        if (!System.IO.File.Exists(filePath))
        {
            return null;
        }


        return File.ReadAllBytes(filePath);

    }

    public string[] BrowseFiles()
    {
        if (!Directory.Exists("Files"))
        {
            return new string[] { };
        }
        return Directory.GetFiles("Files")
            .Select(file => Path.GetFileName(file))
            .ToArray();
    }

}

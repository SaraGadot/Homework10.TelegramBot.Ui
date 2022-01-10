using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Homework10.TelegramBot.Ui
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        BlondeDreamBot blondeDreamBot;
        CancellationTokenSource botCancellation = new CancellationTokenSource();
        public MainWindow()
        {
            InitializeComponent();

           
            var token = System.IO.File.ReadAllText("token.txt");

            blondeDreamBot = new BlondeDreamBot(token);
            Task.Run(async () => await blondeDreamBot.Execute(botCancellation.Token));


            //botCancellation.Cancel();



        }


    
    }
}
//Что нужно сделать
//Создайте оконный интерфейс для бота из предыдущего задания с использованием WPF.

//В приложении необходимо реализовать отображение списка сообщений, которые написал боту пользователь.
//В списке присутствуют как минимум имя пользователя и его сообщение. При нажатии на сообщение оно становится выделенным.

//Помимо этого, приложение может отправлять выбранному пользователю ответ в виде текста.
//Для реализации этого потребуется использовать элементы управления Button и TextBox. При каждом новом полученном сообщении приложение сохраняет
//его в истории сообщений. Потом её можно импортировать в файл формата JSON. Также вы можете добавить в приложение меню, в котором можно совершить
//сохранение истории, выход из приложения, просмотр список присланных файлов в новом окне и так далее.

//При этом приложение не должно выглядеть некрасиво при растягивании на весь экран.



//Советы и рекомендации
//Необязательно использовать стандартный дизайн элементов управления WPF. Вы можете установить, например, пакет Material Design.
//Не ограничивайте себя поставленным заданием. Если ваш бот может присылать курс криптовалют, попробуйте сделать его график,
//а если бот позволяет узнать погоду, выведите таблицу с основными атмосферно-температурными показателями.


//Что оценивается
//В задании используется WPF.
//В главном окне программы содержатся: список сообщений пользователя, поле для ввода ответа, кнопка для отправки ответа.
//Все сообщения от всех пользователей сохраняются в формате JSON.
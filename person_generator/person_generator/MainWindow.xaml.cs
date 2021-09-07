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

namespace person_generator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static string[] name_male = new string[] { "Александр", "Алексей", "Анатолий", "Андрей", "Антон", "Аркадий", "Артем", "Борислав", "Вадим", "Валентин", "Валерий", "Василий", "Виктор", "Виталий", "Владимир", "Вячеслав", "Геннадий", "Георгий", "Григорий", "Даниил", "Денис", "Дмитpий", "Евгений", "Егор", "Иван", "Игорь", "Илья", "Кирилл", "Лев", "Максим", "Михаил", "Никита", "Николай", "Олег", "Семен", "Сергей", "Станислав", "Степан", "Федор", "Юрий" };
        public static string[] name_female = new string[] { "Анастасия","Анна","Мария","Елена","Дарья","Алина","Ирина","Екатерина","Арина","Полина","Ольга","Юлия","Татьяна","Наталья","Виктория","Елизавета","Ксения","Милана","Вероника","Алиса","Валерия","Александра","Ульяна","Кристина","София","Марина","Светлана","Варвара","Софья","Диана","Яна","Кира","Ангелина","Маргарита","Ева","Алёна","Дарина","Карина","Василиса","Олеся","Аделина","Оксана","Таисия","Надежда","Евгения","Элина","Злата","Есения","Милена","Вера"};
        public static string[] hobbies = new string[] {"Программирование", "Компьютерное зрение", "Компьютерные игры", "Вышивание", "Танцы", "Спорт", "Пение", "Учеба", "Медицина", "Музыка", "Рисование", "Аригами"};
        public static string[] qualities = new string[] { "Интелект", "Сила", "Скорость", "Красота", "Вежливость", "Интересный", "Застенчивость", "Ласковый", "Доброта", "Трудолюбивый", "Ленивый", "Жизнерадостный"};
        public static int age;
        public static int gender;
        public static int height;
        public static int weight;
        public static string name;
        public static int trash;
        public static string hobbie;
        public static string qa;
        public MainWindow()
        {
            InitializeComponent();
        }
        void main_button(object sender, RoutedEventArgs eventArgs)
        {
            Random random = new Random();
           age = random.Next(14, 60);
            height = random.Next(165, 200);
            weight = random.Next(62, 100);
            gender = random.Next(2);
            if (gender == 1)
            {
                trash = random.Next(name_male.Length);
                name = name_male[trash];
            }
            else
            {
                height = random.Next(160, 180);
                weight = random.Next(55, 80);
                trash = random.Next(name_female.Length);
                name = name_female[trash];
            }
            trash = random.Next(hobbies.Length);
            hobbie = hobbies[trash];
            trash = random.Next(qualities.Length);
            qa = qualities[trash];

            Age_t.Text = "Возвраст: " + age;
            Name_t.Text = "Имя: " + name;
            Height_t.Text = "Рост: " + height;
            Weight_t.Text = "Вес: " + weight;
            Hobbies_t.Text = "Увлечение: " + hobbie;
            qa_t.Text = "Качество: " + qa;
            if (gender == 1)
            {
                Gender_t.Text = "Пол: Мужской";
            }
            else
            {
                Gender_t.Text = "Пол: Женский";
            }

            main1.Text = "";
            main2.Text = "";
        }
    }
}

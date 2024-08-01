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

namespace Адовые_интерфейсы__18
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void culturolog_1_Checked(object sender, RoutedEventArgs e)
        {
            vedenie_1.Text = "3, 4 семестр"; //Вывод культурологии
        }

        private void philosof_1_Checked(object sender, RoutedEventArgs e)
        {
            vedenie_1.Text = "4, 3 семестр"; //Вывод философии
        }

        private void history_1_Checked(object sender, RoutedEventArgs e)
        {
            vedenie_1.Text = "1, 2 семестр"; //Вывод истории
        }

        private void language_1_Checked(object sender, RoutedEventArgs e)
        {
            vedenie_1.Text = "1, 2, 3, 4 семестр"; //Вывод иностранного 
        }


        private void poka_Click(object sender, RoutedEventArgs e)
        {
            this.Close(); //Выход из программы 
        }

        private void about_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Горе-дизайнер Бирюков Георгий, ИСП-23. По списку дисциплин составить программу, которая бы выводила список семестров при выборе предметов. А пока анекдот: Дагестанские блохи, услышав лезгинку, затоптали кошку насмерть."); //Сасщение
        }

        private void otvet_Click(object sender, RoutedEventArgs e) //Вывод в ручную (если есть руки)
        {
            if (history_2.IsChecked.Value == true) vedenie_2.Text = "1, 2 семестр";
            if (culturolog_2.IsChecked.Value == true) vedenie_2.Text = "3, 4 семестр";
            if (philosof_2.IsChecked.Value == true) vedenie_2.Text = "4, 3 семестр";
            if (language_2.IsChecked.Value == true) vedenie_2.Text = "1, 2, 3, 4 семестр";
        }

        private void grovestreet_Click(object sender, RoutedEventArgs e) //Контроль чек-бокса, чтобы бы галочка работала
        {
            if (grovestreet.IsChecked.Value == true)
            {
                grovestreetbox.IsEnabled = true;
                ballasbox.IsEnabled = false;
                grovestreet.IsChecked = true;
                ballas.IsChecked = false;
            }
            else
            {
                grovestreetbox.IsEnabled = false;
                ballas.IsChecked = false;
            }
        }

        private void ballas_Click(object sender, RoutedEventArgs e) //Контроль чек-бокса, чтобы бы галочка работала part2
        {
            if (ballas.IsChecked.Value == true)
            {
                ballasbox.IsEnabled = true;
                grovestreetbox.IsEnabled = false;
                ballas.IsChecked = true;
                grovestreet.IsChecked = false;
            }
            else
            {
                ballasbox.IsEnabled = false;
                ballas.IsChecked = false;
            }
        }
    }
}

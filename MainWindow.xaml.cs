using System.Diagnostics;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace new_shtuka
{
    public partial class MainWindow : Window
    {
        Random random = new Random();
        Button[,] buttons;
        int chislo_hodov;
        int a;
        string you;
        string robot;
        int nechy;
        public MainWindow()
        {
            InitializeComponent();

            buttons = new Button[,] { { _1, _2, _3 }, { _4, _5, _6 }, { _7, _8, _9 } };
        }
        private void NewGame_Click(object sender, RoutedEventArgs e)
        {
            Texstic.Text = "Крестики нолики";
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    buttons[i,j].Content = null;
                    buttons[i,j].IsEnabled = true;
                }
            }
            var who = MessageBox.Show("Хотите играть за креcтики??", "Крестики или нолики??",MessageBoxButton.YesNo);
            if (who == MessageBoxResult.Yes)
            {
                you = "X";
                robot = "O";
            }
            else
            {
                you = "O";
                robot = "X";
            }
            if (you == "O")
            {
                Hod_robota(robot);
            }
        }
        private void prosto_click(object sender, RoutedEventArgs e)
        {
            Hod_you(sender, e, you);
            a =  Check_pobeda();
            if (chislo_hodov == 9)
            {
                Texstic.Text = "Нечья\n(Нажмите Новая игра)";
                nechy = (int)Enum.nechy;
            }
            if (a != (int)Enum.pobeda)
            {
                Hod_robota(robot);
            }
            a =  Check_pobeda();
        }
        private void Hod_you(object sender , RoutedEventArgs e, string you)
        {
            (sender as Button).Content = you;
            (sender as Button).IsEnabled = false;
            chislo_hodov++;
        }
        private void Hod_robota(string robot)
        {
            if (nechy != (int)Enum.nechy)
            {
                int knnopkai = random.Next(0, 3);
                int knnopkaj = random.Next(0, 3);
                if (buttons[knnopkai, knnopkaj].IsEnabled == true)
                {
                    buttons[knnopkai, knnopkaj].Content = robot;
                    buttons[knnopkai, knnopkaj].IsEnabled = false;
                    chislo_hodov++;
                }
                else
                {
                    while (buttons[knnopkai, knnopkaj].IsEnabled == false)
                    {
                        knnopkai = random.Next(0, 3);
                        knnopkaj = random.Next(0, 3);
                        if (buttons[knnopkai, knnopkaj].IsEnabled == true)
                        {
                            buttons[knnopkai, knnopkaj].Content = robot;
                            buttons[knnopkai, knnopkaj].IsEnabled = false;
                            chislo_hodov++;
                            break;
                        }
                    }
                }
            }
            else
            {
                Obnull_knopok();
                return;
            }
        }
        private int Check_pobeda()
        {
            if (buttons[0, 0].Content == buttons[0, 1].Content && buttons[0, 1].Content == buttons[0, 2].Content)
            {
                if (buttons[0, 0].Content != null)
                {
                    switch (buttons[0, 0].Content)
                    {
                        case "O":
                            Texstic.Text = "Выиграли нолики\n(Нажмите Новая игра)";
                            break;
                        case "X":
                            Texstic.Text = "Выиграли крестики\n(Нажмите Новая игра)";
                            break;
                    }
                    Obnull_knopok();
                    return (int)Enum.pobeda;
                }
            }
            else if (buttons[0, 0].Content == buttons[1, 0].Content && buttons[1, 0].Content == buttons[2, 0].Content)
            {
                if (buttons[0, 0].Content != null)
                {
                    switch (buttons[0, 0].Content)
                    {
                        case "O":
                            Texstic.Text = "Выиграли нолики\n(Нажмите Новая игра)";
                            break;
                        case "X":
                            Texstic.Text = "Выиграли крестики\n(Нажмите Новая игра)";
                            break;
                    }
                    Obnull_knopok();
                    return (int)Enum.pobeda;
                }
            }
            else if (buttons[0, 1].Content == buttons[1, 1].Content && buttons[1, 1].Content == buttons[2, 1].Content)
            {
                if (buttons[0, 1].Content != null)
                {
                    switch (buttons[0, 1].Content)
                    {
                        case "O":
                            Texstic.Text = "Выиграли нолики\n(Нажмите Новая игра)";
                            break;
                        case "X":
                            Texstic.Text = "Выиграли крестики\n(Нажмите Новая игра)";
                            break;
                    }
                    Obnull_knopok();
                    return (int)Enum.pobeda;
                }
            }
            else if (buttons[0, 2].Content == buttons[1, 2].Content && buttons[1, 2].Content == buttons[2, 2].Content)
            {
                if (buttons[0, 2].Content != null)
                {
                    switch (buttons[0, 2].Content)
                    {
                        case "O":
                            Texstic.Text = "Выиграли нолики\n(Нажмите Новая игра)";
                            break;
                        case "X":
                            Texstic.Text = "Выиграли крестики\n(Нажмите Новая игра)";
                            break;
                    }
                    Obnull_knopok();
                    return (int)Enum.pobeda;
                }
            }
            else if (buttons[1, 0].Content == buttons[1, 1].Content && buttons[1, 1].Content == buttons[1, 2].Content)
            {
                if (buttons[1, 0].Content != null)
                {
                    switch (buttons[1, 0].Content)
                    {
                        case "O":
                            Texstic.Text = "Выиграли нолики\n(Нажмите Новая игра)";
                            break;
                        case "X":
                            Texstic.Text = "Выиграли крестики\n(Нажмите Новая игра)";
                            break;
                    }
                    Obnull_knopok();
                    return (int)Enum.pobeda;
                }
            }
            else if (buttons[2, 0].Content == buttons[2, 1].Content && buttons[2, 1].Content == buttons[2, 2].Content)
            {
                if (buttons[2, 0].Content != null)
                {
                    switch (buttons[2, 0].Content)
                    {
                        case "O":
                            Texstic.Text = "Выиграли нолики\n(Нажмите Новая игра)";
                            break;
                        case "X":
                            Texstic.Text = "Выиграли крестики\n(Нажмите Новая игра)";
                            break;
                    }
                    Obnull_knopok();
                    return (int)Enum.pobeda;
                }
            }
            else if (buttons[0, 0].Content == buttons[1, 1].Content && buttons[1, 1].Content == buttons[2, 2].Content)
            {
                if (buttons[0, 0].Content != null)
                {
                    switch (buttons[0, 0].Content)
                    {
                        case "O":
                            Texstic.Text = "Выиграли нолики\n(Нажмите Новая игра)";
                            break;
                        case "X":
                            Texstic.Text = "Выиграли крестики\n(Нажмите Новая игра)";
                            break;
                    }
                    Obnull_knopok();
                    return (int)Enum.pobeda;
                }
            }
            else if (buttons[0, 2].Content == buttons[1, 1].Content && buttons[1, 1].Content == buttons[2, 0].Content)
            {
                if (buttons[0, 2].Content != null)
                {
                    switch (buttons[0, 2].Content)
                    {
                        case "O":
                            Texstic.Text = "Выиграли нолики\n(Нажмите Новая игра)";
                            break;
                        case "X":
                            Texstic.Text = "Выиграли крестики\n(Нажмите Новая игра)";
                            break;
                    }
                    Obnull_knopok();
                    return (int)Enum.pobeda;
                }
            }
            else
            {
                return (int)Enum.nechy;
            }
            return 0;
        }
        private void Obnull_knopok()
        {
            chislo_hodov = 0;
            nechy = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    buttons[i, j].IsEnabled = false;
                }
            }
        }
    }
}
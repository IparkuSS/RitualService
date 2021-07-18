using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using System.Windows.Media.Animation;
using System.Threading;

namespace FuneralServices
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        AppCont db = new AppCont();
        private List<user> list;
        public MainWindow()
        {
            InitializeComponent();

            //new Thread(() => error()).Start();






        }
        //static bool error()
        //{
        //    //while (true)
        //    //{
        //    //    if (DateTime.Now.Minute == 11)
        //    //    {
        //    //        Process.Start("notepad");
        //    //        return true;
        //    //    }
        //    //}

        //}
        private void InputBatt(object sender, RoutedEventArgs e)
        {
            string Log = LoginForm.Text.Trim();
            string pas = PassForm.Password.Trim();
            if (Log.Length < 3)
            {
                LoginForm.ToolTip = "это поле введено не корректно";
                LoginForm.Background = Brushes.Red;

            }
            else
            {
                LoginForm.ToolTip = "";
                LoginForm.Background = Brushes.Transparent;
                PassForm.ToolTip = "";
                PassForm.Background = Brushes.Transparent;
                list = db.users.ToList();
                bool flag = true;
                string Temp = default;
                foreach (user i in list)
                {
                    if (i.login == Log)
                    {
                        if (i.pass == pas)
                        {
                            flag = false;
                            Temp = i.role;
                        }


                    }
                }
                if (flag == false)
                {
                    MessageBox.Show("Успешно");
                    if (Temp == "Менеджер")
                    {
                        MenegMainForm MenegMainFormAt = new MenegMainForm();
                        MenegMainFormAt.Show();
                        Hide();
                    }
                    else if (Temp == "Админестратор")
                    {
                        AdmMainForm AdmMainFormAt = new AdmMainForm();
                        AdmMainFormAt.Show();
                        Hide();
                    }
                    else if (Temp == "Продавец")
                    {
                        SellMainForm SellMainFormAt = new SellMainForm();
                        SellMainFormAt.Show();
                        Hide();
                    }
                    else if (Temp == "Бухгалтер")
                    {
                        bughalterMainForm SellMainFormAt = new bughalterMainForm();
                        SellMainFormAt.Show();
                        Hide();
                    }


                }

                else
                    MessageBox.Show("Неверный логин или пароль");

            }



        }
        //private void Window_ContentRendered(object sender, EventArgs e)
        //{
        //    for (int i = 0; i < 100; i++)
        //    {
        //        pbStatus.Value++;
        //        Thread.Sleep(100);
        //    }
        //}
        private void RegButt(object sender, RoutedEventArgs e)
        {
            RegForm RegFormAt = new RegForm();
            RegFormAt.Show();
            Hide();
        }

        private void TextBlock_ColorChanged(object sender, RoutedPropertyChangedEventArgs<Color> e)
        {

        }

        private void Window_ContentRendered(object sender, EventArgs e)
        {
            //for (int i = 0; i < 100; i++)
            //{
            //    pbStatus.Value++;
            //    Thread.Sleep(100);
            //}
        }

        private void outBatt(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}

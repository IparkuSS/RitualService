using System;
using System.Collections.Generic;
using System.Data.Entity;
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
using System.Windows.Shapes;
using System.Windows.Controls.Primitives;
namespace FuneralServices
{
    /// <summary>
    /// Логика взаимодействия для RegForm.xaml
    /// </summary>
    public partial class RegForm : Window
    {
        AppCont db = new AppCont();
        List<user> list = new List<user>();
        public RegForm()
        {
            InitializeComponent();

        }
        private void regButton(object sender, RoutedEventArgs e)
        {

            string Log = Login.Text.Trim();
            bool flag = true;
            list = db.users.ToList();
            foreach (user i in list)
            {
                if(Log == i.login)
                {
                    flag = false;
                }
            }
            string pas = Pass.Password.Trim();
            string pasReb = PassReb.Password.Trim();
            string name = nameF.Text.Trim();
            string surname = SurNameF.Text.Trim();
            string rol = Comb.Text;

            if (Log.Length < 4|| flag == false)
            {
                Login.ToolTip = "это поле введено не корректно";
                Login.Background = Brushes.Gray;

            }
           
            else if (name.Length < 3)
            {
                nameF.ToolTip = "это поле введено не корректно";
                nameF.Background = Brushes.Gray;
            }
            else if (surname.Length < 3)
            {
                SurNameF.ToolTip = "это поле введено не корректно";
                SurNameF.Background = Brushes.Gray;
            }
            else if (pas.Length < 6)
            {
                Pass.ToolTip = "это поле введено не корректно";
                Pass.Background = Brushes.Gray;
            }
            else if (pasReb != pas)
            {
                PassReb.ToolTip = "Пороли не совпали";
                PassReb.Background = Brushes.Gray;
            }
            else if (rol == "")
            {
                Comb.ToolTip = "Нечего не выбранно";
                Comb.Background = Brushes.Gray;
            }
            else
            {
                AppCont dbt = new AppCont();
                Login.ToolTip = "";
                Login.Background = Brushes.Transparent;
                Pass.ToolTip = "";
                Pass.Background = Brushes.Transparent;
                PassReb.ToolTip = "";
                PassReb.Background = Brushes.Transparent;
                MessageBox.Show("Зарегистрирован");
                user userNew = new user(Log, pas, rol, name, surname);
                dbt.users.Add(userNew);
                dbt.SaveChanges();
                MainWindow MainWindowAt = new MainWindow();
                MainWindowAt.Show();
                Hide();
            }
        }
        private void Buton_ToCom(object sender, RoutedEventArgs e)
        {
            MainWindow MainWindowAt = new MainWindow();
            MainWindowAt.Show();
            Hide();
        }

        private void myCmb_Loaded(object sender, RoutedEventArgs e)
        {
            List<string> listTemp = new List<string>();
            //List<user> listCustC;
            ComboBox cmb = (ComboBox)sender;

            listTemp.Add("Админестратор");
            listTemp.Add("Менеджер");
            listTemp.Add("Продавец");
            listTemp.Add("Бухгалтер");
            cmb.ItemsSource = listTemp;

        }

        private void ComboBox_Selected(object sender, SelectionChangedEventArgs e)
        {
            //List<user> list = new List<user>();

            //list = db.users.ToList();

            //ComboBox comboBox = (ComboBox)sender;
            //string s;

            //if (comboBox.SelectedItem == null) return;
            //s = comboBox.SelectedItem.ToString();
            //user userr = new user();
                   
            //    userr.role = s;
            //    db.Entry(userr).State = EntityState.Modified;
            //    db.SaveChanges();
            
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
           // Comb.Items.Add("Добавить этот пункт");
        }
    }
}

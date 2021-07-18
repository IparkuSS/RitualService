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

namespace FuneralServices
{
    /// <summary>
    /// Логика взаимодействия для AddWork.xaml
    /// </summary>
    public partial class AddWork : Window
    {
        public FuneralC funeralC { get; private set; }
        AppCont db;
        private List<Worker> list;
        public AddWork(FuneralC s)
        {
            InitializeComponent();
            funeralC = s;
            this.DataContext = funeralC;

            db = new AppCont();
            db.Workers.Load();
            this.DataContext = db.Wreaths.Local.ToBindingList();

            list = db.Workers.ToList();
            GridTwo.ItemsSource = list;
        }
        private void Accept_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
        }
       

        private void buttonOutCust(object sender, RoutedEventArgs e)
        {
            MenegerFunrPForm MenegerFunrPForm = new MenegerFunrPForm();
            MenegerFunrPForm.Show();
            Hide();
        }
    }
}


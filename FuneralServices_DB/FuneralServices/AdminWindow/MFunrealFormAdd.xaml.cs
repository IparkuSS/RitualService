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
using System.Windows.Shapes;

namespace FuneralServices
{
    /// <summary>
    /// Логика взаимодействия для FunrealFormAdd.xaml
    /// </summary>
    public partial class MFunrealFormAdd : Window
    {
        public FuneralC FuneralCAt { get; private set; }
        public MFunrealFormAdd(FuneralC s)
        {
            InitializeComponent();
            FuneralCAt = s;
            this.DataContext = FuneralCAt;
        }
        private void Accept_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
        }
        private void buttonOutCust(object sender, RoutedEventArgs e)
        {
            MenegerFunrPForm MenegerFunrPFormAt = new MenegerFunrPForm();
            MenegerFunrPFormAt.Show();
            Hide();
        }
    }
}

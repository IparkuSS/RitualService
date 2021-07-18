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
    /// Логика взаимодействия для MenWorkAdd.xaml
    /// </summary>
    public partial class MenWorkAdd : Window
    {
        public Worker WorkerA { get; private set; }
        public MenWorkAdd(Worker s)
        {
            InitializeComponent();
            WorkerA = s;
            this.DataContext = WorkerA;
        }
        private void Accept_Click(object sender, RoutedEventArgs e)
        {
            string NameWorkerr = NameWorker.Text.Trim();
            string SurNameWorkerr = SurNameWorker.Text.Trim();
            string PartWorkerr = PartWorker.Text;
            string NumberTelWorkerr = NumberTelWorker.Text;
            int res;
            
            bool isInt = Int32.TryParse(NameWorkerr, out res);
            bool isIntTwo = Int32.TryParse(SurNameWorkerr, out res);
            bool isIntThree = Int32.TryParse(PartWorkerr, out res);
            bool isIntFour = Int32.TryParse(NumberTelWorkerr, out res);
            if (NameWorkerr.Length < 4 || isInt == true)
            {
                NameWorker.ToolTip = "это поле введено не корректно";
                NameWorker.Background = Brushes.Red;

            }
            else if (SurNameWorkerr.Length < 4 || isIntTwo == true)
            {
                SurNameWorker.ToolTip = "это поле введено не корректно";
                SurNameWorker.Background = Brushes.Red;
            }
            else if (PartWorkerr.Length == 0 || isIntThree == true)
            {
                PartWorker.ToolTip = "это поле введено не корректно";
                PartWorker.Background = Brushes.Red;
            }
            else if (NumberTelWorkerr.Length != 9 || isIntFour == false)
            {
                NumberTelWorker.ToolTip = "это поле введено не корректно";
                NumberTelWorker.Background = Brushes.Red;
            }


            else this.DialogResult = true;
        }
        private void buttonOutCust(object sender, RoutedEventArgs e)
        {
            MenWork MenWorkA = new MenWork();
            MenWorkA.Show();
            Hide();
        }
    }
}

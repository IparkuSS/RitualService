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
    /// Логика взаимодействия для BughRitServ.xaml
    /// </summary>
    public partial class BughRitServ : Window
    {
        private List<Monument> listMun;
        private List<TheFuneral> listthef;
        private List<Hearse> listhe;
        AppCont db;
        public BughRitServ()
        {
            InitializeComponent();
            db = new AppCont();
            //db.Coffins.Load();
            //this.DataContext = db.Coffins.Local.ToBindingList();
            listMun = db.Monuments.ToList();
            Grid.ItemsSource = listMun;

            listthef = db.TheFunerals.ToList();
            GridTwo.ItemsSource = listthef;

            listhe = db.Hearses.ToList();
            GridFthree.ItemsSource = listhe;
        }

        private void AddCofin(object sender, RoutedEventArgs e)
        {

            if (Grid.SelectedItem == null) return;
            Monument CoffinAt = Grid.SelectedItem as Monument;
            if (CoffinAt == null) return;
            BughMonumAdd MenCrosAddA = new BughMonumAdd(new Monument
            {

                solidMon = CoffinAt.solidMon


            });

            if (MenCrosAddA.ShowDialog() == true)
            {

                //CoffinAt = db.Coffins.Find(MenCrosAddA.CoffinAA.solidCof);
                //if (CoffinAt != null)
                //{
                CoffinAt.solidMon = MenCrosAddA.CoffinAA.solidMon;

                db.Entry(CoffinAt).State = EntityState.Modified;
                listMun = db.Monuments.ToList();
                Grid.ItemsSource = listMun;
                db.SaveChanges();
                // }
            }
        }

        private void AddCross(object sender, RoutedEventArgs e)
        {
            if (GridTwo.SelectedItem == null) return;
            TheFuneral CoffinAt = GridTwo.SelectedItem as TheFuneral;
            if (CoffinAt == null) return;
            BughAddThef MenCrosAddA = new BughAddThef(new TheFuneral
            {

                solidFunr = CoffinAt.solidFunr,


            });

            if (MenCrosAddA.ShowDialog() == true)
            {

                //CoffinAt = db.Coffins.Find(MenCrosAddA.CoffinAA.solidCof);
                //if (CoffinAt != null)
                //{
                CoffinAt.solidFunr = MenCrosAddA.CoffinAA.solidFunr;

                db.Entry(CoffinAt).State = EntityState.Modified;
                listthef = db.TheFunerals.ToList();
                GridTwo.ItemsSource = listthef;
                db.SaveChanges();
            }
        }

        private void AddWn(object sender, RoutedEventArgs e)
        {
            if (GridFthree.SelectedItem == null) return;
            Hearse CoffinAt = GridFthree.SelectedItem as Hearse;
            if (CoffinAt == null) return;
            BughAddHear MenCrosAddA = new BughAddHear(new Hearse
            {

                solidHe = CoffinAt.solidHe


            });

            if (MenCrosAddA.ShowDialog() == true)
            {

                //CoffinAt = db.Coffins.Find(MenCrosAddA.CoffinAA.solidCof);
                //if (CoffinAt != null)
                //{
                CoffinAt.solidHe = MenCrosAddA.CoffinAA.solidHe;

                db.Entry(CoffinAt).State = EntityState.Modified;
                listhe = db.Hearses.ToList();
                GridFthree.ItemsSource = listhe;
                db.SaveChanges();
                // }
            }
        }

        private void back(object sender, RoutedEventArgs e)
        {
            bughalterMainForm ManegerRitGodsa = new bughalterMainForm();
            ManegerRitGodsa.Show();
            Hide();
        }
    }
}

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
    /// Логика взаимодействия для BughRItgod.xaml
    /// </summary>
    public partial class BughRItgod : Window
    {
        AppCont db;
        private List<Coffin> listCof;
        private List<Crosse> listCros;
        private List<Wreath> listWhe;
        public BughRItgod()
        {
            InitializeComponent();
            db = new AppCont();
            //db.Coffins.Load();
            //this.DataContext = db.Coffins.Local.ToBindingList();
            listCof = db.Coffins.ToList();
            Grid.ItemsSource = listCof;

            listCros = db.Crosses.ToList();
            GridTwo.ItemsSource = listCros;

            listWhe = db.Wreaths.ToList();
            GridFthree.ItemsSource = listWhe;

        }

        private void AddCofin(object sender, RoutedEventArgs e)
        {

            if (Grid.SelectedItem == null) return;
            Coffin CoffinAt = Grid.SelectedItem as Coffin;
            if (CoffinAt == null) return;
            BughPriceCrof MenCrosAddA = new BughPriceCrof(new Coffin
            {
              
                solidCof = CoffinAt.solidCof,
              

            });

            if (MenCrosAddA.ShowDialog() == true)
            {

                //CoffinAt = db.Coffins.Find(MenCrosAddA.CoffinAA.solidCof);
                //if (CoffinAt != null)
                //{
                    CoffinAt.solidCof = MenCrosAddA.CoffinAA.solidCof;
                   
                    db.Entry(CoffinAt).State = EntityState.Modified;
                    listCof = db.Coffins.ToList();
                    Grid.ItemsSource = listCof;
                    db.SaveChanges();
               // }
            }
        }

        private void AddCross(object sender, RoutedEventArgs e)
        {
            if (GridTwo.SelectedItem == null) return;
            Crosse CoffinAt = GridTwo.SelectedItem as Crosse;
            if (CoffinAt == null) return;
            BughCrossAdd MenCrosAddA = new BughCrossAdd(new Crosse
            {

                solidCros = CoffinAt.solidCros,


            });

            if (MenCrosAddA.ShowDialog() == true)
            {

                //CoffinAt = db.Coffins.Find(MenCrosAddA.CoffinAA.solidCof);
                //if (CoffinAt != null)
                //{
                CoffinAt.solidCros = MenCrosAddA.CoffinAA.solidCros;

                db.Entry(CoffinAt).State = EntityState.Modified;
                listCros = db.Crosses.ToList();
                GridTwo.ItemsSource = listCros;
                db.SaveChanges();
                // }
            }
        }

        private void AddWn(object sender, RoutedEventArgs e)
        {
            if (GridFthree.SelectedItem == null) return;
            Wreath CoffinAt = GridFthree.SelectedItem as Wreath;
            if (CoffinAt == null) return;
            BughAddWh MenCrosAddA = new BughAddWh(new Wreath
            {

                solid = CoffinAt.solid,


            });

            if (MenCrosAddA.ShowDialog() == true)
            {

                //CoffinAt = db.Coffins.Find(MenCrosAddA.CoffinAA.solidCof);
                //if (CoffinAt != null)
                //{
                CoffinAt.solid = MenCrosAddA.CoffinAA.solid;

                db.Entry(CoffinAt).State = EntityState.Modified;
                listWhe = db.Wreaths.ToList();
                GridFthree.ItemsSource = listWhe;
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

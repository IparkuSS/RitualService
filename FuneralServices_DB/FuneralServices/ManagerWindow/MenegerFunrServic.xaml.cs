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
    /// Логика взаимодействия для MenegerFunrServic.xaml
    /// </summary>
    public partial class MenegerFunrServic : Window
    {
        //AppCont db;
        //private List<FunrService> list;
        public MenegerFunrServic()
        {
            InitializeComponent();
            //db = new AppCont();
            //db.FunrServices.Load();
            //this.DataContext = db.FunrServices.Local.ToBindingList();
            //list = db.FunrServices.ToList();
            //Grid.ItemsSource = list;
        }

        //private void Add_Click(object sender, RoutedEventArgs e)
        //{
        //    list = db.FunrServices.ToList();
        //    MenegerFuntServicAdd MenegerFuntServicAddAt = new MenegerFuntServicAdd(new FunrService());
        //    if (MenegerFuntServicAddAt.ShowDialog() == true)
        //    {

        //        //FunrService FunrServicesAt = MenegerFuntServicAddAt.funrService;
        //        //db.FunrServices.Add(FunrServicesAt);
        //        //list.Add(FunrServicesAt);
        //        //Grid.ItemsSource = list;
        //        //db.SaveChanges();
        //    }
        //}
        //private void Edit_Click(object sender, RoutedEventArgs e)
        //{

        //    if (Grid.SelectedItem == null) return;

        //    FunrService FunrServiceAt = Grid.SelectedItem as FunrService;

        //    //MenegerFuntServicAdd MenegerFuntServicAddAt = new MenegerFuntServicAdd(new FunrService
        //    //{
        //    //    Id = FunrServiceAt.Id,
        //    //    hearse = FunrServiceAt.hearse,
        //    //    monument = FunrServiceAt.monument,
        //    //    funeral = FunrServiceAt.funeral,
        //    //    theFuneral = FunrServiceAt.theFuneral
        //    //});

        //    //if (MenegerFuntServicAddAt.ShowDialog() == true)
        //    //{

        //    //    FunrServiceAt = db.FunrServices.Find(MenegerFuntServicAddAt.funrService.Id);
        //    //    if (FunrServiceAt != null)
        //    //    {
        //    //        FunrServiceAt.hearse = MenegerFuntServicAddAt.funrService.hearse;
        //    //        FunrServiceAt.monument = MenegerFuntServicAddAt.funrService.monument;
        //    //        FunrServiceAt.funeral = MenegerFuntServicAddAt.funrService.funeral;
        //    //        FunrServiceAt.theFuneral = MenegerFuntServicAddAt.funrService.theFuneral;
        //    //        db.Entry(FunrServiceAt).State = EntityState.Modified;
        //    //        list = db.FunrServices.ToList();
        //    //        Grid.ItemsSource = list;
        //    //        db.SaveChanges();
        //    //    }
        //    //}
        //}

        //private void Delete_Click(object sender, RoutedEventArgs e)
        //{
        //    list = db.FunrServices.ToList();
        //    if (Grid.SelectedItem == null) return;
        //    FunrService FunrServiceAt = Grid.SelectedItem as FunrService;
        //    if (FunrServiceAt == null) return;
        //    list.Remove(FunrServiceAt);
        //    db.FunrServices.Remove(FunrServiceAt);
        //    Grid.ItemsSource = list;
        //    db.SaveChanges();
        //}

        private void MenMaFoOut(object sender, RoutedEventArgs e)
        {
            AdmMainForm MenegMainFormAt = new AdmMainForm();
            MenegMainFormAt.Show();
            Hide();
        }

        //private void RadioButton_Checked(object sender, RoutedEventArgs e)
        //{

        //}

        private void MenMaFoRitGo(object sender, RoutedEventArgs e)
        {

            MenegerFunrPForm MenegerFunrPFormAt = new MenegerFunrPForm();
            MenegerFunrPFormAt.Show();
            Hide();
        }

        private void MenMaFoCust(object sender, RoutedEventArgs e)
        {
            MenMonumentForm MenMonumentFormAt = new MenMonumentForm();
            MenMonumentFormAt.Show();
            Hide();
        }

        private void MenMaFoFunSer(object sender, RoutedEventArgs e)
        {
            MHers MHersAt = new MHers();
            MHersAt.Show();
            Hide();
        }

        private void MenMaFoOrd(object sender, RoutedEventArgs e)
        {
            MtheFun MHersAta = new MtheFun();
            MHersAta.Show();
            Hide();
        }

        private void MenMaFoRitGoe(object sender, RoutedEventArgs e)
        {
            MenWork MHersAta = new MenWork();
            MHersAta.Show();
            Hide();
        }
    }
}

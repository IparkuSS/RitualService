using MaterialDesignThemes.Wpf;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace FuneralServices
{
    /// <summary>
    /// Логика взаимодействия для MenegerFunrPForm.xaml
    /// </summary>
    public partial class MenegerFunrPForm : Window
    {
        AppCont db;
        private List<FuneralC> list = new List<FuneralC>();
        public MenegerFunrPForm()
        {
            InitializeComponent();
            db = new AppCont();
            List<Order> ListOrder = new List<Order>();
            list = db.FuneralCs.ToList();

            Grid.ItemsSource = list;
        }

        private void button(object sender, RoutedEventArgs e)
        {
            MenegerFunrServic MenegerFunrServicAt = new MenegerFunrServic();
            MenegerFunrServicAt.Show();
            Hide();
        }


        private void Edit_Click(object sender, RoutedEventArgs e)
        {

            if (Grid.SelectedItem == null) return;

            FuneralC FuneralCA = Grid.SelectedItem as FuneralC;

            if (FuneralCA == null) return;
            MFunrealFormAdd MFunrealFormAddAt = new MFunrealFormAdd(new FuneralC
            {
                idFuneralC = FuneralCA.idFuneralC,

                timeFun = FuneralCA.timeFun
            });

            if (MFunrealFormAddAt.ShowDialog() == true)
            {

                FuneralCA = db.FuneralCs.Find(MFunrealFormAddAt.FuneralCAt.idFuneralC);
                if (FuneralCA != null)
                {

                    FuneralCA.timeFun = MFunrealFormAddAt.FuneralCAt.timeFun;
                    db.Entry(FuneralCA).State = EntityState.Modified;
                    list = db.FuneralCs.ToList();
                    Grid.ItemsSource = list;
                    db.SaveChanges();
                }
            }
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            list = db.FuneralCs.ToList();
            if (Grid.SelectedItem == null) return;

            FuneralC FuneralCqq = Grid.SelectedItem as FuneralC;
            if (FuneralCqq == null) return;
            MessageBoxResult dialogResult = MessageBox.Show("Вы действительно хотите удалить запись?", "Проверка", MessageBoxButton.YesNo);
            if (dialogResult == MessageBoxResult.Yes)
            {
                list.Remove(FuneralCqq);
                db.FuneralCs.Remove(FuneralCqq);
                Grid.ItemsSource = list;
                db.SaveChanges();
            }
        }

        private void buttonWOR(object sender, RoutedEventArgs e)
        {
            MenWork MenegMainFormAt = new MenWork();
            MenegMainFormAt.Show();
            Hide();
        }

        private void myCmb_LoadedCros(object sender, RoutedEventArgs e)
        {
            // List<string> listTemp = new List<string>();
            // List<Order> listCustC; 
            // TextBox cmb = (TextBox)sender;
            //// cmb = (ComboBox)sender;

            // listCustC = db.Orders.ToList();ist<Order> listCustC; 
            // list = db.FuneralCs.ToList();
            // foreach (Order i in listCustC)
            // {
            //     listTemp.Add(i.funDate);// Склад не работает только с 0, убрать время, поиск вроде есть встроенные функции
            // }

            // foreach(FuneralC i in list)
            // {


            // }
            // cmb.ItemsSource = listTemp;
        }

        private void LoadDat(object sender, RoutedEventArgs e)
        {
            //List<Order> ListOrder;
            //list = db.FuneralCs.ToList();
            //ListOrder = db.Orders.ToList();
            //if (Grid.SelectedItem == null) return;
            //FuneralC FuneralCA = Grid.SelectedItem as FuneralC;
            //foreach (Order i in ListOrder)
            //{
            //    i.funDate = FuneralCA.OrderFunDate;
            //}
            //list.Add(FuneralCA);
            //list = db.FuneralCs.ToList();
            ////Grid.ItemsSource = list;
            //db.SaveChanges();

        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            list = db.FuneralCs.ToList();
            MFunrealFormAdd MFunrealFormAdd = new MFunrealFormAdd(new FuneralC());

            FuneralC OrderAt = MFunrealFormAdd.FuneralCAt;

            list.Add(OrderAt);
            Grid.ItemsSource = list;
            db.FuneralCs.Add(OrderAt);

            db.SaveChanges();
        }

        private void Faind_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < list.Count; i++)
                (Grid.ItemContainerGenerator.ContainerFromIndex(i) as DataGridRow).Background = null;
            bool flag = true;
            for (int i = 0; i < list.Count; i++)
                if (list[i].OrderFunDate == Search.Text || Search.Text == list[i].klWorker.ToString() ||
                      Search.Text == list[i].timeFun.ToString())
                {
                    (Grid.ItemContainerGenerator.ContainerFromIndex(i) as DataGridRow).Background = Brushes.Green;
                    flag = false;

                }
            if (flag == true) MessageBox.Show("Не найдено");

            Search.Text = null;
        }

        private void myCmb_LoadedCof(object sender, RoutedEventArgs e)
        {
            List<string> listTemp = new List<string>();
            List<Order> listCustC;
            ComboBox cmb = (ComboBox)sender;
            listCustC = db.Orders.ToList();

            foreach (Order i in listCustC)
            {
                listTemp.Add(i.funDate);
            }
            cmb.ItemsSource = listTemp;
        }
        private bool UserSeriesChange;
        private void comboBox1_DropDownOpened(object sender, EventArgs e)
        {
            UserSeriesChange = true;
        }

        private void ComboBox_SelectedCof(object sender, SelectionChangedEventArgs e)
        {
            if (UserSeriesChange == false)
            {
                return;
            }

            var comboBox = (ComboBox)sender;
            list = db.FuneralCs.ToList();
            FuneralC funeralC = Grid.SelectedItem as FuneralC;
            string SelectComb = comboBox.SelectedItem.ToString();

            if (funeralC != null)
            {
                funeralC.OrderFunDate = SelectComb;
                db.Entry(funeralC).State = EntityState.Modified;
                db.SaveChanges();
            }


            Popup myPopup = new Popup();
            myPopup.PlacementTarget = comboBox; //FrameworkElement where you want to show this tooltip             
            myPopup.Placement = PlacementMode.Top;
            myPopup.PopupAnimation = PopupAnimation.Slide;
            myPopup.AllowsTransparency = true;

            ListBox popupText = new ListBox();

            Image imag = new Image();
            List<string> ListTemp = new List<string>();
            List<Order> listWre = new List<Order>();
            listWre = db.Orders.ToList();
            //string Temp = default;
            foreach (Order i in listWre)
            {
                if (i.funDate == SelectComb)
                {
                    ListTemp.Add("Пол: " + i.flo);
                    ListTemp.Add("Вид похорон: " + i.viewFunr);
                    ListTemp.Add("катафалк: " + i.customerBrand);
                    ListTemp.Add("Цена за копку: " + i.SolidKop);
                }

            }


            popupText.ItemsSource = ListTemp;
            // popupText.ItemsSource = imag;
            popupText.Background = Brushes.White;
            popupText.Foreground = Brushes.Black;

            popupText.FontSize = 10;
            myPopup.Child = popupText;
            comboBox.ToolTip = myPopup;
            if (!myPopup.IsFocused)
                myPopup.IsOpen = true;
            DispatcherTimer time = new DispatcherTimer();
            time.Interval = TimeSpan.FromSeconds(5);
            time.Start();
            time.Tick += delegate
            {
                myPopup.IsOpen = false;
                time.Stop();
            };

            UserSeriesChange = false;

        }

        private void EvClos(object sender, ContextMenuEventArgs e)
        {
            TimePicker datePicker = (TimePicker)sender;
            DateTime? s;
            if (datePicker.SelectedTime == null) return;
            s = datePicker.SelectedTime.Value;
            FuneralC order = Grid.SelectedItem as FuneralC;
            order.timeFun = (DateTime)s;
            db.Entry(order).State = EntityState.Modified;
            db.SaveChanges();
        }

        private void Add_Work(object sender, RoutedEventArgs e)
        {

            List<Worker> listW = new List<Worker>();
            List<string> listStr = new List<string>();
            List<string> listStrTwo = new List<string>();
            list = db.FuneralCs.ToList();
            if (Grid.SelectedItem == null) return;
            FuneralC OrderAt = Grid.SelectedItem as FuneralC;
            AddWork mwhAdd = new AddWork(new FuneralC());
            if (mwhAdd.ShowDialog() == true)
            {
                if (mwhAdd.GridTwo.SelectedItem == null) return;
                //Wreath f = new Wreath();
                if (mwhAdd.GridTwo.SelectedItems.Count > 0)
                {

                    for (int i = 0; i < mwhAdd.GridTwo.SelectedItems.Count; i++)
                    {
                        //     list = (List<Wreath>)GridTwo.SelectedItems[i];

                        listW.Add((Worker)mwhAdd.GridTwo.SelectedItems[i]);
                    }

                }

                foreach (FuneralC i in list)
                {
                    listStr.Add(i.OrderFSurNameWorker);

                }


                bool flag = true;
                OrderAt.OrderFSurNameWorker = default;

                foreach (Worker j in listW)
                {
                    foreach (string i in listStr)
                    {
                        if (i != j.surNameWorker)
                        {
                            OrderAt.OrderFSurNameWorker += " ";
                            OrderAt.OrderFSurNameWorker += j.surNameWorker;
                        }
                        else
                        {
                            listStrTwo.Add(j.surNameWorker);
                            flag = false;
                        }

                    }
                }
                string TempTwo = default;
                if (flag == true)
                {
                    db.Entry(OrderAt).State = EntityState.Modified;
                    list = db.FuneralCs.ToList();
                    Grid.ItemsSource = list;
                    db.SaveChanges();
                }
                else

                    for (int i = 0; i < listStrTwo.Count; i++)
                    {
                        TempTwo += listStrTwo[i];
                    }
                MessageBox.Show(TempTwo, "Work");
            }



        }

        private void df(object sender, DependencyPropertyChangedEventArgs e)
        {
            TimePicker datePicker = (TimePicker)sender;
            DateTime? s;
            if (datePicker.SelectedTime == null) return;
            s = datePicker.SelectedTime.Value;
            FuneralC order = Grid.SelectedItem as FuneralC;
            order.timeFun = (DateTime)s;
            db.Entry(order).State = EntityState.Modified;
            db.SaveChanges();
        }
        //     private bool UserSeriesChangeTwo;
        private void sd(object sender, RoutedPropertyChangedEventArgs<DateTime?> e)
        {
            //if (UserSeriesChangeTwo == false)
            //{
            //    return;
            //}
            TimePicker datePicker = (TimePicker)sender;
            DateTime? s;
            if (datePicker.SelectedTime == null) return;
            s = datePicker.SelectedTime.Value;
            FuneralC order = Grid.SelectedItem as FuneralC;
            if (order == null) return;
            order.timeFun = (DateTime)s;
            db.Entry(order).State = EntityState.Modified;
            db.SaveChanges();
            //  UserSeriesChangeTwo = false;
        }



        private void TimePicker_PreviewDrop(object sender, ContextMenuEventArgs e)
        {
            //  UserSeriesChangeTwo = true;
        }

        //private void clos(object sender, ContextMenuEventArgs e)
        //{
        //    TimePicker datePicker = (TimePicker)sender;
        //    DateTime? s;
        //    if (datePicker.SelectedTime == null) return;
        //    s = datePicker.SelectedTime.Value;
        //    FuneralC order = Grid.SelectedItem as FuneralC;
        //    order.timeFun = (DateTime)s;
        //    db.Entry(order).State = EntityState.Modified;
        //    db.SaveChanges();
        //}

        //private void clos(object sender, ToolTipEventArgs e)
        //{
        //    TimePicker datePicker = (TimePicker)sender;
        //    DateTime? s;
        //    if (datePicker.SelectedTime == null) return;
        //    s = datePicker.SelectedTime.Value;
        //    FuneralC order = Grid.SelectedItem as FuneralC;
        //    order.timeFun = (DateTime)s;
        //    db.Entry(order).State = EntityState.Modified;
        //    db.SaveChanges();
        //}













        //}
    }
}

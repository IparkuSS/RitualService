using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Threading;

namespace FuneralServices
{
    /// <summary>
    /// Логика взаимодействия для MenegOrder.xaml
    /// </summary>
    public partial class MenegOrder : Window
    {
        AppCont db;
        private List<Order> list;
        private List<Customer> listCust;
        private double GenCe = default;
        ComboBox cmb;

        public MenegOrder()
        {
            InitializeComponent();
            db = new AppCont();
            list = db.Orders.ToList();
            Grid.ItemsSource = list;
        }

        
        private void Add_Click(object sender, RoutedEventArgs e)
        {
            list = db.Orders.ToList();
            MenegerOrderAdd MenegerOrderAddAt = new MenegerOrderAdd(new Order());
            if (MenegerOrderAddAt.ShowDialog() == true)
            {
                Order OrderAt = MenegerOrderAddAt.order;
                list.Add(OrderAt);
                Grid.ItemsSource = list;
                db.Orders.Add(OrderAt);

                db.SaveChanges();

            }
        }

        private void Edit_Click(object sender, RoutedEventArgs e)
        {

            if (Grid.SelectedItem == null) return;

            Order OrderAt = Grid.SelectedItem as Order;
            if (OrderAt == null) return;
            MenegerOrderAdd MenegerOrderAddAt = new MenegerOrderAdd(new Order
            {
                idOrder = OrderAt.idOrder,
                flo = OrderAt.flo,
                adress = OrderAt.adress,
                SolidKop = OrderAt.SolidKop,
                viewFunr = OrderAt.viewFunr,
                
            });

            if (MenegerOrderAddAt.ShowDialog() == true)
            {

                OrderAt = db.Orders.Find(MenegerOrderAddAt.order.idOrder);
                if (OrderAt != null)
                {
                    OrderAt.flo = MenegerOrderAddAt.order.flo;
                    OrderAt.adress = MenegerOrderAddAt.order.adress;
                    OrderAt.SolidKop = MenegerOrderAddAt.order.SolidKop;
                    OrderAt.viewFunr = MenegerOrderAddAt.order.viewFunr;
                    db.Entry(OrderAt).State = EntityState.Modified;
                    list = db.Orders.ToList();
                    Grid.ItemsSource = list;
                    db.SaveChanges();
                }
            } 
        }
       
        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            list = db.Orders.ToList();
            if (Grid.SelectedItem == null) return;
            Order OrderAt = Grid.SelectedItem as Order;
            if (OrderAt == null) return;
            MessageBoxResult dialogResult = MessageBox.Show("Вы действительно хотите удалить запись?", "Проверка", MessageBoxButton.YesNo);
            if (dialogResult == MessageBoxResult.Yes)
            {
                list.Remove(OrderAt);
                db.Orders.Remove(OrderAt);
                Grid.ItemsSource = list;
                db.SaveChanges();
            }
        }
        private void buttonOutFunrOrd(object sender, RoutedEventArgs e)
        {
            MenegMainForm MenegMainFormAt = new MenegMainForm();
            MenegMainFormAt.Show();
            Hide();
        }
        private void myCmb_Loaded(object sender, RoutedEventArgs e)
        {
            List<string> listTemp = new List<string>();
            cmb = (ComboBox)sender;
            listCust = db.Customers.ToList();
            foreach (Customer i in listCust)
            {
                listTemp.Add(i.surName);
            }
            cmb.ItemsSource = listTemp;

        }
        private void ComboBox_Selected(object sender, SelectionChangedEventArgs e)
        {
            if (UserSeriesChange == false)
            {
                return;
            }
            list = db.Orders.ToList();
            List<Customer> listCustTemp = new List<Customer>();
            ComboBox comboBox = (ComboBox)sender;
            string s;
            listCust = db.Customers.ToList();
            if (comboBox.SelectedItem == null) return;
            s = comboBox.SelectedItem.ToString();
            Order order = Grid.SelectedItem as Order;

            if (order != null)
            {
                order.customerSurName = s;
                db.Entry(order).State = EntityState.Modified;
                db.SaveChanges();
            }
            Popup myPopup = new Popup();
            myPopup.PlacementTarget = comboBox;
            myPopup.Placement = PlacementMode.Top;
            myPopup.PopupAnimation = PopupAnimation.Slide;
            myPopup.AllowsTransparency = true;
            ListBox popupText = new ListBox();
            List<string> ListTemp = new List<string>();
            foreach (Customer i in listCust)
            {
                if (i.surName == s)
                {
                    ListTemp.Add("Имя заказчика: " + i.name);
                    ListTemp.Add("Отчество заказчика: " + i.part);
                    ListTemp.Add("Номер телефона заказчика: " + i.phoneNumber);
                    ListTemp.Add("Адрес Заказчика: " + i.addres);
                }

            }

            popupText.ItemsSource = ListTemp;
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
        private void button(object sender, RoutedEventArgs e)
        {
            List<Wreath> listW = new List<Wreath>();
            List<string> listStr = new List<string>();
            list = db.Orders.ToList();
            if (Grid.SelectedItem == null) return;
            Order OrderAt = Grid.SelectedItem as Order;
            if (OrderAt == null) return;
            mWhAdd mwhAdd = new mWhAdd(new Order());
            if (mwhAdd.ShowDialog() == true)
            {
                if (mwhAdd.GridTwo.SelectedItem == null) return;
                if (mwhAdd.GridTwo.SelectedItems.Count > 0)
                {

                    for (int i = 0; i < mwhAdd.GridTwo.SelectedItems.Count; i++)
                    {
                        if (mwhAdd.GridTwo.SelectedItems[i] != null)
                        listW.Add((Wreath)mwhAdd.GridTwo.SelectedItems[i]);
                    }

                }

                OrderAt.customerClassWre = default;

                GenCe = default;
                foreach (Wreath i in listW)
                {
                    //i.skladKol -= 1;
                    //db.Entry(i).State = EntityState.Modified;
                    //db.SaveChanges();
                  
                    OrderAt.customerClassWre += " ";
                    OrderAt.customerClassWre += i.classWre;
                    GenCe += i.solid;

                }


                db.Entry(OrderAt).State = EntityState.Modified;
                list = db.Orders.ToList();
                Grid.ItemsSource = list;
                db.SaveChanges();
            }

        }
        private void ComboBox_SelectedCof(object sender, SelectionChangedEventArgs e)
        {
            if (UserSeriesChange == false)
            {
                return;
            }

            List<Coffin> listWre;
            List<string> listTemp = new List<string>();
            list = db.Orders.ToList();
            int TempInd = Grid.SelectedIndex;
            string TempOne = default;
            int Counter = 0;
            foreach (Order i in list)
            {

                if (Counter == TempInd)
                    TempOne = i.customerClassCof;
                Counter++;
            }
            listWre = db.Coffins.ToList();
            ComboBox comboBox = (ComboBox)sender;
            string SelectCoff = default;
            SelectCoff = comboBox.SelectedItem.ToString();
            Order order = Grid.SelectedItem as Order;
            //int Count = 0;

            foreach (Coffin i in listWre)
            {
                if (SelectCoff == i.classCof)
                {
                    if (i.countSk == 0)
                    {
                        comboBox.Background = Brushes.Gray;

                        return;
                    }
                    else
                    {
                        i.countSk -= 1;
                        db.Entry(i).State = EntityState.Modified;
                        db.SaveChanges();
                    }
                }
                else if (TempOne == i.classCof)
                {
                    i.countSk += 1;
                    db.Entry(i).State = EntityState.Modified;
                    db.SaveChanges();
                }
            }

            if (order != null)
            {
                order.customerClassCof = SelectCoff;
                db.Entry(order).State = EntityState.Modified;
                db.SaveChanges();
            }
            Popup myPopup = new Popup();
            myPopup.PlacementTarget = comboBox; //FrameworkElement where you want to show this tooltip             
            myPopup.Placement = PlacementMode.Top;
            myPopup.PopupAnimation = PopupAnimation.Slide;
            myPopup.AllowsTransparency = true;

            ListBox popupText = new ListBox();

            Image imag = new Image();
            List<Object> ListTemp = new List<Object>();
            string Temp = default;
            foreach (Coffin i in listWre)
            {
                if (i.classCof == SelectCoff)
                {

                  
                    ListTemp.Add("Количество на складе: " + i.countSk);
                    ListTemp.Add("Материал: " + i.materCof);
                    ListTemp.Add("Цена за гроб: " + i.solidCof);// телефон памятнику и паминкам
                    Temp = i.imageCoffin;
                }

            }
            if (Temp != null)
            {
                imag.Source = BitmapFrame.Create(new Uri(Temp));
                imag.Width = 150;
                ListTemp.Add(imag);
            }
            popupText.ItemsSource = ListTemp;
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
        private void myCmb_LoadedCof(object sender, RoutedEventArgs e)
        {
            List<string> listTemp = new List<string>();
            List<Coffin> listCustC;
            cmb = (ComboBox)sender;
            listCustC = db.Coffins.ToList();

            foreach (Coffin i in listCustC)
            {
                listTemp.Add(i.classCof);
            }
            cmb.ItemsSource = listTemp;
        }
        private void ComboBox_SelectedCros(object sender, SelectionChangedEventArgs e)
        {
            if (UserSeriesChange == false)
            {
                return;
            }

            List<Crosse> listWre;
            list = db.Orders.ToList();
            listWre = db.Crosses.ToList();

            int TempInd = Grid.SelectedIndex;
            string TempOne = default;
            int Counter = 0;
            foreach (Order i in list)
            {

                if (Counter == TempInd)
                    TempOne = i.customerClassCros;
                Counter++;
            }

            ComboBox comboBox = (ComboBox)sender;
            string SelectCr;

            if (comboBox.SelectedItem == null) return;
            SelectCr = comboBox.SelectedItem.ToString();
            Order order = Grid.SelectedItem as Order;
            foreach (Crosse i in listWre)
            {
                if (SelectCr == i.classCros)
                {
                    if (i.countSkCr == 0)
                    {
                        comboBox.Background = Brushes.Gray;

                        return;
                    }
                    else
                    {
                        i.countSkCr -= 1;
                        db.Entry(i).State = EntityState.Modified;
                        db.SaveChanges();
                    }
                }
                else if (TempOne == i.classCros)
                {
                    i.countSkCr += 1;
                    db.Entry(i).State = EntityState.Modified;
                    db.SaveChanges();
                }

            }

            if (order != null)
            {
                order.customerClassCros = SelectCr;
                db.Entry(order).State = EntityState.Modified;
                db.SaveChanges();
            }
            Popup myPopup = new Popup();
            myPopup.PlacementTarget = comboBox;
            myPopup.Placement = PlacementMode.Top;
            myPopup.PopupAnimation = PopupAnimation.Slide;
            myPopup.AllowsTransparency = true;

            ListBox popupText = new ListBox();

            Image imag = new Image();
            List<Object> ListTemp = new List<Object>();
            string Temp = default;
            foreach (Crosse i in listWre)
            {
                if (i.classCros == SelectCr)
                {

                    ListTemp.Add("тип креста: " + i.typeCros);
                    ListTemp.Add("Количество на складе: " + i.countSkCr);
                    ListTemp.Add("цена: " + i.solidCros);
                    Temp = i.imageCrosses;
                }

            }
            if (Temp != null)
            {
                imag.Source = BitmapFrame.Create(new Uri(Temp));
                imag.Width = 120;
                ListTemp.Add(imag);
            }
            popupText.ItemsSource = ListTemp;
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
        private void Sol_Click(object sender, RoutedEventArgs e)
        {
            if (Grid.SelectedItem == null) return;
            Order OrderAt = Grid.SelectedItem as Order;
            list = db.Orders.ToList();
            TextBox textBox = new TextBox();
            List<double> listTemp = new List<double>();
            List<Crosse> listCross;
            listCross = db.Crosses.ToList();
            List<Coffin> listCof;
            listCof = db.Coffins.ToList();
            List<Wreath> listWr;
            listWr = db.Wreaths.ToList();
            List<Hearse> listCHers;
            listCHers = db.Hearses.ToList();
            List<TheFuneral> listthef;
            listthef = db.TheFunerals.ToList();
            List<Monument> listCM;
            listCM = db.Monuments.ToList();
            List<FuneralC> listFn;
            listFn = db.FuneralCs.ToList();
            foreach (Crosse i in listCross)
            {
                if (i.classCros == OrderAt.customerClassCros)
                    listTemp.Add(i.solidCros);

            }
            foreach (Coffin i in listCof)
            {
                if (i.classCof == OrderAt.customerClassCof)
                    listTemp.Add(i.solidCof);

            }
            foreach (Hearse i in listCHers)
            {
                if (i.brand == OrderAt.customerBrand)
                    listTemp.Add(i.solidHe);

            }
            foreach (TheFuneral i in listthef)
            {
                if (i.organiz == OrderAt.customerOrganiz)
                    listTemp.Add(i.solidFunr);

            }
            foreach (Monument i in listCM)
            {
                if (i.orgMon == OrderAt.customerOrgMon)
                    listTemp.Add(i.solidMon);

            }

            if (OrderAt.SolidKop != 0)
                listTemp.Add(OrderAt.SolidKop);


            OrderAt.customerSolidGen = 0;
            foreach (double i in listTemp)
            {
                OrderAt.customerSolidGen += i;

            }
            if (OrderAt.customerClassWre != null)
                OrderAt.customerSolidGen += GenCe;
            db.Entry(OrderAt).State = EntityState.Modified;
            list = db.Orders.ToList();
            Grid.ItemsSource = list;
            db.SaveChanges();

        }
        private void myCmb_LoadedCros(object sender, RoutedEventArgs e)
        {
            List<string> listTemp = new List<string>();
            List<Crosse> listCustC;
            cmb = (ComboBox)sender;
            listCustC = db.Crosses.ToList();

            foreach (Crosse i in listCustC)
            {
                listTemp.Add(i.classCros);
            }
            cmb.ItemsSource = listTemp;

        }
        private bool UserSeriesChange;
        private void comboBox1_DropDownOpened(object sender, EventArgs e)
        {
            UserSeriesChange = true;
        }
        private void ComboBox_Selectedwthe(object sender, SelectionChangedEventArgs e)
        {
            if (UserSeriesChange == false) 
            {
                return;
            }
            var comboBox = (ComboBox)sender;
            list = db.Orders.ToList();
            Order order = Grid.SelectedItem as Order;
            string SelectComb = comboBox.SelectedItem.ToString();
            if (order != null)
            {
                order.customerBrand = SelectComb;
                db.Entry(order).State = EntityState.Modified;
                db.SaveChanges();
            }
            Popup myPopup = new Popup();
            myPopup.PlacementTarget = comboBox;
            myPopup.Placement = PlacementMode.Top;
            myPopup.PopupAnimation = PopupAnimation.Slide;
            myPopup.AllowsTransparency = true;

            ListBox popupText = new ListBox();

            Image imag = new Image();
            List<string> ListTemp = new List<string>();
            List<Hearse> listWre = new List<Hearse>();
            listWre = db.Hearses.ToList();
            foreach (Hearse i in listWre)
            {
                if (i.brand == SelectComb)
                {
                    ListTemp.Add("Цена: " + i.solidHe);
                }

            }


            popupText.ItemsSource = ListTemp;
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

        private void myCmb_Loadedwrehe(object sender, RoutedEventArgs e)
        {
            List<string> listTemp = new List<string>();
            List<Hearse> listCustC;
            cmb = (ComboBox)sender;
            listCustC = db.Hearses.ToList();

            foreach (Hearse i in listCustC)
            {
                listTemp.Add(i.brand);
            }
            cmb.ItemsSource = listTemp;
        }
        private void ComboBox_SelectedtheF(object sender, SelectionChangedEventArgs e)
        {
            if (UserSeriesChange == false)
            {
                return;
            }
            list = db.Orders.ToList();

            ComboBox comboBox = (ComboBox)sender;
            string SelectThef;

            if (comboBox.SelectedItem == null) return;
            SelectThef = comboBox.SelectedItem.ToString();
            Order order = Grid.SelectedItem as Order;
            if (order != null)
            {
                order.customerOrganiz = SelectThef;
                db.Entry(order).State = EntityState.Modified;
                db.SaveChanges();
            }

            Popup myPopup = new Popup();
            myPopup.PlacementTarget = comboBox;
            myPopup.Placement = PlacementMode.Top;
            myPopup.PopupAnimation = PopupAnimation.Slide;
            myPopup.AllowsTransparency = true;

            ListBox popupText = new ListBox();

            Image imag = new Image();
            List<string> ListTemp = new List<string>();
            List<TheFuneral> listWre = new List<TheFuneral>();
            listWre = db.TheFunerals.ToList();
            //string Temp = default;
            foreach (TheFuneral i in listWre)
            {
                if (i.organiz == SelectThef)
                {
                    ListTemp.Add("Номер телефона: " + i.numPhon);
                    ListTemp.Add("Цена: " + i.solidFunr);
                }

            }


            popupText.ItemsSource = ListTemp;
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
        private void myCmb_LoadedwrehetheF(object sender, RoutedEventArgs e)
        {
            List<string> listTemp = new List<string>();
            List<TheFuneral> listCustC;
            cmb = (ComboBox)sender;
            listCustC = db.TheFunerals.ToList();

            foreach (TheFuneral i in listCustC)
            {
                listTemp.Add(i.organiz);
            }
            cmb.ItemsSource = listTemp;
        }
        private void ComboBox_SelectedMon(object sender, SelectionChangedEventArgs e)
        {
            if (UserSeriesChange == false)
            {
                return;
            }
            list = db.Orders.ToList();

            ComboBox comboBox = (ComboBox)sender;
            string Select;

            if (comboBox.SelectedItem == null) return;
            Select = comboBox.SelectedItem.ToString();
            Order order = Grid.SelectedItem as Order;
            if (order != null)
            {
                order.customerOrgMon = Select;
                db.Entry(order).State = EntityState.Modified;
                db.SaveChanges();
            }

            Popup myPopup = new Popup();
            myPopup.PlacementTarget = comboBox;
            myPopup.Placement = PlacementMode.Top;
            myPopup.PopupAnimation = PopupAnimation.Slide;
            myPopup.AllowsTransparency = true;

            ListBox popupText = new ListBox();

            Image imag = new Image();
            List<string> ListTemp = new List<string>();
            List<Monument> listWre = new List<Monument>();
            listWre = db.Monuments.ToList();
            //string Temp = default;
            foreach (Monument i in listWre)
            {
                if (i.orgMon == Select)
                {
                    ListTemp.Add("Номер телефона: " + i.numPhon);
                    ListTemp.Add("Цена: " + i.solidMon);

                }

            }


            popupText.ItemsSource = ListTemp;
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
        private void myCmb_LoadedMon(object sender, RoutedEventArgs e)
        {
            List<string> listTemp = new List<string>();
            List<Monument> listCustC;
            cmb = (ComboBox)sender;
            listCustC = db.Monuments.ToList();

            foreach (Monument i in listCustC)
            {
                listTemp.Add(i.orgMon);
            }
            cmb.ItemsSource = listTemp;
        }

        private void EvClos(object sender, RoutedEventArgs e)
        {
            DatePicker datePicker = (DatePicker)sender;
            DateTime selectDate = default;
           
            if (datePicker.SelectedDate == null) return;
            selectDate = (DateTime)datePicker.SelectedDate;
            var temp = selectDate.ToShortDateString();
            Order order = Grid.SelectedItem as Order;

            if (order == null) return;
            order.funDate = temp;
            db.Entry(order).State = EntityState.Modified;
            db.SaveChanges();


        }
        private void Faind_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < list.Count; i++) (Grid.ItemContainerGenerator.ContainerFromIndex(i) as DataGridRow).Background = null;
            bool flag = true;
            for (int i = 0; i < list.Count; i++)
                if (list[i].flo.ToLower() == Search.Text.ToLower() || Search.Text == list[i].funDate || 
                    Search.Text.ToLower() == list[i].customerSurName.ToLower()
                    || Search.Text.ToLower() == list[i].customerOrgMon.ToLower() 
                    || Search.Text.ToLower() == list[i].customerOrganiz.ToLower()
                    || Search.Text.ToLower() == list[i].customerClassWre.ToLower() 
                    || Search.Text.ToLower() == list[i].customerClassCof.ToLower()
                    || Search.Text == list[i].customerSolidGen.ToString() || Search.Text == list[i].SolidKop.ToString())
                {
                    (Grid.ItemContainerGenerator.ContainerFromIndex(i) as DataGridRow).Background = Brushes.Green;
                    flag = false;

                }
            if (flag == true) MessageBox.Show("Не найдено");

            Search.Text = null;
        }


    }
}

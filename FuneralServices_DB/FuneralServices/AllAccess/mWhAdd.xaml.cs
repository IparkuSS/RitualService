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
    /// Логика взаимодействия для mWhAdd.xaml
    /// </summary>
    public partial class mWhAdd : Window
    {
        public Order order { get; private set; }
        AppCont db;
        private List<Wreath> list;
        public mWhAdd(Order s)
        {
            InitializeComponent();
            order = s;
            this.DataContext = order;

            db = new AppCont();
            db.Wreaths.Load();
            this.DataContext = db.Wreaths.Local.ToBindingList();

            list = db.Wreaths.ToList();
            GridTwo.ItemsSource = list;
        }
        private void Accept_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
        }
        //public List<Wreath> Select()
        //{
        //    if (GridTwo.SelectedItems.Count > 0)
        //    {
               
        //        for (int i = 0; i < GridTwo.SelectedItems.Count; i++)
        //        {
        //     //     list = (List<Wreath>)GridTwo.SelectedItems[i];
        //            list.Add((Wreath)GridTwo.SelectedItems[i]);
        //        }
        //        return list;
        //    }
        //    return null;
        //}
        //public int Coun()
        //{

        //    //   int a = GridTwo.SelectedCells;
        //    if (GridTwo.SelectedItem != null)
        //    {
        //        //s = comboBox.SelectedItem.ToString();
        //        //    Wreath d = (Wreath)GridTwo.SelectedItem;

        //        list.Add((Wreath)GridTwo.SelectedItem);
        //        int Cont = default;
        //        foreach(Wreath i in list)
        //        {
        //            Cont++;
        //        }


        //    return Cont;
        //    }
        //    return 0;



        //}

        private void buttonOutCust(object sender, RoutedEventArgs e)
        {
            MenegOrder MenegOrderAt = new MenegOrder();
            MenegOrderAt.Show();
            Hide();
        }
    }
}

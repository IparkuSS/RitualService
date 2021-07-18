using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace FuneralServices
{
    public class Order
    {
        [Key]
        public int idOrder { set; get; }
        public string customerSurName { set; get; }
        public string customerClassCof { set; get; }
        public string customerClassWre { set; get; }
        public string customerClassCros { set; get; }
        public string customerBrand { set; get; }
        public string customerOrgMon { set; get; }
        public string customerOrganiz { set; get; }
        private string ViewFunr;
        public double? customerSolidGen { set; get; }
        //customerOrgMon customerOrganiz


        private string Flo, Adress;
        private string FunDate;

        public static explicit operator ComboBox(Order v)
        {
            throw new NotImplementedException();
        }

        private double solidKop;
        public double SolidKop
        {
            set { solidKop = value; }
            get { return solidKop; }
        }
        public string viewFunr
        {
            set { ViewFunr = value; }
            get { return ViewFunr; }
        }
        public string flo
        {
            set { Flo = value; }
            get { return Flo; }
        }
        public string adress
        {
            set { Adress = value; }
            get { return Adress; }
        }
        public string funDate
        {
            set { FunDate = value; }
            get { return FunDate; }
        }
        public Order()
        {

        }
        public Order(string Flo, string FunDate, string Adress, string ViewFunr)
        {
            this.Flo = Flo;
            this.FunDate = FunDate;
            this.Adress = Adress;
            this.ViewFunr = ViewFunr;
        }
    }
}

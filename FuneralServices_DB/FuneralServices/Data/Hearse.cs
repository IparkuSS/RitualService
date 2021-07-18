using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuneralServices
{
   public class Hearse
    {
        [Key]
        public int idHearse { set; get; }
        private string Brand;
        private double SolidHe;
        public string brand
        {
            set { Brand = value; }
            get { return Brand; }
        }
       
        public double solidHe
        {
            set { SolidHe = value; }
            get { return SolidHe; }
        }
        public Hearse()
        {

        }
        public Hearse(string Brand, double SolidHe)
        {
            this.Brand = Brand;
            this.SolidHe = SolidHe;
           
        }
    }
}

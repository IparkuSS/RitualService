using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuneralServices
{
    public class Coffin
    {
        [Key]
        public int idCoffin { set; get; }
        private string  ClassCof, MaterCof, ImageCoffin;
        private DateTime DateCreat;
        private double SolidCof;
        private int? CountSk;
        public string classCof
        {
            set { ClassCof = value; }
            get { return ClassCof; }
        }
        public string imageCoffin
        {
            set { ImageCoffin = value; }
            get { return ImageCoffin; }
        }
        public string materCof
        {
            set { MaterCof = value; }
            get { return MaterCof; }
        }
        public DateTime dateCreat
        {
            set { DateCreat = value; }
            get { return DateCreat; }
        }
        public double solidCof
        {
            set { SolidCof = value; }
            get { return SolidCof; }
        }
        public int? countSk
        {
            set { CountSk = value; }
            get { return CountSk; }
        }
        
        public Coffin(){}
        public Coffin(string ClassCof, string MaterCof, DateTime DateCreat, double SolidCof, int CountSk)
        {
            this.ClassCof = ClassCof;
            this.MaterCof = MaterCof;
            this.DateCreat = DateCreat;
            this.SolidCof = SolidCof;
            this.CountSk = CountSk;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuneralServices
{
    public class Crosse
    {
        [Key]
        public int idCrossed { set; get; }
        private string ClassCros, TypeCros, ImageCrosses;
        private double SolidCros;
        private int? CountSkCr;
        public string classCros
        {
            set { ClassCros = value; }
            get { return ClassCros; }
        }
        public string imageCrosses
        {
            set { ImageCrosses = value; }
            get { return ImageCrosses; }
        }
        public string typeCros
        {
            set { TypeCros = value; }
            get { return TypeCros; }
        }
        public double solidCros
        {
            set { SolidCros = value; }
            get { return SolidCros; }
        }
        public int? countSkCr
        {
            set { CountSkCr = value; }
            get { return CountSkCr; }
        }
        public Crosse() { }      
        public Crosse(string ClassCros, string TypeCros, double SolidCros,int CountSkCr)
        {
            this.ClassCros = ClassCros;
            this.TypeCros = TypeCros;
            this.SolidCros = SolidCros;
            this.CountSkCr = CountSkCr;
        }
    }
}

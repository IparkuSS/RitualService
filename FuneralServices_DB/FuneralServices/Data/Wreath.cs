using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace FuneralServices
{
    public class Wreath
    {
        [Key]
        public int idWreath { set; get; }
        private string ClassWre, TypeWrea, ImageCh, TypeV;
        //private int? SkladKol;
        private double Solid;
        //private Image ImageWreaths;
        //public Image imageWreaths
        //{
        //    set { ImageWreaths = value; }
        //    get { return ImageWreaths; }
        //}
        public string typeV
        {
            set { TypeV = value; }
            get { return TypeV; }
        }
        public string classWre
        {
            set { ClassWre = value; }
            get { return ClassWre; }
        }
        public string imageCh
        {
            set { ImageCh = value; }
            get { return ImageCh; }
        }
        public string typeWrea
        {
            set { TypeWrea = value; }
            get { return TypeWrea; }
        }
        public double solid
        {
            set { Solid = value; }
            get { return Solid; }
        }
        //public int? skladKol
        //{
        //    set { SkladKol = value; }
        //    get { return SkladKol; }
        //}
        public Wreath()
        {

        }
        public Wreath(string ClassWre, string TypeWrea, double Solid, string TypeV/*Image ImageWreaths*/)
        {
            this.ClassWre = ClassWre;
            this.TypeWrea = TypeWrea;
            this.Solid = Solid;
            this.TypeV = TypeV;
            //            this.SkladKol = SkladKol;
            //this.ImageWreaths = ImageWreaths;
        }

    }
}

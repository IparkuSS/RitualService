using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuneralServices
{
    public class TheFuneral
    {
        [Key]
        public int idTheFuneral { set; get; }
        private string Organiz, NumPhon;
        private double SolidFunr;
        public string numPhon
        {
            set { NumPhon = value; }
            get { return NumPhon; }
        }
        public string organiz
        {
            set { Organiz = value; }
            get { return Organiz; }
        }
        
        public double solidFunr
        {
            set { SolidFunr = value; }
            get { return SolidFunr; }
        }

        public TheFuneral()
        {

        }
        public TheFuneral(string Organiz, double SolidFunr)
        {
            this.Organiz = Organiz;
            this.SolidFunr = SolidFunr;
         
        }
    }
}

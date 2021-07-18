using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuneralServices
{
   public class FuneralC
    {
        [Key]
        public int idFuneralC { set; get; }
        public int id_Workers { set; get; }
        public int id_Order { set; get; }
        public string OrderFSurNameWorker { set; get; }
        
        public string OrderFunDate { set; get; }
        private int KlWorker;
        private DateTime TimeFun;
   //     private decimal SolidKop;
        public int klWorker
        {
            set { KlWorker = value; }
            get { return KlWorker; }
        }
        public DateTime timeFun
        {
            set { TimeFun = value; }
            get { return TimeFun; }
        }
        //public decimal solidKop
        //{
        //    set { SolidKop = value; }
        //    get { return SolidKop; }
        //}

        public FuneralC()
        {

        }
        public FuneralC(int KlWorker, DateTime TimeFun /*decimal SolidKop*/)
        {
            this.KlWorker = KlWorker;
            this.TimeFun = TimeFun;
            //this.SolidKop = SolidKop;
        }
    }
}

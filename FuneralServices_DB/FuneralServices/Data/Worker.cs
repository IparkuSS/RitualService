using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuneralServices
{
    public class Worker
    {
        [Key]
        public int idWorker { set; get; }
        private string NameWorker, SurNameWorker, PartWorker, NumberTelWorker;







        public string nameWorker
        {
            set { NameWorker = value; }
            get { return NameWorker; }
        }
        public string surNameWorker
        {
            set { SurNameWorker = value; }
            get { return SurNameWorker; }
        }
        public string partWorker
        {
            set { PartWorker = value; }
            get { return PartWorker; }
        }
        public string numberTelWorker
        {
            set { NumberTelWorker = value; }
            get { return NumberTelWorker; }
        }
        public Worker()
        {

        }
        public Worker(string NameWorker, string SurNameWorker, string PartWorker, string numberTelWorker)
        {
            this.NameWorker = NameWorker;
            this.SurNameWorker = SurNameWorker;
            this.PartWorker = PartWorker;
            this.numberTelWorker = numberTelWorker;
           
        }
    }
}

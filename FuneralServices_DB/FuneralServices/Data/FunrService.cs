using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuneralServices
{
    public class FunrService
    {
        [Key]
        public int idFunrServices { set; get; }
        private int id_FuneralCs, id_TheFuneral, id_Hearse, id_Monument;
        public int hearse
        {
            set { id_Hearse = value; }
            get { return id_Hearse; }
        }
        public int monument
        {
            set { id_Monument = value; }
            get { return id_Monument; }
        }
        public int funeral
        {
            set { id_FuneralCs = value; }
            get { return id_FuneralCs; }
        }
        public int theFuneral
        {
            set { id_TheFuneral = value; }
            get { return id_TheFuneral; }
        }


        public FunrService()
        {

        }
        public FunrService(int id_Hearse, int id_Monument, int id_FuneralCs, int id_TheFuneral)
        {
            this.id_Hearse = id_Hearse;
            this.id_Monument = id_Monument;
            this.id_FuneralCs = id_FuneralCs;
            this.id_TheFuneral = id_TheFuneral;
        }
    }
}

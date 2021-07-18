using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuneralServices
{
   public class RitualGod
    {
        [Key]
        public int idRitualGod { set; get; }
        private int id_Wreaths, id_Crossed, id_Coffins;
        public int wreath
        {
            set { id_Wreaths = value; }
            get { return id_Wreaths; }
        }
        public int coffin
        {
            set { id_Coffins = value; }
            get { return id_Coffins; }
        }
        public int cross
        {
            set { id_Crossed = value; }
            get { return id_Crossed; }
        }
      
        public RitualGod()
        {

        }
        public RitualGod(int id_Wreaths, int id_Coffins, int id_Crossed)
        {
            this.id_Wreaths = id_Wreaths;
            this.id_Coffins = id_Coffins;
            this.id_Crossed = id_Crossed;
        }



    }
}

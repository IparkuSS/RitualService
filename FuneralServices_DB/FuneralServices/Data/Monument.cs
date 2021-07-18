using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuneralServices
{
    public class Monument
    {
        [Key]
        public int idMonument { set; get; }
        private string OrgMon, NumPhon;
        private double SolidMon;
        public string numPhon
        {
            set { NumPhon = value; }
            get { return NumPhon; }
        }
        public string orgMon
        {
            set { OrgMon = value; }
            get { return OrgMon; }
        }
        public double solidMon
        {
            set { SolidMon = value; }
            get { return SolidMon; }
        }
        public Monument()
        {

        }
        public Monument(string OrgMon, double SolidMon)
        {
            this.OrgMon = OrgMon;
            this.SolidMon = SolidMon;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuneralServices
{
   public class Customer
    {
        [Key]
        public int idCustomer { set; get; }
        private string Name, SurName,Part,Addres,PhoneNumber;
      //  public List<string> listKl { set; get; }
        public string name
        {
            set { Name = value; }
            get { return Name; }
        }
        public string surName
        {
            set { SurName = value; }
            get { return SurName; }
        }
        public string part
        {
            set { Part = value; }
            get { return Part; }
        }
        public string addres
        {
            set { Addres = value; }
            get { return Addres; }
        }
        public string phoneNumber
        {
            set { PhoneNumber = value; }
            get { return PhoneNumber; }
        }
      



        public Customer()
        {

        }
        public Customer(string Name, string SurName, string Part, string Addres, string PhoneNumber)
        {
            this.Name = Name;
            this.SurName = SurName;
            this.Part = Part;
            this.Addres = Addres;
            this.PhoneNumber = PhoneNumber;

        }
    }
}

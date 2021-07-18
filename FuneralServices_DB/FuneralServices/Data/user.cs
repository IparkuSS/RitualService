using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuneralServices
{
    class user
    {
     
        public int Id { set; get; }
        private string Login, Pass, Role, Name, SurName;




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
 





        public string login
        {
            set { Login = value; }
            get { return Login; }
        }
        public string role
        {
            set { Role = value; }
            get { return Role; }
        }
        public string pass
        {
            set { Pass = value; }
            get { return Pass; }
        }
        public user()
        {

        }
        public user(string Login, string Pass, string Role, string Name,string SurName)
        {
            this.Login = Login;
            this.Pass = Pass;
            this.Role = Role;
            this.Name = Name;
            this.SurName = SurName;
           

        }

    }
}

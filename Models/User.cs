using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Models
{
    class User
    {

        public int Id;
        public string FirstName;
        public string LastName;
        public string Old;
        public string Salary;
        public string Tax;

        public User()
        {
        }

        public User(int id, string FirsName, string LastName, string Old, string Salary, string Tax)
        {
            this.Id = id;
            this.FirstName = FirsName;
            this.LastName = LastName;
            this.Old = Old;
            this.Salary = Salary;
            this.Tax = Tax;
        }
    }
   
}

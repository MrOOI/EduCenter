using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edu
{
    class Teacher
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Subject { get; set; }
        public string Level { get; set; }
        private int Money { get; set; }

        public Teacher()
        {

        }

        public Teacher(string firstname, string lastname, string subject, string level)
        {
            this.FirstName = firstname;
            this.LastName = lastname;
            this.Level = level;
            this.Subject = subject;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppWin2.NewFolder
{
    class Teacher
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Subject { get; set; }
        public string Level { get; set; }
        public int Id { get; set; }

        public Teacher()
        {

        }

        public Teacher(string firstname, string lastname, string subject, string level, int id )
        {
            this.FirstName = firstname;
            this.LastName = lastname;
            this.Level = level;
            this.Subject = subject;
            this.Id = id;
        }
    }
}

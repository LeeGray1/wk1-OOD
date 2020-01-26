using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q1
{
    class Members
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public Members()
        {

        }

        public Members(string FName, string LName)
        {
            FirstName = FName;
            LastName = LName;
        }
    }
}

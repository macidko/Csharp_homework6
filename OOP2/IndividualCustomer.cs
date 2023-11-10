using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    //miras - inheritance
    internal class IndividualCustomer:Customer
    {
        public string IdentityNumber { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
    }
}

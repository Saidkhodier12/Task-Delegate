using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_One;
internal class Customer
{
    public string Name { get; set; }
    public string Mobile { get; set; }
    public string Email { get; set; }

    public Customer(string name, string mobile, string email)
    {
        Name = name;
        Mobile = mobile;
        Email = email;
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class User
    {
        public int MyProperty { get; }

        readonly string name = "test";
        //Constructor
        public User()
        {
            name = "Bharath";
            //Logic
        }
        public string getUsername()
        {           
            return name;
            //logic
        }
    }
}

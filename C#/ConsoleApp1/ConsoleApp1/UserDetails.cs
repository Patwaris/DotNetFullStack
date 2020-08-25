using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class UserDetails:UserData
    {
        public int Age;
        public UserDetails()
        {
            Console.WriteLine("Child Class Constructor");
            Console.ReadLine();
        }
        public void GetAge()
        {            
            Console.WriteLine("Age:" + Age);
            Console.ReadLine();
        }
    }
}

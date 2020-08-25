using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class InheritanceDemo
    {
    }

    public class UserData
    {
        public string Name;
        public string FatherName;

        public UserData()
        {
            Console.WriteLine("Base class Constructor");
        }
        public void GetUserInfo(string name)
        {
            Name = name;
            Console.WriteLine("Name:" + Name);
            Console.ReadLine();
        }        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class MultiLevelInheritance
    {
        public class A
        {
            public string Name;
            public void GetName()
            {
                Console.WriteLine("Name: {0}", Name);
                Console.ReadLine();
            }
        }

        public class B : A
        {
            public string Location;
            public void GetLocation()
            {
                Console.WriteLine("Location: {0}", Location);
                Console.ReadLine();
            }
        }

        public class C : B
        {
            public int Age;
            public void GetAge()
            {
                Console.WriteLine("Age: {0}", Age);
                Console.ReadLine();
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Polymorphism
    {
        // Compile Time Polymorphism
        public void AddNumbers(int a, int b)
        {
            //Add
            Console.WriteLine(a + b);
            Console.ReadLine();
        }
        public void AddNumbers(int a, int b, int c)
        {
            //Add
            Console.WriteLine(a + b + c);
            Console.ReadLine();
        }


        //Run Time Polymorphism

        public class AClass
        {
            public virtual void GetLoanInfo()
            {
                Console.WriteLine("This method gets the data from Oracle Database");
                Console.WriteLine();
            }
        }

        public class BClass : AClass
        {
            public override void GetLoanInfo()
            {
                Console.WriteLine("This method gets the data from SQL Database");
                Console.WriteLine();
            }
        }
    }
}

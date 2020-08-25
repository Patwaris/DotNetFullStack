using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class EncapsulationDemo
    {
        private int x;
        public int getX()
        {
            return x;
        }
        public void setX(int x)
        {
            if (x > 0)
            {
                this.x = x;
            }
            else
            {
                Console.WriteLine("Please Pass a positive value");
            }
        }
    }
    
}

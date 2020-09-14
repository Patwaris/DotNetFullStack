using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class AbstractClassDemo
    {
        abstract class UserInfo
        {
            abstract public void GetUserIfo(string userName);          
        }
        class User : UserInfo
        {
            public override void GetUserIfo(string userName)
            {
                //Get user info from data source 1 
                Console.WriteLine("got the data from AD-ENT");
            }
        }
    }
}

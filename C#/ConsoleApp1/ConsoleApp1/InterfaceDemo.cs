using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    interface InterfaceDemo
    {
        void GetDetails(string uId);      
    }
    interface IUser
    {
        void getUserId(int uId);
    }
    class UserInformation : InterfaceDemo,IUser
    {
        public void GetDetails(string uId)
        {
            Console.WriteLine("Test1");
        }

        public void getUserId(int uId)
        {
            Console.WriteLine("Test2");
        }

    }

}

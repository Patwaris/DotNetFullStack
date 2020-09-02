using System;
using static ConsoleApp1.MultiLevelInheritance;
using static ConsoleApp1.Polymorphism;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //******EXCEPTION HANDLING CODE  **********************************

            //try
            //{                
            //    //Code
            //    int i = 0;
            //    int j = 10;
            //    Console.WriteLine(j / i);
            //    Console.ReadLine();               
            //}
            //catch(DivideByZeroException ex)
            //{
            //    Console.WriteLine("Error" + ex.Message + " Stack Trace");
            //    Console.ReadLine();
            //}
            //catch (Exception objex)
            //{
            //    //Code                
            //    Console.WriteLine("Error" + objex.Message  + " Stack Trace");
            //    Console.ReadLine();
            //}
            //finally
            //{                
            //    //code
            //}

            //******ACCESS MODIFIERS CODE  **********************************

            //AccessModifiers objAcc = new AccessModifiers();
            //objAcc.GetEmpName();


            //******ENCAPSULATION *******************************************

            //EncapsulationDemo e = new EncapsulationDemo();            
            //e.setX(-50);
            //Console.WriteLine(e.getX());          
            //Console.ReadKey();

            //****CONSTRUCTOR ***********************************************

            //User objuser = new User();
            //objuser.getUsername();

            //***INHERITANCE *************************************************

            //UserDetails objUdetails = new UserDetails();
            //objUdetails.Name = "Bharath P";

            //objUdetails.Age = 34;
            //objUdetails.GetUserInfo("Test");
            //objUdetails.GetAge();

            //******MULTILEVEL INHERITANCE **********************************

            //C objc = new C();
            //objc.Name = "Bharath";
            //objc.Location = "Hyderabad";
            //objc.Age = 34;
            //objc.GetName();
            //objc.GetLocation();
            //objc.GetAge();


            //********POLYMORPHISM - COMPILE TIME******************************************
            //Polymorphism objPoly = new Polymorphism();
            //objPoly.AddNumbers(5, 6,8);

            //***********POLYMORPHISM - RUN TIME******************************************
            //BClass objB = new BClass();
            //objB.GetLoanInfo();

            //AClass objA = new AClass();
            //objA.GetLoanInfo();


            //ARRAYS*****FOR LOOP********FOR EACH********WHILE******************

            // type[] arraname;
            string[] data = new string[2] { "Test1", "Test2" };

            for (int i = 1; i < data.Length; i++)
            {
                Console.WriteLine(data[i]);
                Console.ReadLine();
            }


            //foreach (var item in data)
            //{
            //    Console.WriteLine(item);
            //    Console.ReadLine();
            //}


            //int i = 0;
            //while (i <= data.Length)
            //{
            //    Console.WriteLine(i);
            //    Console.ReadLine();
            //    i++;
            //}
        }
    }
}




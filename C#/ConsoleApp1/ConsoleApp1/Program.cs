using System;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {            
            try
            {                
                //Code
                int i = 0;
                int j = 10;
                Console.WriteLine(j / i);
                Console.ReadLine();               
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine("Error" + ex.Message + " Stack Trace");
                Console.ReadLine();
            }
            catch (Exception objex)
            {
                //Code                
                Console.WriteLine("Error" + objex.Message  + " Stack Trace");
                Console.ReadLine();
            }
            finally
            {                
                //code
            }

        }
    }
}

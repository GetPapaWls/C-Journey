using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int Num;
            Console.WriteLine("Tell us a number(1-9)");
            Num = Convert.ToInt32(Console.ReadLine());
           
            
                switch (Num)
                {
                    case 1:
                        Console.WriteLine("a");
                        break;
                    case 2:
                        Console.WriteLine("b");
                        break;
                    case 3:
                        Console.WriteLine("c");
                        break;
                    case 4:
                        Console.WriteLine("d");
                        break;

                    case 5:

                        Console.WriteLine("e");

                        break;
                    case 6:
                        Console.WriteLine("f");
                        break;
                    case 7:
                        Console.WriteLine("g");
                        break;

                    case 8:
                        Console.WriteLine("h");
                        break;
                    case 9:
                        Console.WriteLine("i");
                        break;
                    default:
                        Console.WriteLine("It doesnt exist");
                        break;
                }
            }
             catch(Exception e)
             {
                Console.WriteLine(e.Message);
             }
                        
                  
               
            
            
        }
      
      
    }
}

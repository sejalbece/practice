using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string"); 
            string s1 = Console.ReadLine();
            string temp = s1;
            s1 = s1.Replace(" ", string.Empty);
            Console.WriteLine($"The original string is: {temp}");
            
            while (s1.Length > 0)
            {
                Console.Write(s1[0] + " : ");
                int count = 0;
                for (int i = 0; i < s1.Length; i++)
                {
                    if (s1[0] == s1[i])
                    { 
                        count++;
                    }                    
                }
                Console.WriteLine(count);
                s1 = s1.Replace(s1[0].ToString(), string.Empty);

            }    

            
            
           

            Console.ReadLine();
        }
    }
}

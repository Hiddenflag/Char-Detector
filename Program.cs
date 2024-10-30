using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //double man;
            //Console.WriteLine("Hello & Welcome To The Auto Calculator. Please Enter the Radius Of the Circle...");
            //double r = Convert.ToDouble(Console.ReadLine());
            
            //double P = 2 * r * Math.PI;
            //double S = r*r * Math.PI;
            //Console.WriteLine("The Perimeter is : {0:N3}" , P);
            //Console.WriteLine("The Area is : {0:N3}", S);
            //Console.WriteLine("<<<<<<<<<<<<<<<<>>>>>>>>>>>>>>>>>>>>>>>");

            //bool l = Math.Equals(P,S);
            //if (l == false)
            //{
            //    Console.WriteLine("Sike,That's The Wrong Number!");
            //}

            //Console.WriteLine("<<<<<<<<<<<<<<<<>>>>>>>>>>>>>>>>>>>>>>>");

            //Console.WriteLine(Math.Sign(P));

            //Console.WriteLine("<<<<<<<<<<<<<<<<>>>>>>>>>>>>>>>>>>>>>>>");
            //int ra = 2;
            //int rb = 4;

            //Console.WriteLine(ra % rb);
            //Console.WriteLine("<<<<<<<<<<<<<<<<>>>>>>>>>>>>>>>>>>>>>>>");

            //ra += rb;
            //Console.WriteLine(ra);
            //int rw= 2;
            //Console.WriteLine(rw -=rb);
            //Console.WriteLine("<<<<<<<<<<<<<<<<>>>>>>>>>>>>>>>>>>>>>>>");
            char ch = Console.ReadKey().KeyChar;
            Console.WriteLine();
            if ((ch >= '0') && (ch <= '9'))
            {
                Console.WriteLine("Digit!");

            }
            else if ((ch >= 'a') && (ch <= 'z'))
            {
                Console.WriteLine("Lower Case Character");
            }
            else if ((ch >= 'A') && (ch <= 'Z'))
            {
                Console.WriteLine("Upper Case Character");
            }
            else if ((ch == 'a') || (ch == 'e') || (ch == 'o') || (ch =='i') || (ch =='u') || (ch == 'A') || (ch == 'E') || (ch == 'O') || (ch == 'I') || (ch == 'U'))
            {
                Console.WriteLine("Vowel");
            }
            else
            {
                Console.WriteLine("Symbol");
            }

            Console.WriteLine("<<<<<<<<<<<<<<<<>>>>>>>>>>>>>>>>>>>>>>>");

            
            Console.ReadKey();
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 

namespace С_sharp_lesson_3
{
    class franction
    {
        //access modif
        public int numerator { get; set; }
        public int denominator { get; set; }

        
        //ctor
        public franction(int val1,int val2)
        {
            numerator = val1;
            if(val2 != 0) denominator = val2;
            else {
                Console.WriteLine("Error!You can't divide to 0!");
                denominator = 1;
            }
        }
        public franction() : this(1,1) { }
        // operator +
        public static franction operator +(franction a,franction b)
        {
            franction var = new franction();
            var.numerator = a.numerator * b.denominator + a.denominator * b.numerator;
            var.denominator = a.denominator * b.denominator;
            return var;
        }
        // operator -
        public static franction operator -(franction a, franction b)
        {
            franction var = new franction();
            var.numerator = a.numerator * b.denominator - a.denominator * b.numerator;
            var.denominator = a.denominator * b.denominator;
            return var;
        }
        // operator *
        public static franction operator *(franction a, franction b)
        {
            franction var = new franction();
            var.numerator = a.numerator * b.numerator;
            var.denominator = a.denominator * b.denominator;
            return var;
        }
        // operator /
        public static franction operator /(franction a, franction b)
        {
            franction var = new franction();
            var.numerator = a.numerator * b.denominator;
            var.denominator = a.denominator * b.numerator;
            return var;
        }
        // ==
        public static bool operator ==(franction a,franction b)
        {
            if((a.numerator == b.numerator) && (a.denominator == b.denominator)) return true;
            else return false;
        }
        // !=
        public static bool operator !=(franction a,franction b)
        {
            if((a.numerator != b.numerator) || (a.denominator != b.denominator)) return true;
            else return false;
        }
        // ToString
        public override string ToString() => $"{numerator}\n--\n{denominator} ";
    }
    internal class Program
    {

        static void Main(string[] args)
        {
            int a1, a2, b1, b2;
            Console.WriteLine("Enter numerator of first fraction : ");
            Int32.TryParse(Console.ReadLine(),out a1);

            Console.WriteLine("Enter denominator of first fraction : ");
            Int32.TryParse(Console.ReadLine(),out a2);

            Console.WriteLine("Enter numerator of second fraction : ");
            Int32.TryParse(Console.ReadLine(),out b1);
           
            Console.WriteLine("Enter denominator of second fraction : ");
            Int32.TryParse(Console.ReadLine(),out b2);


            franction a = new franction(a1,a2);
            franction b = new franction(b1,b2);
            franction c = new franction();
            // +
            Console.WriteLine($"{a1}    {b1}\n-- + -- = \n{a2}    {b2}");    
            c = a + b;
            Console.WriteLine($"Result :\n{c.ToString()}\n-------------------------------------------------");  
            
            // -
            Console.WriteLine($"{a1}    {b1}\n-- - -- = \n{a2}    {b2}");    
            c = a - b;
            Console.WriteLine($"Result :\n{c.ToString()}\n-------------------------------------------------");   
            
            // *
            Console.WriteLine($"{a1}    {b1}\n-- * -- = \n{a2}    {b2}");    
            c = a * b;
            Console.WriteLine($"Result :\n{c.ToString()}\n-------------------------------------------------");

            // /
            Console.WriteLine($"{a1}    {b1}\n-- / -- = \n{a2}    {b2}");    
            c = a / b;
            Console.WriteLine($"Result :\n{c.ToString()}\n-------------------------------------------------");

            // ==
            Console.WriteLine($"{a1}    {b1}\n-- == --  \n{a2}    {b2}");   
            Console.WriteLine($"Result : {a==b}\n-------------------------------------------------");

            // !=
            Console.WriteLine($"{a1}    {b1}\n-- != --  \n{a2}    {b2}");   
            Console.WriteLine($"Result : {a!=b}");
        }
    }
}

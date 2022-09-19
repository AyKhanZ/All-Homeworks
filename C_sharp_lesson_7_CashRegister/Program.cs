using System;
using System.Net;
using System.Text;
using System.Text.Json;

namespace CashRegister
{
    public class CashRegister
    {
        public static void Main()
        {
            Console.WriteLine("Enter count of money for converting: ");
            int money = Convert.ToInt32(Console.ReadLine());
            var result = new CurrentService(money);
            result.ShowResult();
            
        }
    }

}

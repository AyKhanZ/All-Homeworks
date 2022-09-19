using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace CashRegister
{
    internal class CurrentService
    {
        public enum valuts { AZN = 0 , EUR , RUB , TRY  }
        private CashRegisterService cashRegisterService = new CashRegisterService();
        private Rootobject JsonContent;
        public CurrentService(int CountOfMoney) {
            string date = "2022-09-19 03:39:09";
            JsonContent = JsonSerializer.Deserialize<Rootobject>(cashRegisterService.GetCashRegister());
            JsonContent.ms = CountOfMoney;
            JsonContent._base = "USD";
            JsonContent.updated = date;
        }
        public void ShowResult()
        {
            Console.WriteLine($"Enter valut for converting from {JsonContent._base}");
            Console.WriteLine("\nAZN = \'0\'" +
                              "\nEUR = \'1\'" +
                              "\nRUB = \'2\'" +
                              "\nTRY = \'3\'");
            int input = Convert.ToInt32(Console.ReadLine());
            switch (input) {
                case (int)valuts.AZN:
                    Console.WriteLine($"{JsonContent.ms} {JsonContent._base} to AZN: {Math.Round((JsonContent.ms * JsonContent.results.AZN),2)}");
                    break;

                case (int)valuts.TRY:
                    Console.WriteLine($"{JsonContent.ms} {JsonContent._base} to TRY: {Math.Round((JsonContent.ms * JsonContent.results.TRY),2)}");
                    break;

                case (int)valuts.EUR:
                    Console.WriteLine($"{JsonContent.ms} {JsonContent._base} to EUR: {Math.Round((JsonContent.ms * JsonContent.results.EUR),2)}");
                    break;

                case (int)valuts.RUB:
                    Console.WriteLine($"{JsonContent.ms} {JsonContent._base} to RUB: {Math.Round((JsonContent.ms * JsonContent.results.RUB),2)}");
                    break;
                
            }

        }

    } 
}

    

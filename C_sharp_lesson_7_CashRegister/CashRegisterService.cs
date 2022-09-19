using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CashRegister
{
    public class CashRegisterService
    {
        private string api_key = "7293cf1933-24c89c6264-riftbb";
        public string GetCashRegister()
        {
            string url = $"https://api.fastforex.io/fetch-all?api_key={api_key}";

            WebClient client_ = new();

            var result = client_.DownloadString(url);
            return result;
        }
    }
}

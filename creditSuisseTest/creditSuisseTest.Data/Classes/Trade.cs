using System;
namespace creditSuisseTest.Data.Classes
{
    public class Trade
    {
        public double Value { get; set; }
        public string ClientSector { get; set; }
        public DateTime NextPaymentDate { get; set; }


        public Trade()
        {
        }


    }
}

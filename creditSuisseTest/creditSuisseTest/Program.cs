using System;
using creditSuisseTest.Data.Classes;
using creditSuisseTest.Data.Interfaces;

namespace creditSuisseTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Trade trade = new Trade();

            Console.WriteLine("Input NextPaymentDate:");
            trade.NextPaymentDate = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine("Input Value:");
            trade.Value = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Input ClientSector:");
            trade.ClientSector = Console.ReadLine();

            TradeTransaction tradeTransaction = new TradeTransaction();

            Console.WriteLine(tradeTransaction.GetCategory(trade));

        }
    }
}

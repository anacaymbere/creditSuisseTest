using System;
using System.Collections.Generic;
using creditSuisseTest.Data.Classes;
using creditSuisseTest.Data.Interfaces;

namespace creditSuisseTest
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                Trade trade = new Trade();

                Console.WriteLine("Input the date reference:");
                DateTime dateRef = Convert.ToDateTime(Console.ReadLine());

                Console.WriteLine("Input the number of trades:");
                int qntTrades = Convert.ToInt32(Console.ReadLine());

                List<string> portifolio = new List<string>();

                for (int qntTradesProces = 0; qntTradesProces < qntTrades; qntTradesProces ++)
                 {
                    Console.WriteLine("Input NextPaymentDate:");
                    trade.NextPaymentDate = Convert.ToDateTime(Console.ReadLine());

                    Console.WriteLine("Input Value:");
                    trade.Value = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Input ClientSector:");
                    trade.ClientSector = Console.ReadLine();

                    TradeTransaction tradeTransaction = new TradeTransaction();

                    portifolio.Add(tradeTransaction.GetCategory(trade));
                 }

                Console.WriteLine("-----------------");

                foreach (var item in portifolio)
                {
                    
                    Console.WriteLine(item);
                }

            }

            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}

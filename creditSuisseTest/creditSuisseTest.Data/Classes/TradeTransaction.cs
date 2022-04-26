using creditSuisseTest.Data.Interfaces;
using System;
namespace creditSuisseTest.Data.Classes
{
    public class TradeTransaction : ITradeTransaction
    {
        public TradeTransaction()
        {

        }

        public string GetCategory(Trade trade)
        {
            try
            {
                Category category = new Category();

                if (trade.NextPaymentDate < DateTime.Now.AddDays(-30))
                    return category.Expired;

                if ((trade.Value > 1000000.00) && (trade.ClientSector.Equals("Private")))
                    return category.Highrisk;

                if ((trade.Value > 1000000.00) && (trade.ClientSector.Equals("Public")))
                    return category.Mediumrisk;

                return "No category found!";
            }

            catch (Exception ex)
            {
                return "Error: " + ex.Message;
            }


        }
    }
}

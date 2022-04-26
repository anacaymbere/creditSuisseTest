using System;
using creditSuisseTest.Data.Classes;
namespace creditSuisseTest.Data.Interfaces
{
    public interface ITradeTransaction
    {
        string GetCategory(Trade trade);

    }
}

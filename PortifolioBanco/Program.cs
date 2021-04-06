using System;
using System.Collections.Generic;

namespace PortifolioBanco
{
    class Program
    {
        static void Main(string[] args)
        {
            var Trade1 = new Trade { Value = 2000000, ClientSector = "Private"};
            var Trade2 = new Trade { Value = 400000, ClientSector = "Public"};
            var Trade3 = new Trade { Value = 500000, ClientSector = "Public"};
            var Trade4 = new Trade { Value = 3000000, ClientSector = "Public"};

            List<ITrade> portfolio = new List<ITrade>(){ Trade1, Trade2, Trade3, Trade4 };
            List<string> tradeCategories = new List<string>();

            ICalculateCategory calculate = new CalculateCategory();

            foreach (var item in portfolio)
            {
                var category = calculate.Category(item);
                Console.WriteLine($@"{item} --> Category = {category}");
                tradeCategories.Add(category);
            }
        }
    }
}
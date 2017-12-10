using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsumableBuy
{
    internal class EaMath
    {
        internal int AveragePrice(List<int> list)
        {
            var avgPriceList = new List<int>();
            for (var k = 0; k < 3; k++)
            {
                var maximum = 100000;
                var currentIdentifier = -1;
                for (var i = 0; i < list.Count; i++)
                {
                    if (list[i] >= maximum) continue;
                    maximum = list[i];
                    currentIdentifier = i;
                }
                try
                {
                    avgPriceList.Add(maximum);
                    list.RemoveAt(currentIdentifier);
                }
                catch (Exception)
                {
                    return 0;
                }
            }
            return Convert.ToInt32(avgPriceList.Average());
        }
    }
}

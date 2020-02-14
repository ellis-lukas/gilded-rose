using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRoseFirstRewrite
{
    public class SellInUpdater
    {
        public static void DecrementSellInByOne(Item item)
        {
            item.SellIn -= 1;
        }
    }
}

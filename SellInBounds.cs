using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRoseFirstRewrite
{
    public class SellInBounds
    {
        public static bool SellByDatePassed(Item item)
        {
            return item.SellIn < 0;
        }
    }
}

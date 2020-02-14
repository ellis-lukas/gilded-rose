using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRoseFirstRewrite
{
    public class QualityUpdater
    {
        public static void IncrementQualityByOne(Item item)
        {
            item.Quality += 1;
        }

        public static void DecrementQualityByOne(Item item)
        {
            item.Quality -= 1;
        }
    }
}

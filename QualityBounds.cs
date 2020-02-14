using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRoseFirstRewrite
{
    public class QualityBounds
    {
        public const int Maximum = 50;

        public const int Minimum = 0;

        public static bool QualityLessThanMaximum(Item item)
        {
            return item.Quality < Maximum;
        }

        public static bool QualityGreaterThanMinimum(Item item)
        {
            return item.Quality > Minimum;
        }
    }
}

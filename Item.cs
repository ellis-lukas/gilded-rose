using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("GildedRoseFirstRewrite.UnitTests")]

namespace GildedRoseFirstRewrite
{
    public class Item
    {
        public string Name { get; set; }

        public int SellIn { get; set; }

        public int Quality { get; set; }
    }
}

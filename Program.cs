using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

[assembly: InternalsVisibleTo("GildedRoseFirstRewrite.UnitTests")]

namespace GildedRoseFirstRewrite
{
    partial class Program
    {
        static void Main()
        {
            PrintItems();
            Console.WriteLine();

            int numberOfUpdate = 24;

            for (int i = 1; i <= numberOfUpdate; i++)
            {
                Console.WriteLine($"Update {i}");
                UpdateQuality(Items);
                PrintItems();
                Console.WriteLine();
            }

            Console.Read();
        }

        private static void UpdateQuality(IList<Item> items)
        {
            ItemsUpdater.Update(items);
        }

        static void PrintItems()
        {
            foreach (Item item in Items)
            {
                Console.WriteLine($"Name: {item.Name}, Quality: {item.Quality}, SellIn: {item.SellIn}");
            }
        }

        static IList<Item> Items = new List<Item>
            {
                new Item { Name = "+5 Dexterity Vest", SellIn = 10, Quality = 20 },
                new Item { Name = "Aged Brie", SellIn = 2, Quality = 0 },
                new Item { Name = "Elixir of the Mongoose", SellIn = 5, Quality = 7 },
                new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 80 },
                new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 15, Quality = 20 }
            };
    }
}

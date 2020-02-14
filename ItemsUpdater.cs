using GildedRoseFirstRewrite.ItemUpdaters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static GildedRoseFirstRewrite.Program;

namespace GildedRoseFirstRewrite
{
    public class ItemsUpdater
    {
        public static void Update(IList<Item> items)
        {
            for (var i = 0; i < items.Count; i++)
            {
                Item item = items[i];

                IItemUpdater itemUpdater = new ItemUpdaterFactory().GetFactory(item);

                itemUpdater.Update(item);
            }
        }
    }
}

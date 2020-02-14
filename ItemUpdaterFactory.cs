using System;
using GildedRoseFirstRewrite.ItemUpdaters;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRoseFirstRewrite
{
    class ItemUpdaterFactory
    {
        public IItemUpdater GetFactory(Item item)
        {
            switch(item.Name)
            {
                case ItemNames.AgedBrie:
                    return new AgedBrieUpdater();
                case ItemNames.BackstagePasses:
                    return new BackstagePassesUpdater();
                case ItemNames.Sulfuras:
                    return new SulfurasUpdater();
                default:
                    return new NormalItemUpdater();
            }
        }
    }
}

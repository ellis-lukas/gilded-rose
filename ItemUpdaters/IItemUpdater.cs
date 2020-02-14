using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRoseFirstRewrite.ItemUpdaters
{
    public interface IItemUpdater
    {
        void Update(Item item);
    }
}

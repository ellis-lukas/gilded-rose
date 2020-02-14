using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRoseFirstRewrite.ItemUpdaters
{
    public class NormalItemUpdater : IItemUpdater
    {
        public void Update(Item item)
        {
            if (QualityBounds.QualityGreaterThanMinimum(item))
            {
                QualityUpdater.DecrementQualityByOne(item);
            }

            SellInUpdater.DecrementSellInByOne(item);

            if (SellInBounds.SellByDatePassed(item))
            {
                if (QualityBounds.QualityGreaterThanMinimum(item))
                {
                    QualityUpdater.DecrementQualityByOne(item);
                }
            }
        }
    }
}

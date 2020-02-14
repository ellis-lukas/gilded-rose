using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRoseFirstRewrite.ItemUpdaters
{
    public class AgedBrieUpdater : IItemUpdater
    {
        public void Update(Item agedBrie)
        {
            UpdateAgedBrieQuality(agedBrie);
            SellInUpdater.DecrementSellInByOne(agedBrie);

            if (SellInBounds.SellByDatePassed(agedBrie))
            {
                UpdateAgedBrieQuality(agedBrie);
            }
        }

        private void UpdateAgedBrieQuality(Item agedBrie)
        {
            if (QualityBounds.QualityLessThanMaximum(agedBrie))
            {
                QualityUpdater.IncrementQualityByOne(agedBrie);
            }
        }
    }
}

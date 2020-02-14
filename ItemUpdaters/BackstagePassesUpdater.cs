using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRoseFirstRewrite.ItemUpdaters
{
    public class BackstagePassesUpdater : IItemUpdater
    {
        public void Update(Item backstagePass)
        {
            UpdateBackstagePassQuality(backstagePass);
            SellInUpdater.DecrementSellInByOne(backstagePass);

            if (SellInBounds.SellByDatePassed(backstagePass))
            {
                backstagePass.Quality = 0;
            }
        }

        private void UpdateBackstagePassQuality(Item backstagePass)
        {
            if (QualityBounds.QualityLessThanMaximum(backstagePass))
            {
                QualityUpdater.IncrementQualityByOne(backstagePass);

                if (backstagePass.SellIn < 11 && QualityBounds.QualityLessThanMaximum(backstagePass))
                {
                    QualityUpdater.IncrementQualityByOne(backstagePass);
                }

                if (backstagePass.SellIn < 6 && QualityBounds.QualityLessThanMaximum(backstagePass))
                {
                    QualityUpdater.IncrementQualityByOne(backstagePass);
                }
            }
        }
    }
}

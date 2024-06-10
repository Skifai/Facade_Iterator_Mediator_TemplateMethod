// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace DesignPatterns.Strategy
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class AbsoluteDiscountOverThresholdStrategy : ISalePricingStrategy
    {
        private readonly decimal _threshold;
        private readonly decimal _absoluteDiscount;

        public AbsoluteDiscountOverThresholdStrategy(decimal threshold, decimal absoluteDiscount)
        {
            _threshold = threshold;
            _absoluteDiscount = absoluteDiscount;
        }

        public decimal GetTotal(Sale sale)
        {
            if (sale.Amount >= _threshold)
            {
                return sale.Amount - _absoluteDiscount;
            }

            return sale.Amount;
        }
    }
}

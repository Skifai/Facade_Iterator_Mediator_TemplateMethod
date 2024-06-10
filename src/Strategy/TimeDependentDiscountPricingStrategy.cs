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

    public class TimeDependentDiscountPricingStrategy : ISalePricingStrategy
    {
        private readonly decimal _percentage;
        private readonly TimeProvider _timeProvider;
        private readonly ISystemTime _systemTime;
        private readonly Func<DateTime> _getDateTime;

        public TimeDependentDiscountPricingStrategy(decimal percentage, Func<DateTime> getDateTime)
        {
            _percentage = percentage;
            _getDateTime = getDateTime;
        }

        public TimeDependentDiscountPricingStrategy(decimal percentage, ISystemTime systemTime)
        {
            _percentage = percentage;
            _systemTime = systemTime;
        }

        public TimeDependentDiscountPricingStrategy(decimal percentage, TimeProvider timeProvider)
        {
            _percentage = percentage;
            _timeProvider = timeProvider;
        }

        public decimal GetTotal(Sale sale)
        {
            //var dateTime = _getDateTime();
            //var dateTime = _systemTime.Now;
            var dateTime = _timeProvider.GetLocalNow();


            if (dateTime.Hour < 12)
            {
                return sale.Amount - sale.Amount / 100 * _percentage;
            }

            return sale.Amount - sale.Amount / 100 * 2 * _percentage;
        }
    }
}

// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace DesignPatterns.Adapter
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    // Freezed
    public class PresidentOfTheBoard
    {
        public PresidentOfTheBoard(decimal bonus)
        {
            Bonus = bonus;
        }

        public decimal Bonus { get; }
    }
}

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

    public interface ISystemTime
    {
        DateTime Now { get; }
    }

    public class SystemTime : ISystemTime
    {
        public DateTime Now => DateTime.Now;
    }
}

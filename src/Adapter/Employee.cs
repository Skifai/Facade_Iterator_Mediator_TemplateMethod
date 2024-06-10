// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace DesignPatterns.Adapter
{
    public class Employee : IEmployee
    {
        public Employee(decimal salary)
        {
            Salary = salary;
        }

        public decimal Salary { get; }
    }
}

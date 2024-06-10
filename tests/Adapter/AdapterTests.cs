// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace DesignPatterns.Tests.Adapter
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using DesignPatterns.Adapter;
    using FluentAssertions;

    public class AdapterTests
    {
        [Fact]
        public void PaySalaries_WhenPresidentOfTheBoard_ThenSalaryIncluded()
        {
            var employeeManager = new EmployeeManager();
            employeeManager.Add(new Employee(100));
            employeeManager.Add(new Employee(100));
            employeeManager.Add(new Employee(100));
            employeeManager.Add(new Employee(100));
            employeeManager.Add(new Employee(100));
            employeeManager.Add(new EmployeeAdapter(new PresidentOfTheBoard(1_000_000)));

            employeeManager.PaySalaries().Should().Be(1_000_500);
        }
    }
}

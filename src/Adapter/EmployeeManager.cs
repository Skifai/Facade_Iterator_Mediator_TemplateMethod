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

    public class EmployeeManager
    {
        private readonly List<IEmployee> _employees = [];

        public void Add(IEmployee employee)
        {
            _employees.Add(employee);
        }

        public void Remove(IEmployee employee)
        {
            _employees.Remove(employee);
        }

        public decimal PaySalaries()
        {
            return _employees.Sum(x => x.Salary);

            ////var sum = decimal.Zero;
            ////foreach (var employee in _employees)
            ////{
            ////    sum += employee.Salary;
            ////}

            ////return sum;
        }
    }
}

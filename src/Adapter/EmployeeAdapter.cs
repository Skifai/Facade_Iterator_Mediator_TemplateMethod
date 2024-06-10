namespace DesignPatterns.Adapter
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class EmployeeAdapter : IEmployee
    {
        private readonly PresidentOfTheBoard _presidentOfTheBoard;

        public EmployeeAdapter(PresidentOfTheBoard presidentOfTheBoard)
        {
            _presidentOfTheBoard = presidentOfTheBoard;
        }

        public decimal Salary => _presidentOfTheBoard.Bonus;
    }

    public class EmployeeAdapter2 : Employee
    {
        public EmployeeAdapter2(PresidentOfTheBoard presidentOfTheBoard)
            : base(presidentOfTheBoard.Bonus)
        {
        }
    }
}

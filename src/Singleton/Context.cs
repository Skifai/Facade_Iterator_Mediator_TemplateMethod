namespace DesignPatterns.Singleton
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal class Context
    {
        public void Foo()
        {
            var result = EmployeeManager.Instance.Calculate();

            var newResult = result switch
            {
                20 => "OK",
                25 => "Not Ok",
                30 => throw new ApplicationException(),
                _ => throw new InvalidOperationException()
            };
        }
    }

    public class Context2
    {
        private readonly IEmployeeManager2 _employeeManager;

        public Context2(IEmployeeManager2 employeeManager)
        {
            _employeeManager = employeeManager;
        }

        public void Foo()
        {
            var result = _employeeManager.Calculate();

            var newResult = result switch
            {
                20 => "OK",
                25 => "Not Ok",
                30 => throw new ApplicationException(),
                _ => throw new InvalidOperationException()
            };
        }
    }
}

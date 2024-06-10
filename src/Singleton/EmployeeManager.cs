namespace DesignPatterns.Singleton
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Text;
    using System.Threading.Tasks;

    public class EmployeeManager2 : IEmployeeManager2
    {
        public int Calculate()
        {
            return 20;
        }
    }

    public interface IEmployeeManager2
    {
        int Calculate();
    }

    public class EmployeeManager
    {
        private static EmployeeManager _instance;

        private EmployeeManager()
        {
        }

        public void Add(int i)
        {
        }

        public int Calculate()
        {
            return 20;
        }


        public static EmployeeManager Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new EmployeeManager();
                }

                return _instance;
            }
        }
    }
}

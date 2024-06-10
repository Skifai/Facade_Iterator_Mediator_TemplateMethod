namespace DesignPatterns.Tests.Singleton
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using DesignPatterns.Singleton;
    using Moq;

    public class SingletonTests
    {
        [Fact]
        public void Demo_Singleton()
        {
            EmployeeManager.Instance.Add(1);
            EmployeeManager.Instance.Add(2);
        }

        [Fact]
        public void Demo_Singleton_Good()
        {
            var mock = new Mock<IEmployeeManager2>();
            mock.Setup(x => x.Calculate()).Returns(20);
            mock.Setup(x => x.Calculate()).Returns(25);

            var context = new Context2(mock.Object);
            context.Foo();
        }














































































        private void Foo()
        {
            EmployeeManager.Instance.Add(1);
        }
    }
}

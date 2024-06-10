using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Iterator
{
    public interface IIterableCollection<T>
    {
        public IIterator<T> CreateAmountIterator();
        public IIterator<T> CreateTotalIterator();
    }
}

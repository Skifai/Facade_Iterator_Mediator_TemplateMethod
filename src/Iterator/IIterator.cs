using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Iterator
{
    public interface IIterator<T>
    {
        public T getNext();
        public bool hasMore();
        public void reset();
    }
}

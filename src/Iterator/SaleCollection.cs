using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Iterator
{
    public class SaleCollection : IIterableCollection<Sale>
    {
        private readonly List<Sale> _sales;
        public SaleCollection() { }
        public SaleCollection(List<Sale> sales)
        {
            _sales = sales;
        }
        public void Add(Sale sale)
        {
            _sales.Add(sale);
        }
        public void Remove(Sale sale)
        {
            _sales.Remove(sale);
        }
        public int Count()
        {
            return _sales.Count;
        }
        public IIterator<Sale> createAmountIterator()
        {
            return new IteratorByAmount(_sales);
        }

        public IIterator<Sale> createTotalIterator()
        {
            return new IteratorByTotal(_sales);
        }
    }
}

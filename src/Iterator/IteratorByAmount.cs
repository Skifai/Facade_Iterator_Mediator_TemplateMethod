﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Iterator
{
    public class IteratorByAmount : IIterator<Sale>
    {
        private readonly List<Sale> _collection;
        private int _index = 0;

        public IteratorByAmount(List<Sale> collection)
        {
            _collection = collection
                .OrderBy(x => x.Amount)
                .ToList();
        }
        public Sale getNext()
        {
            if (hasMore())
            {
                return _collection[++_index];
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }
        }

        public bool hasMore()
        {
            return _index < _collection.Count;
        }

        public void reset()
        {
            _index = 0;
        }
    }
}

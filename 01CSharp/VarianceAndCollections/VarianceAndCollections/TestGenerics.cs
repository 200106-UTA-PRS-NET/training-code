using System;
using System.Collections.Generic;
using System.Text;

namespace VarianceAndCollections
{
    class TestGenerics<T>
    {
       internal T x;
      internal T Add(T a)
        {
            return a;
        }
        internal bool TestEquals(T x, T y)
        {
            if (x.Equals(y))
                return true;
            else
                return false;
        }
    }
}

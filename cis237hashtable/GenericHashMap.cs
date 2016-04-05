using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237hashtable
{
    class GenericHashMap<TKey, TValue>
    {
        private const int PRIMEVALUE = 97;
        TValue[] theValues;

        public GenericHashMap()
        {
            theValues = new TValue[PRIMEVALUE];
        }

        public TValue Get(TKey key)
        {
            int indexForValues = HashFunction(key);
            return theValues[indexForValues];
        }

        public void Put(TKey key, TValue value)
        {
            int indexForValues = HashFunction(key);
            theValues[indexForValues] = value;
        }

        private int HashFunction(TKey key)
        {
            return key.GetHashCode() % PRIMEVALUE;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237hashtable
{
    class HashMap
    {
        // Make a prime value to use in the hash function and as the size
        // of the array. 
        private const int PRIMEVALUE = 97;

        // Define a few arrays. One for the keys and one for the values.
        int[] theKeys;
        string[] theValues;

        // Constructor
        public HashMap()
        {
            theKeys = new int[PRIMEVALUE];
            theValues = new string[PRIMEVALUE];
        }

        public override string ToString()
        {
            string returnString = "Key    => Value\n";
            returnString += "-------------------------------------------\n";
            for (int i = 0; i< theKeys.Length; i++)
            {
                if (theKeys[i] != 0)
                {
                    returnString += theKeys[i] + " => " + theValues[i] + "\n";
                }
            }

            return returnString;
        }

        public string ShowArrays()
        {
            string returnString = "Idx - Key     => Value\n";
            returnString += "-----------------------------\n";
            for (int i = 0; i < theKeys.Length; i++)
            {
                returnString += "[" + i + "] - " + theKeys[i] + " => " + theValues[i] + "\n";
            }

            return returnString;
        }

        public void Put(int Key, string Value)
        {
            // Get the index to use for storing the info from the hash function.
            int indexForValue = HashFunction(Key);

            // Use the index to put the key and value into the associated array.
            theKeys[indexForValue] = Key;
            theValues[indexForValue] = Value;
        }

        public string Get(int Key)
        {
            // Get the index to use for looking up the value
            int indexForValues = HashFunction(Key);

            // Return the information at the array location of indexForValues.
            return theValues[indexForValues];
        }

        // Hash function to take in a key and map it to a smaller number space that
        // is between 0 and PRIMEVALUE. This is accomplished by the MOD function.
        private int HashFunction(int key)
        {
            return key % PRIMEVALUE;
        }
    }
}

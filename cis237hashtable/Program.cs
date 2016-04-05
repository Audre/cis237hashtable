using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237hashtable
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dictionary<int, string> valleyNumToName = new Dictionary<int, string>();
            
            /*
            HashMap valleyNumToName = new HashMap();

            Console.SetBufferSize(80, 1200);

            Console.WriteLine("Adding some entries to the HashMap.");
            Console.WriteLine("Ex: valleyNumToName.Put(12345, \"David Barnes\")");
            Console.WriteLine();

            valleyNumToName.Put(12345, "James Kirk");
            valleyNumToName.Put(23456, "Benjamin Sisko");
            valleyNumToName.Put(34567, "Kathryn Janeway");
            valleyNumToName.Put(45678, "Jean-Luc Picard");
            valleyNumToName.Put(56789, "Jonathan Archer");

            Console.WriteLine("The created hash table:");
            Console.WriteLine(valleyNumToName.ToString());
            Console.WriteLine();

            Console.WriteLine("The full arrays as they got filled out:");
            Console.WriteLine(valleyNumToName.ShowArrays());
            Console.WriteLine();

            Console.WriteLine("**************************************");

            Console.WriteLine("Get a single value out from the hash table passing in the key");
            Console.WriteLine("valleyNumToName.Get(45678)");
            Console.WriteLine(valleyNumToName.Get(45678));
            Console.WriteLine();

            Console.WriteLine("Press Enter to continue.");
            Console.ReadLine();

            Console.WriteLine("*******************************");
            Console.WriteLine();
            Console.WriteLine("What if we add 2 entries to the hash table that map to the same location:");
            Console.WriteLine("valleyNumToName.put(26189, \"First Entry\")");
            valleyNumToName.Put(26189, "First Entry");
            Console.WriteLine("valleyNumToName.put(26092, \"Second Entry\")");
            valleyNumToName.Put(26092, "Second Entry");
            Console.WriteLine();

            Console.WriteLine("Reprint the hash table and arrays:");
            Console.WriteLine(valleyNumToName.ToString());
            Console.WriteLine(valleyNumToName.ShowArrays());
             */

            GenericHashMap<int, string> valleyNumToName = new GenericHashMap<int, string>();

            Console.SetBufferSize(80, 1200);

            Console.WriteLine("Adding some entries to the HashMap.");
            Console.WriteLine("Ex: valleyNumToName.Put(12345, \"David Barnes\")");
            Console.WriteLine();

            valleyNumToName.Put(12345, "James Kirk");
            valleyNumToName.Put(23456, "Benjamin Sisko");
            valleyNumToName.Put(34567, "Kathryn Janeway");
            valleyNumToName.Put(45678, "Jean-Luc Picard");
            valleyNumToName.Put(56789, "Jonathan Archer");

            //Console.WriteLine("The created hash table:");
            //Console.WriteLine(valleyNumToName.ToString());
            //Console.WriteLine();

            //Console.WriteLine("The full arrays as they got filled out:");
            //Console.WriteLine(valleyNumToName.ShowArrays());
            //Console.WriteLine();

            Console.WriteLine("**************************************");

            Console.WriteLine("Get a single value out from the hash table passing in the key");
            Console.WriteLine("valleyNumToName.Get(45678)");
            Console.WriteLine(valleyNumToName.Get(45678));
            Console.WriteLine();

            Console.WriteLine("Press Enter to continue.");
            Console.ReadLine();

            Console.WriteLine("*******************************");
            Console.WriteLine();
            Console.WriteLine("What if we add 2 entries to the hash table that map to the same location:");
            Console.WriteLine("valleyNumToName.put(26189, \"First Entry\")");
            valleyNumToName.Put(26189, "First Entry");
            Console.WriteLine("valleyNumToName.put(26092, \"Second Entry\")");
            valleyNumToName.Put(26092, "Second Entry");
            Console.WriteLine();

            //Console.WriteLine("Reprint the hash table and arrays:");
            //Console.WriteLine(valleyNumToName.ToString());
            //Console.WriteLine(valleyNumToName.ShowArrays());

            Console.WriteLine("Let's try to get out the first entry.");
            Console.WriteLine("It should not exist since it was overwritten.");
            Console.WriteLine("by the second entry. Therefore, retrieving the first");
            Console.WriteLine("will actually return the second");
            Console.WriteLine();
            Console.WriteLine("valleyNumToName.Get(26189)");
            Console.WriteLine(valleyNumToName.Get(26189));
        }
    }
}

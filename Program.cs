using System;
using System.Collections.Generic;

namespace CS_Using_HashSet
// Code based upon code from Mahesh Sabnis  - link: https://www.dotnetcurry.com/csharp/1362/hashset-csharp-with-examples

//***************************//
//* Work Together with      *//
//* Nathan Sean Littlefield *//
//*                         *//
//* nlittl22-MED2           *//
//***************************//

{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Using HashSet");
            //1. Defining String Array and the name "Sarah" is repeated
            string[] names = new string[] {
                "sarah",
                "nathan",
                "sarah",
                "jun",
                "apo",
                "marcus",
                "eksan"
            };
            //2. Check the length of the array Using .Length where the lengths are the amount of items
            Console.WriteLine("Length of Array " + names.Length);
            Console.WriteLine();
            Console.WriteLine("The Data in Array");
            foreach (var n in names)
            {
                Console.WriteLine(n);
            }

            Console.WriteLine();
            //3. Defining HashSet by passing names Array to it
            HashSet<string> hSet = new HashSet<string>(names);
            //4. Count of Elements in HashSet, this is similar to .Length in array
            Console.WriteLine("Count of Data in HashSet " + hSet.Count);
            Console.WriteLine();
            //5. Printing Data in HashSet¨but since "Sarah" is repeated it will get remove. 
            Console.WriteLine("Data in HashSet");
            foreach (var n in hSet)
            {
                Console.WriteLine(n);
            }
            Console.ReadLine();

            string[] names1 = new string[] {
             "sarah","lucas","eksan","levi","marcus","peter"
             };

            string[] names2 = new string[] {
            "apo","kevin","nathan","emil","sarah","casper"
            };
            //2.

            HashSet<string> hSetN1 = new HashSet<string>(names1);
            Console.WriteLine("Data in First HashSet");
            foreach (var n in hSetN1)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine("_______________________________________________________________");
            HashSet<string> hSetN2 = new HashSet<string>(names2);
            Console.WriteLine("Data in Second HashSet");
            foreach (var n in hSetN2)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine("________________________________________________________________");
            //3.
            Console.WriteLine("Data After Union");
            hSetN1.UnionWith(hSetN2);
            foreach (var n in hSetN1)
            {
                Console.WriteLine(n);
            }

            Console.WriteLine();
            Console.WriteLine("_________________________________");
            Console.WriteLine("Data in HashSet before using Except With");
            Console.WriteLine("_________________________________");
            //storing data of hSetN3 in temporary HashSet
            HashSet<string> hSetN3 = new HashSet<string>(names1);
            foreach (var n in hSetN3)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine();
            Console.WriteLine("_________________________________");
            Console.WriteLine("Using Except With");
            Console.WriteLine("_________________________________");
            hSetN3.ExceptWith(hSetN2);
            foreach (var n in hSetN3)
            {
                Console.WriteLine(n);
            }

            HashSet<string> hSetN4 = new HashSet<string>(names1);
            Console.WriteLine("_________________________________");
            Console.WriteLine("Elements in HashSet before using SymmetricExceptWith");
            Console.WriteLine("_________________________________");
            Console.WriteLine("HashSet 1");
            foreach (var n in hSetN4)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine("HashSet 2");
            foreach (var n in hSetN2)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine("_________________________________");
            Console.WriteLine("Using SymmetricExceptWith");
            Console.WriteLine("_________________________________");
            hSetN4.SymmetricExceptWith(hSetN2);
            foreach (var n in hSetN4)
            {
                Console.WriteLine(n);
            }
        }
        //Its slower to add values to hashsets because everytime you add a new value, it will have to check with all its exciting values if it already exists,
        //Therefore it will be faster to add values in lists.

        //contain
        //Since there are no duplication in Hashset it is faster

        //remove
        //The removal method is faster in Hashset
    }
}

using System;
using System.Collections.Generic;

namespace ListConceptExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            // Bir liste oluşturma ve eleman ekleme
            List<string> names = new List<string> { "Alice", "Bob", "Charlie" };
            names.Add("David");  // Listeye yeni bir eleman ekleme
            Console.WriteLine("Initial list of names:");
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }

            // Belirli bir indeksteki elemanı çıkarma
            names.RemoveAt(1);  // Bob'u çıkarır (index 1)
            Console.WriteLine("\nList after removing element at index 1:");
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }

            // Eleman bulma ve kontrol etme
            string searchName = "Charlie";
            if (names.Contains(searchName))
            {
                Console.WriteLine($"\n{searchName} is in the list.");
            }
            else
            {
                Console.WriteLine($"\n{searchName} is not in the list.");
            }

            // Liste elemanlarını sıralama
            names.Sort();
            Console.WriteLine("\nSorted list of names:");
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }

            // Listedeki eleman sayısını yazdırma
            Console.WriteLine($"\nTotal number of names in the list: {names.Count}");
        }
    }
}
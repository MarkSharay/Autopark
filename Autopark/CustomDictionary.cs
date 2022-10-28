using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autopark
{
    internal class CustomDictionary
    {
        Dictionary<string, int> dict = new Dictionary<string, int>(); // Add access modifier. It's better to initialize this variable in the constructor.

        public IEnumerable<string> LoadOrders(string path)
        {
            string[] lines = File.ReadAllLines(path);
            foreach (string line in lines)
            {
                string[] words = line.Split(";");
                foreach(string word in words)
                {
                    yield return word;
                }

            }
        }

        public CustomDictionary(string path)
        {
            List<string> list = this.LoadOrders(path).ToList(); //no needs to use 'this'
            
            foreach(string el in list)
            {
                if (dict.ContainsKey(el))
                {
                    dict[el] += 1;
                }
                else
                {
                    dict.Add(el, 1);
                }
              }
          
        }

        public void Print()
        {
            foreach(var value in dict)
            {
                Console.WriteLine($"{value.Key} {value.Value}");
            }
        }

        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autopark
{
    internal class CustomStack<T> where T : Vehicle
    {
        T?[] values;

        readonly int _count;

        private int counter;

        public CustomStack(int count)
        {
            _count = count;
            values = new T?[_count];
        }

        public bool Push(T obj)
        {
            if(counter == _count)
            {
                Console.WriteLine("Гараж заполнен");

                return false;
            }
            else
            {
                values[counter] = obj;
                Console.WriteLine($"{obj.ToString()} приехал в гараж");
                counter++;
                return true;
            }
        }

        public bool Pop()
        {
            if(counter == 0)
            {
                Console.WriteLine("В гараже нет машин");
                return false;
            }
            else
            {
                Console.WriteLine($"{values[counter - 1].ToString()} выехал");
                values[counter - 1] = null;
                counter--;
                return true;
            }
        }

        public int Count()
        {
            return _count;
        }
    }
}

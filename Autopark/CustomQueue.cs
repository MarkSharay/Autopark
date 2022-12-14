using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autopark
{
    internal class CustomQueue<T> where T : Vehicle
    {
        T[] values;

        int head = -1;

        int tail = -1;

        public CustomQueue(){
            values = new T[0];
        }


        public void Enqueue(T data)
        {
            Array.Resize<T>(ref values, values.Length + 1);
            tail++;
            values[tail] = data;
        }

        public void Dequeue()
        {
            if(head < tail)
            {
                head++;
                Console.WriteLine($"Автомобиль {values[head].ToString()} был помыт \n");
            }
            else
            {
                Console.WriteLine("В очереди никого нет");
            }
        }

        public int Count()
        {
            return tail-head;
        }

        public void Clear()
        {
            values = new T[0];
        }

        public bool Contains(T value)
        {
            return values.Contains(value);
        }

    }
}

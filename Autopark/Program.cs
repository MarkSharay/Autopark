// See https://aka.ms/new-console-template for more information
using Autopark;

Collections cols = new Collections("types.csv", "vehicles.csv", "rents.csv");

cols.Print();

cols.Sort();

cols.Print();


CustomQueue<Vehicle> queue = new CustomQueue<Vehicle>();
foreach(Vehicle v in cols.Vehicles)
{
    queue.Enqueue(v);
}
int count = queue.Count();
for(int i = 0; i<count; i++)
{
    queue.Dequeue();
}

CustomStack<Vehicle> stack = new CustomStack<Vehicle>(3);

foreach(Vehicle v in cols.Vehicles)
{
    if (!stack.Push(v))
    {
        for(int i = 0; i < stack.Count(); i++)
        {
            stack.Pop();
        }
        stack.Push(v);
    }
}

CustomDictionary dictionary = new CustomDictionary("orders.csv");

dictionary.Print();


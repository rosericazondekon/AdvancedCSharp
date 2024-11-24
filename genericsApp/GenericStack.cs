using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


public class GenericStack<T>
{
    public List<T> items = new List<T>();
    public void Push(T item){items.Add(item);}
    public T Pop()
    {
        if(items.Count > 0){
            T poppedItem = items[items.Count - 1];
            items.RemoveAt(items.Count - 1);
            return poppedItem;
        }
        throw new InvalidOperationException("Cannot pop from an empty stack.");
    }
    public void Display()
    {
        foreach(T item in items)
        {
            Console.Write($"{item} ");
        }
        Console.WriteLine();
    }
}
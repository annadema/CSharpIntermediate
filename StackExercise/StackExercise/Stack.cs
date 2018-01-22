using System;
using System.Collections.Generic;

namespace StackExercise
{
    public class Stack
    {
        public List<object> container { get; set; } = new List<object>();

        public void Push(object obj)
        {
            if (obj == null)
                throw new InvalidOperationException("null can't be added to stack");
            container.Add(obj);
        }

        public object Pop()
        {
            if (container.Count == 0)
                throw new InvalidOperationException("Stack empty");
            var temp = container[container.Count - 1];
            container.RemoveAt(container.Count - 1);
            return temp;
        }

        public void Clear()
        {
            container.Clear();
            Console.WriteLine("Stack cleared  {0}", container.Count);
        }
    }
}
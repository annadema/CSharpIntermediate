using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackExercise
{
    class Program
    {
        
        static void Main(string[] args)
        {
            var stack=new Stack();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());

            //stack.Push(null);
            //Console.WriteLine(stack.Pop());

            stack.Push(4);
            stack.Clear();

        }
    }
}

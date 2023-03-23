using System;

public class collections
{
	public collections()
	{

	}
		static void Main(string[] args)
		{

        Console.WriteLine("List Demo");
        var listDemo = new List<string>() { "new", "oranges" };
        listDemo.Add("Hello");
        listDemo.Add("Hello1");
        listDemo.Add("Hello2");
        listDemo.Add("Hello3");
        listDemo.Add("Hello3");
        foreach (var item in listDemo)
        {
            Console.WriteLine(item);
        }
        listDemo.Remove("Hello1");

        Console.WriteLine("\nAfter Removal of hello1");
        foreach (var item in listDemo)
        {
            Console.WriteLine(item);
        }

		Console.WriteLine();
        Console.WriteLine("Sorted Set");
        var sortIntSet = new SortedSet<int>() { 12, 3, 1 };
        var sortStringSet = new SortedSet<char>() { 'a', 'c', 'd' };
        foreach (var i in sortIntSet)
		{
			Console.WriteLine($"interger set - {i}");
		}
        Console.WriteLine();
        foreach (var i in sortStringSet)
        {
            Console.WriteLine($"char set - {i}");
        }
        Console.WriteLine();
		Console.WriteLine("Stack");
        Stack<int> stack = new Stack<int>();
		stack.Push(1);
		stack.Push(2);
		stack.Push(3);

		while(stack.Count > 0)
		{
			Console.WriteLine("peek is: "+stack.Peek());
			Console.WriteLine("popped element: "+stack.Pop());

			
		}

		Console.WriteLine();
		Console.WriteLine("Queue");

		Queue<int> queue = new Queue<int>();	
		queue.Enqueue(1);
		queue.Enqueue(2);
		queue.Enqueue(3);
		queue.Enqueue(1);

		while(queue.Count > 0)
		{
			Console.WriteLine("dequeued element: "+ queue.Dequeue()) ;
		}



    }

	
}

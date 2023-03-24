using System;

public class collections
{
	public collections()
	{

	}

	static void Main(string[] args)
	{

		//Dictionary

		var dict1 = new Dictionary<int, string>();
		dict1.Add(1, "a");
		dict1.Add(2, "b");
		dict1.Add(3, "c");
		dict1.Add(4, "d");
		dict1.Add(5, "e");
		dict1.Add(6, "f");
		dict1.Add(7, "g");
		dict1.TryAdd(1, "d");
		foreach(var kvp in dict1)
		{
			if (kvp.Key == 5)
			{
				dict1[kvp.Key] = "A";
			}
		}
		foreach (var kvp in dict1)
		{
			Console.WriteLine("KEY: " + kvp.Key+" VALUE: "+kvp.Value);
		}








		/*
		//Linked list

		var linkedList = new LinkedList<int>();

		linkedList.AddLast(1);
		linkedList.AddLast(2);
		linkedList.AddLast(3);
		linkedList.AddLast(4);
		linkedList.AddLast(5);
		linkedList.AddLast(6);
		linkedList.AddLast(7);
		linkedList.AddLast(8);
		linkedList.AddLast(9);
		linkedList.AddLast(2);

		
		LinkedListNode<int> node = linkedList.Find(2);
        LinkedListNode<int> node2 = linkedList.FindLast(2);
        linkedList.AddBefore(node, -2);
		linkedList.AddAfter(node2, -2);

		for(LinkedListNode<int> i = linkedList.First; i!=null;i=i.Next)
		{
			if(i.Value == -2)
			{
				linkedList.AddBefore(i, -1);
			}
		}
        foreach (var item in linkedList)
        {
            Console.WriteLine(item);
        }
		*/

    }
}











		/*
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
	*/


	

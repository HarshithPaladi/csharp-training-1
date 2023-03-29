using System;

public class test
{
	public class testInternal
	{
		protected internal void testInternalmethod ()
		{
            Console.WriteLine("in test internal class method");
        }

	}
	public test()
	{
	}

	public void testMethod()
	{
		Console.WriteLine("in test class method");
	}
}

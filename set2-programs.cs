using System;
using System.Net.Http.Headers;



public class Class2
{
	public Class2()
	{

	}

    public static int Duplicate(int[] arr)
    {
        var temp = new List<int>();
        int count = 0;

        foreach (var item in arr)
        {
            if (temp.Contains(item))
            {
                count++;
            }
            else
            {
                temp.Add(item);
            }
        }
        return count;
    }

    public static void merge(int[] arr1, int[] arr2)
        {
            var temp = new List<int>();
        Console.Write("Given array1: ");
        foreach (int i in arr1)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();
        Console.Write("Given array2: ");
        foreach (int i in arr2)
        {
            Console.Write(i + " ");
        }
        foreach (var i in arr1)
            {
                temp.Add(i);
            }
            foreach (var i in arr2)
             {
            temp.Add(i);
             }
        for (int i =temp.Count-1;i>=0;i--)
        {
            for(int j=0;j<i;j++)
            {
                if (temp[j]>=temp[i])
                {
                    int x = temp[j];
                    temp[j] = temp[i];
                    temp[i] = x;
                }
            }
        }
        Console.WriteLine();
        Console.Write("Merged and sorted array: ");
       foreach(int i in temp)
        {
            Console.Write(i+" ");
        }
        }

    public static void even_odd(int[] arr)
    {
        Console.WriteLine("SEPARATING EVEN AND ODD INTEGERS");
        Console.Write("Given array: ");
        foreach (int i in arr)
        {
            Console.Write(i + " ");
        }
        var even = new List<int>();
        var odd = new List<int>();
        foreach(int i in arr)
        {
            if(i%2==0)
            {
                even.Add(i);
            }
            else
            {
                odd.Add(i);
            }
        }
        Console.WriteLine();
        Console.Write("Even integers: ");

        foreach(int i in even)
        {
            Console.Write(i+" ");
        }
        Console.WriteLine();
        Console.Write("Odd integers: ");
        foreach (int i in odd)
        {
            Console.Write(i+" ");
        }
        Console.WriteLine();
    }


    public static void Main(string[] args)
    {
        int[] a = { 1, 2, 5, 2, 3, 4, 1, 3, 5, 3, 56, 1 }; 
       even_odd(a);
       Console.WriteLine("No of duplicates in the given array: "+ Duplicate(a));
       int[] b = { 1, 2, 90 };
        merge(a, b);
    }

    }


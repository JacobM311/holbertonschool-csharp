using System;
using System.Linq;

class Array
{

	public static int[] CreatePrint(int size)
	{
		int[] IntArray;

		IntArray = size > 0 ? Enumerable.Range(0, size).ToArray() : (size == 0 ? new int[0] : null);

		Console.WriteLine(size > 0
				  ? string.Join(" ", IntArray)
				  : size == 0
				  ? "\n"
				  : "Size cannot be negative");

		return IntArray;
	}
}
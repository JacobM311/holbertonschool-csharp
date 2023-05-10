using System;

class Program
{
	static void Main(string[] args)
	{
		string str = "Holberton School";
		Console.WriteLine(string.Format("{0}{1}", str, string.Join("", Enumerable.Repeat(str, 2))));
    }
}
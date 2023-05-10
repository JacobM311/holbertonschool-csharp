using System;
using System.Linq;
class Program
{
	static void Main(string[] args)
	{
		string str = "Holberton School";
		Console.WriteLine(string.Format("{0}{1}", str, string.Join("", Enumerable.Repeat(str, 2))));
        Console.WriteLine(str.Substring(0, 9) + Environment.NewLine);
    }
}
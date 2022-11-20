using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			IEnumerable<int> list = Enumerable.Range(1, 10);
			foreach (var item in list)
			{
				Console.WriteLine(item);
			}
			Console.WriteLine();
			list=Enumerable.Range(10, 6);
			foreach (var item in list)
			{
				Console.WriteLine(item);
			}
		}
	}
}

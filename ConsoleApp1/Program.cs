using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
		static void Main(string[] args)
		{
			while (true)
			{
				Console.WriteLine("Деление числа на розряды");
				ulong x = Convert.ToUInt64(Console.ReadLine());
				Console.WriteLine("Выберите розрядок 1, 2, 3, 4, 5, 6");
				long rozr = Convert.ToInt64(Console.ReadLine());
			
				switch (rozr)
				{
					case 1:
						ulong a = x / 10000;
						Console.WriteLine("1: {0}", a);
						break;
					case 2:
						ulong b = ((x / 1000) % 10);
						Console.WriteLine("2: {0}", b);
						break;
					case 3:
						ulong c = ((x / 100) % 10);
						Console.WriteLine("3: {0}", c);
						break;
					case 4:
						ulong d = ((x / 10) % 10);
						Console.WriteLine("4: {0}", d);
						break;
					case 5:
						ulong e = ((x / 1) % 10);
						Console.WriteLine("5: {0}", e);
						break;
					case 6:
						ulong f = x;
						Console.WriteLine("6: {0}", f);
						break;
					default:
						Console.WriteLine(" ::: ");
						break;
				}
			}
		}
    }
}

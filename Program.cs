using System;

namespace prime_number
{
    class Program
    {
        static void Main(string[] args)
        {
			Console.WriteLine("please enter first");

			int first = int.Parse(Console.ReadLine());
			Console.WriteLine("please enter second");

			int second = int.Parse(Console.ReadLine());

			bool prime = true;


			for (int y = first; y < second; y++)
			{
				for (int o = 2; o < y; o++)
				{
					if (y % o == 0)
					{

						prime = false;
						break;
					}
				}
				if (prime == true)
				{
					Console.WriteLine(y);
				}
				else
				{
					prime = true;
				}
			}
		}
    }
}

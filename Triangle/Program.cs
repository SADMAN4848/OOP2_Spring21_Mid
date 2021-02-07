using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTriangle
{
	public class Triangle
	{
		int x;
		int y;
		int z;

		public Triangle()
		{
		}
		public Triangle(int x, int y, int z)
		{
			this.x = x;
			this.y = y;
			this.z = z;
		}

		public void TestTriangle()
		{
			if (x == y && y == z)
			{
				Console.WriteLine("The triangle is Equilateral");
			}
			else if (x == y && x != z)
			{
				Console.WriteLine("The triangle is Isosceles");
			}
			else if (y == z && x != y)
			{
				Console.WriteLine("The triangle is Isosceles");
			}
			else if (x == z && x != y)
			{
				Console.WriteLine("The triangle is Isosceles");
			}
			else
			{
				Console.WriteLine("The triangle is Scalene");
			}
		}

		public void ShowInfo()
		{
			Console.WriteLine("Length of first arm is " + x);
			Console.WriteLine("Length of second arm is " + y);
			Console.WriteLine("Length of third arm is " + z);

		}
	}
}


		
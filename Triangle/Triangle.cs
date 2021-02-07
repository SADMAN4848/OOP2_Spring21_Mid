using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTriangle
{
	public class Triangle
	{
		private int x;
		private int y;
		private int z;

		public Triangle()
		{
		}
		public Triangle(int x, int y, int z)
		{
			this.x = x;
			this.y = y;
			this.z = z;
		}

		public int X
		{
			get { return x; }
			set { x = value; }
		}

		public int Y
		{
			get { return y; }
			set { y = value; }
		}

		public int Z
		{
			get { return z; }
			set { z = value; }
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
			Console.WriteLine("\nLength of first arm is " + x);
			Console.WriteLine("Length of second arm is " + y);
			Console.WriteLine("Length of third arm is " + z);

		}
	}
}


		
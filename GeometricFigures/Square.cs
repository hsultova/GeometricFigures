using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricFigures
{
	public class Square : GeometryObject, IObject2D
	{
		private double _side;

		public double Side
		{
			get
			{
				return _side;
			}
			set
			{
				if (value > 0)
				{
					_side = value;
				}
			}
		}

		public Square(string name, double side) : base(name)
		{
			_side = side;
		}

		public double CalculatePerimeter()
		{
			double perimeter = 4 * Side;
			return perimeter;
		}

		public double CalculateArea()
		{
			double area = Side * Side;
			return area;
		}

		public override string ToString()
		{
			return string.Format("\n" + base.ToString() + "\nSide: {0:f2}\nPerimeter: {1:f2}\nArea: {2:f2} ", Side,
				CalculatePerimeter(), CalculateArea());
		}
	}
}

using System;

namespace GeometricFigures
{
	public class Circle : GeometryObject, IObject2D
	{
		private double _radius;

		public double Radius
		{
			get
			{
				return _radius;
			}
			set
			{
				if (value > 0)
				{
					_radius = value;
				}
			}
		}

		public Circle(string name, double radius) : base(name)
		{
			_radius = radius;
		}

		public double CalculatePerimeter()
		{
			double perimeter = 2 * Math.PI * Radius;
			return perimeter;
		}

		public double CalculateArea()
		{
			double area = Math.PI * Radius * Radius;
			return area;
		}

		public override string ToString()
		{
			return string.Format("\n" + base.ToString() + "\nRadius: {0:f2}\nPerimeter: {1:f2}\nArea: {2:f2} ", Radius, 
				CalculatePerimeter(), CalculateArea());
		}
	}
}

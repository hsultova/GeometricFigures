using System;

namespace GeometricFigures
{
	public class Triangle : GeometryObject, IObject2D
	{
		private double _aSide;
		private double _bSide;
		private double _cSide;

		public double ASide
		{
			get
			{
				return _aSide;
			}
			set
			{
				if (value > 0)
				{
					_aSide = value;
				}
			}
		}

		public double BSide
		{
			get
			{
				return _bSide;
			}
			set
			{
				if (value > 0)
				{
					_bSide = value;
				}
			}
		}

		public double CSide
		{
			get
			{
				return _cSide;
			}
			set
			{
				if (value > 0)
				{
					_cSide = value;
				}
			}
		}

		public Triangle(string name, double a, double b, double c) : base(name)
		{
			_aSide = a;
			_bSide = b;
			_cSide = c;
		}

		public double CalculatePerimeter()
		{
			double perimeter = ASide + BSide + CSide;
			return perimeter;
		}

		public double CalculateArea()
		{
			double semiperimeter = CalculatePerimeter() / 2;
			double area = Math.Sqrt(semiperimeter * (semiperimeter - ASide) * (semiperimeter - BSide) * (semiperimeter - CSide));
			return area;
		}

		public override string ToString()
		{
			return string.Format("\n" + base.ToString() + "\na= {0:f2}\nb= {1:f2}\nc= {2:f2}\nPerimeter: {3:f2}\nArea: {4:f2} ", ASide,
				BSide, CSide, CalculatePerimeter(), CalculateArea());
		}
	}
}

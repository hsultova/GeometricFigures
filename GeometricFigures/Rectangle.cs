namespace GeometricFigures
{
	public class Rectangle : GeometryObject, IObject2D
	{
		private double _aSide;
		private double _bSide;

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

		public Rectangle(string name, double aSide, double bSide) : base(name)
		{
			_aSide = aSide;
			_bSide = bSide;
		}

		public double CalculatePerimeter()
		{
			double perimeter = 2 * ASide + 2 * BSide;
			return perimeter;
		}

		public double CalculateArea()
		{
			double area = ASide * BSide;
			return area;
		}

		public override string ToString()
		{
			return string.Format("\n" + base.ToString() + "\na= {0:f2}\nb= {1:f2}\nPerimeter: {2:f2}\nArea: {3:f2} ", ASide,
				BSide, CalculatePerimeter(), CalculateArea());
		}
	}
}

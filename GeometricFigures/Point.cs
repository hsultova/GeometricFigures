using System;

namespace GeometricFigures
{
	public class Point : GeometryObject
	{
		public double XAxis { get; set; }
		public double YAxis { get; set; }

		public Point(string name, double x, double y) : base(name)
		{
			XAxis = x;
			YAxis = y;
		}

		public override string ToString()
		{
			return String.Format( base.ToString() + "({0},{1})", XAxis,YAxis);
		}
	}
}

using System;

namespace GeometricFigures
{
	public class Cylinder : GeometryObject, IObject3D
	{
		private double _radius;
		private double _height;

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

		public double Height
		{
			get
			{
				return _height;
			}
			set
			{
				if (value > 0)
				{
					_height = value;
				}
			}
		}

		public Cylinder(string name, double radius, double height) : base(name)
		{
			_radius = radius;
			_height = height;
		}

		public double CalculateSurface()
		{
			double surface = 2 * Math.PI * Radius * (Height + Radius);
			return surface;
		}

		public double CalculateVolume()
		{
			double volume = Math.PI * Radius * Radius * Height;
			return volume;
		}

		public override string ToString()
		{
			return string.Format("\n" + base.ToString() + "\nRadius: {0:f2}\nHeight: {1:f2}\nSurface: {2:f2}\nVolume: {3:f2} ", Radius, Height,
				CalculateSurface(), CalculateVolume());
		}
	}
}

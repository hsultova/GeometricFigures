using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricFigures
{
	public class Sphere : GeometryObject, IObject3D
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

		public Sphere(string name, double radius) : base(name)
		{
			_radius = radius;
		}

		public double CalculateSurface()
		{
			double surface = 4 * Radius * Radius * Math.PI;
			return surface;
		}

		public double CalculateVolume()
		{
			double volume = 4 / 3 * Math.PI * Radius * Radius * Radius;
			return volume;
		}

		public override string ToString()
		{
			return string.Format("\n" + base.ToString() + "\nRadius: {0:f2}\nSurface: {1:f2}\nVolume: {2:f2} ", Radius,
				CalculateSurface(), CalculateVolume());
		}
	}
}

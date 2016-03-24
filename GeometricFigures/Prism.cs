using System;

namespace GeometricFigures
{
	public class Prism : GeometryObject, IObject3D
	{
		private int _anglesNumber;
		private double _side;
		private double _height;

		public int AngleNumber
		{
			get
			{
				return _anglesNumber;
			}
			set
			{
				if (value == 3 || value == 4)
				{
					_anglesNumber = value;
				}
				else
				{
					Console.WriteLine("Enter number of angles 3 or 4.");
				}
			}
		}

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

		public Prism(string name,int anglesNumber, double side, double height) : base(name)
		{
			_anglesNumber = anglesNumber;
			_side = side;
			_height = height;
		}

		public double CalculateSurface()
		{
			double surface = 0;

			if (AngleNumber == 3)
			{
				surface = 3 * Side * Height + Side * Side * (Math.Sqrt(3) / 2);
			}
			else
			{
				surface = 4 * Height * Side + 2 * Side * Side;
			}
			return surface;
		}

		public double CalculateVolume()
		{
			double volume = 0;

			if (AngleNumber == 3)
			{
				volume = Side * Side * (Math.Sqrt(3) / 4) * Height;
			}
			else
			{
				volume = Side * Side * Height;
			}
			return volume;
		}

		public override string ToString()
		{
			return string.Format("\n" + base.ToString() + "\nAngles number: {0}\nSide: {1:f2}\nHeight: {2:f2}\nSurface: {3:f2}\nVolume: {4:f2} ", AngleNumber, Side,
				Height, CalculateSurface(), CalculateVolume());
		}
	}
}

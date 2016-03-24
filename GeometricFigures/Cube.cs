namespace GeometricFigures
{
	public class Cube : GeometryObject, IObject3D
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

		public Cube(string name, double side) : base(name)
		{
			_side = side;
		}

		public double CalculateSurface()
		{
			double surface = 6 * Side * Side;
			return surface;
		}

		public double CalculateVolume()
		{
			double volume = Side * Side * Side;
			return volume;
		}

		public override string ToString()
		{
			return string.Format("\n" + base.ToString() + "\nSide: {0:f2}\nSurface: {1:f2}\nVolume: {2:f2} ", Side,
				CalculateSurface(), CalculateVolume());
		}
	}
}

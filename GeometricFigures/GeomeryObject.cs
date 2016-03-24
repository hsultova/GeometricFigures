using System;

namespace GeometricFigures
{
	public class GeometryObject
	{
		public string ObjectName { get; set; }

		public GeometryObject(string name)
		{
			ObjectName = name;
		}

		public override string ToString()
		{
			return String.Format("Name: {0}", ObjectName);
		}
	}
}

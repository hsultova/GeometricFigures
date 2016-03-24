namespace GeometricFigures
{
	public class Line : GeometryObject
	{
		public Point FirstPoint { get; set; }
		public Point LastPoint { get; set; }

		public Line(string name, Point firstPoint, Point lastPoint) : base(name)
		{
			FirstPoint = firstPoint;
			LastPoint = lastPoint;
		}
	}
}

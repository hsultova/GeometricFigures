using System;
using System.Collections.Generic;

namespace GeometricFigures
{
	class Program
	{
		static void Main(string[] args)
		{
			List<GeometryObject> geometryObjects = new List<GeometryObject>();

			Console.Write("Type of object: ");
			string objectType = Console.ReadLine();

			Sphere sphere = new Sphere("Sphere", 5);
			Pyramid pyramid1 = new Pyramid("Pyramid 1", 3, 8, 12);
			Pyramid pyramid2 = new Pyramid("Pyramid 2", 5, 8, 12);
			Cylinder cylinder = new Cylinder("Cylinder", 2.55, 5);

			switch (objectType)
			{
				case "circle":
					AddCircle(geometryObjects);
					break;
				case "cube":
					AddCube(geometryObjects);
					break;
				case "cylinder":
					AddCylinder(geometryObjects);
					break;
				case "prism":
					AddPrism(geometryObjects);
					break;
				case "pyramid":
					AddPyramid(geometryObjects);
					break;
				case "rectangle":
					AddRectangle(geometryObjects);
					break;
				case "sphere":
					AddSphere(geometryObjects);
					break;
				case "square":
					AddSquare(geometryObjects);
					break;
				case "triangle":
					AddTriangle(geometryObjects);
					break;
			}
			Console.WriteLine(objectType + " was added to collections");

			geometryObjects.Add(sphere);
			geometryObjects.Add(pyramid2);
			geometryObjects.Add(cylinder);
			geometryObjects.Add(pyramid1);
		}

		public static void AddCircle(List<GeometryObject> geometryObjects)
		{
			Console.Write("Radius: ");
			double radius = double.Parse(Console.ReadLine());

			Circle circle = new Circle("Circle", radius);
			geometryObjects.Add(circle);
        }

		public static void AddCube(List<GeometryObject> geometryObjects)
		{
			Console.Write("Side: ");
			double side = double.Parse(Console.ReadLine());

			Cube cube = new Cube("Cube", side);
			geometryObjects.Add(cube);
		}

		public static void AddCylinder(List<GeometryObject> geometryObjects)
		{
			Console.Write("Radius: ");
			double radius = double.Parse(Console.ReadLine());

			Console.Write("Height: ");
			double height = double.Parse(Console.ReadLine());

			Cylinder cylinder = new Cylinder("Cylinder", radius, height);
			geometryObjects.Add(cylinder);
		}

		public static void AddPrism(List<GeometryObject> geometryObjects)
		{
			Console.Write("Number of angles");
			int anglesNumber = int.Parse(Console.ReadLine());

			Console.Write("Side: ");
			double side = double.Parse(Console.ReadLine());

			Console.Write("Height: ");
			double height = double.Parse(Console.ReadLine());

			Prism prism = new Prism("Prism", anglesNumber, side, height);
			geometryObjects.Add(prism);
		}

		public static void AddPyramid(List<GeometryObject> geometryObjects)
		{
			Console.Write("Number of angles");
			int anglesNumber = int.Parse(Console.ReadLine());

			Console.Write("Side: ");
			double side = double.Parse(Console.ReadLine());

			Console.Write("Height: ");
			double height = double.Parse(Console.ReadLine());

			Pyramid pyramid = new Pyramid("Pyramid", anglesNumber, side, height);
			geometryObjects.Add(pyramid);
		}

		public static void AddRectangle(List<GeometryObject> geometryObjects)
		{
			Console.Write("Side a: ");
			double aSide = double.Parse(Console.ReadLine());

			Console.Write("Side b: ");
			double bSide = double.Parse(Console.ReadLine());

			Rectangle rectangle = new Rectangle("Rectangle", aSide, bSide);
			geometryObjects.Add(rectangle);
		}

		public static void AddSphere(List<GeometryObject> geometryObjects)
		{
			Console.Write("Radius: ");
			double radius = double.Parse(Console.ReadLine());

			Sphere sphere = new Sphere("Sphere", radius);
			geometryObjects.Add(sphere);
		}

		public static void AddSquare(List<GeometryObject> geometryObjects)
		{
			Console.Write("Side: ");
			double side = double.Parse(Console.ReadLine());

			Square square = new Square("Square", side);
			geometryObjects.Add(square);
		}

		public static void AddTriangle(List<GeometryObject> geometryObjects)
		{
			Console.Write("Side a: ");
			double aSide = double.Parse(Console.ReadLine());

			Console.Write("Side b: ");
			double bSide = double.Parse(Console.ReadLine());

			Console.Write("Side c: ");
			double cSide = double.Parse(Console.ReadLine());

			Triangle triangle = new Triangle("Triangle", aSide, bSide, cSide);
			geometryObjects.Add(triangle);
		}
	}
}

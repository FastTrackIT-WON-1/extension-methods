using System;
using System.Text;

namespace ExtensionMethods
{
    public static class ShapeExtensions
    {
        public static void Rotate(this IShape shape, double angleDegrees)
        {
            if ((shape is null) || (shape.Points is null))
            {
                return;
            }

            foreach (Point p in shape.Points)
            {
                p.Rotate(angleDegrees);
            }
        }

        public static void Translate(this IShape shape, int dx, int dy)
        {
            if ((shape is null) || (shape.Points is null))
            {
                return;
            }

            foreach (Point p in shape.Points)
            {
                p.Translate(dx, dy);
            }
        }

        public static void Print(this IShape shape)
        {
            if ((shape is null) || (shape.Points is null))
            {
                return;
            }

            StringBuilder sbShapeAreaAndCoords = new StringBuilder();
            sbShapeAreaAndCoords.AppendLine($"Shape {shape.GetType().Name} - Area: {shape.GetArea()}");
            for (int i = 0; i < shape.Points.Length; i++)
            {
                sbShapeAreaAndCoords.AppendLine($"Point {i + 1} at ({ Math.Round(shape.Points[i].X) }, { Math.Round(shape.Points[i].Y) })");
            }

            Console.WriteLine(sbShapeAreaAndCoords.ToString());
        }
    }
}

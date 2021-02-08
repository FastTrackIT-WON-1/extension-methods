using System;

namespace ExtensionMethods
{
    public class Point
    {
        public Point(double x, double y)
        {
            this.X = x;
            this.Y = y;
        }

        public double X
        {
            get;
            set;
        }

        public double Y
        {
            get;
            set;
        }

        public static implicit operator string(Point p)
        {
            return $"[{p.X}, {p.Y}]";
        }

        public static explicit operator Point(string coords)
        {
            if (string.IsNullOrWhiteSpace(coords))
            {
                throw new FormatException($"String '{coords}' doesn't represent a valid point format!");
            }

            string sanitized = coords.Replace("[", string.Empty)
                                     .Replace("]", string.Empty);

            string[] parts = sanitized.Split(",", StringSplitOptions.RemoveEmptyEntries);
            if(parts.Length != 2)
            {
                throw new FormatException($"String '{coords}' doesn't represent a valid point format!");
            }

            if(!double.TryParse(parts[0], out double x))
            {
                throw new FormatException($"String '{parts[0]}' doesn't represent a valid real number!");
            }

            if (!double.TryParse(parts[1], out double y))
            {
                throw new FormatException($"String '{parts[1]}' doesn't represent a valid real number!");
            }

            return new Point(x, y);
        }
    }
}

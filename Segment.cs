using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4_Kashin_1Part
{
    internal class Segment
    {
        public Point Start { get; set; }
        public Point End { get; set; }

        public Segment(Point start, Point end)
        {
            Start = start;
            End = end;
            Console.WriteLine($"Створено відрізок від {Start} до {End}");
        }

        public double Length()
        {
            double dx = End.X - Start.X;
            double dy = End.Y - Start.Y;
            return Math.Sqrt(dx * dx + dy * dy);
        }

        public override string ToString()
        {
            return $"Відрізок: {Start} - {End}, довжина: {Length()}";
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;
            Segment other = (Segment)obj;
            return Start.Equals(other.Start) && End.Equals(other.End);
        }
        public override int GetHashCode()
        {
            return Start.GetHashCode() ^ End.GetHashCode();
        }
    }
}

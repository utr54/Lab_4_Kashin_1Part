using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4_Kashin_1Part
{
    internal class Square : Figure
    {
        public Point Point { get; set; }
        public Segment Side { get; set; }
        public double Angle { get; set; } = 0;

        public Square(Point point, Segment side)
        {
            if (side == null || side.Length() <= 0)
            {
                Console.WriteLine("Відрізок сторони не може бути null або мати нульову довжину.");
            }
            Point = point;
            Side = side;
            Console.WriteLine($"Створено квадрат з точкою {Point} та {Side}");
        }

        public override void SetDimensions()
        {
            Console.WriteLine($"Отримуємо довжину сторони: {Side.Length()}");
        }

        public void SetDimensions(double newLength)
        {
            Console.WriteLine();
            if (newLength <= 0)
            {
                Console.WriteLine($"Нова довжина сторони ({newLength}) повинна бути більшою за нуль. Розміри не змінено.");
                return;
            }
            double currentLength = Side.Length();
            if (currentLength == 0)
            {
                Console.WriteLine("Неможливо встановити розміри, оскільки довжина відрізка дорівнює 0.");
                return;
            }
            double ratio = newLength / currentLength;
            double dx = Side.End.X - Side.Start.X;
            double dy = Side.End.Y - Side.Start.Y;
            dx *= ratio;
            dy *= ratio;
            Side.End = new Point(Side.Start.X + dx, Side.Start.Y + dy);
            Console.WriteLine($"Встановлено нову довжину сторони квадрата: {newLength}");
        }

        public override void Stretch(double factor)
        {
            if (factor <= 0)
            {
                Console.WriteLine();
                Console.WriteLine($"Коефіцієнт розтягнення ({factor}) повинен бути більшим за нуль. Розтягнення не виконано.");
                return;
            }
            SetDimensions(Side.Length() * factor);
            Console.WriteLine($"Квадрат розтягнуто у {factor} разів.");
        }

        public override void Compress(double factor)
        {
            if (factor <= 0 || factor >= 1)
            {
                Console.WriteLine();
                Console.WriteLine($"Коефіцієнт стиснення ({factor}) повинен бути більшим за нуль та менше за 1. Стиснення не виконано.");
                return;
            }
            SetDimensions(Side.Length() * factor);
            Console.WriteLine($"Квадрат стиснуто у {factor} разів.");
        }

        public override void Rotate(double angle)
        {
            Console.WriteLine();
            Angle += angle;
            Angle = Angle % 360;
            if (Angle < 0)
            {
                Angle += 360;
            }
            Console.WriteLine($"Квадрат повернуто на {angle} градусів. Поточний кут: {Angle}°");
        }

        public override void ChangeColor(string newColor)
        {
            Console.WriteLine();
            if (string.IsNullOrWhiteSpace(newColor))
            {
                Console.WriteLine($"Новий колір не може бути порожнім. Колір не змінено.");
                return;
            }
            Color = newColor;
            Console.WriteLine($"Колір квадрата змінено на: {Color}");
        }

        public void ChangeColor()
        {
            ChangeColor("Синій");
        }

        public override string ToString()
        {
            return $"Квадрат: Точка {Point}, Сторона {Side}, Кут повороту: {Angle}°, Колір: {Color}";
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;
            Square other = (Square)obj;
            return Point.Equals(other.Point) &&
                   Side.Equals(other.Side) &&
                   Angle == other.Angle &&
                   Color == other.Color;
        }
        public override int GetHashCode()
        {
            return Point.GetHashCode() ^ Side.GetHashCode() ^ Angle.GetHashCode() ^ (Color?.GetHashCode() ?? 0);
        }
    }
}

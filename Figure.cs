using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4_Kashin_1Part
{
    public abstract class Figure
    {
        public string Color { get; set; } = "Чорний";

        public abstract void SetDimensions();
        public abstract void Stretch(double factor);
        public abstract void Compress(double factor);
        public abstract void Rotate(double angle);
        public abstract void ChangeColor(string newColor);

        public override string ToString()
        {
            return $"Фігура кольору: {Color}";
        }
    }
}

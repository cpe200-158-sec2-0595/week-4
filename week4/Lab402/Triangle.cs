using System;

namespace Lab4
{
    public class Triangle : Shape
    {

        public Triangle() : base("gold")
        {
            Width = 1.0;
            Height = 1.0;
        }

        public Triangle(string color, double w, double h) : base(color)
        {
            Width = w;
            Height = h;
        }

        public Triangle(Triangle rec) : base(rec.Color)
        {
            Width = rec.Width;
            Height = rec.Height;
        }

        public override double getArea()
        {
            return Width * Height;
        }

        public override double getPerimeter()
        {
            return Width + Height + Math.Sqrt((Width * Width + Height * Height));
        }

        public override string ToString()
        {
            return "[Triangle: base=" + Width + ", height=" + Height + ", area=" + getArea() + ", color=\"" + Color + "\"]";
        }
    }
}
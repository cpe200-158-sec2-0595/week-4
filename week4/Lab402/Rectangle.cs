using System;

namespace Lab4
{
    public class Rectangle : Shape
    {


        public Rectangle() : base("gold")
        {
            Width = 1;
            Height = 1;
        }

        public Rectangle(string c, double w, double h) : base(c)
        {
            Width = w;
            Height = h;
        }

        public Rectangle(Rectangle rec) : base(rec.Color)
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
            return Width + Width + Height + Height;
        }

        public override string ToString()
        {
            return "[Rectangle: width=" + Width + ", height=" + Height + ", area=" + getArea() + ", color=\"" + Color + "\"]";
        }

    }
}
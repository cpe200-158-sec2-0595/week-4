using System;

namespace Lab4
{
    public class Cylinder : Circle
    {
        private double height;

        public double Height
        {
            get { return height; }
            set
            {
                if (value >= 0)
                    height = value;
                else height = 1;
            }
        }


        public Cylinder()
        {
            height = 1.0;
            setCircle(0, 0, 1);
        }

        public Cylinder(Circle c3) //: base(c3)
        {
            height = 1.0;
            setCircle(c3.Center.x, c3.Center.y, c3.Radius);
        }

        public Cylinder(Cylinder cl3)
        {
            height = cl3.Height;
            setCircle(cl3.Center.x, cl3.Center.y, cl3.Radius);
        }

        public Cylinder(double x, double y, double r, double h) : base(x, y, r)
        {
            height = h;
            setCircle(x, y, r);
        }
        public Cylinder(double r, double h) : base(0, 0, r)
        {
            height = h;
            setCircle(0, 0, r);
        }

        public override double getArea()
        {
            return base.getArea() * 2 + (2 * Math.PI * Radius * height);
        }
        public double getVolume()
        {
            return height * base.getArea();
        }
        public override string ToString()
        {
            return "[Cylinder: center" + Center + ", radius=" + Radius + ", height=" + height + ", surface=" + getArea() + ", volume=" + getVolume() + "]";
            //[Cylinder: center(0, 0), radius=1, height=1, surface=12.5663706143592, volume=3.14159265358979]
        }

    }
}
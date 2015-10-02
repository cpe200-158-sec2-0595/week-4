using System;

namespace Lab4
{
    public class Circle
    {
        public Point Center { get; set; }

        private double radius;

        public double Radius
        {
            get { return radius; }
            set
            {
                if (value >= 0)
                    radius = value;
                else radius = 1.0;
            }
        }

        public Circle()
        {
            setCircle(0, 0, 1.0);
        }
        public Circle(double r)
        {
            setCircle(0, 0, r);
        }
        public Circle(double x, double y, double r)
        {
            setCircle(x, y, r);
        }
        public Circle(Circle tmp)
        {
            setCircle(tmp.Center.x, tmp.Center.y, tmp.radius);
        }

        public void setCircle(double x, double y, double r)
        {
            Center = new Point(x, y);
            this.radius = r;
        }

        public virtual double getArea()
        {
            return Math.PI * radius * radius;
        }

        public override string ToString()
        {
            return "[Circle: center" + Center + ", radius=" + radius + ", area=" + getArea() + "]";
        }
    }
}
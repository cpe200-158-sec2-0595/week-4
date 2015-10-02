using System;

namespace Lab4
{
    public class Point
    {
        public double x { get; set; }
        public double y { get; set; }

        public Point()
        {
            x = 0;
            y = 0;
        }
        public Point(Point tmp)
        {
            x = tmp.x;
            y = tmp.y;
        }
        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public override string ToString()
        {
            return "(" + x + "," + y + ")";

        }
    }
}
//# 1. point class:
//## propeties:
//- double x, y : represent a point in 2d cartesian coordinate system

//    ## Constructors:
//- Point(): default
//- Point(Point): copy constructor
//- Point(double x, double y): take x and y as parementers
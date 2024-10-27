using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vertice
{
    public class Vertice
    {
        private double x;
        public double X{ get { return x; } }

        private double y;
        public double Y { get { return y; } }


        public Vertice(double x, double y)
        {
            this.x = x; this.y = y;
        }

        public double Distancia(Vertice vert)
        {
            double DEx = Math.Pow((this.x - vert.x), 2);
            double DEy = Math.Pow((this.y - vert.y), 2);

            return Math.Sqrt(DEx + DEy);
        }

        public void Move(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public bool isEqual(Vertice vert)
        {
            if (vert.x == this.x && vert.y == this.y) return true;
            else return false;
        }
    }
}

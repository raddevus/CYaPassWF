using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace CYaPass
{
    class Segment
    {
        public Point Begin;
        public Point End;
        public int PointValue;
        public Segment(Point begin, Point end, int pointValue)
        {
            Begin = begin;
            End = end;
            PointValue = pointValue;
        }

        public override bool Equals(object obj)
        {
            var incoming = obj as Segment;

            if (incoming == null)
            {
                return false;
            }

            bool a = ((this.Begin.X == incoming.Begin.X) && (this.Begin.Y == incoming.Begin.Y)) &&
                    ((this.End.X == incoming.End.X) && (this.End.Y == incoming.End.Y));

            bool b = ((this.Begin.X == incoming.End.X) && (this.Begin.Y == incoming.End.Y)) &&
                    ((this.End.X == incoming.Begin.X) && (this.End.Y == incoming.Begin.Y));
            return (a || b);
        }

        public override int GetHashCode()
        {
            var flippedHashValueString = String.Format("{0}{1}{2}{3}",
                    this.End.X, this.End.Y,
                    this.Begin.X, this.Begin.Y);
            
            var hashValueString = String.Format("{0}{1}{2}{3}",
                    this.Begin.X, this.Begin.Y,
                    this.End.X, this.End.Y);
            
            return flippedHashValueString.GetHashCode() + hashValueString.GetHashCode();
        }
    }
}

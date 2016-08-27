using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragPass
{
    class LineSegment
    {
        public Point Start { get; set; }
        public Point End { get; set; }
        public LineSegment(Point start, Point end)
        {
            Start = start;
            End = end;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace CYaPass
{
    class UserPath
    {
        public List<Point> allPoints = new List<Point>();
        public HashSet<Segment> allSegments = new HashSet<Segment>();
        private Point currentPoint;
        public int PointValue;
        private int previousPostValue;

        public void append(Point currentPoint, int postValue)
        {
            this.currentPoint = currentPoint;
            
            if (allPoints.Count >= 1)
            {
                if (allPoints[allPoints.Count - 1].X == currentPoint.X && allPoints[allPoints.Count - 1].Y == currentPoint.Y)
                {
                    // user clicked the same point twice
                    return;
                }
                allSegments.Add(new Segment(allPoints[allPoints.Count - 1], currentPoint, postValue + previousPostValue));
            }
            allPoints.Add(currentPoint);
            previousPostValue = postValue;

        }

        public void CalculateGeometricValue()
        {
            this.PointValue = 0;
            foreach (Segment s in allSegments)
            {
                this.PointValue += s.PointValue;
            }
        }
    }
}

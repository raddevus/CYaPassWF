using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragPass 
{
    class LineSegments : List<LineSegment>
    {
        public String PostPoints { get; set; }
        public int PostValue { get; set; }
        public void AddOn(int pointValue)
        {
            PostValue += pointValue;
            PostPoints += String.Format("{0},", pointValue);
        }

    }
}

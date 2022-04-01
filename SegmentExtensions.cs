using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeometryTasks;

namespace GeometryPainting
{
    static class SegmentExtension
    {
        public static Color GetColor(this Segment a)
        {
            return Color.Green;
        }
        public static Color SetColor(this Segment a, Color color)
        {
            return color;
        }
    }
}


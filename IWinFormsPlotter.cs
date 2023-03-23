using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plot
{
    public interface IWinFormsPlotter
    {
        Point CenterPoint { get; set; }
        float Unit { get; set; }
        float FontSizeInPoints { get; set; }
        Color PlotColor { get; set; }
        float PlotWidth { get; set; }

        void DrawAxes(Graphics graphics, int width, int height);
        void DrawGrid(Graphics graphics, int width, int height);
        void DrawPlot(Graphics graphics, IFunction function, int width);
        PointF GetCoordsAtPoint(Point point);
    }
}

using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plot
{
    public interface IControlToBitmap
    {
        Control ControlToSaveBitmapFor { get; set; }

        void SaveToLocation(string location, ImageFormat imageFormat);
    }
}

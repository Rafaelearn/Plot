using System.Drawing.Imaging;
using System.Globalization;
using Plot.Properties;

namespace Plot
{
    public partial class FormPlot : Form
    {
        private readonly IWinFormsPlotter _plotter;
        private readonly IControlToBitmap _controlToBitmap;
        private IFunction _function = new PolynomialFunction(1, -2, 1, -4);
        private bool _mousePressedOnPlot = false;
        private Point _lastCenterPoint;
        private Point _pressedAtLocation;

        public FormPlot(IControlToBitmap controlToBitmap, IWinFormsPlotter plotter)
        {
            InitializeComponent();
            _controlToBitmap = controlToBitmap;
            _plotter = plotter;
            _controlToBitmap.ControlToSaveBitmapFor = pictureBoxPlot;
            pictureBoxPlot.MouseWheel += PictureBoxPlot_MouseWheel;
            textBoxUnit.Text = _plotter.Unit.ToString(CultureInfo.InvariantCulture);
            textBoxFunction.Text = _function.FormatAsString();

            _lastCenterPoint = _plotter.CenterPoint = Settings.Default.PlotCenter;
            numericFontSize.Value = Settings.Default.FontSize;
            plotter.FontSizeInPoints = (float)Settings.Default.FontSize;

            numericPlotWidth.Value = Settings.Default.PlotWidth;
            plotter.PlotWidth = (float)Settings.Default.PlotWidth;

            plotter.Unit = Settings.Default.Unit;
            textBoxUnit.Text = Settings.Default.Unit.ToString(CultureInfo.InvariantCulture);

            buttonPlotColor.BackColor = plotter.PlotColor = Settings.Default.PlotColor;
        }

        private void PictureBoxPlot_MouseWheel(object sender, MouseEventArgs e)
        {
            _plotter.Unit *= (Math.Sign(e.Delta) == 1 ? 1 / 1.1f : 1.1f);
            textBoxUnit.Text = _plotter.Unit.ToString(CultureInfo.InvariantCulture);
            pictureBoxPlot.Invalidate();
        }

        private void PictureBoxPlot_Paint(object sender, PaintEventArgs e)
        {
            var graphics = e.Graphics;
            var clipRectangle = e.ClipRectangle;
            var width = clipRectangle.Width;
            var height = clipRectangle.Height;

            graphics.Clear(Color.White);
            graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            _plotter.DrawAxes(graphics, width, height);
            _plotter.DrawPlot(graphics, _function, width);
        }

        private void PictureBoxPlot_MouseMove(object sender, MouseEventArgs e)
        {
            DisplayCoordinates(e.Location);
            MoveCenterIfMousePressed(e.Location);
        }

        private void MoveCenterIfMousePressed(Point location)
        {
            if (!_mousePressedOnPlot) return;

            _plotter.CenterPoint = new Point(_lastCenterPoint.X + location.X - _pressedAtLocation.X, _lastCenterPoint.Y + location.Y - _pressedAtLocation.Y);
            pictureBoxPlot.Invalidate();
        }

        private void DisplayCoordinates(Point point)
        {
            textBoxCoordinates.Text = _plotter.GetCoordsAtPoint(point).ToString();
        }

        private void PictureBoxPlot_SizeChanged(object sender, EventArgs e)
        {
            pictureBoxPlot.Invalidate();
        }

        private void TextBoxUnit_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!float.TryParse(textBoxUnit.Text, NumberStyles.Float, CultureInfo.InvariantCulture, out float given) || given <= 0)
                e.Cancel = true;
        }

        private void TextBoxUnit_Validated(object sender, EventArgs e)
        {
            if (float.TryParse(textBoxUnit.Text, NumberStyles.Float, CultureInfo.InvariantCulture, out float unit) && unit > 0)
                _plotter.Unit = unit;
        }

        private void ButtonSaveAsImage_Click(object sender, EventArgs e)
        {
            PromptForSaveLocation();
        }

        private void PromptForSaveLocation()
        {
            using SaveFileDialog saveFileDialog = new() { Filter = "PNG files|*.png", OverwritePrompt = false };
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
                _controlToBitmap.SaveToLocation(saveFileDialog.FileName, ImageFormat.Png);
        }


        private void NumericFontSize_ValueChanged(object sender, EventArgs e)
        {
            _plotter.FontSizeInPoints = (float)numericFontSize.Value;
            pictureBoxPlot.Invalidate();
        }

        private void PictureBoxPlot_MouseDown(object sender, MouseEventArgs e)
        {
            _mousePressedOnPlot = true;
            _pressedAtLocation = e.Location;
        }

        private void PictureBoxPlot_MouseUp(object sender, MouseEventArgs e)
        {
            _mousePressedOnPlot = false;
            _lastCenterPoint = _plotter.CenterPoint;
        }


        private void NumericPlotWidth_ValueChanged(object sender, EventArgs e)
        {
            _plotter.PlotWidth = (float)numericPlotWidth.Value;
            pictureBoxPlot.Invalidate();
        }

        private void ButtonPlotColor_Click(object sender, EventArgs e)
        {
            using ColorDialog colorDialog = new();
            if (colorDialog.ShowDialog() != DialogResult.OK)
                return;
            buttonPlotColor.BackColor = _plotter.PlotColor = colorDialog.Color;
            pictureBoxPlot.Invalidate();
        }

        private void FormPlot_FormClosing(object sender, FormClosingEventArgs e)
        {
            Settings.Default.FontSize = numericFontSize.Value;
            Settings.Default.PlotWidth = numericPlotWidth.Value;
            Settings.Default.PlotColor = buttonPlotColor.BackColor;
            Settings.Default.PlotCenter = _plotter.CenterPoint;
            Settings.Default.Unit = _plotter.Unit;

            Settings.Default.Save();
        }
        private void pictureBoxPlot_Click(object sender, EventArgs e)
        {

        }

        private void textBoxFrom_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxFunction_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormPlot_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormPlot_Load_1(object sender, EventArgs e)
        {

        }
    }
}
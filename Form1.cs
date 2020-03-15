using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaintTest3
{
    public partial class Form1 : Form
    {
        #region Global vars
        private Bitmap _canvas; //This is the offscreen drawing buffer
        private Bitmap _canvas2; //Additional offscreen drawing buffer
        private Point _anchor; //The start point for click-drag operations
        private PaintToolControl _paintingTool;
        #endregion

        #region Constructor
        public Form1()
        {
            InitializeComponent();
            _canvas = new Bitmap(this.Width, this.Height);
            _canvas2 = new Bitmap(this.Width, this.Height);
            _paintingTool = new PaintToolControl(PaintingToolType.Pen);
        }
        #endregion

        #region Mouse Events Handlers for pictureBoxCanvas
        private void pictureBoxCanvas_MouseDown(object sender, MouseEventArgs e)
        {
            _anchor = new Point(e.X, e.Y);
        }

        private void pictureBoxCanvas_MouseMove(object sender, MouseEventArgs e)
        {
            Pen p = new Pen(CurrentColorBox.BackColor, WidthTrackBar.Value);
            p.StartCap = p.EndCap = System.Drawing.Drawing2D.LineCap.Round;
            Graphics g = Graphics.FromImage(_canvas);
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias; //Почему это работает только в режиме Rectangle + MouseButtons.Left???

            Graphics g2 = Graphics.FromImage(_canvas2);
            g2.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            if (e.Button == MouseButtons.Left)
            {
                switch (_paintingTool.ChoosendPaintingTool)
                {
                    case PaintingToolType.Pen:
                        g.DrawLine(p, _anchor, e.Location);
                        _anchor = e.Location;
                        this.Invalidate();
                        pictureBoxCanvas.Image = _canvas;
                        break;
                    case PaintingToolType.Rectangle:
                        g2.Clear(Color.White); //Так получается рисовать прямоугольники только позади линий
                        g2.DrawRectangle(p, Math.Min(e.X, _anchor.X), Math.Min(e.Y, _anchor.Y), Math.Abs(e.X - _anchor.X), Math.Abs(e.Y - _anchor.Y));
                        this.Invalidate();
                        break;
                    case PaintingToolType.Circle:
                        g2.Clear(Color.White); //Так получается рисовать круги только позади линий
                        g2.DrawEllipse(p, Math.Min(e.X, _anchor.X), Math.Min(e.Y, _anchor.Y), Math.Abs(e.X - _anchor.X), Math.Abs(e.Y - _anchor.Y));
                        this.Invalidate();
                        break;
                    case PaintingToolType.Triangle:
                        Point triangleSecondFoundation = new Point(e.X, _anchor.Y);
                        g2.Clear(Color.White); //Так получается рисовать треугольники только позади линий
                        g2.DrawPolygon(p, new Point[] { _anchor, triangleSecondFoundation, new Point((triangleSecondFoundation.X + _anchor.X) / 2, e.Y)});
                        //Paint несколько иначе рисует треугольники, но мне так норм
                        this.Invalidate();
                        break;
                    default:
                        break;
                }
            }
            g2.DrawImage(_canvas, 0, 0);
            pictureBoxCanvas.Image = _canvas2;

            #region Unused code (commented out)
            //Неиспользуемая альтернатива:

            //switch (_paintingTool.ChoosendPaintingTool)
            //{
            //    case PaintingToolType.Pen:
            //        if (e.Button == MouseButtons.Left)
            //        {
            //            g.DrawLine(p, _anchor, e.Location);
            //            this.Invalidate();
            //        }
            //        pictureBoxCanvas.Image = _canvas;
            //        break;
            //    case PaintingToolType.Rectangle:

            //        if (e.Button == MouseButtons.Left)
            //        {
            //            //g2.Clear(Color.White);
            //            g2.DrawRectangle(p, Math.Min(e.X, _anchor.X), Math.Min(e.Y, _anchor.Y), Math.Abs(e.X - _anchor.X), Math.Abs(e.Y - _anchor.Y));
            //        }
            //        g2.DrawImage(_canvas, 0, 0);
            //        pictureBoxCanvas.Image = _canvas2;
            //        break;
            //    case PaintingToolType.Circle:
            //        break;
            //    case PaintingToolType.Triangle:
            //        break;
            //    default:
            //        break;
            //}
            #endregion

            g.Dispose();
            g2.Dispose();
            p.Dispose();
        }

        private void pictureBoxCanvas_MouseUp(object sender, MouseEventArgs e)
        {
            using (Pen p = new Pen(CurrentColorBox.BackColor, WidthTrackBar.Value))
            {
                p.StartCap = p.EndCap = System.Drawing.Drawing2D.LineCap.Round;
                using (Graphics g = Graphics.FromImage(_canvas))
                {
                    g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                    if (_paintingTool.ChoosendPaintingTool == PaintingToolType.Rectangle)
                    {
                        g.DrawRectangle(p, Math.Min(e.X, _anchor.X), Math.Min(e.Y, _anchor.Y), Math.Abs(e.X - _anchor.X), Math.Abs(e.Y - _anchor.Y));
                    }
                    else if (_paintingTool.ChoosendPaintingTool == PaintingToolType.Circle)
                    {
                        g.DrawEllipse(p, Math.Min(e.X, _anchor.X), Math.Min(e.Y, _anchor.Y), Math.Abs(e.X - _anchor.X), Math.Abs(e.Y - _anchor.Y));
                    }
                    else if (_paintingTool.ChoosendPaintingTool == PaintingToolType.Triangle)
                    {
                        Point triangleSecondFoundation = new Point(e.X, _anchor.Y);
                        g.DrawPolygon(p, new Point[] { _anchor, triangleSecondFoundation, new Point((triangleSecondFoundation.X + _anchor.X) / 2, e.Y) });
                    }
                }
            }
        }
        #endregion

        private void pictureBoxCanvas_Resize(object sender, EventArgs e)
        {
            ResizeCanvas();
        }

        #region Private Helpers
        /// <summary>
        /// Должен нормально ресайзить Битмеп, но если раскоментить, то расширение окна
        /// дает краш, если уже есть что-то нарисованное на холсте. На данный момент
        /// получается сделать ресайз только с полным обновлением изображения.
        /// 
        /// Абсолютно этот же код работает нормально при рисовании непосредственно на Form1
        /// </summary>
        private void ResizeCanvas()
        {
            Bitmap tmp = new Bitmap(this.Width, this.Height);
            //using (Graphics g = Graphics.FromImage(tmp))
            //{
            //    g.Clear(Color.White);
            //    if (_canvas != null)
            //    {
            //        g.DrawImage(_canvas, 0, 0);
            //        _canvas.Dispose();
            //    }
            //}
            _canvas = tmp;
        }
        #endregion

        private void AnyColorButton_MouseClick(object sender, MouseEventArgs e)
        {
            Button colorButton = (Button)sender;
            CurrentColorBox.BackColor = colorButton.BackColor;
        }

        #region Setting Painting Tool
        /// <summary>
        /// Methods attached to buttons for setting painting tool
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SetPenButton_Click(object sender, EventArgs e)
        {
            _paintingTool.ChoosendPaintingTool = PaintingToolType.Pen;
        }

        private void SetRectangleButton_Click(object sender, EventArgs e)
        {
            _paintingTool.ChoosendPaintingTool = PaintingToolType.Rectangle;
        }

        private void SetCircleButton_Click(object sender, EventArgs e)
        {
            _paintingTool.ChoosendPaintingTool = PaintingToolType.Circle;
        }

        private void SetTriangleButton_Click(object sender, EventArgs e)
        {
            _paintingTool.ChoosendPaintingTool = PaintingToolType.Triangle;
        }
        #endregion

        #region ToolStripMenu Items
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            if (saveFileDialog1.FileName != string.Empty)
            {
                _canvas.Save(saveFileDialog1.FileName);
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            if (openFileDialog1.FileName != string.Empty)
            {
                _canvas = (Bitmap)Image.FromFile(openFileDialog1.FileName);
                pictureBoxCanvas.Image = _canvas;
            }
        }

        #endregion

    }
}

using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace WinFormsApp3.Controls
{
    public class RoundButton : Button
    {
        private int borderRadius = 10;
        private int borderSize = 2;
        private Color borderColor = Color.Black;

        private Color normalBackColor = Color.RoyalBlue;
        private Color hoverBackColor = Color.MediumSlateBlue;

        private bool isHovering = false;

        [Category("RoundButton")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int BorderRadius
        {
            get { return borderRadius; }
            set { borderRadius = value; Invalidate(); }
        }

        [Category("RoundButton")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int BorderSize
        {
            get { return borderSize; }
            set { borderSize = value; Invalidate(); }
        }

        [Category("RoundButton")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Color BorderColor
        {
            get { return borderColor; }
            set { borderColor = value; Invalidate(); }
        }

        [Category("RoundButton")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Color NormalBackColor
        {
            get { return normalBackColor; }
            set { normalBackColor = value; Invalidate(); }
        }

        [Category("RoundButton")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Color HoverBackColor
        {
            get { return hoverBackColor; }
            set { hoverBackColor = value; Invalidate(); }
        }

        public RoundButton()
        {
            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderSize = 4;
            Size = new Size(120, 40);
            ForeColor = Color.White;
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            isHovering = true;
            Invalidate();
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            isHovering = false;
            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);

            pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            Rectangle rect = ClientRectangle;

            using (GraphicsPath path = GetRoundPath(rect, borderRadius))
            using (SolidBrush brush = new SolidBrush(isHovering ? hoverBackColor : normalBackColor))
            using (Pen pen = new Pen(borderColor, borderSize))
            {
                this.Region = new Region(path);

                pevent.Graphics.FillPath(brush, path);

                if (borderSize > 0)
                    pevent.Graphics.DrawPath(pen, path);

                TextRenderer.DrawText(
                    pevent.Graphics,
                    Text,
                    Font,
                    rect,
                    ForeColor,
                    TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter
                );
            }
        }

        private GraphicsPath GetRoundPath(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            int diameter = radius * 2;

            path.AddArc(rect.X, rect.Y, diameter, diameter, 180, 90);
            path.AddArc(rect.Right - diameter, rect.Y, diameter, diameter, 270, 90);
            path.AddArc(rect.Right - diameter, rect.Bottom - diameter, diameter, diameter, 0, 90);
            path.AddArc(rect.X, rect.Bottom - diameter, diameter, diameter, 90, 90);
            path.CloseFigure();

            return path;
        }
    }
}
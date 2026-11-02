using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.ComponentModel;

namespace WinFormsApp1.Custom
{
    public class RoundedLabel : Label
    {
        private int _cornerRadius = 20; // 丸みの半径

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int CornerRadius
        {
            get => _cornerRadius;
            set
            {
                _cornerRadius = value;
                UpdateRegion();
            }
        }

        public RoundedLabel()
        {
            this.BackColor = Color.LightBlue;
            this.TextAlign = ContentAlignment.MiddleCenter;
        }

        protected override void OnSizeChanged(System.EventArgs e)
        {
            base.OnSizeChanged(e);
            UpdateRegion();
        }

        private void UpdateRegion()
        {
            using (var path = new GraphicsPath())
            {
                Rectangle rect = this.ClientRectangle;
                int r = _cornerRadius;

                path.AddArc(rect.X, rect.Y, r, r, 180, 90);
                path.AddArc(rect.Right - r, rect.Y, r, r, 270, 90);
                path.AddArc(rect.Right - r, rect.Bottom - r, r, r, 0, 90);
                path.AddArc(rect.X, rect.Bottom - r, r, r, 90, 90);
                path.CloseFigure();

                this.Region = new Region(path);
            }
        }
    }
}
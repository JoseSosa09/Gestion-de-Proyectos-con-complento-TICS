using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RJM
{
	public class panelButton : Button
	{
		private int borderRadius = 30;
		private float gradientAngle = 90F;
		private Color gradientTopColor = Color.FromArgb(68, 71, 145);
		private Color gradientBottomColor = Color.FromArgb(68, 71, 145);

		//Constructor
		public panelButton()
		{
			this.FlatAppearance.BorderSize = 5;
			this.FlatAppearance.BorderColor = gradientBottomColor;
			this.BackColor = Color.FromArgb(68, 71, 145);
			this.ForeColor = Color.Black;
			this.Size = new Size(150, 58);
		}

		public int BorderRadius
		{
			get => borderRadius;
			set
			{

				borderRadius = value;
				this.Invalidate();
			}
		}

		public float GradientAngle
		{
			get => gradientAngle;
			set
			{
				gradientAngle = value;
				this.Invalidate();
			}
		}

		public Color GradientTopColor
		{
			get => gradientTopColor;
			set
			{
				gradientTopColor = value;
				this.Invalidate();
			}
		}

		public Color GradientBottomColor
		{
			get => gradientBottomColor;
			set
			{
				gradientBottomColor = value;
				this.Invalidate();
			}
		}

		private GraphicsPath GetPanelPath(RectangleF rectangle, float radius)
		{
			GraphicsPath graphicsPath = new GraphicsPath();
			graphicsPath.StartFigure();
			graphicsPath.AddArc(rectangle.Width - radius, rectangle.Height - radius, radius, radius, 0, 90);
			graphicsPath.AddArc(rectangle.X, rectangle.Height - radius, radius, radius, 90, 90);
			graphicsPath.AddArc(rectangle.X, rectangle.Y, radius, radius, 180, 90);
			graphicsPath.AddArc(rectangle.Width - radius, rectangle.Y, radius, radius, 270, 90);
			graphicsPath.CloseFigure();
			return graphicsPath;
		}

		//Overriden Methods

		protected override void OnPaint(PaintEventArgs e)
		{
			base.OnPaint(e);

			//Gradient
			e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
			LinearGradientBrush brushArtan = new LinearGradientBrush(this.ClientRectangle, this.GradientTopColor, this.gradientBottomColor, this.GradientAngle);
			Graphics graphicsArtan = e.Graphics;
			graphicsArtan.FillRectangle(brushArtan, ClientRectangle);

			//BorderRadius
			RectangleF rectangleF = new RectangleF(0, 0, this.Width, this.Height);
			if (borderRadius > 2)
			{
				using (GraphicsPath graphicsPath = GetPanelPath(rectangleF, borderRadius))
				using (Pen pen = new Pen(this.Parent.BackColor, 2))
				{
					this.Region = new Region(graphicsPath);
					e.Graphics.DrawPath(pen, graphicsPath);
				}
			}

			else this.Region = new Region(rectangleF);

		}
	}
}

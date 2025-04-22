using System;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;

namespace Swift_Edit
{
    public class SlantedTabControl : TabControl
    {
        private const int tabSlant = 10;
        private const int closeButtonSize = 12;
        private const int tabHeight = 40;

        public SlantedTabControl()
        {
            this.DrawMode = TabDrawMode.OwnerDrawFixed;
            this.SizeMode = TabSizeMode.Fixed;
            this.ItemSize = new Size(150, tabHeight);
            this.Padding = new Point(16, 4);
            this.SetStyle(ControlStyles.UserPaint, true);
        }

        protected override void OnDrawItem(DrawItemEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            TabPage tab = this.TabPages[e.Index];
            Rectangle bounds = this.GetTabRect(e.Index);

            bool isSelected = (this.SelectedIndex == e.Index);
            Color fill = isSelected ? Color.MediumSlateBlue : Color.Gray;
            Color textColor = Color.White;

            Point[] slantedPolygon = new Point[]
            {
            new Point(bounds.Left + tabSlant, bounds.Top),
            new Point(bounds.Right, bounds.Top),
            new Point(bounds.Right - tabSlant, bounds.Bottom),
            new Point(bounds.Left, bounds.Bottom)
            };

            using (SolidBrush brush = new SolidBrush(fill))
            {
                g.FillPolygon(brush, slantedPolygon);
            }

            TextRenderer.DrawText(g, tab.Text, this.Font, bounds, textColor,
                TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);

            // Draw close button
            Rectangle closeRect = GetCloseButtonRect(bounds);
            using (Pen pen = new Pen(Color.White, 2))
            {
                g.DrawLine(pen, closeRect.Left, closeRect.Top, closeRect.Right, closeRect.Bottom);
                g.DrawLine(pen, closeRect.Left, closeRect.Bottom, closeRect.Right, closeRect.Top);
            }
        }

        private Rectangle GetCloseButtonRect(Rectangle tabBounds)
        {
            return new Rectangle(
                tabBounds.Right - closeButtonSize - 8,
                tabBounds.Top + (tabBounds.Height - closeButtonSize) / 2,
                closeButtonSize,
                closeButtonSize
            );
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            for (int i = 0; i < this.TabPages.Count; i++)
            {
                Rectangle tabBounds = GetTabRect(i);
                Rectangle closeButton = GetCloseButtonRect(tabBounds);

                if (closeButton.Contains(e.Location))
                {
                    this.TabPages.RemoveAt(i);
                    break;
                }
            }

            base.OnMouseDown(e);
        }
    }
}
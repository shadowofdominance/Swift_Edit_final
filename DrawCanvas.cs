public class DrawCanvas : Panel
{
    private List<List<Point>> strokes = new(); // list of strokes
    private List<Point> currentStroke = new();

    public DrawCanvas()
    {
        this.DoubleBuffered = true; // prevent flickering
        this.BackColor = Color.White;
        this.MouseDown += StartDrawing;
        this.MouseMove += ContinueDrawing;
        this.MouseUp += FinishDrawing;
    }

    private void StartDrawing(object sender, MouseEventArgs e)
    {
        if (e.Button == MouseButtons.Left)
        {
            currentStroke = new List<Point> { e.Location };
        }
    }

    private void ContinueDrawing(object sender, MouseEventArgs e)
    {
        if (e.Button == MouseButtons.Left && currentStroke != null)
        {
            currentStroke.Add(e.Location);
            Invalidate(); // triggers Paint
        }
    }

    private void FinishDrawing(object sender, MouseEventArgs e)
    {
        if (currentStroke != null && currentStroke.Count > 0)
        {
            strokes.Add(new List<Point>(currentStroke));
            currentStroke = null;
            Invalidate();
        }
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);

        using (Pen pen = new Pen(Color.Black, 2))
        {
            // draw completed strokes
            foreach (var stroke in strokes)
            {
                for (int i = 1; i < stroke.Count; i++)
                {
                    e.Graphics.DrawLine(pen, stroke[i - 1], stroke[i]);
                }
            }

            // draw current stroke
            if (currentStroke != null)
            {
                for (int i = 1; i < currentStroke.Count; i++)
                {
                    e.Graphics.DrawLine(pen, currentStroke[i - 1], currentStroke[i]);
                }
            }
        }
    }

    // You’ll use this later for undo/redo
    public void UndoLastStroke()
    {
        if (strokes.Count > 0)
        {
            strokes.RemoveAt(strokes.Count - 1);
            Invalidate();
        }
    }
}

protected override void OnPaint(PaintEventArgs e)
{
  // Allocate graphics device context
    cardDrawing.Begin( e.Graphics );

      // Do Card drawing
        . . .

          // Release graphics device context
            cardDrawing.End();

              // Draw anything else

                base.OnPaint(e);
                }
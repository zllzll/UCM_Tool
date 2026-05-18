using System.Drawing;
using System.Windows.Forms;

namespace UCM_Tools.ExtendControls
{
    /// <summary>
    /// Transparent overlay panel for displaying GDI+ rendered text on top of VTK RenderWindowControl.
    /// Uses WS_EX_TRANSPARENT to pass mouse events through to the underlying control.
    /// </summary>
    public class TransparentOverlayPanel : Panel
    {
        private Bitmap _overlayBitmap;
        private readonly object _lock = new object();

        public TransparentOverlayPanel()
        {
            DoubleBuffered = false;
            SetStyle(ControlStyles.Opaque, false);
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.ResizeRedraw, false);
            BackColor = Color.Transparent;
            TabStop = false;
        }

        public void SetOverlayBitmap(Bitmap bmp)
        {
            lock (_lock)
            {
                _overlayBitmap = bmp;
            }
            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Bitmap bmp;
            lock (_lock)
            {
                bmp = _overlayBitmap;
            }
            if (bmp != null)
            {
                e.Graphics.DrawImageUnscaled(bmp, 0, 0);
            }
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            // Skip background painting for true transparency
        }

        protected override CreateParams CreateParams
        {
            get
            {
                var cp = base.CreateParams;
                cp.ExStyle |= 0x00000020; // WS_EX_TRANSPARENT: click-through
                return cp;
            }
        }
    }
}

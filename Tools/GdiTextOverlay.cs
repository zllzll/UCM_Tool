using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;

namespace UCM_Tools.Tools
{
    /// <summary>
    /// GDI+ bitmap overlay for high-performance batch text rendering.
    /// Renders all tracking texts to a single bitmap in one pass — 1 draw call instead of N.
    /// </summary>
    public class GdiTextOverlay : IDisposable
    {
        private Bitmap _buffer;
        private Graphics _graphics;
        private Font _font;
        private Brush _textBrush;
        private Brush _shadowBrush;
        private Brush _bgBrush;
        private StringFormat _stringFormat;
        private int _width;
        private int _height;
        private bool _disposed;

        public bool Enabled { get; set; } = true;
        public bool DrawDropShadow { get; set; } = true;
        public bool DrawBackground { get; set; } = false;
        public int MaxTargets { get; set; } = 256;

        public Font TextFont
        {
            get => _font;
            set
            {
                if (_font != value)
                {
                    _font?.Dispose();
                    _font = value;
                }
            }
        }

        public Color TextColor
        {
            set
            {
                _textBrush?.Dispose();
                _textBrush = new SolidBrush(value);
                _shadowBrush?.Dispose();
                _shadowBrush = new SolidBrush(Color.FromArgb(128, 0, 0, 0));
            }
        }

        public GdiTextOverlay()
        {
            _stringFormat = new StringFormat
            {
                FormatFlags = StringFormatFlags.NoWrap | StringFormatFlags.MeasureTrailingSpaces
            };
            _textBrush = new SolidBrush(Color.Red);
            _shadowBrush = new SolidBrush(Color.FromArgb(128, 0, 0, 0));
            _bgBrush = new SolidBrush(Color.FromArgb(180, 0, 0, 0));
            _font = new Font("Consolas", 12, FontStyle.Bold);
        }

        public void Initialize(int width, int height)
        {
            _width = width;
            _height = height;
            CreateBuffer();
        }

        public void Resize(int width, int height)
        {
            if (width == _width && height == _height) return;
            _width = width;
            _height = height;
            CreateBuffer();
        }

        private void CreateBuffer()
        {
            _graphics?.Dispose();
            _buffer?.Dispose();

            if (_width <= 0 || _height <= 0) return;

            _buffer = new Bitmap(_width, _height, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
            _graphics = Graphics.FromImage(_buffer);
            _graphics.TextRenderingHint = TextRenderingHint.AntiAliasGridFit;
            _graphics.SmoothingMode = SmoothingMode.HighQuality;
        }

        public void BeginFrame()
        {
            if (!Enabled || _graphics == null) return;
            _graphics.Clear(Color.Transparent);
        }

        public void DrawTarget(string text, float screenX, float screenY, Color? color = null)
        {
            if (!Enabled || _graphics == null || string.IsNullOrEmpty(text)) return;

            if (color.HasValue)
            {
                // Per-target color: use a temporary brush
                using (var tempBrush = new SolidBrush(color.Value))
                {
                    if (DrawDropShadow)
                        _graphics.DrawString(text, _font, _shadowBrush, screenX + 1, screenY + 1, _stringFormat);
                    _graphics.DrawString(text, _font, tempBrush, screenX, screenY, _stringFormat);
                }
                return;
            }

            if (DrawDropShadow)
                _graphics.DrawString(text, _font, _shadowBrush, screenX + 1, screenY + 1, _stringFormat);

            if (DrawBackground)
            {
                var textSize = _graphics.MeasureString(text, _font);
                var bgRect = new RectangleF(screenX - 1, screenY - 1, textSize.Width + 2, textSize.Height + 2);
                _graphics.FillRectangle(_bgBrush, bgRect);
            }

            _graphics.DrawString(text, _font, _textBrush, screenX, screenY, _stringFormat);
        }

        public void EndFrame()
        {
            if (!Enabled || _graphics == null) return;
            _graphics.Flush();
        }

        public Bitmap GetBitmap()
        {
            return _buffer;
        }

        public void Dispose()
        {
            if (_disposed) return;
            _disposed = true;
            _graphics?.Dispose();
            _buffer?.Dispose();
            _font?.Dispose();
            _textBrush?.Dispose();
            _shadowBrush?.Dispose();
            _bgBrush?.Dispose();
            _stringFormat?.Dispose();
            _graphics = null;
            _buffer = null;
            _font = null;
            _textBrush = null;
            _shadowBrush = null;
            _bgBrush = null;
            _stringFormat = null;
        }
    }
}

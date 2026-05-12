using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace UCM_Tools.ExtendControls
{
    /// <summary>
    /// 真正透明的标签 - 可以透视到父控件的背景图片
    /// </summary>
    public class TransparentLabel : Sunny.UI.UILabel
    {
        public TransparentLabel()
        {
            this.SetStyle(ControlStyles.SupportsTransparentBackColor |
                         ControlStyles.OptimizedDoubleBuffer |
                         ControlStyles.AllPaintingInWmPaint, true);
            this.BackColor = Color.Transparent;
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            if (Parent == null || Parent.BackgroundImage == null)
            {
                base.OnPaintBackground(e);
                return;
            }

            // 获取父控件的背景图片和布局方式
            Image bgImage = Parent.BackgroundImage;
            ImageLayout layout = Parent.BackgroundImageLayout;

            // 计算图片在父控件中的实际显示区域
            Rectangle parentImageRect = CalculateImageDisplayRect(Parent.ClientRectangle, bgImage.Size, layout);

            // 计算本控件相对于父控件的位置
            Point relativeLocation = this.Location;

            // 根据图片布局方式，计算源矩形
            Rectangle srcRect;

            if (layout == ImageLayout.Stretch)
            {
                // Stretch模式：图片被拉伸填满整个父控件
                // 需要将子控件位置映射到原始图片的坐标
                float scaleX = (float)bgImage.Width / Parent.ClientSize.Width;
                float scaleY = (float)bgImage.Height / Parent.ClientSize.Height;

                srcRect = new Rectangle(
                    (int)(relativeLocation.X * scaleX),
                    (int)(relativeLocation.Y * scaleY),
                    (int)(this.Width * scaleX),
                    (int)(this.Height * scaleY)
                );
            }
            else if (layout == ImageLayout.Zoom)
            {
                // Zoom模式：图片等比缩放，保持完整显示，可能有黑边
                float imageAspect = (float)bgImage.Width / bgImage.Height;
                float parentAspect = (float)Parent.ClientSize.Width / Parent.ClientSize.Height;

                float scale;
                int imgX = 0, imgY = 0;

                if (parentAspect > imageAspect)
                {
                    // 父控件更宽，图片按高度缩放
                    scale = (float)Parent.ClientSize.Height / bgImage.Height;
                    imgX = (int)((Parent.ClientSize.Width - bgImage.Width * scale) / 2);
                }
                else
                {
                    // 父控件更高，图片按宽度缩放
                    scale = (float)Parent.ClientSize.Width / bgImage.Width;
                    imgY = (int)((Parent.ClientSize.Height - bgImage.Height * scale) / 2);
                }

                // 检查子控件是否在图片显示区域内
                srcRect = new Rectangle(
                    (int)((relativeLocation.X - imgX) / scale),
                    (int)((relativeLocation.Y - imgY) / scale),
                    (int)(this.Width / scale),
                    (int)(this.Height / scale)
                );
            }
            else if (layout == ImageLayout.Center)
            {
                // Center模式：图片原尺寸居中显示
                int imgX = (Parent.ClientSize.Width - bgImage.Width) / 2;
                int imgY = (Parent.ClientSize.Height - bgImage.Height) / 2;

                srcRect = new Rectangle(
                    relativeLocation.X - imgX,
                    relativeLocation.Y - imgY,
                    this.Width,
                    this.Height
                );
            }
            else if (layout == ImageLayout.Tile)
            {
                // Tile模式：平铺，比较复杂，简单处理为绘制整个背景然后裁剪
                // 或者使用纹理画刷
                using (TextureBrush brush = new TextureBrush(bgImage))
                {
                    // 调整画刷原点以对齐平铺
                    brush.TranslateTransform(-relativeLocation.X, -relativeLocation.Y);
                    e.Graphics.FillRectangle(brush, 0, 0, this.Width, this.Height);
                }
                return; // 已经绘制完成
            }
            else
            {
                // None模式：原尺寸左上角对齐
                srcRect = new Rectangle(relativeLocation.X, relativeLocation.Y, this.Width, this.Height);
            }

            // 确保源矩形在图片范围内
            srcRect.Intersect(new Rectangle(0, 0, bgImage.Width, bgImage.Height));

            // 如果计算后的源矩形有效，则绘制
            if (srcRect.Width > 0 && srcRect.Height > 0)
            {
                // 计算目标矩形（可能需要调整大小以匹配源矩形比例）
                Rectangle destRect = new Rectangle(0, 0, srcRect.Width, srcRect.Height);

                // 如果源矩形被裁剪了，调整目标矩形
                if (layout == ImageLayout.Stretch || layout == ImageLayout.Zoom)
                {
                    float scaleX = (float)this.Width / srcRect.Width;
                    float scaleY = (float)this.Height / srcRect.Height;
                    // 保持比例，可能需要调整
                }

                e.Graphics.DrawImage(bgImage,
                    new Rectangle(0, 0, this.Width, this.Height),  // 目标：填满控件
                    srcRect,  // 源：计算后的区域
                    GraphicsUnit.Pixel);
            }
            else
            {
                // 子控件不在图片显示区域内，绘制透明背景
                base.OnPaintBackground(e);
            }
        }

        /// <summary>
        /// 计算图片在父控件中的实际显示区域
        /// </summary>
        private Rectangle CalculateImageDisplayRect(Rectangle parentRect, Size imageSize, ImageLayout layout)
        {
            switch (layout)
            {
                case ImageLayout.Stretch:
                    return parentRect;

                case ImageLayout.Center:
                    return new Rectangle(
                        (parentRect.Width - imageSize.Width) / 2,
                        (parentRect.Height - imageSize.Height) / 2,
                        imageSize.Width,
                        imageSize.Height);

                case ImageLayout.Zoom:
                    float imageAspect = (float)imageSize.Width / imageSize.Height;
                    float parentAspect = (float)parentRect.Width / parentRect.Height;

                    if (parentAspect > imageAspect)
                    {
                        int width = (int)(parentRect.Height * imageAspect);
                        return new Rectangle(
                            (parentRect.Width - width) / 2,
                            0,
                            width,
                            parentRect.Height);
                    }
                    else
                    {
                        int height = (int)(parentRect.Width / imageAspect);
                        return new Rectangle(
                            0,
                            (parentRect.Height - height) / 2,
                            parentRect.Width,
                            height);
                    }

                case ImageLayout.Tile:
                    return parentRect; // 平铺填满整个区域

                case ImageLayout.None:
                default:
                    return new Rectangle(0, 0, imageSize.Width, imageSize.Height);
            }
        }
    }
}

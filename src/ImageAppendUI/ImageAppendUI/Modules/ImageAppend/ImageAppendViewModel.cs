using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

using ImageProcessor;
using ImageProcessor.Imaging;
using ImageProcessor.Imaging.Formats;

namespace ImageAppendUI.Modules.ImageAppend
{
    public class ImageAppendViewModel : IDisposable
    {
        public ImageFactory Image;
        public ImageFactory tumbImage;

        public string UserImageName;

        public ImageAppendViewModel()
        {

        }

        public void Load(byte[] imageBytes, string ext)
        {
            if (Image == null)
                Image = new ImageFactory().Load(imageBytes);
            else
                Image.Load(imageBytes);
        }

        public ImageAppendViewModel(byte[] imageBytes, string ext)
        {
            Load(imageBytes, ext);
        }

        public ImageAppendViewModel(string userImageName)
        {
            this.UserImageName = userImageName;
        }

        public void Dispose()
        {
            Reset();
        }

        public void Reset()
        {
            Image?.Dispose(); Image = null;
            tumbImage?.Dispose(); tumbImage = null;
        }

        public void Normalize()
        {
            ISupportedImageFormat format = new JpegFormat { Quality = 70 };
            ResizeLayer resizeLayer = new ResizeLayer(new System.Drawing.Size(1024, 768), resizeMode: ResizeMode.Min);

            Image.Resize(resizeLayer)
                .Format(format);
        }

        public string GetImageExtension() => Image.CurrentImageFormat.DefaultExtension;

        public byte[] GetImageBytes()
        {
            using (MemoryStream st = new MemoryStream())
            {
                Image.Save(st);
                return st.ToArray();
            }
        }
    }
}

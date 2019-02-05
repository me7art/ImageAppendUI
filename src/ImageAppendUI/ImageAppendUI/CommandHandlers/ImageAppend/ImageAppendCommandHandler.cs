using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ImageProcessor;

using ImageAppendUI.Modules.ImageAppend;

namespace ImageAppendUI.CommandHandlers.ImageAppend
{
    public class ImageAppendCommandHandler
    {
        public void SelectImageAction(ImageAppendViewModel model, Modules.ImageAppend.ImageAppendUI ui)
        {
            using (var openDialog = new OpenFileDialog())
            {
                var res = openDialog.ShowDialog();
                if (res == DialogResult.OK)
                {
                    model.Reset();
                    model.Image = new ImageFactory();
                    model.Image.Load(openDialog.FileName);

                    ui.RefreshUI();
                }
            }
        }

        public void DeleteImageAction(ImageAppendViewModel model, Modules.ImageAppend.ImageAppendUI ui)
        {
            model.Reset();
            ui.RefreshImage();
        }
    }
}

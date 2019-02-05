using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ImageAppendUI.Modules.ImageAppend;
using ImageAppendUI.CommandHandlers.ImageAppend;

namespace DemoApp
{
    public partial class Form1 : Form
    {
        ImageAppendViewModel _imageAppendViewModel1 = new ImageAppendViewModel();
        ImageAppendViewModel _imageAppendViewModel2 = new ImageAppendViewModel();
        ImageAppendCommandHandler _imageAppendCommandHandler = new ImageAppendCommandHandler();

        public Form1()
        {
            InitializeComponent();

            this.imageAppendUI1.Bind(_imageAppendViewModel1, 
                selectImageAction: _imageAppendCommandHandler.SelectImageAction, 
                deleteImageAction: _imageAppendCommandHandler.DeleteImageAction);
            this.imageAppendUI2.Bind(_imageAppendViewModel2,
                selectImageAction: _imageAppendCommandHandler.SelectImageAction,
                deleteImageAction: _imageAppendCommandHandler.DeleteImageAction);

        }

        private void btnGetImage1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = _imageAppendViewModel1.Image?.Image;
        }

        private void btnGetImage2_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = _imageAppendViewModel2.Image?.Image;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            _imageAppendViewModel1.Dispose();
            _imageAppendViewModel2.Dispose();
        }
    }
}

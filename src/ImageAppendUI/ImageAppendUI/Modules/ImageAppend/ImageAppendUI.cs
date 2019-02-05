using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using ImageProcessor;


namespace ImageAppendUI.Modules.ImageAppend
{
    public partial class ImageAppendUI : UserControl
    {
        public string ImageName
        {
            get { return this.labelImageName.Text; }
            set { this.labelImageName.Text = value; }
        }

        private bool _selectLabelVisible = false;
        public bool SelectLabelVisible
        {
            get
            {
                return _selectLabelVisible;
            }
            set
            {
                _selectLabelVisible = value;
                linkLabelSelectImage.Visible = value;
            }
        }
        public bool SelectButtonVisible
        {
            get { return rbAdd.Visible; }
            set {
                rbAdd.Visible = value;
                splitContainer1.Panel2Collapsed = !value;
            }
        }

        private ImageAppendViewModel _model;
        private Action<ImageAppendViewModel, ImageAppendUI> _selectImageAction;
        private Action<ImageAppendViewModel, ImageAppendUI> _deleteImageAction;
        private Action<Exception, string> _errorAction;

        public ImageAppendUI()
        {
            InitializeComponent();

            linkLabelSelectImage.Parent = pictureBox1;
            linkLabelSelectImage.LinkBehavior = LinkBehavior.NeverUnderline;
            rbDeleteImage.Parent = pictureBox1;
        }

        public void Bind(ImageAppendViewModel model, 
            Action<ImageAppendViewModel, ImageAppendUI> selectImageAction,
            Action<ImageAppendViewModel, ImageAppendUI> deleteImageAction,
            Action<Exception, string> errorAction = null)
        {
            _selectImageAction = selectImageAction;
            _deleteImageAction = deleteImageAction;
            _errorAction = errorAction ?? DefaultErrorAction;

            this._model = model;
            if (model.Image != null)
            {
                RefreshTumbnail();
                rbDeleteImage.Visible = true;
                linkLabelSelectImage.Visible = false;
            }

            RefreshImage();
        }

        public void RefreshUI()
        {
            if (_model?.Image?.Image == null)
            {
                return;
            }

            RefreshTumbnail();
            RefreshImage();
        }

        // TODO: make this private?
        public void RefreshImage()
        {
            pictureBox1.Image = _model.tumbImage?.Image;

            if (_model.Image != null)
            {
                rbDeleteImage.Visible = true;
                linkLabelSelectImage.Visible = false;
            }
            else
            {
                rbDeleteImage.Visible = false;
                linkLabelSelectImage.Visible = SelectLabelVisible;
            }
        }

        private void RefreshTumbnail()
        {
            if (_model.tumbImage != null)
            {
                _model.tumbImage.Dispose();
            }

            _model.tumbImage = new ImageFactory();
            _model.tumbImage
                .Load(_model.Image.Image)
                .Resize(new Size(width: pictureBox1.Width, height: pictureBox1.Height));
        }

        private void RBAdd_Click(object sender, EventArgs e)
        {
            try
            {
                _selectImageAction.Invoke(_model, this);
            } catch (Exception ex)
            {
                _errorAction?.Invoke(ex, "Add Image");
            }
        }

        private void rbDeletePicture_Click(object sender, EventArgs e)
        {
            try
            {
                _deleteImageAction.Invoke(_model, this);
            } catch(Exception ex)
            {
                _errorAction?.Invoke(ex, "Delete Image");
            }
        }

        private void linkLabelSelectImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                _selectImageAction.Invoke(_model, this);
            }
            catch (Exception ex)
            {
                _errorAction?.Invoke(ex, "Add Image");
            }
        }

        private void DefaultErrorAction(Exception ex, string op)
        {
            MessageBox.Show($"Error: {ex.Message}", op, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }



}

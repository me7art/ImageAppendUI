namespace ImageAppendUI.Modules.ImageAppend
{
    partial class ImageAppendUI
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rbAdd = new System.Windows.Forms.Button();
            this.labelImageName = new System.Windows.Forms.Label();
            this.rbDeleteImage = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.linkLabelSelectImage = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbAdd
            // 
            this.rbAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rbAdd.Location = new System.Drawing.Point(0, 0);
            this.rbAdd.Name = "rbAdd";
            this.rbAdd.Size = new System.Drawing.Size(140, 25);
            this.rbAdd.TabIndex = 0;
            this.rbAdd.Text = "Add Image";
            this.rbAdd.Click += new System.EventHandler(this.RBAdd_Click);
            // 
            // labelImageName
            // 
            this.labelImageName.BackColor = System.Drawing.SystemColors.ControlLight;
            this.labelImageName.Location = new System.Drawing.Point(1, 1);
            this.labelImageName.Name = "labelImageName";
            this.labelImageName.Size = new System.Drawing.Size(95, 16);
            this.labelImageName.TabIndex = 0;
            this.labelImageName.Text = "Report Image";
            // 
            // rbDeleteImage
            // 
            this.rbDeleteImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbDeleteImage.BackColor = System.Drawing.Color.Transparent;
            this.rbDeleteImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbDeleteImage.Location = new System.Drawing.Point(123, 1);
            this.rbDeleteImage.Name = "rbDeleteImage";
            this.rbDeleteImage.Size = new System.Drawing.Size(16, 16);
            this.rbDeleteImage.TabIndex = 3;
            this.rbDeleteImage.TabStop = false;
            this.rbDeleteImage.Text = "X";
            this.rbDeleteImage.UseVisualStyleBackColor = false;
            this.rbDeleteImage.Visible = false;
            this.rbDeleteImage.Click += new System.EventHandler(this.rbDeletePicture_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(140, 118);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.rbDeleteImage);
            this.splitContainer1.Panel1.Controls.Add(this.labelImageName);
            this.splitContainer1.Panel1.Controls.Add(this.linkLabelSelectImage);
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.rbAdd);
            this.splitContainer1.Size = new System.Drawing.Size(140, 145);
            this.splitContainer1.SplitterDistance = 118;
            this.splitContainer1.SplitterWidth = 2;
            this.splitContainer1.TabIndex = 4;
            // 
            // linkLabelSelectImage
            // 
            this.linkLabelSelectImage.ActiveLinkColor = System.Drawing.Color.LightGray;
            this.linkLabelSelectImage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabelSelectImage.BackColor = System.Drawing.Color.Transparent;
            this.linkLabelSelectImage.DisabledLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.linkLabelSelectImage.Font = new System.Drawing.Font("Arial", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linkLabelSelectImage.LinkColor = System.Drawing.Color.DimGray;
            this.linkLabelSelectImage.Location = new System.Drawing.Point(3, 1);
            this.linkLabelSelectImage.Name = "linkLabelSelectImage";
            this.linkLabelSelectImage.Size = new System.Drawing.Size(134, 118);
            this.linkLabelSelectImage.TabIndex = 5;
            this.linkLabelSelectImage.TabStop = true;
            this.linkLabelSelectImage.Text = "+";
            this.linkLabelSelectImage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkLabelSelectImage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelSelectImage_LinkClicked);
            // 
            // ImageAppendUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Name = "ImageAppendUI";
            this.Size = new System.Drawing.Size(140, 145);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        //private Telerik.WinControls.UI.RadButton rbAdd;
        private System.Windows.Forms.Button rbAdd;
        //private Telerik.WinControls.UI.RadLabel radLabel1;
        private System.Windows.Forms.Label labelImageName;
        //private Telerik.WinControls.Themes.Office2013LightTheme office2013LightTheme1;
        //private Telerik.WinControls.UI.RadButton rbDeletePicture;
        private System.Windows.Forms.Button rbDeleteImage;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.LinkLabel linkLabelSelectImage;
    }
}

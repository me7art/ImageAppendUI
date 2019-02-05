namespace DemoApp
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnGetImage1 = new System.Windows.Forms.Button();
            this.btnGetImage2 = new System.Windows.Forms.Button();
            this.imageAppendUI2 = new ImageAppendUI.Modules.ImageAppend.ImageAppendUI();
            this.imageAppendUI1 = new ImageAppendUI.Modules.ImageAppend.ImageAppendUI();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(630, 565);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btnGetImage1
            // 
            this.btnGetImage1.Location = new System.Drawing.Point(77, 338);
            this.btnGetImage1.Name = "btnGetImage1";
            this.btnGetImage1.Size = new System.Drawing.Size(75, 23);
            this.btnGetImage1.TabIndex = 3;
            this.btnGetImage1.Text = "Get Image 1";
            this.btnGetImage1.UseVisualStyleBackColor = true;
            this.btnGetImage1.Click += new System.EventHandler(this.btnGetImage1_Click);
            // 
            // btnGetImage2
            // 
            this.btnGetImage2.Location = new System.Drawing.Point(77, 367);
            this.btnGetImage2.Name = "btnGetImage2";
            this.btnGetImage2.Size = new System.Drawing.Size(75, 23);
            this.btnGetImage2.TabIndex = 4;
            this.btnGetImage2.Text = "Get Image 2";
            this.btnGetImage2.UseVisualStyleBackColor = true;
            this.btnGetImage2.Click += new System.EventHandler(this.btnGetImage2_Click);
            // 
            // imageAppendUI2
            // 
            this.imageAppendUI2.ImageName = "Report Image 2";
            this.imageAppendUI2.Location = new System.Drawing.Point(12, 185);
            this.imageAppendUI2.Name = "imageAppendUI2";
            this.imageAppendUI2.SelectButtonVisible = false;
            this.imageAppendUI2.SelectLabelVisible = true;
            this.imageAppendUI2.Size = new System.Drawing.Size(140, 145);
            this.imageAppendUI2.TabIndex = 1;
            // 
            // imageAppendUI1
            // 
            this.imageAppendUI1.ImageName = "Report Image 1";
            this.imageAppendUI1.Location = new System.Drawing.Point(12, 12);
            this.imageAppendUI1.Name = "imageAppendUI1";
            this.imageAppendUI1.SelectButtonVisible = true;
            this.imageAppendUI1.SelectLabelVisible = false;
            this.imageAppendUI1.Size = new System.Drawing.Size(140, 145);
            this.imageAppendUI1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(158, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(630, 565);
            this.panel1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Or";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 589);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnGetImage2);
            this.Controls.Add(this.btnGetImage1);
            this.Controls.Add(this.imageAppendUI2);
            this.Controls.Add(this.imageAppendUI1);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ImageAppendUI.Modules.ImageAppend.ImageAppendUI imageAppendUI1;
        private ImageAppendUI.Modules.ImageAppend.ImageAppendUI imageAppendUI2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnGetImage1;
        private System.Windows.Forms.Button btnGetImage2;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}


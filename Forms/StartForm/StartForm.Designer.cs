namespace EasyHeadlines
{
    partial class startForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(startForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.subheadingPicturebox = new System.Windows.Forms.PictureBox();
            this.showMeButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subheadingPicturebox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(12, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(887, 475);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // subheadingPicturebox
            // 
            this.subheadingPicturebox.BackColor = System.Drawing.Color.Transparent;
            this.subheadingPicturebox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("subheadingPicturebox.BackgroundImage")));
            this.subheadingPicturebox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.subheadingPicturebox.Location = new System.Drawing.Point(209, 276);
            this.subheadingPicturebox.Name = "subheadingPicturebox";
            this.subheadingPicturebox.Size = new System.Drawing.Size(451, 148);
            this.subheadingPicturebox.TabIndex = 1;
            this.subheadingPicturebox.TabStop = false;
            // 
            // showMeButton
            // 
            this.showMeButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.showMeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showMeButton.Font = new System.Drawing.Font("Montserrat", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showMeButton.ForeColor = System.Drawing.Color.White;
            this.showMeButton.Location = new System.Drawing.Point(350, 409);
            this.showMeButton.Name = "showMeButton";
            this.showMeButton.Size = new System.Drawing.Size(166, 57);
            this.showMeButton.TabIndex = 2;
            this.showMeButton.Text = "Show Me";
            this.showMeButton.UseVisualStyleBackColor = false;
            this.showMeButton.Click += new System.EventHandler(this.showMeButton_Click);
            // 
            // startForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(884, 499);
            this.Controls.Add(this.showMeButton);
            this.Controls.Add(this.subheadingPicturebox);
            this.Controls.Add(this.pictureBox1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "startForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Easy Headlines";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subheadingPicturebox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox subheadingPicturebox;
        private System.Windows.Forms.Button showMeButton;
    }
}


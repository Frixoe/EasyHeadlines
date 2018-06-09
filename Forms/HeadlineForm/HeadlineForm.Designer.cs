namespace EasyHeadlines.Forms.HeadlineForm
{
    partial class headlineForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(headlineForm));
            this.leftArrow = new System.Windows.Forms.PictureBox();
            this.rightArrow = new System.Windows.Forms.PictureBox();
            this.viewStoryButton = new System.Windows.Forms.Button();
            this.quitButton = new System.Windows.Forms.Button();
            this.headlineLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.leftArrow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightArrow)).BeginInit();
            this.SuspendLayout();
            // 
            // leftArrow
            // 
            this.leftArrow.BackColor = System.Drawing.Color.Transparent;
            this.leftArrow.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("leftArrow.BackgroundImage")));
            this.leftArrow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.leftArrow.Location = new System.Drawing.Point(12, 41);
            this.leftArrow.Name = "leftArrow";
            this.leftArrow.Size = new System.Drawing.Size(54, 201);
            this.leftArrow.TabIndex = 0;
            this.leftArrow.TabStop = false;
            this.leftArrow.Click += new System.EventHandler(this.leftArrow_Click);
            // 
            // rightArrow
            // 
            this.rightArrow.BackColor = System.Drawing.Color.Transparent;
            this.rightArrow.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rightArrow.BackgroundImage")));
            this.rightArrow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rightArrow.Location = new System.Drawing.Point(822, 41);
            this.rightArrow.Name = "rightArrow";
            this.rightArrow.Size = new System.Drawing.Size(54, 201);
            this.rightArrow.TabIndex = 0;
            this.rightArrow.TabStop = false;
            this.rightArrow.Click += new System.EventHandler(this.rightArrow_Click);
            // 
            // viewStoryButton
            // 
            this.viewStoryButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.viewStoryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewStoryButton.Font = new System.Drawing.Font("Montserrat", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewStoryButton.ForeColor = System.Drawing.Color.White;
            this.viewStoryButton.Location = new System.Drawing.Point(451, 374);
            this.viewStoryButton.Name = "viewStoryButton";
            this.viewStoryButton.Size = new System.Drawing.Size(166, 57);
            this.viewStoryButton.TabIndex = 3;
            this.viewStoryButton.Text = "View Story";
            this.viewStoryButton.UseVisualStyleBackColor = false;
            this.viewStoryButton.Click += new System.EventHandler(this.viewStoryButton_Click);
            // 
            // quitButton
            // 
            this.quitButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.quitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.quitButton.Font = new System.Drawing.Font("Montserrat", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quitButton.ForeColor = System.Drawing.Color.White;
            this.quitButton.Location = new System.Drawing.Point(264, 374);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(166, 57);
            this.quitButton.TabIndex = 3;
            this.quitButton.Text = "Quit";
            this.quitButton.UseVisualStyleBackColor = false;
            this.quitButton.Click += new System.EventHandler(this.quitButton_Click);
            // 
            // headlineLabel
            // 
            this.headlineLabel.AutoEllipsis = true;
            this.headlineLabel.BackColor = System.Drawing.Color.Transparent;
            this.headlineLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.headlineLabel.Font = new System.Drawing.Font("Montserrat SemiBold", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headlineLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.headlineLabel.Location = new System.Drawing.Point(110, 41);
            this.headlineLabel.Name = "headlineLabel";
            this.headlineLabel.Size = new System.Drawing.Size(668, 208);
            this.headlineLabel.TabIndex = 4;
            this.headlineLabel.Text = "Headline will appear here...";
            this.headlineLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // headlineForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(888, 503);
            this.Controls.Add(this.headlineLabel);
            this.Controls.Add(this.quitButton);
            this.Controls.Add(this.viewStoryButton);
            this.Controls.Add(this.rightArrow);
            this.Controls.Add(this.leftArrow);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "headlineForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Easy Headlines";
            ((System.ComponentModel.ISupportInitialize)(this.leftArrow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightArrow)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox leftArrow;
        private System.Windows.Forms.PictureBox rightArrow;
        private System.Windows.Forms.Button viewStoryButton;
        private System.Windows.Forms.Button quitButton;
        private System.Windows.Forms.Label headlineLabel;
    }
}
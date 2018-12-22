namespace Edge_and_Filter
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.PreviewPictureBox = new System.Windows.Forms.PictureBox();
            this.LoadButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CrazyButton = new System.Windows.Forms.Button();
            this.RainbowButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Laplacian5x5Button = new System.Windows.Forms.Button();
            this.Laplacian3x3Button = new System.Windows.Forms.Button();
            this.ResetButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PreviewPictureBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // PreviewPictureBox
            // 
            this.PreviewPictureBox.BackColor = System.Drawing.SystemColors.Control;
            this.PreviewPictureBox.Location = new System.Drawing.Point(20, 20);
            this.PreviewPictureBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PreviewPictureBox.Name = "PreviewPictureBox";
            this.PreviewPictureBox.Size = new System.Drawing.Size(900, 707);
            this.PreviewPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PreviewPictureBox.TabIndex = 0;
            this.PreviewPictureBox.TabStop = false;
            // 
            // LoadButton
            // 
            this.LoadButton.Location = new System.Drawing.Point(946, 20);
            this.LoadButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(363, 67);
            this.LoadButton.TabIndex = 1;
            this.LoadButton.Text = "Load Image";
            this.LoadButton.UseVisualStyleBackColor = true;
            this.LoadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(946, 574);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(363, 67);
            this.SaveButton.TabIndex = 2;
            this.SaveButton.Text = "Save Image";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CrazyButton);
            this.groupBox1.Controls.Add(this.RainbowButton);
            this.groupBox1.Location = new System.Drawing.Point(946, 100);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(363, 222);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter";
            // 
            // CrazyButton
            // 
            this.CrazyButton.Location = new System.Drawing.Point(36, 133);
            this.CrazyButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CrazyButton.Name = "CrazyButton";
            this.CrazyButton.Size = new System.Drawing.Size(296, 67);
            this.CrazyButton.TabIndex = 4;
            this.CrazyButton.Text = "Crazy";
            this.CrazyButton.UseVisualStyleBackColor = true;
            this.CrazyButton.Click += new System.EventHandler(this.CrazyButton_Click);
            // 
            // RainbowButton
            // 
            this.RainbowButton.Location = new System.Drawing.Point(36, 42);
            this.RainbowButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RainbowButton.Name = "RainbowButton";
            this.RainbowButton.Size = new System.Drawing.Size(296, 67);
            this.RainbowButton.TabIndex = 3;
            this.RainbowButton.Text = "Rainbow";
            this.RainbowButton.UseVisualStyleBackColor = true;
            this.RainbowButton.Click += new System.EventHandler(this.RainbowButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Laplacian5x5Button);
            this.groupBox2.Controls.Add(this.Laplacian3x3Button);
            this.groupBox2.Location = new System.Drawing.Point(946, 336);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(363, 222);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Edge Detection";
            // 
            // Laplacian5x5Button
            // 
            this.Laplacian5x5Button.Location = new System.Drawing.Point(36, 131);
            this.Laplacian5x5Button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Laplacian5x5Button.Name = "Laplacian5x5Button";
            this.Laplacian5x5Button.Size = new System.Drawing.Size(296, 67);
            this.Laplacian5x5Button.TabIndex = 6;
            this.Laplacian5x5Button.Text = "Laplacian 5x5";
            this.Laplacian5x5Button.UseVisualStyleBackColor = true;
            this.Laplacian5x5Button.Click += new System.EventHandler(this.Laplacian5x5Button_Click);
            // 
            // Laplacian3x3Button
            // 
            this.Laplacian3x3Button.Location = new System.Drawing.Point(36, 41);
            this.Laplacian3x3Button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Laplacian3x3Button.Name = "Laplacian3x3Button";
            this.Laplacian3x3Button.Size = new System.Drawing.Size(296, 67);
            this.Laplacian3x3Button.TabIndex = 5;
            this.Laplacian3x3Button.Text = "Laplacian 3x3";
            this.Laplacian3x3Button.UseVisualStyleBackColor = true;
            this.Laplacian3x3Button.Click += new System.EventHandler(this.Laplacian3x3Button_Click);
            // 
            // ResetButton
            // 
            this.ResetButton.Location = new System.Drawing.Point(946, 660);
            this.ResetButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(363, 67);
            this.ResetButton.TabIndex = 5;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1336, 749);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.LoadButton);
            this.Controls.Add(this.PreviewPictureBox);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PreviewPictureBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PreviewPictureBox;
        private System.Windows.Forms.Button LoadButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button CrazyButton;
        private System.Windows.Forms.Button RainbowButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Laplacian5x5Button;
        private System.Windows.Forms.Button Laplacian3x3Button;
        private System.Windows.Forms.Button ResetButton;
    }
}


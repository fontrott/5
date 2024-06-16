namespace PR4
{
    partial class Form2
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.alphaBlendTextBox2 = new ZBobb.AlphaBlendTextBox();
            this.alphaBlendTextBox4 = new ZBobb.AlphaBlendTextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.alphaBlendTextBox1 = new ZBobb.AlphaBlendTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Cornsilk;
            this.button1.Location = new System.Drawing.Point(220, 233);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(139, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 24);
            this.label1.TabIndex = 12;
            this.label1.Text = "Программа \"Автобусы\"";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PR4.Properties.Resources.jumping_bus_bus;
            this.pictureBox1.Location = new System.Drawing.Point(260, 108);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(291, 192);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // alphaBlendTextBox2
            // 
            this.alphaBlendTextBox2.BackAlpha = 10;
            this.alphaBlendTextBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.alphaBlendTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.alphaBlendTextBox2.Location = new System.Drawing.Point(12, 108);
            this.alphaBlendTextBox2.Name = "alphaBlendTextBox2";
            this.alphaBlendTextBox2.ReadOnly = true;
            this.alphaBlendTextBox2.Size = new System.Drawing.Size(465, 23);
            this.alphaBlendTextBox2.TabIndex = 20;
            this.alphaBlendTextBox2.Text = "Специальность: Информационные системы и программирование";
            // 
            // alphaBlendTextBox4
            // 
            this.alphaBlendTextBox4.BackAlpha = 10;
            this.alphaBlendTextBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.alphaBlendTextBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.alphaBlendTextBox4.Location = new System.Drawing.Point(12, 137);
            this.alphaBlendTextBox4.Name = "alphaBlendTextBox4";
            this.alphaBlendTextBox4.ReadOnly = true;
            this.alphaBlendTextBox4.Size = new System.Drawing.Size(44, 23);
            this.alphaBlendTextBox4.TabIndex = 22;
            this.alphaBlendTextBox4.Text = "Email: ";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.linkLabel1.Location = new System.Drawing.Point(62, 140);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(192, 17);
            this.linkLabel1.TabIndex = 23;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "andrejleskiv2006@gmail.com";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked_1);
            // 
            // alphaBlendTextBox1
            // 
            this.alphaBlendTextBox1.BackAlpha = 0;
            this.alphaBlendTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.alphaBlendTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.alphaBlendTextBox1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.alphaBlendTextBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.alphaBlendTextBox1.Location = new System.Drawing.Point(12, 80);
            this.alphaBlendTextBox1.Name = "alphaBlendTextBox1";
            this.alphaBlendTextBox1.ReadOnly = true;
            this.alphaBlendTextBox1.Size = new System.Drawing.Size(198, 23);
            this.alphaBlendTextBox1.TabIndex = 19;
            this.alphaBlendTextBox1.Text = "Разработал: Лескив А. С.";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ClientSize = new System.Drawing.Size(525, 279);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.alphaBlendTextBox4);
            this.Controls.Add(this.alphaBlendTextBox2);
            this.Controls.Add(this.alphaBlendTextBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.Text = "Справка";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ZBobb.AlphaBlendTextBox alphaBlendTextBox2;
        private ZBobb.AlphaBlendTextBox alphaBlendTextBox4;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private ZBobb.AlphaBlendTextBox alphaBlendTextBox1;
    }
}
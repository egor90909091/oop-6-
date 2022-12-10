namespace oop_6_last_last
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Color = new System.Windows.Forms.Button();
            this.drawSquar = new System.Windows.Forms.Button();
            this.drawTriangle = new System.Windows.Forms.Button();
            this.drawCircle = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.DecreaseButton = new System.Windows.Forms.Button();
            this.IncreaseButton = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnGroup = new System.Windows.Forms.Button();
            this.btnUnGroup = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Color
            // 
            this.Color.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Color.Location = new System.Drawing.Point(735, 177);
            this.Color.Name = "Color";
            this.Color.Size = new System.Drawing.Size(70, 50);
            this.Color.TabIndex = 4;
            this.Color.Text = "Color";
            this.Color.UseVisualStyleBackColor = true;
            this.Color.Click += new System.EventHandler(this.Color_Click);
            // 
            // drawSquar
            // 
            this.drawSquar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.drawSquar.Image = ((System.Drawing.Image)(resources.GetObject("drawSquar.Image")));
            this.drawSquar.Location = new System.Drawing.Point(734, 95);
            this.drawSquar.Name = "drawSquar";
            this.drawSquar.Size = new System.Drawing.Size(70, 50);
            this.drawSquar.TabIndex = 3;
            this.drawSquar.UseVisualStyleBackColor = true;
            this.drawSquar.Click += new System.EventHandler(this.drawSquar_Click);
            // 
            // drawTriangle
            // 
            this.drawTriangle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.drawTriangle.ForeColor = System.Drawing.Color.Cornsilk;
            this.drawTriangle.Image = ((System.Drawing.Image)(resources.GetObject("drawTriangle.Image")));
            this.drawTriangle.Location = new System.Drawing.Point(734, 46);
            this.drawTriangle.Name = "drawTriangle";
            this.drawTriangle.Size = new System.Drawing.Size(70, 50);
            this.drawTriangle.TabIndex = 2;
            this.drawTriangle.UseVisualStyleBackColor = true;
            this.drawTriangle.Click += new System.EventHandler(this.drawRectangle_Click);
            // 
            // drawCircle
            // 
            this.drawCircle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.drawCircle.BackColor = System.Drawing.SystemColors.ControlLight;
            this.drawCircle.Image = ((System.Drawing.Image)(resources.GetObject("drawCircle.Image")));
            this.drawCircle.Location = new System.Drawing.Point(734, -2);
            this.drawCircle.Name = "drawCircle";
            this.drawCircle.Size = new System.Drawing.Size(70, 50);
            this.drawCircle.TabIndex = 1;
            this.drawCircle.UseVisualStyleBackColor = false;
            this.drawCircle.Click += new System.EventHandler(this.drawCircle_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 450);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.Resize += new System.EventHandler(this.pictureBox1_Resize);
            // 
            // DecreaseButton
            // 
            this.DecreaseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DecreaseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DecreaseButton.Location = new System.Drawing.Point(734, 259);
            this.DecreaseButton.Name = "DecreaseButton";
            this.DecreaseButton.Size = new System.Drawing.Size(68, 38);
            this.DecreaseButton.TabIndex = 5;
            this.DecreaseButton.Text = "-";
            this.DecreaseButton.UseVisualStyleBackColor = true;
            this.DecreaseButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // IncreaseButton
            // 
            this.IncreaseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.IncreaseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)), true);
            this.IncreaseButton.Location = new System.Drawing.Point(734, 226);
            this.IncreaseButton.Name = "IncreaseButton";
            this.IncreaseButton.Size = new System.Drawing.Size(68, 35);
            this.IncreaseButton.TabIndex = 6;
            this.IncreaseButton.Text = "+";
            this.IncreaseButton.UseVisualStyleBackColor = true;
            this.IncreaseButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(746, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Change";
            // 
            // BtnGroup
            // 
            this.BtnGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnGroup.Location = new System.Drawing.Point(734, 296);
            this.BtnGroup.Name = "BtnGroup";
            this.BtnGroup.Size = new System.Drawing.Size(68, 38);
            this.BtnGroup.TabIndex = 8;
            this.BtnGroup.Text = "Group";
            this.BtnGroup.UseVisualStyleBackColor = true;
            this.BtnGroup.Click += new System.EventHandler(this.BtnGroup_Click);
            // 
            // btnUnGroup
            // 
            this.btnUnGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUnGroup.Location = new System.Drawing.Point(734, 332);
            this.btnUnGroup.Name = "btnUnGroup";
            this.btnUnGroup.Size = new System.Drawing.Size(68, 38);
            this.btnUnGroup.TabIndex = 9;
            this.btnUnGroup.Text = "Ungroup";
            this.btnUnGroup.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnUnGroup);
            this.Controls.Add(this.BtnGroup);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IncreaseButton);
            this.Controls.Add(this.DecreaseButton);
            this.Controls.Add(this.Color);
            this.Controls.Add(this.drawSquar);
            this.Controls.Add(this.drawTriangle);
            this.Controls.Add(this.drawCircle);
            this.Controls.Add(this.pictureBox1);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button drawCircle;
        private System.Windows.Forms.Button drawTriangle;
        private System.Windows.Forms.Button drawSquar;
        private System.Windows.Forms.Button Color;
        private System.Windows.Forms.Button DecreaseButton;
        public System.Windows.Forms.Button IncreaseButton;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnGroup;
        private System.Windows.Forms.Button btnUnGroup;
    }
}


namespace Игра_с_матрицами_Csharp
{
    partial class Лёгкие_задания_UF
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
            this.Label1 = new System.Windows.Forms.Label();
            this.btn_ex3 = new System.Windows.Forms.Button();
            this.btn_ex2 = new System.Windows.Forms.Button();
            this.btn_ex1 = new System.Windows.Forms.Button();
            this.pb_picture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_picture)).BeginInit();
            this.SuspendLayout();
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.BackColor = System.Drawing.Color.Transparent;
            this.Label1.Location = new System.Drawing.Point(11, 10);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(579, 13);
            this.Label1.TabIndex = 9;
            this.Label1.Text = "Нажмите на одну из кнопок ниже чтоб открыть задание после решения которого открое" +
    "тся часть изображения\r\n";
            // 
            // btn_ex3
            // 
            this.btn_ex3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(202)))), ((int)(((byte)(183)))));
            this.btn_ex3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(97)))), ((int)(((byte)(85)))));
            this.btn_ex3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(239)))), ((int)(((byte)(75)))));
            this.btn_ex3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ex3.Location = new System.Drawing.Point(11, 231);
            this.btn_ex3.Name = "btn_ex3";
            this.btn_ex3.Size = new System.Drawing.Size(640, 175);
            this.btn_ex3.TabIndex = 8;
            this.btn_ex3.UseVisualStyleBackColor = false;
            this.btn_ex3.Click += new System.EventHandler(this.btn_ex3_Click);
            // 
            // btn_ex2
            // 
            this.btn_ex2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(202)))), ((int)(((byte)(183)))));
            this.btn_ex2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(97)))), ((int)(((byte)(85)))));
            this.btn_ex2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(239)))), ((int)(((byte)(75)))));
            this.btn_ex2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ex2.Location = new System.Drawing.Point(396, 46);
            this.btn_ex2.Name = "btn_ex2";
            this.btn_ex2.Size = new System.Drawing.Size(255, 189);
            this.btn_ex2.TabIndex = 7;
            this.btn_ex2.UseVisualStyleBackColor = false;
            this.btn_ex2.Click += new System.EventHandler(this.btn_ex2_Click);
            // 
            // btn_ex1
            // 
            this.btn_ex1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(202)))), ((int)(((byte)(183)))));
            this.btn_ex1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(97)))), ((int)(((byte)(85)))));
            this.btn_ex1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(239)))), ((int)(((byte)(75)))));
            this.btn_ex1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ex1.Location = new System.Drawing.Point(11, 46);
            this.btn_ex1.Name = "btn_ex1";
            this.btn_ex1.Size = new System.Drawing.Size(388, 189);
            this.btn_ex1.TabIndex = 6;
            this.btn_ex1.UseVisualStyleBackColor = false;
            this.btn_ex1.Click += new System.EventHandler(this.btn_ex1_Click);
            // 
            // pb_picture
            // 
            this.pb_picture.Location = new System.Drawing.Point(11, 46);
            this.pb_picture.Name = "pb_picture";
            this.pb_picture.Size = new System.Drawing.Size(640, 360);
            this.pb_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_picture.TabIndex = 5;
            this.pb_picture.TabStop = false;
            // 
            // Лёгкие_задания_UF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 416);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.btn_ex3);
            this.Controls.Add(this.btn_ex2);
            this.Controls.Add(this.btn_ex1);
            this.Controls.Add(this.pb_picture);
            this.Name = "Лёгкие_задания_UF";
            this.Text = "Матрицы: Легко";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Лёгкие_задания_UF_FormClosed);
            this.Load += new System.EventHandler(this.Лёгкие_задания_UF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Button btn_ex3;
        internal System.Windows.Forms.Button btn_ex2;
        internal System.Windows.Forms.Button btn_ex1;
        internal System.Windows.Forms.PictureBox pb_picture;
    }
}
namespace Игра_с_матрицами_Csharp
{
    partial class Меню_сложность
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
            this.btn_Hard = new System.Windows.Forms.Button();
            this.btn_Normal = new System.Windows.Forms.Button();
            this.btn_Easy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Hard
            // 
            this.btn_Hard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(130)))), ((int)(((byte)(64)))));
            this.btn_Hard.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(58)))), ((int)(((byte)(0)))));
            this.btn_Hard.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(151)))), ((int)(((byte)(209)))));
            this.btn_Hard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(164)))), ((int)(((byte)(115)))));
            this.btn_Hard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Hard.Location = new System.Drawing.Point(70, 124);
            this.btn_Hard.Name = "btn_Hard";
            this.btn_Hard.Size = new System.Drawing.Size(148, 23);
            this.btn_Hard.TabIndex = 6;
            this.btn_Hard.Text = "Сложно";
            this.btn_Hard.UseVisualStyleBackColor = false;
            this.btn_Hard.Click += new System.EventHandler(this.btn_Hard_Click);
            // 
            // btn_Normal
            // 
            this.btn_Normal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(228)))), ((int)(((byte)(64)))));
            this.btn_Normal.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(143)))), ((int)(((byte)(0)))));
            this.btn_Normal.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(242)))), ((int)(((byte)(61)))));
            this.btn_Normal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(115)))));
            this.btn_Normal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Normal.Location = new System.Drawing.Point(70, 74);
            this.btn_Normal.Name = "btn_Normal";
            this.btn_Normal.Size = new System.Drawing.Size(148, 23);
            this.btn_Normal.TabIndex = 5;
            this.btn_Normal.Text = "Нормально";
            this.btn_Normal.UseVisualStyleBackColor = false;
            this.btn_Normal.Click += new System.EventHandler(this.btn_Normal_Click);
            // 
            // btn_Easy
            // 
            this.btn_Easy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(202)))), ((int)(((byte)(98)))));
            this.btn_Easy.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(97)))), ((int)(((byte)(15)))));
            this.btn_Easy.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(202)))), ((int)(((byte)(183)))));
            this.btn_Easy.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(202)))), ((int)(((byte)(126)))));
            this.btn_Easy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Easy.Location = new System.Drawing.Point(70, 24);
            this.btn_Easy.Name = "btn_Easy";
            this.btn_Easy.Size = new System.Drawing.Size(148, 23);
            this.btn_Easy.TabIndex = 4;
            this.btn_Easy.Text = "Легко";
            this.btn_Easy.UseVisualStyleBackColor = false;
            this.btn_Easy.Click += new System.EventHandler(this.btn_Easy_Click);
            // 
            // Меню_сложность
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 171);
            this.Controls.Add(this.btn_Hard);
            this.Controls.Add(this.btn_Normal);
            this.Controls.Add(this.btn_Easy);
            this.Name = "Меню_сложность";
            this.Text = "Выберите сложность";
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button btn_Hard;
        internal System.Windows.Forms.Button btn_Normal;
        internal System.Windows.Forms.Button btn_Easy;
    }
}
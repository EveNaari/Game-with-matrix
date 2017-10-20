namespace Игра_с_матрицами_Csharp
{
    partial class Сложная_матрица_1
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
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.btn_calc = new System.Windows.Forms.Button();
            this.tb_res_matrix = new System.Windows.Forms.TextBox();
            this.lbl_matrix1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PictureBox1
            // 
            this.PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.PictureBox1.Location = new System.Drawing.Point(183, 12);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(53, 50);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBox1.TabIndex = 52;
            this.PictureBox1.TabStop = false;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.BackColor = System.Drawing.Color.Transparent;
            this.Label1.Location = new System.Drawing.Point(15, 12);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(136, 13);
            this.Label1.TabIndex = 51;
            this.Label1.Text = "Вычислить определитель";
            // 
            // btn_calc
            // 
            this.btn_calc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(151)))), ((int)(((byte)(209)))));
            this.btn_calc.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(66)))), ((int)(((byte)(106)))));
            this.btn_calc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(166)))), ((int)(((byte)(209)))));
            this.btn_calc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_calc.Location = new System.Drawing.Point(172, 94);
            this.btn_calc.Name = "btn_calc";
            this.btn_calc.Size = new System.Drawing.Size(75, 55);
            this.btn_calc.TabIndex = 50;
            this.btn_calc.Text = "Готово";
            this.btn_calc.UseVisualStyleBackColor = false;
            this.btn_calc.Click += new System.EventHandler(this.btn_calc_Click);
            // 
            // tb_res_matrix
            // 
            this.tb_res_matrix.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(166)))), ((int)(((byte)(209)))));
            this.tb_res_matrix.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_res_matrix.Location = new System.Drawing.Point(172, 66);
            this.tb_res_matrix.Multiline = true;
            this.tb_res_matrix.Name = "tb_res_matrix";
            this.tb_res_matrix.Size = new System.Drawing.Size(75, 22);
            this.tb_res_matrix.TabIndex = 49;
            // 
            // lbl_matrix1
            // 
            this.lbl_matrix1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(164)))), ((int)(((byte)(115)))));
            this.lbl_matrix1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_matrix1.Location = new System.Drawing.Point(14, 35);
            this.lbl_matrix1.Name = "lbl_matrix1";
            this.lbl_matrix1.Size = new System.Drawing.Size(130, 113);
            this.lbl_matrix1.TabIndex = 48;
            this.lbl_matrix1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Сложная_матрица_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 161);
            this.Controls.Add(this.PictureBox1);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.btn_calc);
            this.Controls.Add(this.tb_res_matrix);
            this.Controls.Add(this.lbl_matrix1);
            this.Name = "Сложная_матрица_1";
            this.Text = "Сложная_матрица_1";
            this.Load += new System.EventHandler(this.Сложная_матрица_1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.PictureBox PictureBox1;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Button btn_calc;
        internal System.Windows.Forms.TextBox tb_res_matrix;
        internal System.Windows.Forms.Label lbl_matrix1;
    }
}
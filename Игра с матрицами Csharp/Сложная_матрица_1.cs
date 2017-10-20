using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Игра_с_матрицами_Csharp
{
    public partial class Сложная_матрица_1 : Form
    {
        float result;

        public Сложная_матрица_1()
        {
            InitializeComponent();
        }

        private void Сложная_матрица_1_Load(object sender, EventArgs e)
        {
            int[,] matrix = new int[5, 5], minor = new int[3, 3], ThirdOrder_matrix = new int[4, 4];
            int i, j, n, k, i_, j_, k_;
            Random rnd = new Random();

            for (i = 1; i <= 4; i++)
            {
                for (j = 1; j <= 4; j++)
                {
                    matrix[i, j] = rnd.Next(-10, 10);
                    lbl_matrix1.Text += matrix[i, j] + " " + "\t";
                }
                lbl_matrix1.Text += "\n";
            }

            n = 4;
            for (j = 1; j <= n; j++)
            {

                for (i = 1; i <= n - 1; i++)
                {
                    for (k = 1; k <= n - 1; k++)
                    {
                        if (k < j) ThirdOrder_matrix[i, k] = matrix[i + 1, k];
                        if (k >= j) ThirdOrder_matrix[i, k] = matrix[i + 1, k + 1];
                    }
                }

                for (j_ = 1; j_ <= n - 1; j_++)
                {
                    for (i_ = 1; i_ <= n - 2; i_++)
                    {
                        for (k_ = 1; k_ <= n - 2; k_++)
                        {
                            if (k_ < j_) minor[i_, k_] = ThirdOrder_matrix[i_ + 1, k_];
                            if (k_ >= j_) minor[i_, k_] = ThirdOrder_matrix[i_ + 1, k_ + 1];
                        }
                    }
                    result += Convert.ToSingle(Math.Pow(-1, 1 + j)) * matrix[1, j] * (Convert.ToSingle(Math.Pow(-1, 1 + j_)) * ThirdOrder_matrix[1, j_] * Det(minor));
                }
            }
        }

        public static int Det(int[,] matrix)
        {
            return matrix[1, 1] * matrix[2, 2] - matrix[1, 2] * matrix[2, 1];
        }

        private void btn_calc_Click(object sender, EventArgs e)
        {
            try
            {
                if (result == Convert.ToSingle(tb_res_matrix.Text))
                {
                    MessageBox.Show("Правильно");
                    new Сложные_задания_UF().btn_ex1.Visible = false;
                }
                else
                {
                    DialogResult MB_result;
                    MB_result = MessageBox.Show("Допущена ошибка. Открыть лекции по теме ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (MB_result == DialogResult.Yes)
                    {
                        new Лекция_нахождение_определителя().Show();
                    }
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Поле ввода не может быть пустым");
                return;
            }
            this.Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Игра_с_матрицами_Csharp
{
    public partial class Лёгкая_матрица_2 : Form
    {
        float[,] matrix_result = new float[5, 5];
        int rnd_i_1, rnd_j_2;

        public Лёгкая_матрица_2()
        {
            InitializeComponent();
        }

        private void Лёгкая_матрица_2_Load(object sender, EventArgs e)
        {
            float[,] matrix_1 = new float[5, 5], matrix_2 = new float[5, 5];
            int i, j, cells_addition_cycle, rnd_j_1, rnd_i_2;

            Random rnd = new Random();
            rnd_j_1 = rnd.Next(2, 4);
            rnd_i_2 = rnd.Next(2, 4);
            do //генерация чисел для ранга матрицы
            {
                rnd_i_1 = rnd.Next(2, 4);
                rnd_j_2 = rnd.Next(2, 4);
            } while (rnd_i_1 != rnd_j_2);

            for (i = 1; i <= rnd_i_1; i++) //цикл вывода первой матрицы
            {
                for (j = 1; j <= rnd_j_1; j++)
                {
                    matrix_1[i, j] = rnd.Next(-40, 40);
                    lbl_matrix1.Text += matrix_1[i, j] + " " + "\t";
                }
                lbl_matrix1.Text += "\n";

            }

            for (i = 1; i <= rnd_i_2; i++) //цикл вывода второй матрицы
            {
                for (j = 1; j <= rnd_j_2; j++)
                {
                    matrix_2[i, j] = rnd.Next(-40, 40);
                    lbl_matrix2.Text += matrix_2[i, j] + " " + "\t";
                }
                lbl_matrix2.Text += "\n";
            }

            for (i = 1; i <= rnd_i_1; i++) //цикл умножения матриц
            {
                for (j = 1; j <= rnd_j_2; j++)
                {
                    for (cells_addition_cycle = 1; cells_addition_cycle <= 3; cells_addition_cycle++)
                    {
                        matrix_result[i, j] += matrix_1[i, cells_addition_cycle] * matrix_2[cells_addition_cycle, j];
                    }
                }
            }
        }

        private void btn_calc_Click_1(object sender, EventArgs e)
        {
            float[,] matrix_result_check = new float[5, 5];
            string res_matrix = tb_res_matrix.Text;
            string[] matrix_1dim = new string[50];
            int i = 1, j = 1, x, cells_sum;

            res_matrix = new Regex(@"\s+").Replace(res_matrix, @" ");
            matrix_1dim = res_matrix.Split(' ');

            x = 0;
            try
            {
                for (i = 1; i <= rnd_i_1; i++)
                {
                    for (j = 1; j <= rnd_j_2; j++)
                    {
                        matrix_result_check[i, j] = Convert.ToSingle(matrix_1dim[(j - 1) + rnd_j_2 * (i - 1)]);
                        if (matrix_result[i, j] == matrix_result_check[i, j])
                        {
                            x += 1;
                        }
                    }
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Поле ввода не может быть пустым");
                return;
            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("Ошибка с рангом (размерностью) массива");
                return;
            }

            cells_sum = rnd_i_1 * rnd_j_2;
            if (x == cells_sum)
            {
                MessageBox.Show("Правильно");
                new Лёгкие_задания_UF().btn_ex1.Visible = false;
            }
            else
            {
                DialogResult MB_result;
                MB_result = MessageBox.Show("Допущена ошибка. Открыть лекции по теме ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (MB_result == DialogResult.Yes)
                {
                    new Лекция_умножение_матриц().Show();
                }
            }
            this.Close();
        }

        private void btn_help_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Элементы матрицы записывать так же, как и в задании: элементы столбцов разделяются пробелом, элементы строк - клавишей Enter", "Помощь", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
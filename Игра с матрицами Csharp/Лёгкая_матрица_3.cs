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
    public partial class Лёгкая_матрица_3 : Form
    {
        public Лёгкая_матрица_3()
        {
            InitializeComponent();
        }

        float[,] matrix_result = new float[5, 5];

        private void Лёгкая_матрица_3_Load(object sender, EventArgs e)
        {
            Random rnd = new Random();
            float[,] matrix_1 = new float[5, 5], matrix_2 = new float[5, 5];
            int i, j;
            for (i = 1; i <= 3; i++)
            {
                for (j = 1; j <= 3; j++)
                {
                    matrix_1[i, j] = rnd.Next(-100, 100);
                    lbl_matrix_1.Text += matrix_1[i, j] + " " + "\t";
                    matrix_2[i, j] = rnd.Next(-100, 100);
                    lbl_matrix_2.Text += matrix_2[i, j] + " " + "\t";
                    matrix_result[i, j] = matrix_1[i, j] - matrix_2[i, j];
                }
                lbl_matrix_1.Text += "\n";
                lbl_matrix_2.Text += "\n";
            }
        }

        private void btn_calc_Click(object sender, EventArgs e)
        {
            float[,] matrix_result_check = new float[5, 5];
            string res_matrix = tb_res_matrix.Text;
            string[] matrix_1dim = new string[50];
            int i = 1, j = 1, x;

            res_matrix = new Regex(@"\s+").Replace(res_matrix, @" ");
            matrix_1dim = res_matrix.Split(' ');

            x = 0;
            try
            {
                for (i = 1; i <= 3; i++)
                {
                    for (j = 1; j <= 3; j++)
                    {
                        matrix_result_check[i, j] = Convert.ToSingle(matrix_1dim[(j - 1) + 3 * (i - 1)]);
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

            if (x == 9)
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
                    new Лекция_сложение_и_вычитание_матриц().Show();
                }
            }
            this.Close();
        }        

        private void btn_help_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Элементы матрицы записывать так же, как и в задании: элементы столбцов разделяются пробелом, элементы строк - клавишей Enter", "Помощь", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
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
    public partial class Средняя_матрица_3 : Form
    {
        float result;

        public Средняя_матрица_3()
        {
            InitializeComponent();
        }

        private void Средняя_матрица_3_Load(object sender, EventArgs e)
        {
            int[,] matrix = new int[4, 4], minor = new int[3, 3];
            int i, j, n, k;
            Random rnd = new Random();

            for (i = 1; i <= 3; i++)
            {
                for (j = 1; j <= 3; j++)
                {
                    matrix[i, j] = rnd.Next(-10, 10);
                    lbl_matrix1.Text += matrix[i, j] + " " + "\t";
                }
                lbl_matrix1.Text += "\n";
            }
            
            n = 3;
            for (j = 1; j <= n; j++)
            {
                for (i = 1; i <= n - 1; i++)
                {
                    for (k = 1; k <= n - 1; k++)
                    {
                        if (k < j) minor[i, k] = matrix[i + 1, k];
                        if (k >= j) minor[i, k] = matrix[i + 1, k + 1];
                    }
                }
                result += Convert.ToSingle(Math.Pow(-1,(1 + j))) * (matrix[1, j] * Det(minor));
            }
        }

        public static int Det(int[,] matrix)
        {
            return (matrix[1, 1] * matrix[2, 2]) - (matrix[1, 2] * matrix[2, 1]);
        }

        private void btn_calc_Click(object sender, EventArgs e)
        {            
            try
            {
                if (result == Convert.ToSingle(tb_res_matrix.Text.Trim()))
                {
                    MessageBox.Show("Правильно");
                    new Средние_задания_UF().btn_ex1.Visible = false;
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

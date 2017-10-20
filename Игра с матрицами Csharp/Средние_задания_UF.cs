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
    public partial class Средние_задания_UF : Form
    {
        public Средние_задания_UF()
        {
            InitializeComponent();
        }

        private void Средние_задания_UF_FormClosed(object sender, FormClosedEventArgs e)
        {
            new Меню_сложность().Show();
        }

        private void btn_ex1_Click(object sender, EventArgs e)
        {
            new Средняя_матрица_1().Show();
        }

        private void btn_ex2_Click(object sender, EventArgs e)
        {
            new Средняя_матрица_2().Show();
        }

        private void btn_ex3_Click(object sender, EventArgs e)
        {
            new Средняя_матрица_3().Show();
        }

        private void btn_ex4_Click(object sender, EventArgs e)
        {
            new Средняя_матрица_4().Show();
        }

        private void Средние_задания_UF_Load(object sender, EventArgs e)
        {
            Random rnd = new Random();
            pb_picture.Image = Image.FromFile(Environment.CurrentDirectory + "\\pictures\\" + rnd.Next(1, 51) + ".jpg");
        }
    }
}

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
    public partial class Меню_сложность : Form
    {
        public Меню_сложность()
        {
            InitializeComponent();
        }

        private void btn_Easy_Click(object sender, EventArgs e)
        {
            new Лёгкие_задания_UF().Show();
            this.Hide();
        }

        private void btn_Normal_Click(object sender, EventArgs e)
        {
            new Средние_задания_UF().Show();
            this.Hide();
        }

        private void btn_Hard_Click(object sender, EventArgs e)
        {
            new Сложные_задания_UF().Show();
            this.Hide();
        }
    }
}
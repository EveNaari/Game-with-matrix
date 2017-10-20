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
    public partial class Лекция_нахождение_определителя_2 : Form
    {
        public Лекция_нахождение_определителя_2()
        {
            InitializeComponent();
        }

        private void Button2_Click_1(object sender, EventArgs e)
        {
            new Лекция_нахождение_определителя().Show();
            this.Close();
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

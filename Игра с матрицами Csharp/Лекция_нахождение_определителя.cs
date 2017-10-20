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
    public partial class Лекция_нахождение_определителя : Form
    {
        public Лекция_нахождение_определителя()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            new Лекция_нахождение_определителя_2().Show();
            this.Close();
        }
    }
}

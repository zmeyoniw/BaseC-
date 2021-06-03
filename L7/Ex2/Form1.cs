using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex2
{
    public partial class Form1 : Form
    {
        Random r;
        int n;
        int u;
        int maxCount;
        public Form1()
        {
            InitializeComponent();
            RightOrNot.Text = "Введите число";
            btnCheck.Text = "Проверить";
            this.Text = "Угадай число";
            r = new Random();
            maxCount = 5;
            count.Text = $"количество попыток {maxCount}";
        }

        private void RightOrNot_Click(object sender, EventArgs e)
        {
            if (u > n) RightOrNot.Text = "Ваше число больше чем надо";
            else if (u < n) RightOrNot.Text = "Ваше число меньше чем надо";
            else if (u == n) RightOrNot.Text = "Вы угадали!";
        }
        private void btnCheck_Click(object sender, EventArgs e)
        {
            maxCount -= 1;
            count.Text = $"количество попыток {maxCount}";
            u = Convert.ToInt32(UserAnswer.Text);
            do
            {
                if (u > n)
                {
                    RightOrNot.Text = "Ваше число больше чем надо";
                }
                else if (u < n)
                {
                    RightOrNot.Text = "Ваше число меньше чем надо";
                }
                else
                    RightOrNot.Text = "Вы угадали!";
            } while (maxCount != 0);
        }

        private void UserAnswer_TextChanged(object sender, EventArgs e)
        {
            UserAnswer.MaxLength = 3;
        }

        private void игратьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            n = r.Next(1, 100);
        }

        private void count_Click(object sender, EventArgs e)
        {

        }
    }
}

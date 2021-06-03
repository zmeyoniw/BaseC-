using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex1
{
    public partial class Form1 : Form
    {
        public int count = 0;
        Random r;
        int n;
        Stack<string> history = new Stack<string>();
        int maxCount;
        public Form1()
        {
            InitializeComponent();
            btnCommand1.Text = "+1";
            btnCommand2.Text = "x2";
            btnCancelLastStep.Text = "Отменить";
            btnReset.Text = "Сброс";
            lblNumber.Text = "1";
            lblCount.Text = $"количество действий {count.ToString()}";
            this.Text = "Удвоитель";
            r = new Random();
            
        }

        private void btnCommand1_Click(object sender, EventArgs e)
        {
            
            
                int t = int.Parse(lblNumber.Text);
                history.Push(t.ToString());
            if (t != n&&count!=maxCount)
            {
                lblNumber.Text = (t + 1).ToString();
                count++;
                lblCount.Text = $"количество действий {count.ToString()}";
            }
            else if (t == n) MessageBox.Show("Вы выиграли!");
            else if (count == maxCount) MessageBox.Show("Количество попыток закончилось");
            
        }

        private void btnCommand2_Click(object sender, EventArgs e)
        {
            
            
                int t = int.Parse(lblNumber.Text);
                history.Push(t.ToString());
                if (t != n && count!=maxCount)
                {
                    lblNumber.Text = (t * 2).ToString();
                    count++;
                    lblCount.Text = $"количество действий {count.ToString()}";
                }
                else if (t == n) MessageBox.Show("Вы выиграли!");
                else if (count == maxCount) MessageBox.Show("Количество попыток закончилось");

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            lblNumber.Text = "1";
            count = 0;
            lblCount.Text = $"количество действий {count.ToString()}";
        }

        private void lblCount_Click(object sender, EventArgs e)
        {

        }

        private void игратьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            n = r.Next(10, 20);
            maxCount = n / 2;
            MessageBox.Show("Число " + n);
        }

        private void btnCancelLastStep_Click(object sender, EventArgs e)
        {
            lblNumber.Text = history.Pop();
        }
    }
}

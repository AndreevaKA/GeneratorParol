using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ЛР5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string iPass = "";
                int num = Int32.Parse(textBox2.Text);
                string[] arr = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "B", "C", "D", "F", "G", "H", "J", "K", "L", "M", "N", "P", "Q", "R", "S", "T", "V", "W", "X", "Z", "b", "c", "d", "f", "g", "h", "j", "k", "m", "n", "p", "q", "r", "s", "t", "v", "w", "x", "z", "A", "E", "U", "Y", "a", "e", "i", "o", "u", "y" };
                Random rnd = new Random();
                for (int i = 0; i < num; i = i + 1)
                {
                    iPass = iPass + arr[rnd.Next(0, num)];
                }
                textBox1.Text = "Ваш пароль       " + iPass;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Вы ввели не целое число!повторите ввод");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox1.Text = Properties.Settings.Default.s1.ToString();
            textBox3.Text = Properties.Settings.Default.s2.ToString();
            textBox2.Text = Properties.Settings.Default.outText.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a,i=0;
            bool trigger = false;
            string s1 = textBox1.Text,outText;
            string s2 = textBox3.Text,check="1234567890-=_+()!@#$%^&*/[]{}?<>.,` ";

            try
            {

                while (trigger == false)
                {

                    if (check.IndexOf(s1[i]) != -1)
                    {
                        a = int.Parse(" ");
                        trigger = true;
                    }
                    i++;
                    if (i == s1.Length)
                    {
                        trigger = true;
                    }

                }

                trigger = false;
                i = 0;
                while (trigger == false)
                {

                    if (check.IndexOf(s2[i]) != -1)
                    {
                        a = int.Parse(" ");
                        trigger = true;
                    }
                    i++;
                    if (i == s2.Length)
                    {
                        trigger = true;
                    }
                }
            }
            catch (FormatException)
            {
                // сообщение об ошибке
                MessageBox.Show("Некорректный ввод. В оба поля можно вводить только буквы", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                return; // а затем прерываем обработчик
            }

            outText = Logic.Compare(s1, s2);
            textBox2.Text = outText;

            Properties.Settings.Default.s1 = s1;
            Properties.Settings.Default.s2 = s2;
            Properties.Settings.Default.outText = outText;
            Properties.Settings.Default.Save();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                textBox3.Focus();
                // button1_Click( sender, e);
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                button1_Click(sender, e);
            }
        }
    }

    public class Logic
    {
        public static string Compare(string s1, string s2)
        {
            string check = "",outText="";
            for (int i = 0; i < s1.Length; i++)
            {
                //Проверяем есть ли данная буква в строке check,  если есть, значит буква повторяющиеся
                // поэтому пропускаем итерацию и переходим к следующему элементу, если её нет, значит она
                //не повторяющиеся, а значит необходимо проверить её на вхождение во втором слове
                if (check.IndexOf(s1[i]) == -1)
                {
                    //проверяем есть ли эта буква во втором слове
                    if (s2.IndexOf(s1[i]) != -1)
                    {
                        outText = outText + "Да ";
                    }
                    else
                    {
                        outText = outText + "Нет ";
                    }
                }
                //добавляем букву к строке check
                check = check + s1[i];
            }

            return outText;
        }

    }
}
 

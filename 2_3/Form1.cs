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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s1 = textBox1.Text;
            string s2 = textBox3.Text;
            textBox2.Text = Logic.Compare(s1, s2); ;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
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
 

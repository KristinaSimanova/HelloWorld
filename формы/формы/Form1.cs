using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace формы
{
    public partial class Form1 : Form
    {
        public Form1()//подключимся к реестру
        {
            InitializeComponent();
            RegistryKey key = Registry.CurrentUser.CreateSubKey(@"Kristina");
        }

     

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void button4_Click(object sender, EventArgs e)
        {
            RegistryKey key = Registry.CurrentUser.CreateSubKey(@"Kristina");
            key.SetValue("Цвет", "Зеленый");
            key.Close();
            BackColor = System.Drawing.Color.GreenYellow;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RegistryKey key = Registry.CurrentUser.CreateSubKey(@"Kristina");
            key.SetValue("Height", this.Height);
            key.SetValue("Width", this.Width);
            key.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string h = textBox1.Text;
            string w = textBox2.Text;
            this.Height = Convert.ToInt32(h);
            this.Width = Convert.ToInt32(w);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Kristina");
            if (key != null)
            {
                int Height = int.Parse(key.GetValue("Height").ToString());
                int Width = int.Parse(key.GetValue("Width").ToString());
                this.Size = new Size(Width, Height);

                string color = (string)key.GetValue("Цвет");
                if (color == "Белый")
                    BackColor = System.Drawing.Color.White;
                else if (color == "Зеленый")
                    BackColor = System.Drawing.Color.GreenYellow;
                else if (color == "Синий")
                    BackColor = System.Drawing.Color.Blue;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            RegistryKey key = Registry.CurrentUser.CreateSubKey(@"Kristina");
            key.SetValue("Цвет", "Синий");
            key.Close();
            BackColor = System.Drawing.Color.Blue;
        }

        private void белый(object sender, EventArgs e)
        {
            RegistryKey key = Registry.CurrentUser.CreateSubKey(@"Kristina");
            key.SetValue("Цвет", "Белый");
            key.Close();
            BackColor = System.Drawing.Color.White;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string dn = "Пятница";
            MessageBox.Show(dn, "День недели", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string m = "Апрель";
            MessageBox.Show(m, "Месяц", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

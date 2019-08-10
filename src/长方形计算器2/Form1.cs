using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using 数据转换;

namespace 长方形计算器2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            长单位.SelectedIndex = 0;
            宽单位.SelectedIndex = 0;
            直径单位.SelectedIndex = 0;
            第一条边单位.SelectedIndex = 0;
            第二条边单位.SelectedIndex = 0;
            第三条边单位.SelectedIndex = 0;
            底边单位.SelectedIndex = 0;
            高单位.SelectedIndex = 0;
            正多边形边长.SelectedIndex = 0;

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


        //三角形计算先判断已知条件，然后然后让相应的输入框可以输入
        int fuck = 0;
        private void btnTriFor_Click_1(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                textBox10.Enabled = true;
                textBox3.Enabled = true;
                fuck = 0;

            }
            else if (radioButton1.Checked)
            {
                textBox8.Enabled = true;
                textBox12.Enabled = true;
                textBox13.Enabled = true;
                fuck = 1;
            }
        }
        //三角形面积计算
        private void btnTri_Click(object sender, EventArgs e)
        {
            if (fuck == 1)
            {

                try
                {
                    double a = double.Parse(textBox8.Text);
                    double b = double.Parse(textBox12.Text);
                    double c = double.Parse(textBox13.Text);


                    string y = 第一条边单位.Text;
                    string x = 第二条边单位.Text;
                    string f = 第三条边单位.Text;
                    a = Class1.In(a, y);
                    b = Class1.In(b, x);
                    c = Class1.In(c, f);
                    if (a + b > c && b + c > a && a + c > b)
                    {
                        double d = (a + b + c) / 2;
                        textBox15.Text = Convert.ToString(Math.Sqrt(Math.Round(d * (d - a) * (d - c) * (d - b))) + "cm^2");
                    }
                    else
                    {
                        MessageBox.Show("三边长度不满足构成三角形！");
                    }

                }
                catch (FormatException)
                {
                    MessageBox.Show("请输入正确的数据！");

                }
                catch (OverflowException)
                {
                    MessageBox.Show("数据过大，将出现较大误差！");
                }
            }
            else if (fuck == 0)
            {
                try
                {
                    string y = 底边单位.Text;
                    string x = 高单位.Text;

                    double a = double.Parse(textBox10.Text);
                    double b = double.Parse(textBox3.Text);
                    a = Class1.In(a, y);
                    b = Class1.In(b, x);

                    textBox15.Text = Convert.ToString(Math.Round(a * b / 2) + "cm");
                }
                catch (FormatException)
                {
                    MessageBox.Show("请输入正确的数据！");

                }
                catch (OverflowException)
                {
                    MessageBox.Show("数据过大，将出现较大误差！");
                }
            }
        }
        //清空数据
        private void btnTriClean_Click(object sender, EventArgs e)
        {
            textBox10.Text = null;
            textBox3.Text = null;
            textBox8.Text = null;
            textBox12.Text = null;
            textBox13.Text = null;
            textBox15.Text = null;
            textBox8.Enabled = false;
            textBox12.Enabled = false;
            textBox13.Enabled = false;
            textBox10.Enabled = false;
            textBox3.Enabled = false;

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = DateTime.Now.ToString();
            toolStripStatusLabel2.Text = DateTime.Now.ToString();
            toolStripStatusLabel3.Text = DateTime.Now.ToString();
            toolStripStatusLabel4.Text = DateTime.Now.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = DateTime.Now.ToString();
            toolStripStatusLabel2.Text = DateTime.Now.ToString();
            toolStripStatusLabel3.Text = DateTime.Now.ToString();
            toolStripStatusLabel4.Text = DateTime.Now.ToString();
        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            try
            {
                double a = double.Parse(textBox11.Text);
                double b = double.Parse(textBox17.Text);
                string c = 正多边形边长.Text;

                a = Class1.In(a, c);

                textBox14.Text = Convert.ToString(Math.Round(a * b) + "cm");
                textBox16.Text = Convert.ToString(Math.Round(a * b * b / 4 / Math.Tan(Math.PI / a)) + "cm^2");
            }
            catch (FormatException)
            {
                MessageBox.Show("请输入正确的数据！");

            }
            catch (OverflowException)
            {
                MessageBox.Show("数据过大，将出现较大误差！");
            }
        }

        private void btnMulClean_Click(object sender, EventArgs e)
        {
            textBox16.Text = null;
            textBox11.Text = null;
            textBox14.Text = null;
            textBox17.Text = null;
        }

        private void TabPage1_Click(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TextBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void ComboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void 长单位_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void 正多边形边长_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRec_Click(object sender, EventArgs e)
        {
            try
            {
                double a = double.Parse(textBox4.Text);
                double b = double.Parse(textBox5.Text);
                string c = 长单位.Text;
                string d = 宽单位.Text;
                a = Class1.In(a, c);
                b = Class1.In(b, d);

                textBox2.Text = Convert.ToString(Math.Round(a * b, 3) + "cm^2");
                textBox9.Text = Convert.ToString(Math.Round(2 * (a + b), 3) + "cm");
            }
            catch (OverflowException)
            {
                MessageBox.Show("数据过大，将出现较大误差！");
            }
            catch (FormatException)
            {
                MessageBox.Show("请输入正确的数据！");
            }
        }

        private void btnRecClean_Click(object sender, EventArgs e)
        {
            textBox2.Text = null;
            textBox9.Text = null;
            textBox4.Text = null;
            textBox5.Text = null;
        }

        private void btnCir_Click(object sender, EventArgs e)
        {
            try
            {

                double b = double.Parse(textBox1.Text);
                string c = 直径单位.Text;

                b = Class1.In(b, c);
                textBox7.Text = (Convert.ToString(Math.Round(Math.PI * b, 3)) + "cm");
                textBox6.Text = Convert.ToString(Math.Round(Math.PI * (b / 2) * (b / 2), 3) + "cm^2");
            }
            catch (FormatException)
            {
                MessageBox.Show("请输入正确的数据！");

            }
            catch (OverflowException)
            {
                MessageBox.Show("数据过大，将出现较大误差！");
            }
        }

        private void btnCirClean_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
            textBox6.Text = null;
            textBox7.Text = null;
        }

       
    }
}

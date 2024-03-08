using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_1
{
    public partial class Form2 : Form
    {
        private int value1, value2, value3;
        public Form2()
        {
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            value1 = trackBar1.Value;
            value2 = trackBar2.Value;
            value3 = trackBar3.Value;
            comboBox1.Items.Add("Tùy chọn 1");
            comboBox1.Items.Add("Tùy chọn 2");
            comboBox1.Items.Add("Tùy chọn 3");

            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            value1 = trackBar1.Value;
            lbtrack1.Text = value1 + "%";
            textBox2.Text = trackBar1.Value.ToString();
            panel1.Invalidate();
        }

        private void trackBar2_ValueChanged(object sender, EventArgs e)
        {
            value2 = trackBar2.Value;
            lbtrack2.Text = value2 + "%";
            textBox3.Text = trackBar2.Value.ToString();
            panel1.Invalidate();
        }

        private void trackBar3_ValueChanged(object sender, EventArgs e)
        {
            value3 = trackBar3.Value;
            lbtrack3.Text = value3 + "%";
            textBox4.Text = trackBar3.Value.ToString();
            panel1.Invalidate();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(textBox2.Text, out int newValue))
            {
                if (newValue >= trackBar1.Minimum && newValue <= trackBar1.Maximum)
                {
                    trackBar1.Value = newValue;
                }
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(textBox3.Text, out int newValue))
            {
                if (newValue >= trackBar2.Minimum && newValue <= trackBar2.Maximum)
                {
                    trackBar2.Value = newValue;
                }
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(textBox4.Text, out int newValue))
            {
                if (newValue >= trackBar3.Minimum && newValue <= trackBar3.Maximum)
                {
                    trackBar3.Value = newValue;
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedOption = comboBox1.SelectedItem as string;
            if (selectedOption == "Tùy chọn 1")
            {
                // Thiết lập giá trị cho các TrackBar khi chọn "Tùy chọn 1"
                trackBar1.Value = 40;
                trackBar2.Value = 30;
                trackBar3.Value = 30;
            }
            else if (selectedOption == "Tùy chọn 2")
            {
                // Thiết lập giá trị cho các TrackBar khi chọn "Tùy chọn 2"
                trackBar1.Value = 20;
                trackBar2.Value = 40;
                trackBar3.Value = 40;
            }
            else if (selectedOption == "Tùy chọn 3")
            {
                // Thiết lập giá trị cho các TrackBar khi chọn "Tùy chọn 3"
                trackBar1.Value = 50;
                trackBar2.Value = 25;
                trackBar3.Value = 25;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

            // Calculate percentages
            float total = value1 + value2 + value3;
            float percent1 = value1 / total;
            float percent2 = value2 / total;
            float percent3 = value3 / total;

            // Get panel size
            int size = Math.Min(panel1.Width, panel1.Height);

            // Create graphics object
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            // Draw the chart
            float startAngle = 0;
            float sweepAngle1 = percent1 * 360;
            float sweepAngle2 = percent2 * 360;
            float sweepAngle3 = percent3 * 360;

            Brush brush1 = new SolidBrush(Color.Red);
            Brush brush2 = new SolidBrush(Color.Green);
            Brush brush3 = new SolidBrush(Color.Blue);

            g.FillPie(brush1, 0, 0, size, size, startAngle, sweepAngle1);
            g.FillPie(brush2, 0, 0, size, size, startAngle + sweepAngle1, sweepAngle2);
            g.FillPie(brush3, 0, 0, size, size, startAngle + sweepAngle1 + sweepAngle2, sweepAngle3);

            // Clean up
            brush1.Dispose();
            brush2.Dispose();
            brush3.Dispose();
        }

    }
}

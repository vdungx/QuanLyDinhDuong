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
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private Form currentFormchild;

        private void OpenchildForm(Form ChildForm)
        {
            if(currentFormchild != null)
            {
                currentFormchild.Close();
            }
            currentFormchild = ChildForm;
            ChildForm.TopLevel = false;
            ChildForm.FormBorderStyle = FormBorderStyle.None; // đóng dấu x và mở rộng của form con
            ChildForm.Dock = DockStyle.Fill;
            panelBody1.Controls.Add(ChildForm);
            panelBody1.Tag = ChildForm;
            ChildForm.BringToFront();
            ChildForm.Show();
        }
        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Caculate_Click(object sender, EventArgs e)
        {
            OpenchildForm(new FormCon1());
        }

        private void MacroSplit_Click(object sender, EventArgs e)
        {
            OpenchildForm(new Form2());
        }

        private void panelBody1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Settings_Click(object sender, EventArgs e)
        {
            OpenchildForm(new Form3());
        }
    }
}

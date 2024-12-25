using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tyuiu.RyabtsevNE.Sprint7.Project.V2
{
    public partial class MyForm : Form
    {
        public MyForm()
        {
            InitializeComponent();
        }

        private void labelclick_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainform = new MainForm();
            mainform.Show();
        }

        private void MyForm_Load(object sender, EventArgs e)
        {

        }

        private void labelclick_Click_1(object sender, EventArgs e)
        {

        }
    }
}

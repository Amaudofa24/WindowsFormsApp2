using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Shapes : Form
    {
        public Shapes()
        {
            InitializeComponent();
        }

        private void lbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int length = Int32.Parse(lbox.Text);
            int width =  Int32.Parse(widthbox.Text);
            areabox.Text = (GetArea(length, width)).ToString();
        }

        public int GetArea(int length, int width)
        {
            int area = length * width;
            return area;
        }
    }
}

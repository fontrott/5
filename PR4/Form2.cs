using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR4
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            linkLabel1.Parent = pictureBox1;
            linkLabel1.BackColor = Color.Transparent;
            label1.Parent = pictureBox1;
            label1.BackColor = Color.Transparent;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.LinkVisited = true;
            System.Diagnostics.Process.Start("https://mail.google.com/mail/u/0/#inbox?compose=new");
        }
    }
}

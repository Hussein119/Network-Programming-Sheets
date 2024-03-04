using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        bool isServer = true;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
             
                 

            // Sending logic
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox3.Clear();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
                connect_btn.Text = "Connect";
            else
                connect_btn.Text = "Listen";
        }

        private void connect_btn_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = false;


            if (isServer)
            {
                
            }
        }

        private void radioButton2_KeyDown(object sender, KeyEventArgs e)
        {
 
        }

        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                textBox3.Clear();
        }

        private void textBox3_MouseClick(object sender, MouseEventArgs e)
        {
            textBox3.Clear();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!textBox3.Focused && textBox3.Text == string.Empty)
                textBox3.Text = "Enter your message...";
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

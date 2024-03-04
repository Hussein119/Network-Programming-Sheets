using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace sheet2_q1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void write_button_Click(object sender, EventArgs e)
        {
            Stream s = new FileStream(path_textBox.Text, FileMode.Create);
            foreach(char c in file_textBox.Text)
            {
                s.WriteByte((byte)c);
            }
            s.Close();
            status.Text = "Text written to file successfully";
        }

        private void clear_button_Click(object sender, EventArgs e)
        {
            file_textBox.Clear();
            status.Text = "TextBox was cleared";
        }

        private void read_button_Click(object sender, EventArgs e)
        {
            try
            {
                StringBuilder sb = new StringBuilder();
                using (FileStream file = new FileStream(path_textBox.Text, FileMode.Open))
                {
                    int b;
                    while ((b = file.ReadByte()) != -1) // Read until the end of file
                    {
                        char c = (char)b; // Convert byte to character
                        sb.Append(c); // Append character to StringBuilder
                    }

                    file_textBox.Text = sb.ToString(); // Display the result
                }
                status.Text = "Text was read from file successfully";
            }
            catch (Exception ex)
            {
                status.Text = "An error occurred: " + ex.Message;
            }
        }

        private void file_textBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

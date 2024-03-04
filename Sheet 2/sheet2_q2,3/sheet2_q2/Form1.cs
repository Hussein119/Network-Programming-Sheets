using System;
using System.IO;
using System.Windows.Forms;

namespace sheet2_q2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*
            string sourceFile = source_textBox.Text;
            string targetFile = dist_textBox.Text;
            File.Copy(sourceFile, targetFile);
            */

            // Problem 3 sheet 2

            try
            {
                string sourcePath = source_textBox.Text;
                string destinationPath = dist_textBox.Text;

                using (FileStream sourceStream = new FileStream(sourcePath, FileMode.Open))
                using (FileStream destinationStream = new FileStream(destinationPath, FileMode.Create))
                {
                    int bufferSize = 50;
                    byte[] buffer = new byte[bufferSize];
                    int bytesRead;

                    while ((bytesRead = sourceStream.Read(buffer, 0, bufferSize)) > 0)
                    {
                        destinationStream.Write(buffer, 0, bytesRead);
                    }
                }

                status.Text = "File was copied successfully";
            }
            catch (FileNotFoundException ex)
            {
                status.Text = $"File not found: {ex.FileName}";
            }
            catch (Exception ex)
            {
                status.Text = $"Error: {ex.Message}";
            }
        }

        private void source_textBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

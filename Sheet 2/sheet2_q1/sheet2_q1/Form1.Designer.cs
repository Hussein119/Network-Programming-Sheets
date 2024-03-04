namespace sheet2_q1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.path_textBox = new System.Windows.Forms.TextBox();
            this.file_textBox = new System.Windows.Forms.TextBox();
            this.write_button = new System.Windows.Forms.Button();
            this.clear_button = new System.Windows.Forms.Button();
            this.read_button = new System.Windows.Forms.Button();
            this.status = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(132, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Path";
            // 
            // path_textBox
            // 
            this.path_textBox.Location = new System.Drawing.Point(194, 105);
            this.path_textBox.Name = "path_textBox";
            this.path_textBox.Size = new System.Drawing.Size(177, 20);
            this.path_textBox.TabIndex = 1;
            this.path_textBox.Text = "D:\\Collage\\8th\\Network Programming\\Network Programming Sheets\\Sheet 2\\sheet2_q1\\f" +
    "ile.txt";
            // 
            // file_textBox
            // 
            this.file_textBox.Location = new System.Drawing.Point(135, 161);
            this.file_textBox.Multiline = true;
            this.file_textBox.Name = "file_textBox";
            this.file_textBox.Size = new System.Drawing.Size(236, 163);
            this.file_textBox.TabIndex = 2;
            this.file_textBox.TextChanged += new System.EventHandler(this.file_textBox_TextChanged);
            // 
            // write_button
            // 
            this.write_button.Location = new System.Drawing.Point(454, 173);
            this.write_button.Name = "write_button";
            this.write_button.Size = new System.Drawing.Size(90, 23);
            this.write_button.TabIndex = 3;
            this.write_button.Text = "Write File";
            this.write_button.UseVisualStyleBackColor = true;
            this.write_button.Click += new System.EventHandler(this.write_button_Click);
            // 
            // clear_button
            // 
            this.clear_button.Location = new System.Drawing.Point(454, 225);
            this.clear_button.Name = "clear_button";
            this.clear_button.Size = new System.Drawing.Size(90, 23);
            this.clear_button.TabIndex = 4;
            this.clear_button.Text = "Clear TextBox";
            this.clear_button.UseVisualStyleBackColor = true;
            this.clear_button.Click += new System.EventHandler(this.clear_button_Click);
            // 
            // read_button
            // 
            this.read_button.Location = new System.Drawing.Point(454, 276);
            this.read_button.Name = "read_button";
            this.read_button.Size = new System.Drawing.Size(90, 23);
            this.read_button.TabIndex = 5;
            this.read_button.Text = "Read File";
            this.read_button.UseVisualStyleBackColor = true;
            this.read_button.Click += new System.EventHandler(this.read_button_Click);
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Location = new System.Drawing.Point(135, 343);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(0, 13);
            this.status.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.status);
            this.Controls.Add(this.read_button);
            this.Controls.Add(this.clear_button);
            this.Controls.Add(this.write_button);
            this.Controls.Add(this.file_textBox);
            this.Controls.Add(this.path_textBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox path_textBox;
        private System.Windows.Forms.TextBox file_textBox;
        private System.Windows.Forms.Button write_button;
        private System.Windows.Forms.Button clear_button;
        private System.Windows.Forms.Button read_button;
        private System.Windows.Forms.Label status;
    }
}


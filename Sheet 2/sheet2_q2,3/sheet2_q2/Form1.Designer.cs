namespace sheet2_q2
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
            this.label2 = new System.Windows.Forms.Label();
            this.source_textBox = new System.Windows.Forms.TextBox();
            this.dist_textBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.status = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(159, 127);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Path to Source File";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(159, 187);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Path to destination File";
            // 
            // source_textBox
            // 
            this.source_textBox.Location = new System.Drawing.Point(323, 123);
            this.source_textBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.source_textBox.Name = "source_textBox";
            this.source_textBox.Size = new System.Drawing.Size(265, 22);
            this.source_textBox.TabIndex = 2;
            this.source_textBox.Text = "D:\\Collage\\8th\\Network Programming\\Network Programming Sheets\\Sheet 2\\sheet2_q2\\s" +
    "ourceFile.txt";
            this.source_textBox.TextChanged += new System.EventHandler(this.source_textBox_TextChanged);
            // 
            // dist_textBox
            // 
            this.dist_textBox.Location = new System.Drawing.Point(323, 183);
            this.dist_textBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dist_textBox.Name = "dist_textBox";
            this.dist_textBox.Size = new System.Drawing.Size(265, 22);
            this.dist_textBox.TabIndex = 3;
            this.dist_textBox.Text = "D:\\Collage\\8th\\Network Programming\\Network Programming Sheets\\Sheet 2\\sheet2_q2\\t" +
    "argetFile.txt";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(323, 244);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(267, 32);
            this.button1.TabIndex = 4;
            this.button1.Text = "Copy";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Location = new System.Drawing.Point(319, 311);
            this.status.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(0, 16);
            this.status.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.status);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dist_textBox);
            this.Controls.Add(this.source_textBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox source_textBox;
        private System.Windows.Forms.TextBox dist_textBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label status;
    }
}


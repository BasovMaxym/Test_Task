using System;
using System.Windows.Forms;
using System.Drawing;

namespace Handler
{
    partial class HandlerForm
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

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Dock = DockStyle.Top;
            textBox1.Font = new Font("Microsoft Sans Serif", 14F);
            textBox1.Location = new Point(20, 20);
            textBox1.Name = "textBox1";
            textBox1.Text = "";
            textBox1.Size = new Size(467, 29);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += new EventHandler(UpdateUniqueSymbol);
            // 
            // textBox2
            // 
            textBox2.Dock = DockStyle.Fill;
            textBox2.Font = new Font("Courier New", 18F);
            textBox2.Location = new Point(20, 49);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Text = "Set path to the file!";
            textBox2.ReadOnly = true;
            textBox2.ScrollBars = ScrollBars.Both;
            textBox2.Size = new Size(467, 381);
            textBox2.TabIndex = 1;
            // 
            // HandlerForm
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(507, 450);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "HandlerForm";
            Padding = new Padding(20);
            Text = "TextHandler";
            ResumeLayout(false);
            PerformLayout();

        }

        private TextBox textBox1;
        private TextBox textBox2;
    }
}
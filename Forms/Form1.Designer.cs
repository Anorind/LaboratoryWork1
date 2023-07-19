using System;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Forms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "Form1";
            this.MouseMove += new MouseEventHandler(Form1_MouseMove);
            this.MouseDown += new MouseEventHandler(Form1_MouseDown);
            this.Resize += new EventHandler(Form1_Resize);

        }
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            this.Text = "X: " + e.X.ToString() + ", Y: " + e.Y.ToString();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (e.X > 10 && e.X < this.ClientSize.Width - 10 &&
                    e.Y > 10 && e.Y < this.ClientSize.Height - 10)
                {
                    MessageBox.Show("Точка знаходиться всередені прямокутника");
                }
                else if (e.X < 10 || e.X > this.ClientSize.Width - 10 ||
                         e.Y < 10 || e.Y > this.ClientSize.Height - 10)
                {
                    MessageBox.Show("Точка знаходиться поза прямокутником");
                }
                else
                {
                    MessageBox.Show("Точка знаходиться на границі прямокутника");
                }
            }
            else if (e.Button == MouseButtons.Right)
            {
                this.Text = "Ширина = " + this.ClientSize.Width.ToString() +
                            ", Висота = " + this.ClientSize.Height.ToString();
            }
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            this.Text = "Ширина = " + this.ClientSize.Width.ToString() +
                        ", Висота = " + this.ClientSize.Height.ToString();
        }
        #endregion
    }
}
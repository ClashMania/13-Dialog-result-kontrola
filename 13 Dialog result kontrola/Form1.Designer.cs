﻿namespace _13_Dialog_result_kontrola
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
            this.textBoxRezultat = new System.Windows.Forms.RichTextBox();
            this.buttonOtvori = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxRezultat
            // 
            this.textBoxRezultat.Location = new System.Drawing.Point(31, 125);
            this.textBoxRezultat.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxRezultat.Name = "textBoxRezultat";
            this.textBoxRezultat.Size = new System.Drawing.Size(472, 191);
            this.textBoxRezultat.TabIndex = 3;
            this.textBoxRezultat.Text = "";
            // 
            // buttonOtvori
            // 
            this.buttonOtvori.Location = new System.Drawing.Point(190, 48);
            this.buttonOtvori.Margin = new System.Windows.Forms.Padding(2);
            this.buttonOtvori.Name = "buttonOtvori";
            this.buttonOtvori.Size = new System.Drawing.Size(118, 25);
            this.buttonOtvori.TabIndex = 2;
            this.buttonOtvori.Text = "Otvori MessageBox";
            this.buttonOtvori.UseVisualStyleBackColor = true;
            this.buttonOtvori.Click += new System.EventHandler(this.buttonOtvori_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 368);
            this.Controls.Add(this.textBoxRezultat);
            this.Controls.Add(this.buttonOtvori);
            this.Name = "Form1";
            this.Text = "Dialog result kontrola";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox textBoxRezultat;
        private System.Windows.Forms.Button buttonOtvori;
    }
}


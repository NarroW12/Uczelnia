﻿namespace Uczelnia
{
    partial class DodajWydzialForm
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
            button1 = new Button();
            textBoxNazwaWydzialu = new TextBox();
            textBoxZaklad = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(232, 215);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "Dodaj Wydział";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBoxNazwaWydzialu
            // 
            textBoxNazwaWydzialu.Location = new Point(221, 103);
            textBoxNazwaWydzialu.Name = "textBoxNazwaWydzialu";
            textBoxNazwaWydzialu.Size = new Size(125, 27);
            textBoxNazwaWydzialu.TabIndex = 1;
            // 
            // textBoxZaklad
            // 
            textBoxZaklad.Location = new Point(220, 170);
            textBoxZaklad.Name = "textBoxZaklad";
            textBoxZaklad.Size = new Size(125, 27);
            textBoxZaklad.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(220, 65);
            label1.Name = "label1";
            label1.Size = new Size(119, 20);
            label1.TabIndex = 3;
            label1.Text = "Nazwa Wydziału";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(246, 147);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 4;
            label2.Text = "Zakład";
            // 
            // DodajWydzialForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxZaklad);
            Controls.Add(textBoxNazwaWydzialu);
            Controls.Add(button1);
            Name = "DodajWydzialForm";
            Text = "DodajWydzialForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBoxNazwaWydzialu;
        private TextBox textBoxZaklad;
        private Label label1;
        private Label label2;
    }
}
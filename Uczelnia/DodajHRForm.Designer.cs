namespace Uczelnia
{
    partial class DodajHRForm
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
            buttonAddHR = new Button();
            textBoxImie = new TextBox();
            textBoxNazwisko = new TextBox();
            textBoxStanowisko = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // buttonAddHR
            // 
            buttonAddHR.Location = new Point(191, 272);
            buttonAddHR.Name = "buttonAddHR";
            buttonAddHR.Size = new Size(122, 29);
            buttonAddHR.TabIndex = 0;
            buttonAddHR.Text = "Dodaj HR";
            buttonAddHR.UseVisualStyleBackColor = true;
            buttonAddHR.Click += buttonAddHR_Click;
            // 
            // textBoxImie
            // 
            textBoxImie.Location = new Point(188, 75);
            textBoxImie.Name = "textBoxImie";
            textBoxImie.Size = new Size(125, 27);
            textBoxImie.TabIndex = 1;
            // 
            // textBoxNazwisko
            // 
            textBoxNazwisko.Location = new Point(188, 134);
            textBoxNazwisko.Name = "textBoxNazwisko";
            textBoxNazwisko.Size = new Size(125, 27);
            textBoxNazwisko.TabIndex = 2;
            // 
            // textBoxStanowisko
            // 
            textBoxStanowisko.Location = new Point(188, 194);
            textBoxStanowisko.Name = "textBoxStanowisko";
            textBoxStanowisko.Size = new Size(125, 27);
            textBoxStanowisko.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(219, 52);
            label1.Name = "label1";
            label1.Size = new Size(38, 20);
            label1.TabIndex = 4;
            label1.Text = "Imie";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(219, 111);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 5;
            label2.Text = "Nazwisko";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(219, 171);
            label3.Name = "label3";
            label3.Size = new Size(84, 20);
            label3.TabIndex = 6;
            label3.Text = "Stanowisko";
            // 
            // button1
            // 
            button1.Location = new Point(191, 327);
            button1.Name = "button1";
            button1.Size = new Size(119, 29);
            button1.TabIndex = 7;
            button1.Text = "aktualizuj dane";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // DodajHRForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxStanowisko);
            Controls.Add(textBoxNazwisko);
            Controls.Add(textBoxImie);
            Controls.Add(buttonAddHR);
            Name = "DodajHRForm";
            Text = "DodajHRForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonAddHR;
        private TextBox textBoxImie;
        private TextBox textBoxNazwisko;
        private TextBox textBoxStanowisko;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
    }
}
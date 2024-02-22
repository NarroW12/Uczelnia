namespace Uczelnia
{
    partial class DodajUczniaForm
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
            buttonAddStudent = new Button();
            NametextBox = new TextBox();
            LastNametextBox = new TextBox();
            IndexNumbertextBox = new TextBox();
            SemestertextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            buttonAddId = new Button();
            IdUczniaTextBox = new TextBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // buttonAddStudent
            // 
            buttonAddStudent.Location = new Point(98, 265);
            buttonAddStudent.Name = "buttonAddStudent";
            buttonAddStudent.Size = new Size(125, 29);
            buttonAddStudent.TabIndex = 0;
            buttonAddStudent.Text = "Dodaj ";
            buttonAddStudent.UseVisualStyleBackColor = true;
            buttonAddStudent.Click += buttonAddStudent_Click;
            // 
            // NametextBox
            // 
            NametextBox.Location = new Point(98, 32);
            NametextBox.Name = "NametextBox";
            NametextBox.Size = new Size(125, 27);
            NametextBox.TabIndex = 1;
            // 
            // LastNametextBox
            // 
            LastNametextBox.Location = new Point(98, 90);
            LastNametextBox.Name = "LastNametextBox";
            LastNametextBox.Size = new Size(125, 27);
            LastNametextBox.TabIndex = 2;
            // 
            // IndexNumbertextBox
            // 
            IndexNumbertextBox.Location = new Point(98, 141);
            IndexNumbertextBox.Name = "IndexNumbertextBox";
            IndexNumbertextBox.Size = new Size(125, 27);
            IndexNumbertextBox.TabIndex = 3;
            // 
            // SemestertextBox
            // 
            SemestertextBox.Location = new Point(98, 209);
            SemestertextBox.Name = "SemestertextBox";
            SemestertextBox.Size = new Size(125, 27);
            SemestertextBox.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 35);
            label1.Name = "label1";
            label1.Size = new Size(38, 20);
            label1.TabIndex = 5;
            label1.Text = "Imię";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 97);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 6;
            label2.Text = "Nazwisko";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 148);
            label3.Name = "label3";
            label3.Size = new Size(73, 20);
            label3.TabIndex = 7;
            label3.Text = "Nr Indexu";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(30, 209);
            label4.Name = "label4";
            label4.Size = new Size(62, 20);
            label4.TabIndex = 8;
            label4.Text = "Semestr";
            // 
            // buttonAddId
            // 
            buttonAddId.Location = new Point(117, 408);
            buttonAddId.Name = "buttonAddId";
            buttonAddId.Size = new Size(94, 29);
            buttonAddId.TabIndex = 10;
            buttonAddId.Text = "Aktualizuj";
            buttonAddId.UseVisualStyleBackColor = true;
            buttonAddId.Click += buttonAddId_Click;
            // 
            // IdUczniaTextBox
            // 
            IdUczniaTextBox.Location = new Point(98, 364);
            IdUczniaTextBox.Name = "IdUczniaTextBox";
            IdUczniaTextBox.Size = new Size(125, 27);
            IdUczniaTextBox.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(39, 332);
            label5.Name = "label5";
            label5.Size = new Size(228, 20);
            label5.TabIndex = 12;
            label5.Text = "Wpisz Id aby zaktualizować dane";
            label5.Click += label5_Click;
            // 
            // DodajUczniaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(323, 510);
            Controls.Add(label5);
            Controls.Add(IdUczniaTextBox);
            Controls.Add(buttonAddId);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(SemestertextBox);
            Controls.Add(IndexNumbertextBox);
            Controls.Add(LastNametextBox);
            Controls.Add(NametextBox);
            Controls.Add(buttonAddStudent);
            Name = "DodajUczniaForm";
            Text = "DodajUczniaForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonAddStudent;
        private TextBox NametextBox;
        private TextBox LastNametextBox;
        private TextBox IndexNumbertextBox;
        private TextBox SemestertextBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button buttonAddId;
        private TextBox IdUczniaTextBox;
        private Label label5;
    }
}
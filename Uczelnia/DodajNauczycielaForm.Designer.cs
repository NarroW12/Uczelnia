namespace Uczelnia
{
    partial class DodajNauczycielaForm
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
            textBoxName = new TextBox();
            textBoxLastName = new TextBox();
            textBoxSpecjalizacja = new TextBox();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBoxDeleteById = new TextBox();
            buttonDeleteById = new Button();
            label5 = new Label();
            comboBoxStopnie = new ComboBox();
            SuspendLayout();
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(82, 42);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(125, 27);
            textBoxName.TabIndex = 0;
            // 
            // textBoxLastName
            // 
            textBoxLastName.Location = new Point(82, 102);
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.Size = new Size(125, 27);
            textBoxLastName.TabIndex = 1;
            // 
            // textBoxSpecjalizacja
            // 
            textBoxSpecjalizacja.Location = new Point(82, 229);
            textBoxSpecjalizacja.Name = "textBoxSpecjalizacja";
            textBoxSpecjalizacja.Size = new Size(125, 27);
            textBoxSpecjalizacja.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(67, 276);
            button1.Name = "button1";
            button1.Size = new Size(156, 29);
            button1.TabIndex = 4;
            button1.Text = "Dodaj Wykladowce";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(116, 19);
            label1.Name = "label1";
            label1.Size = new Size(38, 20);
            label1.TabIndex = 5;
            label1.Text = "Imie";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(116, 79);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 6;
            label2.Text = "Nazwisko";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(116, 140);
            label3.Name = "label3";
            label3.Size = new Size(60, 20);
            label3.TabIndex = 7;
            label3.Text = "Stopien";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(93, 206);
            label4.Name = "label4";
            label4.Size = new Size(95, 20);
            label4.TabIndex = 8;
            label4.Text = "Specjalizacja";
            // 
            // textBoxDeleteById
            // 
            textBoxDeleteById.Location = new Point(82, 357);
            textBoxDeleteById.Name = "textBoxDeleteById";
            textBoxDeleteById.Size = new Size(125, 27);
            textBoxDeleteById.TabIndex = 9;
            // 
            // buttonDeleteById
            // 
            buttonDeleteById.Location = new Point(94, 405);
            buttonDeleteById.Name = "buttonDeleteById";
            buttonDeleteById.Size = new Size(94, 29);
            buttonDeleteById.TabIndex = 10;
            buttonDeleteById.Text = "Delete";
            buttonDeleteById.UseVisualStyleBackColor = true;
            buttonDeleteById.Click += buttonDeleteById_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(46, 326);
            label5.Name = "label5";
            label5.Size = new Size(220, 20);
            label5.TabIndex = 11;
            label5.Text = "Wpisz id by usunac wykladowce";
            // 
            // comboBoxStopnie
            // 
            comboBoxStopnie.FormattingEnabled = true;
            comboBoxStopnie.Items.AddRange(new object[] { "Doktor (Dr.)", "Doktor Habilitowany (Dr Hab.)", "Magister (Mgr)", "Magister Inżynier (Mgr Inż.)", "Profesor (Prof.)", "Profesor Doktor (Prof. Dr.)", "Profesor Doktor Habilitowany (Prof. Dr Hab.)", "Starszy Wykładowca (Starszy Wykł.)", "Adiunkt (Adiunkt)", "Asystent (Asystent)", "Inny (bez określonego stopnia/tytułu)" });
            comboBoxStopnie.Location = new Point(67, 175);
            comboBoxStopnie.Name = "comboBoxStopnie";
            comboBoxStopnie.Size = new Size(151, 28);
            comboBoxStopnie.TabIndex = 12;
            // 
            // DodajNauczycielaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(318, 470);
            Controls.Add(comboBoxStopnie);
            Controls.Add(label5);
            Controls.Add(buttonDeleteById);
            Controls.Add(textBoxDeleteById);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(textBoxSpecjalizacja);
            Controls.Add(textBoxLastName);
            Controls.Add(textBoxName);
            Name = "DodajNauczycielaForm";
            Text = "DodajNauczycielaForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxName;
        private TextBox textBoxLastName;
        private TextBox comboBoxStopien;
        private TextBox textBoxSpecjalizacja;
        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBoxDeleteById;
        private Button buttonDeleteById;
        private Label label5;
        private ComboBox comboBox1;
        private ComboBox comboBoxStopnie;
    }
}
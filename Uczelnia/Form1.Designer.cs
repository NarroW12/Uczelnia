namespace Uczelnia
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
            buttonADDStudents = new Button();
            buttonAddTeacher = new Button();
            buttonAddHR = new Button();
            buttonAddWydzial = new Button();
            buttonAddKierownikWydzialu = new Button();
            buttonShowData = new Button();
            SuspendLayout();
            // 
            // buttonADDStudents
            // 
            buttonADDStudents.Location = new Point(59, 76);
            buttonADDStudents.Name = "buttonADDStudents";
            buttonADDStudents.Size = new Size(152, 29);
            buttonADDStudents.TabIndex = 0;
            buttonADDStudents.Text = "Dodaj uczniów";
            buttonADDStudents.UseVisualStyleBackColor = true;
            buttonADDStudents.Click += buttonADDStudents_Click;
            // 
            // buttonAddTeacher
            // 
            buttonAddTeacher.Location = new Point(59, 125);
            buttonAddTeacher.Name = "buttonAddTeacher";
            buttonAddTeacher.Size = new Size(152, 29);
            buttonAddTeacher.TabIndex = 2;
            buttonAddTeacher.Text = "Dodaj Nauczyciela";
            buttonAddTeacher.UseVisualStyleBackColor = true;
            buttonAddTeacher.Click += buttonAddTeacher_Click;
            // 
            // buttonAddHR
            // 
            buttonAddHR.Location = new Point(59, 180);
            buttonAddHR.Name = "buttonAddHR";
            buttonAddHR.Size = new Size(152, 29);
            buttonAddHR.TabIndex = 3;
            buttonAddHR.Text = "Dodaj HR";
            buttonAddHR.UseVisualStyleBackColor = true;
            buttonAddHR.Click += buttonAddHR_Click;
            // 
            // buttonAddWydzial
            // 
            buttonAddWydzial.Location = new Point(58, 237);
            buttonAddWydzial.Name = "buttonAddWydzial";
            buttonAddWydzial.Size = new Size(153, 29);
            buttonAddWydzial.TabIndex = 4;
            buttonAddWydzial.Text = "Dodaj Wydział";
            buttonAddWydzial.UseVisualStyleBackColor = true;
            buttonAddWydzial.Click += buttonAddWydzial_Click;
            // 
            // buttonAddKierownikWydzialu
            // 
            buttonAddKierownikWydzialu.Location = new Point(39, 286);
            buttonAddKierownikWydzialu.Name = "buttonAddKierownikWydzialu";
            buttonAddKierownikWydzialu.Size = new Size(204, 29);
            buttonAddKierownikWydzialu.TabIndex = 5;
            buttonAddKierownikWydzialu.Text = "Dodaj kierownika wydzialu";
            buttonAddKierownikWydzialu.UseVisualStyleBackColor = true;
            buttonAddKierownikWydzialu.Click += buttonAddKierownikWydzialu_Click;
            // 
            // buttonShowData
            // 
            buttonShowData.Location = new Point(39, 360);
            buttonShowData.Name = "buttonShowData";
            buttonShowData.Size = new Size(219, 29);
            buttonShowData.TabIndex = 6;
            buttonShowData.Text = "Wyświetl bazę danych";
            buttonShowData.UseVisualStyleBackColor = true;
            buttonShowData.Click += buttonShowData_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonShowData);
            Controls.Add(buttonAddKierownikWydzialu);
            Controls.Add(buttonAddWydzial);
            Controls.Add(buttonAddHR);
            Controls.Add(buttonAddTeacher);
            Controls.Add(buttonADDStudents);
            Name = "Form1";
            Text = "Akademia Bialska";
            ResumeLayout(false);
        }

        #endregion

        private Button buttonADDStudents;
        private Button buttonAddTeacher;
        private Button buttonAddHR;
        private Button buttonAddWydzial;
        private Button buttonAddKierownikWydzialu;
        private Button buttonShowData;
    }
}
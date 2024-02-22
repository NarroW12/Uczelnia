namespace Uczelnia
{
    partial class ListaDanychForm
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
            dataGridViewUczniowie = new DataGridView();
            buttonWyswietlUczniow = new Button();
            buttonShowTeaher = new Button();
            buttonShowHR = new Button();
            buttonShowWydziały = new Button();
            buttonShowKierownicyWydzialu = new Button();
            buttonExit = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUczniowie).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewUczniowie
            // 
            dataGridViewUczniowie.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewUczniowie.Location = new Point(44, 27);
            dataGridViewUczniowie.Name = "dataGridViewUczniowie";
            dataGridViewUczniowie.RowHeadersWidth = 51;
            dataGridViewUczniowie.RowTemplate.Height = 29;
            dataGridViewUczniowie.Size = new Size(657, 223);
            dataGridViewUczniowie.TabIndex = 0;
            // 
            // buttonWyswietlUczniow
            // 
            buttonWyswietlUczniow.Location = new Point(44, 286);
            buttonWyswietlUczniow.Name = "buttonWyswietlUczniow";
            buttonWyswietlUczniow.Size = new Size(178, 31);
            buttonWyswietlUczniow.TabIndex = 1;
            buttonWyswietlUczniow.Text = "Wyświetl Uczniów";
            buttonWyswietlUczniow.UseVisualStyleBackColor = true;
            buttonWyswietlUczniow.Click += buttonWyswietlUczniow_Click;
            // 
            // buttonShowTeaher
            // 
            buttonShowTeaher.Location = new Point(44, 346);
            buttonShowTeaher.Name = "buttonShowTeaher";
            buttonShowTeaher.Size = new Size(178, 29);
            buttonShowTeaher.TabIndex = 2;
            buttonShowTeaher.Text = "Wyświetl Wykladowców";
            buttonShowTeaher.UseVisualStyleBackColor = true;
            buttonShowTeaher.Click += buttonShowTeaher_Click;
            // 
            // buttonShowHR
            // 
            buttonShowHR.Location = new Point(244, 288);
            buttonShowHR.Name = "buttonShowHR";
            buttonShowHR.Size = new Size(174, 29);
            buttonShowHR.TabIndex = 3;
            buttonShowHR.Text = "Wyświetl HR";
            buttonShowHR.UseVisualStyleBackColor = true;
            buttonShowHR.Click += buttonShowHR_Click;
            // 
            // buttonShowWydziały
            // 
            buttonShowWydziały.Location = new Point(244, 346);
            buttonShowWydziały.Name = "buttonShowWydziały";
            buttonShowWydziały.Size = new Size(174, 29);
            buttonShowWydziały.TabIndex = 4;
            buttonShowWydziały.Text = "Wyświetl Wydziały";
            buttonShowWydziały.UseVisualStyleBackColor = true;
            buttonShowWydziały.Click += buttonShowWydziały_Click;
            // 
            // buttonShowKierownicyWydzialu
            // 
            buttonShowKierownicyWydzialu.Location = new Point(452, 288);
            buttonShowKierownicyWydzialu.Name = "buttonShowKierownicyWydzialu";
            buttonShowKierownicyWydzialu.Size = new Size(231, 29);
            buttonShowKierownicyWydzialu.TabIndex = 5;
            buttonShowKierownicyWydzialu.Text = "Wyświetl kierowników wydziału";
            buttonShowKierownicyWydzialu.UseVisualStyleBackColor = true;
            buttonShowKierownicyWydzialu.Click += buttonShowKierownicyWydzialu_Click;
            // 
            // buttonExit
            // 
            buttonExit.Location = new Point(641, 408);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(94, 29);
            buttonExit.TabIndex = 7;
            buttonExit.Text = "Wyjście";
            buttonExit.UseVisualStyleBackColor = true;
            buttonExit.Click += buttonExit_Click;
            // 
            // ListaDanychForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonExit);
            Controls.Add(buttonShowKierownicyWydzialu);
            Controls.Add(buttonShowWydziały);
            Controls.Add(buttonShowHR);
            Controls.Add(buttonShowTeaher);
            Controls.Add(buttonWyswietlUczniow);
            Controls.Add(dataGridViewUczniowie);
            Name = "ListaDanychForm";
            Text = "ListaUczniówForm";
            ((System.ComponentModel.ISupportInitialize)dataGridViewUczniowie).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewUczniowie;
        private Button buttonWyswietlUczniow;
        private Button buttonShowTeaher;
        private Button buttonShowHR;
        private Button buttonShowWydziały;
        private Button buttonShowKierownicyWydzialu;
        private Button buttonExit;
    }
}
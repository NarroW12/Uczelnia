namespace Uczelnia
{
    partial class PodajIDForm
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
            textBoxPodajID = new TextBox();
            button1 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // textBoxPodajID
            // 
            textBoxPodajID.Location = new Point(87, 101);
            textBoxPodajID.Name = "textBoxPodajID";
            textBoxPodajID.Size = new Size(125, 27);
            textBoxPodajID.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(87, 156);
            button1.Name = "button1";
            button1.Size = new Size(125, 29);
            button1.TabIndex = 1;
            button1.Text = "OK";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(115, 78);
            label1.Name = "label1";
            label1.Size = new Size(65, 20);
            label1.TabIndex = 2;
            label1.Text = "Podaj ID";
            // 
            // PodajIDForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(310, 278);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(textBoxPodajID);
            Name = "PodajIDForm";
            Text = "PodajIDForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxPodajID;
        private Button button1;
        private Label label1;
    }
}
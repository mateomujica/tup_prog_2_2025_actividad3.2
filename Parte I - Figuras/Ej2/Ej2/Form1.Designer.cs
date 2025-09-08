namespace Ej2
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
            lsbPrueba = new ListBox();
            btnPrueba = new Button();
            SuspendLayout();
            // 
            // lsbPrueba
            // 
            lsbPrueba.FormattingEnabled = true;
            lsbPrueba.ItemHeight = 15;
            lsbPrueba.Location = new Point(28, 54);
            lsbPrueba.Name = "lsbPrueba";
            lsbPrueba.Size = new Size(439, 274);
            lsbPrueba.TabIndex = 0;
            // 
            // btnPrueba
            // 
            btnPrueba.Location = new Point(484, 180);
            btnPrueba.Name = "btnPrueba";
            btnPrueba.Size = new Size(75, 23);
            btnPrueba.TabIndex = 1;
            btnPrueba.Text = "Prueba";
            btnPrueba.UseVisualStyleBackColor = true;
            btnPrueba.Click += btnPrueba_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnPrueba);
            Controls.Add(lsbPrueba);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox lsbPrueba;
        private Button btnPrueba;
    }
}

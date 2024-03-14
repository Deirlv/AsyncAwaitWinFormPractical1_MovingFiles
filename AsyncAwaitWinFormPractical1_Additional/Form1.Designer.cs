namespace AsyncAwaitWinFormPractical1_Additional
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
            textBoxSource = new TextBox();
            textBoxDestination = new TextBox();
            buttonStart = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // textBoxSource
            // 
            textBoxSource.Location = new Point(224, 122);
            textBoxSource.Name = "textBoxSource";
            textBoxSource.Size = new Size(323, 23);
            textBoxSource.TabIndex = 0;
            // 
            // textBoxDestination
            // 
            textBoxDestination.Location = new Point(224, 213);
            textBoxDestination.Name = "textBoxDestination";
            textBoxDestination.Size = new Size(323, 23);
            textBoxDestination.TabIndex = 1;
            // 
            // buttonStart
            // 
            buttonStart.Location = new Point(347, 286);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(75, 23);
            buttonStart.TabIndex = 2;
            buttonStart.Text = "Move files";
            buttonStart.UseVisualStyleBackColor = true;
            buttonStart.Click += buttonStart_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(361, 92);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 3;
            label1.Text = "Source:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(349, 182);
            label2.Name = "label2";
            label2.Size = new Size(70, 15);
            label2.TabIndex = 4;
            label2.Text = "Destination:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(755, 388);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonStart);
            Controls.Add(textBoxDestination);
            Controls.Add(textBoxSource);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxSource;
        private TextBox textBoxDestination;
        private Button buttonStart;
        private Label label1;
        private Label label2;
    }
}

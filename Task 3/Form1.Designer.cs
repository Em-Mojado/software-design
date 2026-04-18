namespace Task_3
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
            txtListBox = new ListBox();
            btnShowAudioBooks = new Button();
            btnShowTextBooks = new Button();
            SuspendLayout();
            // 
            // txtListBox
            // 
            txtListBox.FormattingEnabled = true;
            txtListBox.Location = new Point(80, 23);
            txtListBox.Name = "txtListBox";
            txtListBox.Size = new Size(640, 334);
            txtListBox.TabIndex = 0;
            // 
            // btnShowAudioBooks
            // 
            btnShowAudioBooks.Location = new Point(80, 367);
            btnShowAudioBooks.Name = "btnShowAudioBooks";
            btnShowAudioBooks.Size = new Size(312, 61);
            btnShowAudioBooks.TabIndex = 1;
            btnShowAudioBooks.Text = "Show Audiobooks";
            btnShowAudioBooks.UseVisualStyleBackColor = true;
            btnShowAudioBooks.Click += btnShowAudioBooks_Click;
            // 
            // btnShowTextBooks
            // 
            btnShowTextBooks.Location = new Point(408, 367);
            btnShowTextBooks.Name = "btnShowTextBooks";
            btnShowTextBooks.Size = new Size(312, 61);
            btnShowTextBooks.TabIndex = 2;
            btnShowTextBooks.Text = "Show Textbooks";
            btnShowTextBooks.UseVisualStyleBackColor = true;
            btnShowTextBooks.Click += btnShowTextBooks_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(btnShowTextBooks);
            Controls.Add(btnShowAudioBooks);
            Controls.Add(txtListBox);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private ListBox txtListBox;
        private Button btnShowAudioBooks;
        private Button btnShowTextBooks;
    }
}

namespace AsyncProgrammingApp
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
            btnHello = new Button();
            btnPrintSync = new Button();
            SuspendLayout();
            // 
            // btnHello
            // 
            btnHello.Location = new Point(58, 49);
            btnHello.Name = "btnHello";
            btnHello.Size = new Size(130, 58);
            btnHello.TabIndex = 0;
            btnHello.Text = "Hello";
            btnHello.UseVisualStyleBackColor = true;
            btnHello.Click += btnHello_Click;
            // 
            // btnPrintSync
            // 
            btnPrintSync.Location = new Point(58, 148);
            btnPrintSync.Name = "btnPrintSync";
            btnPrintSync.Size = new Size(130, 59);
            btnPrintSync.TabIndex = 1;
            btnPrintSync.Text = "SyncPrint";
            btnPrintSync.UseVisualStyleBackColor = true;
            btnPrintSync.Click += btnPrintSync_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(866, 458);
            Controls.Add(btnPrintSync);
            Controls.Add(btnHello);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnHello;
        private Button btnPrintSync;
    }
}

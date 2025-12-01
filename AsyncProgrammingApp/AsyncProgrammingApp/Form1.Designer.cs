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
            btnThread = new Button();
            btnTask = new Button();
            btnAwaitable = new Button();
            btnAwaitableResult = new Button();
            btnApiCall = new Button();
            SuspendLayout();
            // 
            // btnHello
            // 
            btnHello.Location = new Point(41, 29);
            btnHello.Margin = new Padding(2, 2, 2, 2);
            btnHello.Name = "btnHello";
            btnHello.Size = new Size(91, 35);
            btnHello.TabIndex = 0;
            btnHello.Text = "Hello";
            btnHello.UseVisualStyleBackColor = true;
            btnHello.Click += btnHello_Click;
            btnHello.Click += btnHello_Click;
            // 
            // btnPrintSync
            // 
            btnPrintSync.Location = new Point(41, 89);
            btnPrintSync.Margin = new Padding(2, 2, 2, 2);
            btnPrintSync.Name = "btnPrintSync";
            btnPrintSync.Size = new Size(91, 35);
            btnPrintSync.TabIndex = 1;
            btnPrintSync.Text = "SyncPrint";
            btnPrintSync.UseVisualStyleBackColor = true;
            btnPrintSync.Click += btnPrintSync_Click;
            // 
            // btnThread
            // 
            btnThread.Location = new Point(41, 155);
            btnThread.Margin = new Padding(2, 2, 2, 2);
            btnThread.Name = "btnThread";
            btnThread.Size = new Size(78, 20);
            btnThread.TabIndex = 2;
            btnThread.Text = "Thread";
            btnThread.UseVisualStyleBackColor = true;
            btnThread.Click += btnThread_Click;
            // 
            // btnTask
            // 
            btnTask.Location = new Point(245, 49);
            btnTask.Name = "btnTask";
            btnTask.Size = new Size(120, 40);
            btnTask.TabIndex = 3;
            btnTask.Text = "Task";
            btnTask.UseVisualStyleBackColor = true;
            btnTask.Click += btnTask_Click;
            // 
            // btnAwaitable
            // 
            btnAwaitable.Location = new Point(245, 128);
            btnAwaitable.Name = "btnAwaitable";
            btnAwaitable.Size = new Size(121, 53);
            btnAwaitable.TabIndex = 4;
            btnAwaitable.Text = "Awaitable";
            btnAwaitable.UseVisualStyleBackColor = true;
            btnAwaitable.Click += btnAwaitable_Click;
            // 
            // btnAwaitableResult
            // 
            btnAwaitableResult.Location = new Point(463, 118);
            btnAwaitableResult.Name = "btnAwaitableResult";
            btnAwaitableResult.Size = new Size(221, 73);
            btnAwaitableResult.TabIndex = 5;
            btnAwaitableResult.Text = "AwaitableWithResult";
            btnAwaitableResult.UseVisualStyleBackColor = true;
            btnAwaitableResult.Click += btnAwaitableResult_Click;
            // 
            // btnApiCall
            // 
            btnApiCall.Location = new Point(338, 233);
            btnApiCall.Name = "btnApiCall";
            btnApiCall.Size = new Size(174, 84);
            btnApiCall.TabIndex = 6;
            btnApiCall.Text = "API Call";
            btnApiCall.UseVisualStyleBackColor = true;
            btnApiCall.Click += btnApiCall_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;

            ClientSize = new Size(714, 310);

            ClientSize = new Size(866, 458);
            Controls.Add(btnApiCall);
            Controls.Add(btnAwaitableResult);
            Controls.Add(btnAwaitable);
            Controls.Add(btnTask);

            Controls.Add(btnThread);
            Controls.Add(btnPrintSync);
            Controls.Add(btnHello);
            Margin = new Padding(2, 2, 2, 2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnHello;
        private Button btnPrintSync;
        private Button btnThread;
        private Button btnTask;
        private Button btnAwaitable;
        private Button btnAwaitableResult;
        private Button btnApiCall;
    }
}

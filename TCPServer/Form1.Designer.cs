namespace TCPServer
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
            label1 = new Label();
            txtIP = new TextBox();
            btnStart = new Button();
            txtInfo = new TextBox();
            label2 = new Label();
            txtMessage = new TextBox();
            btnSend = new Button();
            listClientIP = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(675, 26);
            label1.Name = "label1";
            label1.Size = new Size(63, 20);
            label1.TabIndex = 0;
            label1.Text = "Client IP";
            // 
            // txtIP
            // 
            txtIP.Location = new Point(186, 23);
            txtIP.Name = "txtIP";
            txtIP.Size = new Size(443, 27);
            txtIP.TabIndex = 1;
            txtIP.Text = "127.0.0.1:8080";
            // 
            // btnStart
            // 
            btnStart.Location = new Point(535, 395);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(94, 29);
            btnStart.TabIndex = 2;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // txtInfo
            // 
            txtInfo.Location = new Point(186, 73);
            txtInfo.Multiline = true;
            txtInfo.Name = "txtInfo";
            txtInfo.Size = new Size(443, 269);
            txtInfo.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(113, 369);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 0;
            label2.Text = "Message";
            // 
            // txtMessage
            // 
            txtMessage.Location = new Point(186, 362);
            txtMessage.Name = "txtMessage";
            txtMessage.Size = new Size(443, 27);
            txtMessage.TabIndex = 1;
            // 
            // btnSend
            // 
            btnSend.Location = new Point(421, 395);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(94, 29);
            btnSend.TabIndex = 2;
            btnSend.Text = "Send";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click;
            // 
            // listClientIP
            // 
            listClientIP.FormattingEnabled = true;
            listClientIP.ItemHeight = 20;
            listClientIP.Location = new Point(675, 58);
            listClientIP.Name = "listClientIP";
            listClientIP.Size = new Size(392, 284);
            listClientIP.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1130, 450);
            Controls.Add(listClientIP);
            Controls.Add(btnSend);
            Controls.Add(btnStart);
            Controls.Add(txtInfo);
            Controls.Add(txtMessage);
            Controls.Add(txtIP);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "TCP Server";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtIP;
        private Button btnStart;
        private TextBox txtInfo;
        private Label label2;
        private TextBox txtMessage;
        private Button btnSend;
        private ListBox listClientIP;
    }
}
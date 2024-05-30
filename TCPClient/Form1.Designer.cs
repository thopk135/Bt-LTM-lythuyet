namespace TCPClient
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
            textBox1 = new TextBox();
            btnConnect = new Button();
            txtInfocl = new TextBox();
            label2 = new Label();
            txtMessage = new TextBox();
            btnSend = new Button();
            pictureBox1 = new PictureBox();
            sendimage = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(77, 30);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 0;
            label1.Text = "Server";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(186, 23);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(443, 27);
            textBox1.TabIndex = 1;
            textBox1.Text = "127.0.0.1:8080";
            // 
            // btnConnect
            // 
            btnConnect.Location = new Point(535, 395);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new Size(94, 29);
            btnConnect.TabIndex = 2;
            btnConnect.Text = "Connect";
            btnConnect.UseVisualStyleBackColor = true;
            btnConnect.Click += btnConnect_Click;
            // 
            // txtInfocl
            // 
            txtInfocl.Location = new Point(186, 73);
            txtInfocl.Multiline = true;
            txtInfocl.Name = "txtInfocl";
            txtInfocl.Size = new Size(443, 269);
            txtInfocl.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(77, 369);
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
            // pictureBox1
            // 
            pictureBox1.Location = new Point(178, 408);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(104, 30);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // sendimage
            // 
            sendimage.Location = new Point(288, 409);
            sendimage.Name = "sendimage";
            sendimage.Size = new Size(109, 29);
            sendimage.TabIndex = 4;
            sendimage.Text = "Send Image";
            sendimage.UseVisualStyleBackColor = true;
            sendimage.Click += sendimage_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(sendimage);
            Controls.Add(pictureBox1);
            Controls.Add(btnSend);
            Controls.Add(btnConnect);
            Controls.Add(txtInfocl);
            Controls.Add(txtMessage);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "TCP Client";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Button btnConnect;
        private TextBox txtInfocl;
        private Label label2;
        private TextBox txtMessage;
        private Button btnSend;
        private PictureBox pictureBox1;
        private Button sendimage;
    }
}
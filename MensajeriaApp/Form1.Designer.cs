namespace MensajeriaApp
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
        private System.Windows.Forms.TextBox txtMessages;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.TextBox txtListenPort;
        private System.Windows.Forms.TextBox txtTargetPort;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnStart;

        private void InitializeComponent()
        {
            txtMessages = new TextBox();
            txtMessage = new TextBox();
            txtListenPort = new TextBox();
            txtTargetPort = new TextBox();
            btnSend = new Button();
            btnStart = new Button();
            SuspendLayout();
            // 
            // txtMessages
            // 
            txtMessages.Location = new Point(16, 18);
            txtMessages.Margin = new Padding(4, 5, 4, 5);
            txtMessages.Multiline = true;
            txtMessages.Name = "txtMessages";
            txtMessages.ReadOnly = true;
            txtMessages.ScrollBars = ScrollBars.Vertical;
            txtMessages.Size = new Size(479, 459);
            txtMessages.TabIndex = 0;
            // 
            // txtMessage
            // 
            txtMessage.Location = new Point(16, 489);
            txtMessage.Margin = new Padding(4, 5, 4, 5);
            txtMessage.Name = "txtMessage";
            txtMessage.PlaceholderText = "Escribe algo... Primero da click \"iniciar\"";
            txtMessage.Size = new Size(479, 27);
            txtMessage.TabIndex = 1;
            // 
            // txtListenPort
            // 
            txtListenPort.Location = new Point(16, 529);
            txtListenPort.Margin = new Padding(4, 5, 4, 5);
            txtListenPort.Name = "txtListenPort";
            txtListenPort.PlaceholderText = "Home Port";
            txtListenPort.Size = new Size(132, 27);
            txtListenPort.TabIndex = 2;
            // 
            // txtTargetPort
            // 
            txtTargetPort.Location = new Point(157, 529);
            txtTargetPort.Margin = new Padding(4, 5, 4, 5);
            txtTargetPort.Name = "txtTargetPort";
            txtTargetPort.PlaceholderText = "Destiny Port";
            txtTargetPort.Size = new Size(132, 27);
            txtTargetPort.TabIndex = 3;
            // 
            // btnSend
            // 
            btnSend.Location = new Point(299, 526);
            btnSend.Margin = new Padding(4, 5, 4, 5);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(100, 35);
            btnSend.TabIndex = 4;
            btnSend.Text = "Enviar";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click;
            // 
            // btnStart
            // 
            btnStart.Location = new Point(407, 526);
            btnStart.Margin = new Padding(4, 5, 4, 5);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(100, 35);
            btnStart.TabIndex = 5;
            btnStart.Text = "Iniciar";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 15, 15);
            ClientSize = new Size(512, 577);
            Controls.Add(btnStart);
            Controls.Add(btnSend);
            Controls.Add(txtTargetPort);
            Controls.Add(txtListenPort);
            Controls.Add(txtMessage);
            Controls.Add(txtMessages);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            Name = "Form1";
            Text = "MensajeriaApp";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}

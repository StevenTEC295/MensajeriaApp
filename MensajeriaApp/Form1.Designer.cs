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
        private System.Windows.Forms.Panel pnlMessages;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.TextBox txtListenPort;
        private System.Windows.Forms.TextBox txtTargetPort;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnStart;

        private void InitializeComponent()
        {
            pnlMessages = new Panel();
            txtMessage = new TextBox();
            txtListenPort = new TextBox();
            txtTargetPort = new TextBox();
            btnSend = new Button();
            btnStart = new Button();
            SuspendLayout();
            // 
            // pnlMessages
            // 
            pnlMessages.AutoScroll = true;
            pnlMessages.BorderStyle = BorderStyle.FixedSingle;
            pnlMessages.Location = new Point(14, 14);
            pnlMessages.Margin = new Padding(4, 3, 4, 3);
            pnlMessages.Name = "pnlMessages";
            pnlMessages.Size = new Size(420, 346);
            pnlMessages.TabIndex = 0;
            // 
            // txtMessage
            // 
            txtMessage.Location = new Point(14, 367);
            txtMessage.Margin = new Padding(4, 3, 4, 3);
            txtMessage.Name = "txtMessage";
            txtMessage.Size = new Size(419, 23);
            txtMessage.TabIndex = 1;
            // 
            // txtListenPort
            // 
            txtListenPort.Location = new Point(14, 397);
            txtListenPort.Margin = new Padding(4, 3, 4, 3);
            txtListenPort.Name = "txtListenPort";
            txtListenPort.Size = new Size(116, 23);
            txtListenPort.TabIndex = 2;
            txtListenPort.Text = "5000";
            // 
            // txtTargetPort
            // 
            txtTargetPort.Location = new Point(138, 397);
            txtTargetPort.Margin = new Padding(4, 3, 4, 3);
            txtTargetPort.Name = "txtTargetPort";
            txtTargetPort.Size = new Size(116, 23);
            txtTargetPort.TabIndex = 3;
            txtTargetPort.Text = "5001";
            // 
            // btnSend
            // 
            btnSend.Location = new Point(261, 395);
            btnSend.Margin = new Padding(4, 3, 4, 3);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(88, 27);
            btnSend.TabIndex = 4;
            btnSend.Text = "Enviar";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click;
            // 
            // btnStart
            // 
            btnStart.Location = new Point(356, 395);
            btnStart.Margin = new Padding(4, 3, 4, 3);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(88, 27);
            btnStart.TabIndex = 5;
            btnStart.Text = "Iniciar";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(448, 433);
            Controls.Add(btnStart);
            Controls.Add(btnSend);
            Controls.Add(txtTargetPort);
            Controls.Add(txtListenPort);
            Controls.Add(txtMessage);
            Controls.Add(pnlMessages);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "Chat";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}

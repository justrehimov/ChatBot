namespace Artificial_Intelligence_Chatbot
{
    partial class Main
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
            this.InputBox = new System.Windows.Forms.TextBox();
            this.OutputBox = new System.Windows.Forms.TextBox();
            this.pb_bot = new System.Windows.Forms.PictureBox();
            this.btn_send = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_bot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_send)).BeginInit();
            this.SuspendLayout();
            // 
            // InputBox
            // 
            this.InputBox.BackColor = System.Drawing.Color.Azure;
            this.InputBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InputBox.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputBox.ForeColor = System.Drawing.Color.Black;
            this.InputBox.Location = new System.Drawing.Point(12, 219);
            this.InputBox.Multiline = true;
            this.InputBox.Name = "InputBox";
            this.InputBox.Size = new System.Drawing.Size(226, 25);
            this.InputBox.TabIndex = 1;
            this.InputBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.InputBox_KeyDown);
            // 
            // OutputBox
            // 
            this.OutputBox.BackColor = System.Drawing.Color.SteelBlue;
            this.OutputBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OutputBox.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutputBox.ForeColor = System.Drawing.Color.Black;
            this.OutputBox.Location = new System.Drawing.Point(12, 142);
            this.OutputBox.Multiline = true;
            this.OutputBox.Name = "OutputBox";
            this.OutputBox.Size = new System.Drawing.Size(259, 71);
            this.OutputBox.TabIndex = 2;
            this.OutputBox.Text = "Hi There!\r\nHow Can I Help You?";
            this.OutputBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pb_bot
            // 
            this.pb_bot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pb_bot.Image = global::Artificial_Intelligence_Chatbot.Properties.Resources._2593627;
            this.pb_bot.Location = new System.Drawing.Point(74, 7);
            this.pb_bot.Name = "pb_bot";
            this.pb_bot.Size = new System.Drawing.Size(137, 129);
            this.pb_bot.TabIndex = 4;
            this.pb_bot.TabStop = false;
            // 
            // btn_send
            // 
            this.btn_send.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_send.Image = global::Artificial_Intelligence_Chatbot.Properties.Resources.icons8_Sent_512px;
            this.btn_send.Location = new System.Drawing.Point(244, 219);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(29, 25);
            this.btn_send.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_send.TabIndex = 3;
            this.btn_send.TabStop = false;
            this.btn_send.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(284, 256);
            this.Controls.Add(this.pb_bot);
            this.Controls.Add(this.btn_send);
            this.Controls.Add(this.OutputBox);
            this.Controls.Add(this.InputBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChatBot";
            ((System.ComponentModel.ISupportInitialize)(this.pb_bot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_send)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox InputBox;
        private System.Windows.Forms.TextBox OutputBox;
        private System.Windows.Forms.PictureBox btn_send;
        private System.Windows.Forms.PictureBox pb_bot;
    }
}


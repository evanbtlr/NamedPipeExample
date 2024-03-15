namespace WinFormsApp2
{
    partial class ClientForm
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
            richTextBox2 = new RichTextBox();
            Send = new Button();
            button2 = new Button();
            textBox1 = new TextBox();
            Read = new Button();
            button1 = new Button();
            statusStrip1 = new StatusStrip();
            Label = new ToolStripStatusLabel();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // richTextBox2
            // 
            richTextBox2.Location = new Point(24, 203);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(764, 96);
            richTextBox2.TabIndex = 1;
            richTextBox2.Text = "";
            // 
            // Send
            // 
            Send.Location = new Point(713, 129);
            Send.Name = "Send";
            Send.Size = new Size(75, 23);
            Send.TabIndex = 2;
            Send.Text = "Send";
            Send.UseVisualStyleBackColor = true;
            Send.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(534, 327);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 3;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Location = new Point(12, 12);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(776, 111);
            textBox1.TabIndex = 4;
            // 
            // Read
            // 
            Read.Location = new Point(632, 129);
            Read.Name = "Read";
            Read.Size = new Size(75, 23);
            Read.TabIndex = 5;
            Read.Text = "Read";
            Read.UseVisualStyleBackColor = true;
            Read.Click += Read_Click;
            // 
            // button1
            // 
            button1.Location = new Point(551, 129);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 6;
            button1.Text = "Connect";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { Label });
            statusStrip1.Location = new Point(0, 428);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 22);
            statusStrip1.TabIndex = 7;
            statusStrip1.Text = "statusStrip1";
            // 
            // Label
            // 
            Label.Name = "Label";
            Label.Size = new Size(0, 17);
            // 
            // ClientForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(statusStrip1);
            Controls.Add(button1);
            Controls.Add(Read);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(Send);
            Controls.Add(richTextBox2);
            Name = "ClientForm";
            Text = "ClientForm";
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private RichTextBox richTextBox2;
        private Button Send;
        private Button button2;
        private TextBox textBox1;
        private Button Read;
        private Button button1;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel Label;
    }
}

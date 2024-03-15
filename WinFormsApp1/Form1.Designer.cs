namespace WinFormsApp1
{
    partial class ServerForm
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
            button1 = new Button();
            button2 = new Button();
            textBox1 = new TextBox();
            Read = new Button();
            Create = new Button();
            statusStrip1 = new StatusStrip();
            Label = new ToolStripStatusLabel();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // richTextBox2
            // 
            richTextBox2.Location = new Point(12, 196);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(776, 96);
            richTextBox2.TabIndex = 1;
            richTextBox2.Text = "";
            // 
            // button1
            // 
            button1.Location = new Point(713, 107);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "Send";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(517, 325);
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
            textBox1.Size = new Size(776, 89);
            textBox1.TabIndex = 4;
            // 
            // Read
            // 
            Read.Location = new Point(632, 107);
            Read.Name = "Read";
            Read.Size = new Size(75, 23);
            Read.TabIndex = 5;
            Read.Text = "Read";
            Read.UseVisualStyleBackColor = true;
            Read.Click += Read_Click;
            // 
            // Create
            // 
            Create.Location = new Point(551, 107);
            Create.Name = "Create";
            Create.Size = new Size(75, 23);
            Create.TabIndex = 6;
            Create.Text = "Create";
            Create.UseVisualStyleBackColor = true;
            Create.Click += Create_Click;
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
            Label.Size = new Size(44, 17);
            Label.Text = "Started";
            // 
            // ServerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(statusStrip1);
            Controls.Add(Create);
            Controls.Add(Read);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(richTextBox2);
            Name = "ServerForm";
            Text = "ServerForm";
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private RichTextBox richTextBox2;
        private Button button1;
        private Button button2;
        private TextBox textBox1;
        private Button Read;
        private Button Create;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel Label;
    }
}

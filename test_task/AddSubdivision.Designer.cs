namespace test_task
{
    partial class AddSubdivision
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
            comboBox1 = new ComboBox();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            textBox2 = new TextBox();
            label1 = new Label();
            textBox1 = new TextBox();
            AddBut = new Button();
            comboBox2 = new ComboBox();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(210, 88);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(134, 28);
            comboBox1.TabIndex = 30;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(153, 125);
            label5.Name = "label5";
            label5.Size = new Size(48, 20);
            label5.TabIndex = 26;
            label5.Text = "Глава";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(16, 88);
            label4.Name = "label4";
            label4.Size = new Size(188, 20);
            label4.TabIndex = 24;
            label4.Text = "Головное подразделение";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(127, 58);
            label2.Name = "label2";
            label2.Size = new Size(77, 20);
            label2.TabIndex = 21;
            label2.Text = "Название";
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox2.Location = new Point(210, 55);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(134, 27);
            textBox2.TabIndex = 20;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(147, 22);
            label1.Name = "label1";
            label1.Size = new Size(57, 20);
            label1.TabIndex = 19;
            label1.Text = "Номер";
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Location = new Point(210, 22);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(134, 27);
            textBox1.TabIndex = 18;
            // 
            // AddBut
            // 
            AddBut.Anchor = AnchorStyles.Bottom;
            AddBut.Location = new Point(156, 181);
            AddBut.Name = "AddBut";
            AddBut.Size = new Size(94, 29);
            AddBut.TabIndex = 17;
            AddBut.Text = "Добавить";
            AddBut.UseVisualStyleBackColor = true;
            AddBut.Click += AddBut_Click;
            // 
            // comboBox2
            // 
            comboBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(207, 122);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(134, 28);
            comboBox2.TabIndex = 32;
            // 
            // AddSubdivision
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(419, 222);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(AddBut);
            Name = "AddSubdivision";
            Text = "AddSubdivision";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox comboBox1;
        private Label label5;
        private Label label4;
        private Label label2;
        private TextBox textBox2;
        private Label label1;
        private TextBox textBox1;
        private Button AddBut;
        private ComboBox comboBox2;
    }
}
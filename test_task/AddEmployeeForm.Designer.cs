namespace test_task
{
    partial class AddEmployeeForm
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
            AddBut = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox3 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            textBox5 = new TextBox();
            label6 = new Label();
            textBox6 = new TextBox();
            label7 = new Label();
            comboBox1 = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            SuspendLayout();
            // 
            // AddBut
            // 
            AddBut.Anchor = AnchorStyles.Bottom;
            AddBut.Location = new Point(158, 289);
            AddBut.Name = "AddBut";
            AddBut.Size = new Size(94, 29);
            AddBut.TabIndex = 0;
            AddBut.Text = "Добавить";
            AddBut.UseVisualStyleBackColor = true;
            AddBut.Click += AddBut_Click;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Location = new Point(204, 29);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(129, 27);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(61, 32);
            label1.Name = "label1";
            label1.Size = new Size(137, 20);
            label1.TabIndex = 2;
            label1.Text = "Табельный номер";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(156, 65);
            label2.Name = "label2";
            label2.Size = new Size(42, 20);
            label2.TabIndex = 4;
            label2.Text = "ФИО";
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox2.Location = new Point(204, 62);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(129, 27);
            textBox2.TabIndex = 3;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(112, 98);
            label3.Name = "label3";
            label3.Size = new Size(86, 20);
            label3.TabIndex = 6;
            label3.Text = "Должность";
            // 
            // textBox3
            // 
            textBox3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox3.Location = new Point(204, 95);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(129, 27);
            textBox3.TabIndex = 5;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(79, 131);
            label4.Name = "label4";
            label4.Size = new Size(119, 20);
            label4.TabIndex = 8;
            label4.Text = "Подразделение";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(147, 164);
            label5.Name = "label5";
            label5.Size = new Size(51, 20);
            label5.TabIndex = 10;
            label5.Text = "Почта";
            // 
            // textBox5
            // 
            textBox5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox5.Location = new Point(204, 161);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(129, 27);
            textBox5.TabIndex = 9;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Location = new Point(129, 197);
            label6.Name = "label6";
            label6.Size = new Size(69, 20);
            label6.TabIndex = 12;
            label6.Text = "Телефон";
            // 
            // textBox6
            // 
            textBox6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox6.Location = new Point(204, 194);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(129, 27);
            textBox6.TabIndex = 11;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Location = new Point(108, 230);
            label7.Name = "label7";
            label7.Size = new Size(90, 20);
            label7.TabIndex = 14;
            label7.Text = "Дата найма";
            // 
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(204, 127);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(129, 28);
            comboBox1.TabIndex = 15;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dateTimePicker1.CustomFormat = "dd.MM.yyyy";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(204, 230);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(129, 27);
            dateTimePicker1.TabIndex = 16;
            dateTimePicker1.Value = new DateTime(2023, 7, 27, 21, 51, 5, 0);
            // 
            // AddEmployeeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(415, 330);
            Controls.Add(dateTimePicker1);
            Controls.Add(comboBox1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(textBox6);
            Controls.Add(label5);
            Controls.Add(textBox5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBox3);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(AddBut);
            Name = "AddEmployeeForm";
            Text = "AddEmployeeForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button AddBut;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox3;
        private Label label4;
        private Label label5;
        private TextBox textBox5;
        private Label label6;
        private TextBox textBox6;
        private Label label7;
        private ComboBox comboBox1;
        private DateTimePicker dateTimePicker1;
    }
}
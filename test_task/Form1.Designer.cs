namespace test_task
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            button12 = new Button();
            button10 = new Button();
            button8 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            AddEmployee = new Button();
            dataGridView1 = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            fio = new DataGridViewTextBoxColumn();
            post = new DataGridViewTextBoxColumn();
            subdivision = new DataGridViewTextBoxColumn();
            email = new DataGridViewTextBoxColumn();
            phone = new DataGridViewTextBoxColumn();
            hire = new DataGridViewTextBoxColumn();
            fired = new DataGridViewTextBoxColumn();
            state = new DataGridViewTextBoxColumn();
            tabPage2 = new TabPage();
            button13 = new Button();
            button9 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            dataGridView2 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            tabPage3 = new TabPage();
            button11 = new Button();
            Browse = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            openFileDialog1 = new OpenFileDialog();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            tabPage3.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl1.Appearance = TabAppearance.FlatButtons;
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(4, 2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(796, 443);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(button12);
            tabPage1.Controls.Add(button10);
            tabPage1.Controls.Add(button8);
            tabPage1.Controls.Add(button3);
            tabPage1.Controls.Add(button2);
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(AddEmployee);
            tabPage1.Controls.Add(dataGridView1);
            tabPage1.Location = new Point(4, 32);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(788, 407);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Сотрудники";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            button12.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button12.Location = new Point(557, 337);
            button12.Name = "button12";
            button12.Size = new Size(223, 29);
            button12.TabIndex = 10;
            button12.Text = "Статистика";
            button12.UseVisualStyleBackColor = true;
            button12.Click += button12_Click;
            // 
            // button10
            // 
            button10.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button10.Location = new Point(559, 372);
            button10.Name = "button10";
            button10.Size = new Size(223, 29);
            button10.TabIndex = 9;
            button10.Text = "Изменить состояние записи";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // button8
            // 
            button8.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button8.Location = new Point(688, 207);
            button8.Name = "button8";
            button8.Size = new Size(94, 29);
            button8.TabIndex = 5;
            button8.Text = "Обновить";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button3.Location = new Point(6, 232);
            button3.Name = "button3";
            button3.Size = new Size(224, 29);
            button3.TabIndex = 4;
            button3.Text = "Поиск";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button2.Location = new Point(4, 337);
            button2.Name = "button2";
            button2.Size = new Size(224, 29);
            button2.TabIndex = 3;
            button2.Text = "Уволить сотрудника";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button1.Location = new Point(6, 372);
            button1.Name = "button1";
            button1.Size = new Size(224, 29);
            button1.TabIndex = 2;
            button1.Text = "Удалить сотрудника из БД";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // AddEmployee
            // 
            AddEmployee.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            AddEmployee.Location = new Point(6, 197);
            AddEmployee.Name = "AddEmployee";
            AddEmployee.Size = new Size(224, 29);
            AddEmployee.TabIndex = 1;
            AddEmployee.Text = "Добавить нового сотрудника";
            AddEmployee.UseVisualStyleBackColor = true;
            AddEmployee.Click += AddEmployee_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { id, fio, post, subdivision, email, phone, hire, fired, state });
            dataGridView1.Location = new Point(6, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(776, 188);
            dataGridView1.TabIndex = 0;
            // 
            // id
            // 
            id.HeaderText = "Табельный номер";
            id.MinimumWidth = 6;
            id.Name = "id";
            id.Width = 125;
            // 
            // fio
            // 
            fio.HeaderText = "ФИО";
            fio.MinimumWidth = 6;
            fio.Name = "fio";
            fio.Width = 125;
            // 
            // post
            // 
            post.HeaderText = "Должность";
            post.MinimumWidth = 6;
            post.Name = "post";
            post.Width = 125;
            // 
            // subdivision
            // 
            subdivision.HeaderText = "Подразделение";
            subdivision.MinimumWidth = 6;
            subdivision.Name = "subdivision";
            subdivision.Width = 125;
            // 
            // email
            // 
            email.HeaderText = "Почта";
            email.MinimumWidth = 6;
            email.Name = "email";
            email.Width = 125;
            // 
            // phone
            // 
            phone.HeaderText = "Телефон";
            phone.MinimumWidth = 6;
            phone.Name = "phone";
            phone.Width = 125;
            // 
            // hire
            // 
            hire.HeaderText = "Принят на работу";
            hire.MinimumWidth = 6;
            hire.Name = "hire";
            hire.Width = 125;
            // 
            // fired
            // 
            fired.HeaderText = "Уволен";
            fired.MinimumWidth = 6;
            fired.Name = "fired";
            fired.Width = 125;
            // 
            // state
            // 
            state.HeaderText = "Статус записи";
            state.MinimumWidth = 6;
            state.Name = "state";
            state.Width = 125;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(button13);
            tabPage2.Controls.Add(button9);
            tabPage2.Controls.Add(button4);
            tabPage2.Controls.Add(button5);
            tabPage2.Controls.Add(button6);
            tabPage2.Controls.Add(button7);
            tabPage2.Controls.Add(dataGridView2);
            tabPage2.Location = new Point(4, 32);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(788, 407);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Подразделения";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // button13
            // 
            button13.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button13.Location = new Point(557, 337);
            button13.Name = "button13";
            button13.Size = new Size(223, 29);
            button13.TabIndex = 11;
            button13.Text = "Статистика";
            button13.UseVisualStyleBackColor = true;
            button13.Click += button13_Click;
            // 
            // button9
            // 
            button9.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button9.Location = new Point(686, 188);
            button9.Name = "button9";
            button9.Size = new Size(94, 29);
            button9.TabIndex = 10;
            button9.Text = "Обновить";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button4.Location = new Point(6, 223);
            button4.Name = "button4";
            button4.Size = new Size(224, 29);
            button4.TabIndex = 9;
            button4.Text = "Поиск";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button5.Location = new Point(562, 372);
            button5.Name = "button5";
            button5.Size = new Size(223, 29);
            button5.TabIndex = 8;
            button5.Text = "Изменить состояние записи";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button6.Location = new Point(6, 363);
            button6.Name = "button6";
            button6.Size = new Size(224, 29);
            button6.TabIndex = 7;
            button6.Text = "Удалить из БД";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button7.Location = new Point(6, 188);
            button7.Name = "button7";
            button7.Size = new Size(224, 29);
            button7.TabIndex = 6;
            button7.Text = "Добавить подразделение";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6 });
            dataGridView2.Location = new Point(6, 4);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.RowTemplate.Height = 29;
            dataGridView2.Size = new Size(776, 178);
            dataGridView2.TabIndex = 5;
            // 
            // Column1
            // 
            Column1.HeaderText = "Номер подразделения";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.HeaderText = "Название";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 125;
            // 
            // Column3
            // 
            Column3.HeaderText = "Головное подразделение";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 125;
            // 
            // Column4
            // 
            Column4.HeaderText = "Руководитель";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 125;
            // 
            // Column5
            // 
            Column5.HeaderText = "Состояние записи";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Width = 125;
            // 
            // Column6
            // 
            Column6.HeaderText = "Сотрудники";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.Width = 125;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(button11);
            tabPage3.Controls.Add(Browse);
            tabPage3.Controls.Add(textBox1);
            tabPage3.Controls.Add(label1);
            tabPage3.Location = new Point(4, 32);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(788, 407);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Загрузка данных";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            button11.Location = new Point(451, 11);
            button11.Name = "button11";
            button11.Size = new Size(195, 29);
            button11.TabIndex = 3;
            button11.Text = "Загрузить данные в БД";
            button11.UseVisualStyleBackColor = true;
            button11.Click += button11_Click;
            // 
            // Browse
            // 
            Browse.Location = new Point(351, 11);
            Browse.Name = "Browse";
            Browse.Size = new Size(94, 29);
            Browse.TabIndex = 2;
            Browse.Text = "Browse";
            Browse.UseVisualStyleBackColor = true;
            Browse.Click += Browse_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(110, 13);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(235, 27);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 16);
            label1.Name = "label1";
            label1.Size = new Size(98, 20);
            label1.TabIndex = 0;
            label1.Text = "Путь к файлу";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn fio;
        private DataGridViewTextBoxColumn post;
        private DataGridViewTextBoxColumn subdivision;
        private DataGridViewTextBoxColumn email;
        private DataGridViewTextBoxColumn phone;
        private DataGridViewTextBoxColumn hire;
        private DataGridViewTextBoxColumn fired;
        private DataGridViewTextBoxColumn state;
        private Button AddEmployee;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private Button button8;
        private Button button9;
        private Button button10;
        private TabPage tabPage3;
        private Button Browse;
        private TextBox textBox1;
        private Label label1;
        private OpenFileDialog openFileDialog1;
        private Button button11;
        private Button button12;
        private Button button13;
    }
}
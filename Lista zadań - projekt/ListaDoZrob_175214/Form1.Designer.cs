namespace ListaDoZrob_175214
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
            listBox1 = new ListBox();
            textBox1 = new TextBox();
            groupBox1 = new GroupBox();
            checkBox1 = new CheckBox();
            textBox2 = new TextBox();
            button3 = new Button();
            dateTimePicker1 = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            button2 = new Button();
            comboBox1 = new ComboBox();
            dateTimePicker2 = new DateTimePicker();
            groupBox2 = new GroupBox();
            button8 = new Button();
            comboBox2 = new ComboBox();
            button7 = new Button();
            label3 = new Label();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            label4 = new Label();
            checkBox2 = new CheckBox();
            button1 = new Button();
            panel1 = new Panel();
            splitter1 = new Splitter();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.HorizontalScrollbar = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(12, 12);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(372, 214);
            listBox1.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(6, 22);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Wyszukaj zdarzenie";
            textBox1.Size = new Size(182, 23);
            textBox1.TabIndex = 2;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(checkBox1);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(button2);
            groupBox1.Location = new Point(12, 337);
            groupBox1.Name = "groupBox1";
            groupBox1.RightToLeft = RightToLeft.No;
            groupBox1.Size = new Size(372, 75);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dodaj/Usuń zadanie";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(217, 48);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(71, 19);
            checkBox1.TabIndex = 8;
            checkBox1.Text = "Priorytet";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(46, 17);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(242, 23);
            textBox2.TabIndex = 5;
            // 
            // button3
            // 
            button3.Location = new Point(294, 45);
            button3.Name = "button3";
            button3.Size = new Size(72, 23);
            button3.TabIndex = 6;
            button3.Text = "Usuń";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(110, 46);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(101, 23);
            dateTimePicker1.TabIndex = 7;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 21);
            label1.Name = "label1";
            label1.Size = new Size(34, 15);
            label1.TabIndex = 5;
            label1.Text = "Opis:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 52);
            label2.Name = "label2";
            label2.Size = new Size(98, 15);
            label2.TabIndex = 6;
            label2.Text = "Data Ukończenia:";
            label2.Click += label2_Click;
            // 
            // button2
            // 
            button2.Location = new Point(294, 17);
            button2.Name = "button2";
            button2.Size = new Size(72, 23);
            button2.TabIndex = 5;
            button2.Text = "Dodaj";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Brak", "Wcześniej niż", "Później za", "Wcześniej do", "Później od", "W dniu" });
            comboBox1.Location = new Point(69, 50);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(97, 23);
            comboBox1.TabIndex = 10;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Format = DateTimePickerFormat.Short;
            dateTimePicker2.Location = new Point(172, 50);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(96, 23);
            dateTimePicker2.TabIndex = 12;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button8);
            groupBox2.Controls.Add(comboBox2);
            groupBox2.Controls.Add(button7);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(textBox1);
            groupBox2.Controls.Add(dateTimePicker2);
            groupBox2.Controls.Add(comboBox1);
            groupBox2.Location = new Point(12, 253);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(372, 83);
            groupBox2.TabIndex = 14;
            groupBox2.TabStop = false;
            groupBox2.Text = "Wyszukiwarka";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // button8
            // 
            button8.Location = new Point(291, 22);
            button8.Name = "button8";
            button8.Size = new Size(75, 23);
            button8.TabIndex = 21;
            button8.Text = "Szukaj";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // comboBox2
            // 
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Bez Zmian", "Bez Priorytetu", "Z Priorytetem" });
            comboBox2.Location = new Point(190, 22);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(98, 23);
            comboBox2.TabIndex = 15;
            // 
            // button7
            // 
            button7.Location = new Point(291, 50);
            button7.Name = "button7";
            button7.Size = new Size(75, 23);
            button7.TabIndex = 19;
            button7.Text = "Przywróć";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 53);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 14;
            label3.Text = "Filtr Daty:";
            // 
            // button4
            // 
            button4.Location = new Point(320, 228);
            button4.Name = "button4";
            button4.Size = new Size(64, 23);
            button4.TabIndex = 16;
            button4.Text = "Eksportuj";
            button4.TextAlign = ContentAlignment.MiddleRight;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(148, 228);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 17;
            button5.Text = "Sortuj Ros.";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(71, 228);
            button6.Name = "button6";
            button6.Size = new Size(75, 23);
            button6.TabIndex = 18;
            button6.Text = "Sortuj Mal.";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 231);
            label4.Name = "label4";
            label4.Size = new Size(68, 15);
            label4.TabIndex = 20;
            label4.Text = "Widok listy:";
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(229, 231);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(88, 19);
            checkBox2.TabIndex = 21;
            checkBox2.Text = "[!] Na Górze";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(299, 413);
            button1.Name = "button1";
            button1.Size = new Size(85, 33);
            button1.TabIndex = 23;
            button1.Text = "Opis Projektu";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(splitter1);
            panel1.Location = new Point(12, 416);
            panel1.Name = "panel1";
            panel1.Size = new Size(280, 30);
            panel1.TabIndex = 24;
            // 
            // splitter1
            // 
            splitter1.Location = new Point(0, 0);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(140, 30);
            splitter1.TabIndex = 0;
            splitter1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 7);
            label5.Name = "label5";
            label5.Size = new Size(100, 15);
            label5.TabIndex = 1;
            label5.Text = "Dł. tab. 1-kierunk:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(146, 7);
            label6.Name = "label6";
            label6.Size = new Size(89, 15);
            label6.TabIndex = 2;
            label6.Text = "Dł. tab. widoku:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(110, 8);
            label7.Name = "label7";
            label7.Size = new Size(13, 15);
            label7.TabIndex = 3;
            label7.Text = "0";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(239, 8);
            label8.Name = "label8";
            label8.Size = new Size(13, 15);
            label8.TabIndex = 4;
            label8.Text = "0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(396, 458);
            Controls.Add(panel1);
            Controls.Add(button1);
            Controls.Add(checkBox2);
            Controls.Add(label4);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(listBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            Text = "Lista Zadań - Bartłomiej Wasyluk (175214)";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ListBox listBox1;
        private TextBox textBox1;
        private GroupBox groupBox1;
        private Label label1;
        private Label label2;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox2;
        private Button button2;
        private Button button3;
        private DateTimePicker dateTimePicker2;
        private CheckBox checkBox1;
        private GroupBox groupBox2;
        private Label label3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Label label4;
        private CheckBox checkBox2;
        private Button button8;
        protected ComboBox comboBox1;
        protected ComboBox comboBox2;
        private Button button1;
        private Panel panel1;
        private Label label7;
        private Label label6;
        private Label label5;
        private Splitter splitter1;
        private Label label8;
    }
}

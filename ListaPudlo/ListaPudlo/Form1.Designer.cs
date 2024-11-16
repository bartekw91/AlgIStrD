namespace ListaPudlo
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
            AddToList = new Button();
            ClearFirst = new Button();
            button3 = new Button();
            ClearBtn = new Button();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(12, 12);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(375, 214);
            listBox1.TabIndex = 0;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 232);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(232, 23);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // AddToList
            // 
            AddToList.Location = new Point(12, 261);
            AddToList.Name = "AddToList";
            AddToList.Size = new Size(88, 23);
            AddToList.TabIndex = 2;
            AddToList.Text = "Dodaj do listy";
            AddToList.UseVisualStyleBackColor = true;
            AddToList.Click += button1_Click;
            // 
            // ClearFirst
            // 
            ClearFirst.Location = new Point(106, 261);
            ClearFirst.Name = "ClearFirst";
            ClearFirst.Size = new Size(138, 23);
            ClearFirst.TabIndex = 5;
            ClearFirst.Text = "Usuń pierwszą pozycję";
            ClearFirst.UseVisualStyleBackColor = true;
            ClearFirst.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(250, 232);
            button3.Name = "button3";
            button3.Size = new Size(82, 23);
            button3.TabIndex = 6;
            button3.Text = "Ilośc pozycji";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // ClearBtn
            // 
            ClearBtn.Location = new Point(250, 261);
            ClearBtn.Name = "ClearBtn";
            ClearBtn.Size = new Size(75, 23);
            ClearBtn.TabIndex = 7;
            ClearBtn.Text = "Wyczyść";
            ClearBtn.UseVisualStyleBackColor = true;
            ClearBtn.Click += ClearBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(396, 293);
            Controls.Add(ClearBtn);
            Controls.Add(button3);
            Controls.Add(ClearFirst);
            Controls.Add(AddToList);
            Controls.Add(textBox1);
            Controls.Add(listBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private TextBox textBox1;
        private Button AddToList;
        private Button ClearFirst;
        private Button button3;
        private Button ClearBtn;
    }
}

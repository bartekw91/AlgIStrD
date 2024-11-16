namespace ListaPudlo_Net6
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
            Lista1 = new ListBox();
            Tekst1 = new TextBox();
            AddToL1Btn = new Button();
            Del1stL1Btn = new Button();
            ClearBtn = new Button();
            MoveRightBtn = new Button();
            MoveLeftBtn = new Button();
            CountBtn = new Button();
            Lista2 = new ListBox();
            Tekst2 = new TextBox();
            AddToL2Btn = new Button();
            Del1sztL2Btn = new Button();
            SuspendLayout();
            // 
            // Lista1
            // 
            Lista1.FormattingEnabled = true;
            Lista1.ItemHeight = 15;
            Lista1.Location = new Point(12, 12);
            Lista1.Name = "Lista1";
            Lista1.Size = new Size(180, 199);
            Lista1.TabIndex = 0;
            // 
            // Tekst1
            // 
            Tekst1.Location = new Point(12, 217);
            Tekst1.Name = "Tekst1";
            Tekst1.Size = new Size(180, 23);
            Tekst1.TabIndex = 1;
            // 
            // AddToL1Btn
            // 
            AddToL1Btn.Location = new Point(64, 246);
            AddToL1Btn.Name = "AddToL1Btn";
            AddToL1Btn.Size = new Size(75, 23);
            AddToL1Btn.TabIndex = 2;
            AddToL1Btn.Text = "Dodaj";
            AddToL1Btn.UseVisualStyleBackColor = true;
            AddToL1Btn.Click += AddToL1Btn_Click;
            // 
            // Del1stL1Btn
            // 
            Del1stL1Btn.Location = new Point(42, 275);
            Del1stL1Btn.Name = "Del1stL1Btn";
            Del1stL1Btn.Size = new Size(117, 23);
            Del1stL1Btn.TabIndex = 3;
            Del1stL1Btn.Text = "Usuń 1-szą pozycję";
            Del1stL1Btn.UseVisualStyleBackColor = true;
            Del1stL1Btn.Click += Del1stBtn_Click;
            // 
            // ClearBtn
            // 
            ClearBtn.Location = new Point(222, 245);
            ClearBtn.Name = "ClearBtn";
            ClearBtn.Size = new Size(75, 23);
            ClearBtn.TabIndex = 4;
            ClearBtn.Text = "Wyczyść";
            ClearBtn.UseVisualStyleBackColor = true;
            ClearBtn.Click += ClearBtn_Click;
            // 
            // MoveRightBtn
            // 
            MoveRightBtn.Location = new Point(245, 70);
            MoveRightBtn.Name = "MoveRightBtn";
            MoveRightBtn.Size = new Size(28, 23);
            MoveRightBtn.TabIndex = 5;
            MoveRightBtn.Text = "->";
            MoveRightBtn.UseVisualStyleBackColor = true;
            MoveRightBtn.Click += MoveRightBtn_Click;
            // 
            // MoveLeftBtn
            // 
            MoveLeftBtn.Location = new Point(245, 159);
            MoveLeftBtn.Name = "MoveLeftBtn";
            MoveLeftBtn.Size = new Size(28, 23);
            MoveLeftBtn.TabIndex = 6;
            MoveLeftBtn.Text = "<-";
            MoveLeftBtn.UseVisualStyleBackColor = true;
            MoveLeftBtn.Click += MoveLeftBtn_Click;
            // 
            // CountBtn
            // 
            CountBtn.Location = new Point(222, 216);
            CountBtn.Name = "CountBtn";
            CountBtn.Size = new Size(75, 23);
            CountBtn.TabIndex = 7;
            CountBtn.Text = "Policz";
            CountBtn.UseVisualStyleBackColor = true;
            CountBtn.Click += CountBtn_Click;
            // 
            // Lista2
            // 
            Lista2.FormattingEnabled = true;
            Lista2.ItemHeight = 15;
            Lista2.Location = new Point(321, 12);
            Lista2.Name = "Lista2";
            Lista2.Size = new Size(180, 199);
            Lista2.TabIndex = 8;
            // 
            // Tekst2
            // 
            Tekst2.Location = new Point(321, 217);
            Tekst2.Name = "Tekst2";
            Tekst2.Size = new Size(180, 23);
            Tekst2.TabIndex = 9;
            // 
            // AddToL2Btn
            // 
            AddToL2Btn.Location = new Point(375, 246);
            AddToL2Btn.Name = "AddToL2Btn";
            AddToL2Btn.Size = new Size(75, 23);
            AddToL2Btn.TabIndex = 10;
            AddToL2Btn.Text = "Dodaj";
            AddToL2Btn.UseVisualStyleBackColor = true;
            AddToL2Btn.Click += AddToL2Btn_Click;
            // 
            // Del1sztL2Btn
            // 
            Del1sztL2Btn.Location = new Point(351, 275);
            Del1sztL2Btn.Name = "Del1sztL2Btn";
            Del1sztL2Btn.Size = new Size(117, 23);
            Del1sztL2Btn.TabIndex = 11;
            Del1sztL2Btn.Text = "Usuń 1-szą pozycję";
            Del1sztL2Btn.UseVisualStyleBackColor = true;
            Del1sztL2Btn.Click += Del1sztL2Btn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(510, 307);
            Controls.Add(Del1sztL2Btn);
            Controls.Add(AddToL2Btn);
            Controls.Add(Tekst2);
            Controls.Add(Lista2);
            Controls.Add(CountBtn);
            Controls.Add(MoveLeftBtn);
            Controls.Add(MoveRightBtn);
            Controls.Add(ClearBtn);
            Controls.Add(Del1stL1Btn);
            Controls.Add(AddToL1Btn);
            Controls.Add(Tekst1);
            Controls.Add(Lista1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox Lista1;
        private TextBox Tekst1;
        private Button AddToL1Btn;
        private Button Del1stL1Btn;
        private Button ClearBtn;
        private Button MoveRightBtn;
        private Button MoveLeftBtn;
        private Button CountBtn;
        private ListBox Lista2;
        private TextBox Tekst2;
        private Button AddToL2Btn;
        private Button Del1sztL2Btn;
    }
}

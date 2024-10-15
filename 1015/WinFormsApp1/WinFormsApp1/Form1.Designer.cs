namespace WinFormsApp1
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtWeeek = new TextBox();
            txtDate = new TextBox();
            txtMounth = new TextBox();
            txtYear = new TextBox();
            lblShow = new Label();
            btnShowDate = new Button();
            btnClear = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label1.Location = new Point(102, 63);
            label1.Name = "label1";
            label1.Size = new Size(114, 41);
            label1.TabIndex = 0;
            label1.Text = "星期幾";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft JhengHei UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label2.Location = new Point(103, 139);
            label2.Name = "label2";
            label2.Size = new Size(82, 41);
            label2.TabIndex = 1;
            label2.Text = "日期";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft JhengHei UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label3.Location = new Point(103, 209);
            label3.Name = "label3";
            label3.Size = new Size(82, 41);
            label3.TabIndex = 2;
            label3.Text = "月份";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft JhengHei UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label4.Location = new Point(103, 279);
            label4.Name = "label4";
            label4.Size = new Size(82, 41);
            label4.TabIndex = 3;
            label4.Text = "年分";
            // 
            // txtWeeek
            // 
            txtWeeek.Font = new Font("Microsoft JhengHei UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 136);
            txtWeeek.Location = new Point(268, 63);
            txtWeeek.Name = "txtWeeek";
            txtWeeek.Size = new Size(191, 48);
            txtWeeek.TabIndex = 4;
            // 
            // txtDate
            // 
            txtDate.Font = new Font("Microsoft JhengHei UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 136);
            txtDate.Location = new Point(268, 139);
            txtDate.Name = "txtDate";
            txtDate.Size = new Size(191, 48);
            txtDate.TabIndex = 5;
            // 
            // txtMounth
            // 
            txtMounth.Font = new Font("Microsoft JhengHei UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 136);
            txtMounth.Location = new Point(268, 206);
            txtMounth.Name = "txtMounth";
            txtMounth.Size = new Size(191, 48);
            txtMounth.TabIndex = 6;
            // 
            // txtYear
            // 
            txtYear.Font = new Font("Microsoft JhengHei UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 136);
            txtYear.Location = new Point(268, 276);
            txtYear.Name = "txtYear";
            txtYear.Size = new Size(191, 48);
            txtYear.TabIndex = 7;
            // 
            // lblShow
            // 
            lblShow.BorderStyle = BorderStyle.Fixed3D;
            lblShow.Font = new Font("Microsoft JhengHei UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 136);
            lblShow.Location = new Point(12, 341);
            lblShow.Name = "lblShow";
            lblShow.Size = new Size(561, 59);
            lblShow.TabIndex = 8;
            lblShow.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnShowDate
            // 
            btnShowDate.Location = new Point(110, 440);
            btnShowDate.Name = "btnShowDate";
            btnShowDate.Size = new Size(92, 31);
            btnShowDate.TabIndex = 9;
            btnShowDate.Text = "顯示完整日期";
            btnShowDate.UseVisualStyleBackColor = true;
            btnShowDate.Click += btnShowDate_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(256, 440);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(92, 31);
            btnClear.TabIndex = 10;
            btnClear.Text = "清空內容";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(402, 440);
            button3.Name = "button3";
            button3.Size = new Size(92, 31);
            button3.TabIndex = 11;
            button3.Text = "離開";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(585, 511);
            Controls.Add(button3);
            Controls.Add(btnClear);
            Controls.Add(btnShowDate);
            Controls.Add(lblShow);
            Controls.Add(txtYear);
            Controls.Add(txtMounth);
            Controls.Add(txtDate);
            Controls.Add(txtWeeek);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtWeeek;
        private TextBox txtDate;
        private TextBox txtMounth;
        private TextBox txtYear;
        private Label lblShow;
        private Button btnShowDate;
        private Button btnClear;
        private Button button3;
    }
}

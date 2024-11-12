namespace Q1
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
            label_mas = new Label();
            text_Length = new TextBox();
            text_Width = new TextBox();
            text_cost = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label1.Location = new Point(50, 49);
            label1.Name = "label1";
            label1.Size = new Size(29, 24);
            label1.TabIndex = 0;
            label1.Text = "長";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label2.Location = new Point(50, 112);
            label2.Name = "label2";
            label2.Size = new Size(29, 24);
            label2.TabIndex = 1;
            label2.Text = "寬";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label3.Location = new Point(50, 165);
            label3.Name = "label3";
            label3.Size = new Size(86, 24);
            label3.TabIndex = 2;
            label3.Text = "單位成本";
            // 
            // label_mas
            // 
            label_mas.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label_mas.Location = new Point(50, 243);
            label_mas.Name = "label_mas";
            label_mas.Size = new Size(295, 52);
            label_mas.TabIndex = 3;
            label_mas.TextAlign = ContentAlignment.TopCenter;
            // 
            // text_Length
            // 
            text_Length.Location = new Point(245, 53);
            text_Length.Name = "text_Length";
            text_Length.Size = new Size(100, 23);
            text_Length.TabIndex = 4;
            // 
            // text_Width
            // 
            text_Width.Location = new Point(245, 103);
            text_Width.Name = "text_Width";
            text_Width.Size = new Size(100, 23);
            text_Width.TabIndex = 5;
            // 
            // text_cost
            // 
            text_cost.Location = new Point(245, 156);
            text_cost.Name = "text_cost";
            text_cost.Size = new Size(100, 23);
            text_cost.TabIndex = 6;
            // 
            // button1
            // 
            button1.Location = new Point(78, 331);
            button1.Name = "button1";
            button1.Size = new Size(96, 41);
            button1.TabIndex = 7;
            button1.Text = "田園面積";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(245, 331);
            button2.Name = "button2";
            button2.Size = new Size(96, 41);
            button2.TabIndex = 8;
            button2.Text = "田地周長";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(392, 331);
            button3.Name = "button3";
            button3.Size = new Size(96, 41);
            button3.TabIndex = 9;
            button3.Text = "田地圍欄成本";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(552, 331);
            button4.Name = "button4";
            button4.Size = new Size(96, 41);
            button4.TabIndex = 10;
            button4.Text = "離開";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(text_cost);
            Controls.Add(text_Width);
            Controls.Add(text_Length);
            Controls.Add(label_mas);
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
        private Label label_mas;
        private TextBox text_Length;
        private TextBox text_Width;
        private TextBox text_cost;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}

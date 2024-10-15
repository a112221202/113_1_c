namespace _3_2
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
            txtKm = new TextBox();
            txtLiter = new TextBox();
            lblShow = new Label();
            btnC = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label1.Location = new Point(76, 91);
            label1.Name = "label1";
            label1.Size = new Size(114, 41);
            label1.TabIndex = 0;
            label1.Text = "公里數";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft JhengHei UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label2.Location = new Point(76, 185);
            label2.Name = "label2";
            label2.Size = new Size(146, 41);
            label2.TabIndex = 1;
            label2.Text = "使用油耗";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft JhengHei UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label3.Location = new Point(45, 312);
            label3.Name = "label3";
            label3.Size = new Size(191, 41);
            label3.TabIndex = 2;
            label3.Text = "公升/每公里";
            // 
            // txtKm
            // 
            txtKm.Font = new Font("Microsoft JhengHei UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 136);
            txtKm.Location = new Point(253, 84);
            txtKm.Name = "txtKm";
            txtKm.Size = new Size(180, 48);
            txtKm.TabIndex = 3;
            // 
            // txtLiter
            // 
            txtLiter.Font = new Font("Microsoft JhengHei UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 136);
            txtLiter.Location = new Point(253, 185);
            txtLiter.Name = "txtLiter";
            txtLiter.Size = new Size(180, 48);
            txtLiter.TabIndex = 4;
            // 
            // lblShow
            // 
            lblShow.BorderStyle = BorderStyle.Fixed3D;
            lblShow.Font = new Font("Microsoft JhengHei UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 136);
            lblShow.Location = new Point(253, 297);
            lblShow.Name = "lblShow";
            lblShow.Size = new Size(190, 66);
            lblShow.TabIndex = 5;
            // 
            // btnC
            // 
            btnC.Location = new Point(91, 415);
            btnC.Name = "btnC";
            btnC.Size = new Size(111, 43);
            btnC.TabIndex = 6;
            btnC.Text = "計算";
            btnC.UseVisualStyleBackColor = true;
            btnC.Click += btnC_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(289, 415);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(114, 43);
            btnExit.TabIndex = 7;
            btnExit.Text = "離開";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(519, 572);
            Controls.Add(btnExit);
            Controls.Add(btnC);
            Controls.Add(lblShow);
            Controls.Add(txtLiter);
            Controls.Add(txtKm);
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
        private TextBox txtKm;
        private TextBox txtLiter;
        private Label lblShow;
        private Button btnC;
        private Button btnExit;
    }
}

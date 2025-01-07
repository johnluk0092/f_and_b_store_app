namespace QL_CAFE
{
    partial class fAccountProfile
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
            panel2 = new Panel();
            txbUserName = new TextBox();
            label1 = new Label();
            panel1 = new Panel();
            txbDisplayName = new TextBox();
            label2 = new Label();
            panel3 = new Panel();
            txbPassWord = new TextBox();
            label3 = new Label();
            panel4 = new Panel();
            txbNewPass = new TextBox();
            label4 = new Label();
            panel5 = new Panel();
            txbReEnterPass = new TextBox();
            label5 = new Label();
            btnUpdate = new Button();
            btnExit = new Button();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(txbUserName);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(12, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(445, 54);
            panel2.TabIndex = 1;
            // 
            // txbUserName
            // 
            txbUserName.Location = new Point(162, 16);
            txbUserName.Name = "txbUserName";
            txbUserName.ReadOnly = true;
            txbUserName.Size = new Size(262, 23);
            txbUserName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(16, 16);
            label1.Name = "label1";
            label1.Size = new Size(116, 20);
            label1.TabIndex = 0;
            label1.Text = "Tên đăng nhập:";
            // 
            // panel1
            // 
            panel1.Controls.Add(txbDisplayName);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(12, 81);
            panel1.Name = "panel1";
            panel1.Size = new Size(445, 54);
            panel1.TabIndex = 2;
            // 
            // txbDisplayName
            // 
            txbDisplayName.Location = new Point(162, 16);
            txbDisplayName.Name = "txbDisplayName";
            txbDisplayName.Size = new Size(262, 23);
            txbDisplayName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(16, 16);
            label2.Name = "label2";
            label2.Size = new Size(95, 20);
            label2.TabIndex = 0;
            label2.Text = "Tên hiển thị:";
            // 
            // panel3
            // 
            panel3.Controls.Add(txbPassWord);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(12, 150);
            panel3.Name = "panel3";
            panel3.Size = new Size(445, 54);
            panel3.TabIndex = 3;
            // 
            // txbPassWord
            // 
            txbPassWord.Location = new Point(162, 16);
            txbPassWord.Name = "txbPassWord";
            txbPassWord.Size = new Size(262, 23);
            txbPassWord.TabIndex = 1;
            txbPassWord.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(16, 16);
            label3.Name = "label3";
            label3.Size = new Size(79, 20);
            label3.TabIndex = 0;
            label3.Text = "Mật khẩu:";
            // 
            // panel4
            // 
            panel4.Controls.Add(txbNewPass);
            panel4.Controls.Add(label4);
            panel4.Location = new Point(12, 219);
            panel4.Name = "panel4";
            panel4.Size = new Size(445, 54);
            panel4.TabIndex = 4;
            // 
            // txbNewPass
            // 
            txbNewPass.Location = new Point(162, 16);
            txbNewPass.Name = "txbNewPass";
            txbNewPass.Size = new Size(262, 23);
            txbNewPass.TabIndex = 1;
            txbNewPass.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(16, 16);
            label4.Name = "label4";
            label4.Size = new Size(110, 20);
            label4.TabIndex = 0;
            label4.Text = "Mật khẩu mới:";
            // 
            // panel5
            // 
            panel5.Controls.Add(txbReEnterPass);
            panel5.Controls.Add(label5);
            panel5.Location = new Point(12, 288);
            panel5.Name = "panel5";
            panel5.Size = new Size(445, 54);
            panel5.TabIndex = 4;
            // 
            // txbReEnterPass
            // 
            txbReEnterPass.Location = new Point(162, 16);
            txbReEnterPass.Name = "txbReEnterPass";
            txbReEnterPass.Size = new Size(262, 23);
            txbReEnterPass.TabIndex = 1;
            txbReEnterPass.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(16, 16);
            label5.Name = "label5";
            label5.Size = new Size(71, 20);
            label5.TabIndex = 0;
            label5.Text = "Nhập lại:";
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.Location = new Point(241, 361);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(104, 33);
            btnUpdate.TabIndex = 5;
            btnUpdate.Text = "Cập nhật";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.Location = new Point(365, 361);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(92, 33);
            btnExit.TabIndex = 6;
            btnExit.Text = "Thoát";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // fAccountProfile
            // 
            AcceptButton = btnUpdate;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnExit;
            ClientSize = new Size(472, 409);
            Controls.Add(btnExit);
            Controls.Add(btnUpdate);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "fAccountProfile";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "THÔNG TIN CÁ NHÂN";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private TextBox txbUserName;
        private Label label1;
        private Panel panel1;
        private TextBox txbDisplayName;
        private Label label2;
        private Panel panel3;
        private TextBox txbPassWord;
        private Label label3;
        private Panel panel4;
        private TextBox txbNewPass;
        private Label label4;
        private Panel panel5;
        private TextBox txbReEnterPass;
        private Label label5;
        private Button btnUpdate;
        private Button btnExit;
    }
}
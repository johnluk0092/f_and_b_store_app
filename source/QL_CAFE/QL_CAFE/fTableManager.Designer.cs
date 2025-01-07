namespace QL_CAFE
{
    partial class fTableManager
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
            menuStrip1 = new MenuStrip();
            adminToolStripMenuItem = new ToolStripMenuItem();
            thôngTinTàiKhoảnToolStripMenuItem = new ToolStripMenuItem();
            thôngTinCáNhânToolStripMenuItem = new ToolStripMenuItem();
            đăngXuấtToolStripMenuItem = new ToolStripMenuItem();
            panel2 = new Panel();
            lsvBill = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            panel3 = new Panel();
            txbTotalPrice = new TextBox();
            cbSwitchTable = new ComboBox();
            btnSwitchTable = new Button();
            nmDiscount = new NumericUpDown();
            btnDiscount = new Button();
            btnCheck = new Button();
            panel4 = new Panel();
            nmDrinkCount = new NumericUpDown();
            btnAddDrink = new Button();
            cbDrink = new ComboBox();
            cbCategory = new ComboBox();
            flpTable = new FlowLayoutPanel();
            menuStrip1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmDiscount).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmDrinkCount).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { adminToolStripMenuItem, thôngTinTàiKhoảnToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(836, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // adminToolStripMenuItem
            // 
            adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            adminToolStripMenuItem.Size = new Size(55, 20);
            adminToolStripMenuItem.Text = "Admin";
            adminToolStripMenuItem.Click += adminToolStripMenuItem_Click;
            // 
            // thôngTinTàiKhoảnToolStripMenuItem
            // 
            thôngTinTàiKhoảnToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { thôngTinCáNhânToolStripMenuItem, đăngXuấtToolStripMenuItem });
            thôngTinTàiKhoảnToolStripMenuItem.Name = "thôngTinTàiKhoảnToolStripMenuItem";
            thôngTinTàiKhoảnToolStripMenuItem.Size = new Size(122, 20);
            thôngTinTàiKhoảnToolStripMenuItem.Text = "Thông tin tài khoản";
            // 
            // thôngTinCáNhânToolStripMenuItem
            // 
            thôngTinCáNhânToolStripMenuItem.Name = "thôngTinCáNhânToolStripMenuItem";
            thôngTinCáNhânToolStripMenuItem.Size = new Size(170, 22);
            thôngTinCáNhânToolStripMenuItem.Text = "Thông tin cá nhân";
            thôngTinCáNhânToolStripMenuItem.Click += thôngTinCáNhânToolStripMenuItem_Click;
            // 
            // đăngXuấtToolStripMenuItem
            // 
            đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            đăngXuấtToolStripMenuItem.Size = new Size(170, 22);
            đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            đăngXuấtToolStripMenuItem.Click += đăngXuấtToolStripMenuItem_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(lsvBill);
            panel2.Location = new Point(420, 117);
            panel2.Name = "panel2";
            panel2.Size = new Size(400, 282);
            panel2.TabIndex = 2;
            // 
            // lsvBill
            // 
            lsvBill.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            lsvBill.GridLines = true;
            lsvBill.Location = new Point(3, 3);
            lsvBill.Name = "lsvBill";
            lsvBill.Size = new Size(393, 276);
            lsvBill.TabIndex = 0;
            lsvBill.UseCompatibleStateImageBehavior = false;
            lsvBill.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Tên món";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Số lượng";
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Đơn giá";
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Thành tiền";
            // 
            // panel3
            // 
            panel3.Controls.Add(txbTotalPrice);
            panel3.Controls.Add(cbSwitchTable);
            panel3.Controls.Add(btnSwitchTable);
            panel3.Controls.Add(nmDiscount);
            panel3.Controls.Add(btnDiscount);
            panel3.Controls.Add(btnCheck);
            panel3.Location = new Point(420, 405);
            panel3.Name = "panel3";
            panel3.Size = new Size(400, 59);
            panel3.TabIndex = 3;
            // 
            // txbTotalPrice
            // 
            txbTotalPrice.Location = new Point(199, 31);
            txbTotalPrice.Name = "txbTotalPrice";
            txbTotalPrice.ReadOnly = true;
            txbTotalPrice.Size = new Size(115, 23);
            txbTotalPrice.TabIndex = 7;
            txbTotalPrice.Text = "0 đ";
            txbTotalPrice.TextAlign = HorizontalAlignment.Right;
            // 
            // cbSwitchTable
            // 
            cbSwitchTable.FormattingEnabled = true;
            cbSwitchTable.Location = new Point(3, 32);
            cbSwitchTable.Name = "cbSwitchTable";
            cbSwitchTable.Size = new Size(88, 23);
            cbSwitchTable.TabIndex = 4;
            // 
            // btnSwitchTable
            // 
            btnSwitchTable.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSwitchTable.Location = new Point(3, 3);
            btnSwitchTable.Name = "btnSwitchTable";
            btnSwitchTable.Size = new Size(88, 23);
            btnSwitchTable.TabIndex = 6;
            btnSwitchTable.Text = "Chuyển bàn";
            btnSwitchTable.UseVisualStyleBackColor = true;
            btnSwitchTable.Click += btnSwitchTable_Click;
            // 
            // nmDiscount
            // 
            nmDiscount.Location = new Point(97, 32);
            nmDiscount.Name = "nmDiscount";
            nmDiscount.Size = new Size(88, 23);
            nmDiscount.TabIndex = 4;
            nmDiscount.TextAlign = HorizontalAlignment.Center;
            // 
            // btnDiscount
            // 
            btnDiscount.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDiscount.Location = new Point(97, 3);
            btnDiscount.Name = "btnDiscount";
            btnDiscount.Size = new Size(88, 23);
            btnDiscount.TabIndex = 5;
            btnDiscount.Text = "Giảm giá";
            btnDiscount.UseVisualStyleBackColor = true;
            // 
            // btnCheck
            // 
            btnCheck.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCheck.Location = new Point(320, 2);
            btnCheck.Name = "btnCheck";
            btnCheck.Size = new Size(76, 53);
            btnCheck.TabIndex = 4;
            btnCheck.Text = "Thanh toán";
            btnCheck.UseVisualStyleBackColor = true;
            btnCheck.Click += btnCheck_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(nmDrinkCount);
            panel4.Controls.Add(btnAddDrink);
            panel4.Controls.Add(cbDrink);
            panel4.Controls.Add(cbCategory);
            panel4.Location = new Point(420, 52);
            panel4.Name = "panel4";
            panel4.Size = new Size(400, 59);
            panel4.TabIndex = 4;
            // 
            // nmDrinkCount
            // 
            nmDrinkCount.Location = new Point(320, 20);
            nmDrinkCount.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
            nmDrinkCount.Name = "nmDrinkCount";
            nmDrinkCount.Size = new Size(76, 23);
            nmDrinkCount.TabIndex = 3;
            nmDrinkCount.TextAlign = HorizontalAlignment.Center;
            nmDrinkCount.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnAddDrink
            // 
            btnAddDrink.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddDrink.Location = new Point(231, 3);
            btnAddDrink.Name = "btnAddDrink";
            btnAddDrink.Size = new Size(68, 53);
            btnAddDrink.TabIndex = 2;
            btnAddDrink.Text = "Thêm món";
            btnAddDrink.UseVisualStyleBackColor = true;
            btnAddDrink.Click += btnAddDrink_Click;
            // 
            // cbDrink
            // 
            cbDrink.FormattingEnabled = true;
            cbDrink.Location = new Point(3, 33);
            cbDrink.Name = "cbDrink";
            cbDrink.Size = new Size(196, 23);
            cbDrink.TabIndex = 1;
            // 
            // cbCategory
            // 
            cbCategory.FormattingEnabled = true;
            cbCategory.Location = new Point(3, 3);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(196, 23);
            cbCategory.TabIndex = 0;
            cbCategory.SelectedIndexChanged += cbCategory_SelectedIndexChanged;
            // 
            // flpTable
            // 
            flpTable.AutoScroll = true;
            flpTable.Location = new Point(8, 52);
            flpTable.Name = "flpTable";
            flpTable.Size = new Size(406, 412);
            flpTable.TabIndex = 5;
            // 
            // fTableManager
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(836, 476);
            Controls.Add(flpTable);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "fTableManager";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PHẦN MỀM QUẢN LÝ QUÁN CAFE";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nmDiscount).EndInit();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)nmDrinkCount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem adminToolStripMenuItem;
        private ToolStripMenuItem thôngTinTàiKhoảnToolStripMenuItem;
        private ToolStripMenuItem thôngTinCáNhânToolStripMenuItem;
        private ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private Panel panel2;
        private Panel panel3;
        private ListView lsvBill;
        private Panel panel4;
        private NumericUpDown nmDrinkCount;
        private Button btnAddDrink;
        private ComboBox cbDrink;
        private ComboBox cbCategory;
        private Button btnCheck;
        private FlowLayoutPanel flpTable;
        private ComboBox cbSwitchTable;
        private Button btnSwitchTable;
        private NumericUpDown nmDiscount;
        private Button btnDiscount;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private TextBox txbTotalPrice;
    }
}
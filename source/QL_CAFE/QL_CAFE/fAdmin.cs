using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using QL_CAFE.DAO;
using QL_CAFE.DTO;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace QL_CAFE
{
    public partial class fAdmin : Form
    {
        BindingSource foodList = new BindingSource();

        BindingSource accountList = new BindingSource();

        BindingSource TableList = new BindingSource();

        BindingSource FoodCList = new BindingSource();

        public Account loginAccount;
        public fAdmin()
        {
            InitializeComponent();

            //LoadFoodList();
            //LoadAccountList();
            //LoadDateTimePickerBill();
            //LoadListBillByDate(dtpkFromDate.Value, dtpkToDate.Value);
            Load();
        }

        List<Food> SearchFoodByName(string name)
        {
            List<Food> listFood = FoodDAO.Instance.SearchFoodByName(name);

            return listFood;
        }
        void Load()
        {
            dtgvDrink.DataSource = foodList;
            dtgvAccount.DataSource = accountList;
            dtgvCategory.DataSource = FoodCList;
            dtgvTable.DataSource = TableList;
            LoadDateTimePickerBill();
            LoadListBillByDate(dtpkFromDate.Value, dtpkToDate.Value);
            LoadListFood();
            AddFoodBinding();
            AddAccountBinding();
            AddFoodCBinding();
            AddTableBinding();
            LoadCategoryIntoCombobox(cbDrinkCategory);
            LoadAccount();
            LoadTable();
            LoadFoodC();
            //InitializeTableStatusComboBox();

        }
        /*
        void LoadFoodList()
        {
            string query = "SELECT * FROM food";
            dtgvDrink.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }
        void LoadAccountList()
        {
            string query = "EXEC USP_GetAccountByUserName @username;";
            dtgvAccount.DataSource = DataProvider.Instance.ExecuteQuery(query, new object[] { "staff" });

        }
        */
        #region methods
        void LoadDateTimePickerBill()
        {
            DateTime today = DateTime.Now;
            dtpkFromDate.Value = new DateTime(today.Year, today.Month, 1);
            dtpkToDate.Value = dtpkFromDate.Value.AddMonths(1).AddDays(-1);
        }
        void LoadListBillByDate(DateTime checkIn, DateTime checkOut)
        {
            dtgvBill.DataSource = BillDAO.Instance.GetBillListByDate(checkIn, checkOut);
        }

        void AddAccountBinding()
        {
            txbUserName.DataBindings.Add(new Binding("Text", dtgvAccount.DataSource, "UserName", true, DataSourceUpdateMode.Never));
            txbDislplayName.DataBindings.Add(new Binding("Text", dtgvAccount.DataSource, "DisplayName", true, DataSourceUpdateMode.Never));
            numericUpDown1.DataBindings.Add(new Binding("Text", dtgvAccount.DataSource, "Type", true, DataSourceUpdateMode.Never));
        }

        void LoadAccount()
        {
            accountList.DataSource = AccountDAO.Instance.GetListAccount();
        }

        void AddFoodCBinding()
        {
            txbCategoryID.DataBindings.Add(new Binding("Text", dtgvCategory.DataSource, "id", true, DataSourceUpdateMode.Never));
            txbCategoryName.DataBindings.Add(new Binding("Text", dtgvCategory.DataSource, "name", true, DataSourceUpdateMode.Never));
        }

        void LoadFoodC()
        {
            FoodCList.DataSource = CategoryDAO.Instance.GetFoodCategory();
        }


        void AddTableBinding()
        {
            txbTableID.DataBindings.Add(new Binding("Text", dtgvTable.DataSource, "id", true, DataSourceUpdateMode.Never));
            txbTableName.DataBindings.Add(new Binding("Text", dtgvTable.DataSource, "name", true, DataSourceUpdateMode.Never));
            txbTableStatus.DataBindings.Add(new Binding("Text", dtgvTable.DataSource, "status", true, DataSourceUpdateMode.Never));
        }

        void LoadTable()
        {
            TableList.DataSource = TableDAO.Instance.GetTable();
        }

        void AddFoodBinding()
        {
            txbDrinkName.DataBindings.Add(new Binding("Text", dtgvDrink.DataSource, "Name", true, DataSourceUpdateMode.Never));
            txbDrinkID.DataBindings.Add(new Binding("Text", dtgvDrink.DataSource, "ID", true, DataSourceUpdateMode.Never));
            nmDrinkPrice.DataBindings.Add(new Binding("Value", dtgvDrink.DataSource, "Price", true, DataSourceUpdateMode.Never));
        }

        void LoadCategoryIntoCombobox(ComboBox cb)
        {
            cb.DataSource = CategoryDAO.Instance.GetListCategory();
            cb.DisplayMember = "Name";
        }

        void LoadListFood()
        {
            foodList.DataSource = FoodDAO.Instance.GetListFood();
        }


        void AddAccount(string userName, string displayName, int type)
        {
            if (AccountDAO.Instance.InsertAccount(userName, displayName, type))
            {
                MessageBox.Show("Thêm tài khoản thành công");
            }
            else
            {
                MessageBox.Show("Thêm tài khoản thất bại");
            }

            LoadAccount();
        }

        void EditAccount(string userName, string displayName, int type)
        {
            if (AccountDAO.Instance.UpdateAccount(userName, displayName, type))
            {
                MessageBox.Show("Cập nhật tài khoản thành công");
            }
            else
            {
                MessageBox.Show("Cập nhật tài khoản thất bại");
            }

            LoadAccount();
        }

        void DeleteAccount(string userName)
        {
            if (loginAccount.UserName.Equals(userName))
            {
                MessageBox.Show("Vui lòng đừng xóa chính bạn chứ");
                return;
            }
            if (AccountDAO.Instance.DeleteAccount(userName))
            {
                MessageBox.Show("Xóa tài khoản thành công");
            }
            else
            {
                MessageBox.Show("Xóa tài khoản thất bại");
            }

            LoadAccount();
        }

        void ResetPass(string userName)
        {
            if (AccountDAO.Instance.ResetPassword(userName))
            {
                MessageBox.Show("Đặt lại mật khẩu thành công");
            }
            else
            {
                MessageBox.Show("Đặt lại mật khẩu thất bại");
            }
        }

        #endregion


        #region events
        private void btnViewBill_Click_1(object sender, EventArgs e)
        {
            LoadListBillByDate(dtpkFromDate.Value, dtpkToDate.Value);
        }

        private event EventHandler insertFood;
        public event EventHandler InsertFood
        {
            add { insertFood += value; }
            remove { insertFood -= value; }
        }

        private event EventHandler deleteFood;
        public event EventHandler DeleteFood
        {
            add { deleteFood += value; }
            remove { deleteFood -= value; }
        }

        private event EventHandler updateFood;
        public event EventHandler UpdateFood
        {
            add { updateFood += value; }
            remove { updateFood -= value; }
        }

        private void btnShowDrink_Click(object sender, EventArgs e)
        {
            LoadListFood();
        }


        private void txbDrinkID_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (dtgvDrink.SelectedCells.Count > 0)
                {
                    int id = (int)dtgvDrink.SelectedCells[0].OwningRow.Cells["CategoryID"].Value;

                    Category cateogory = CategoryDAO.Instance.GetCategoryByID(id);

                    cbDrinkCategory.SelectedItem = cateogory;

                    int index = -1;
                    int i = 0;
                    foreach (Category item in cbDrinkCategory.Items)
                    {
                        if (item.ID == cateogory.ID)
                        {
                            index = i;
                            break;
                        }
                        i++;
                    }

                    cbDrinkCategory.SelectedIndex = index;
                }
            }
            catch { }
        }

        private void btnAddDrink_Click(object sender, EventArgs e)
        {
            string name = txbDrinkName.Text;
            int categoryID = (cbDrinkCategory.SelectedItem as Category).ID;
            float price = (float)nmDrinkPrice.Value;

            if (FoodDAO.Instance.InsertFood(name, categoryID, price))
            {
                MessageBox.Show("Thêm món thành công");
                LoadListFood();
                if (insertFood != null)
                    insertFood(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Có lỗi khi thêm thức ăn");
            }

        }

        private void btnDeleteDrink_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txbDrinkID.Text);

            if (FoodDAO.Instance.DeleteFood(id))
            {
                MessageBox.Show("Xóa món thành công");
                LoadListFood();
                if (deleteFood != null)
                    deleteFood(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Có lỗi khi xóa thức ăn");
            }

        }

        private void btnEditDrink_Click(object sender, EventArgs e)
        {
            string name = txbDrinkName.Text;
            int categoryID = (cbDrinkCategory.SelectedItem as Category).ID;
            float price = (float)nmDrinkPrice.Value;
            int id = Convert.ToInt32(txbDrinkID.Text);

            if (FoodDAO.Instance.UpdateFood(id, name, categoryID, price))
            {
                MessageBox.Show("Sửa món thành công");
                LoadListFood();
                if (updateFood != null)
                    updateFood(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Có lỗi khi sửa thức ăn");
            }

        }

        private void btnSearchDrink_Click(object sender, EventArgs e)
        {
            foodList.DataSource = SearchFoodByName(txbSearchName.Text);
        }

        private void btnShowAccount_Click(object sender, EventArgs e)
        {
            LoadAccount();
        }


        private void btnAddAccount_Click(object sender, EventArgs e)
        {
            string userName = txbUserName.Text;
            string displayName = txbDislplayName.Text;
            int type = (int)numericUpDown1.Value;

            AddAccount(userName, displayName, type);

        }


        private void btnDeleteAccount_Click(object sender, EventArgs e)
        {
            string userName = txbUserName.Text;

            DeleteAccount(userName);
        }


        private void btnEditAccount_Click(object sender, EventArgs e)
        {
            string userName = txbUserName.Text;
            string displayName = txbDislplayName.Text;
            int type = (int)numericUpDown1.Value;

            EditAccount(userName, displayName, type);

        }

        private void btnResetPass_Click(object sender, EventArgs e)
        {
            string userName = txbUserName.Text;

            ResetPass(userName);
        }

        private void btnShowCategory_Click(object sender, EventArgs e)
        {
            LoadFoodC();
        }

        private void btnShowTable_Click(object sender, EventArgs e)
        {
            LoadTable();
        }

        private void btnAddTable_Click(object sender, EventArgs e)
        {
            //string id = txbTableID.Text;
            string name = txbTableName.Text;

            if (TableDAO.Instance.InsertTableName(name))
            {
                MessageBox.Show("Thêm bàn thành công");
                LoadTable();
            }
            else
            {
                MessageBox.Show("Có lỗi khi thêm bàn");
            }
        }

        /*private void InitializeTableStatusComboBox()
        {
            cbTableStatus.Items.Clear();
            cbTableStatus.Items.Add("Trống");
            cbTableStatus.Items.Add("Có người");
        }
        private void cbTableStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        */


        private void btnDeleteTable_Click(object sender, EventArgs e)
        {
            string id = txbTableID.Text;

            if (TableDAO.Instance.DeleteTableName(id))
            {
                MessageBox.Show("Xóa bàn thành công");
                LoadTable();
            }
            else
            {
                MessageBox.Show("Có lỗi khi xóa bàn");
            }
        }

        private void btnEditTable_Click(object sender, EventArgs e)
        {
            string id = txbTableID.Text;
            string name = txbTableName.Text;

            if (TableDAO.Instance.UpdateTableName(name, id))
            {
                MessageBox.Show("Sửa bàn thành công");
                LoadTable();
            }
            else
            {
                MessageBox.Show("Có lỗi khi sửa bàn");
            }
        }


        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            string name = txbCategoryName.Text;

            if (CategoryDAO.Instance.InsertCategory(name))
            {
                MessageBox.Show("Thêm danh mục thành công");
                LoadFoodC();
            }
            else
            {
                MessageBox.Show("Có lỗi khi thêm danh mục");
            }
        }

        private void btnDeleteCategory_Click(object sender, EventArgs e)
        {
            string id = txbCategoryID.Text;

            if (CategoryDAO.Instance.DeleteCategory(id))
            {
                MessageBox.Show("Xóa danh mục thành công");
                LoadFoodC();
            }
            else
            {
                MessageBox.Show("Có lỗi khi xóa danh mục");
            }
        }

        private void btnEditCategory_Click(object sender, EventArgs e)
        {
            string id = txbCategoryID.Text;
            string name = txbCategoryName.Text;

            if (CategoryDAO.Instance.UpdateCategory(name, id))
            {
                MessageBox.Show("Sửa danh mục thành công");
                LoadFoodC();
            }
            else
            {
                MessageBox.Show("Có lỗi khi sửa danh mục");
            }
        }
        #endregion
    }
}



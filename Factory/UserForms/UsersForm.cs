using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Factory.Controls;
using Factory.ObjectClasses;
using Factory.UserForms.GettersForms;

namespace Factory.UserForms
{
    public partial class UsersForm : Form
    {
        public UsersForm()
        {
            InitializeComponent();
        }

        private List<User> _users;
        private Worker _worker;

        private void bSelectWorker_Click(object sender, EventArgs e)
        {
            _worker = null;
            new GetWorker().ShowDialog();
            _worker = GetWorker.SelectedWorker;
            UpdateUsersList();
            if (_worker != null)
                tbWorkerName.Text = _worker.Name;
        }

        private void UpdateUsersList()
        {
            tbWorkerName.Text = "";
            tbLogin.Text = "";
            tbPass.Text = "";
            chbIsAdmin.Checked = false;
            try
            {
                _users = DataBaseController.GetUserList();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            lvUsers.Items.Clear();
            lvUsers.BeginUpdate();
            foreach (var shop in _users)
            {
                var lvItem = new ListViewItem();
                lvItem.Text = shop.Login;
                lvItem.SubItems.Add(shop.Name);
                lvItem.SubItems.Add(shop.IsAdmin ? "ДА" : "НЕТ");
                lvUsers.Items.Add(lvItem);
            }
            lvUsers.EndUpdate();

        }

        private void UsersForm_Load(object sender, EventArgs e)
        {
            UpdateUsersList();
        }

        private void lvUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbWorkerName.Text = "";
            tbLogin.Text = "";
            tbPass.Text = "";
            chbIsAdmin.Checked = false;
            if (lvUsers.SelectedIndices.Count == 0)
            {
                foreach (ListViewItem item in lvUsers.Items)
                {
                    item.BackColor = Color.White;
                }
                return;
            }
            tbLogin.Text = _users[lvUsers.SelectedIndices[0]].Login;
            tbWorkerName.Text = _users[lvUsers.SelectedIndices[0]].Name;
            chbIsAdmin.Checked = _users[lvUsers.SelectedIndices[0]].IsAdmin;
            foreach (ListViewItem item in lvUsers.Items)
            {
                item.BackColor = Color.White;
            }
            if (lvUsers.SelectedItems.Count > 0)
                lvUsers.SelectedItems[0].BackColor = Color.CornflowerBlue;
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            if (!MainForm.UserIsAdmin)
            {
                MessageBox.Show(@"Недостаточно прав", @"Ошибка доступа", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (lvUsers.SelectedItems.Count == 0)
            {
                MessageBox.Show(@"Пользователь не выбран", @"Ошибка выбора", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (tbLogin.TextLength == 0)
            {
                MessageBox.Show(@"Логин введен неверно", @"Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _users[lvUsers.SelectedIndices[0]].Login = tbLogin.Text;
            _users[lvUsers.SelectedIndices[0]].Pass = tbPass.TextLength == 0 ? null : tbPass.Text;
            _users[lvUsers.SelectedIndices[0]].IsAdmin = chbIsAdmin.Checked;
            try
            {
                DataBaseController.ChangeUserFields(_users[lvUsers.SelectedIndices[0]]);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            UpdateUsersList();
        }

        private void bDeleteAccount_Click(object sender, EventArgs e)
        {
            if (!MainForm.UserIsAdmin)
            {
                MessageBox.Show(@"Недостаточно прав", @"Ошибка доступа", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (lvUsers.SelectedItems.Count == 0)
            {
                MessageBox.Show(@"Пользователь не выбран", @"Ошибка выбора", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                DataBaseController.DeleteUserFromDataBase(_users[lvUsers.SelectedIndices[0]]);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            UpdateUsersList();
        }

        private void bAddUser_Click(object sender, EventArgs e)
        {
            if (!MainForm.UserIsAdmin)
            {
                MessageBox.Show(@"Недостаточно прав", @"Ошибка доступа", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (_worker == null)
            {
                MessageBox.Show(@"Сотрудник не выбран", @"Ошибка выбора", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (tbLogin.TextLength == 0 || tbPass.TextLength == 0)
            {
                MessageBox.Show(@"Данные введены неверно", @"Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var newUser = new User
            {
                Login = tbLogin.Text,
                Pass = tbPass.Text,
                IsAdmin = chbIsAdmin.Checked,
                WorkerUuid = _worker.Uuid
            };
            try
            {
                DataBaseController.AddUserToDataBase(newUser);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            _worker = null;
            UpdateUsersList();
        }
    }
}

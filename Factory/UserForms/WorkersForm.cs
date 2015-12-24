using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Factory.Controls;
using Factory.ObjectClasses;

namespace Factory.UserForms
{
    public partial class WorkersForm : Form
    {
        public WorkersForm()
        {
            InitializeComponent();
        }

        private List<Worker> _workerList;
        private List<Post> _posts;
        private List<Shop> _shops;

        private void UpdateShopList()
        {
            _shops = DataBaseController.GetShops();
            foreach (var shop in _shops)
            {
                cbShops.Items.Add(shop.Name);
            }
        }

        private void UpdateWorkerList()
        {
            tbName.Text = "";
            tbPhone.Text = "";
            cbPosts.SelectedIndex = -1;
            cbShops.SelectedIndex = -1;
            lvWorkers.Items.Clear();
            try
            {
                _workerList = DataBaseController.GetWorkerList();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            lvWorkers.BeginUpdate();
            foreach (var worker in _workerList)
            {
                var lvItem = new ListViewItem();
                lvItem.Text = worker.Name;
                lvItem.SubItems.Add(worker.Post);
                lvItem.SubItems.Add(worker.Phone);
                lvItem.SubItems.Add(worker.ShopName);
                lvWorkers.Items.Add(lvItem);
            }
            lvWorkers.EndUpdate();
        }

        private void UpdatePostList()
        {
            lvPosts.Items.Clear();
            cbPosts.Items.Clear();
            tbPostName.Text = "";
            tbPostDuty.Text = "";
            try
            {
                _posts = DataBaseController.GetPostList();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            lvPosts.BeginUpdate();
            foreach (var post in _posts)
            {
                var lvItem = new ListViewItem();
                lvItem.Text = post.Name;
                lvItem.SubItems.Add(post.Duty);
                lvPosts.Items.Add(lvItem);
                cbPosts.Items.Add(post.Name);
            }
            lvPosts.EndUpdate();
        }

        private void bDismissal_Click(object sender, EventArgs e)
        {
            if (!MainForm.UserIsAdmin)
            {
                MessageBox.Show(@"Недостаточно прав", @"Ошибка доступа", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (lvWorkers.SelectedItems.Count == 0)
            {
                MessageBox.Show(@"Сотрудник не выбран", @"Ошибка выбора", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                DataBaseController.DeleteWorkerFromDataBase(_workerList[lvWorkers.SelectedIndices[0]]);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            UpdateWorkerList();
        }

        private void WorkersForm_Load(object sender, EventArgs e)
        {
            UpdateWorkerList();
            UpdatePostList();
            UpdateShopList();
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            if (!MainForm.UserIsAdmin)
            {
                MessageBox.Show(@"Недостаточно прав", @"Ошибка доступа", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (lvWorkers.SelectedItems.Count == 0)
            {
                MessageBox.Show(@"Сотрудник не выбран", @"Ошибка выбора", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (tbName.TextLength == 0)
            {
                MessageBox.Show(@"Имя введено неверно", @"Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _workerList[lvWorkers.SelectedIndices[0]].Name = tbName.Text;
            _workerList[lvWorkers.SelectedIndices[0]].Phone = tbPhone.TextLength == 0 ? "Не указан" : tbPhone.Text;
            if (cbPosts.SelectedIndex != -1)
            {
                _workerList[lvWorkers.SelectedIndices[0]].PostUuid = _posts[cbPosts.SelectedIndex].Uuid;
            }
            if (cbShops.SelectedIndex != -1)
            {
                _workerList[lvWorkers.SelectedIndices[0]].ShopUuid = _shops[cbShops.SelectedIndex].Uuid;
            }
            try
            {
                DataBaseController.ChangeWorkerFields(_workerList[lvWorkers.SelectedIndices[0]]);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            UpdateWorkerList();
        }

        private void lvPosts_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbPostName.Text = "";
            tbPostDuty.Text = "";
            if (lvPosts.SelectedIndices.Count == 0)
            {
                foreach (ListViewItem item in lvPosts.Items)
                {
                    item.BackColor = Color.White;
                }
                return;
            }
            tbPostName.Text = _posts[lvPosts.SelectedIndices[0]].Name;
            tbPostDuty.Text = _posts[lvPosts.SelectedIndices[0]].Duty;
            foreach (ListViewItem item in lvPosts.Items)
            {
                item.BackColor = Color.White;
            }
            if (lvPosts.SelectedItems.Count > 0)
                lvPosts.SelectedItems[0].BackColor = Color.CornflowerBlue;
        }

        private void lvWorkers_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbName.Text = "";
            tbPhone.Text = "";
            cbPosts.SelectedIndex = -1;
            cbShops.SelectedIndex = -1;
            if (lvWorkers.SelectedIndices.Count == 0)
            {
                foreach (ListViewItem item in lvWorkers.Items)
                {
                    item.BackColor = Color.White;
                }
                return;
            }
            tbName.Text = _workerList[lvWorkers.SelectedIndices[0]].Name;
            tbPhone.Text = _workerList[lvWorkers.SelectedIndices[0]].Phone;
            cbPosts.SelectedIndex = _posts.FindIndex(p => p.Uuid == _workerList[lvWorkers.SelectedIndices[0]].PostUuid);
            cbShops.SelectedIndex = _shops.FindIndex(p => p.Uuid == _workerList[lvWorkers.SelectedIndices[0]].ShopUuid);
            foreach (ListViewItem item in lvWorkers.Items)
            {
                item.BackColor = Color.White;
            }
            if (lvWorkers.SelectedItems.Count > 0)
                lvWorkers.SelectedItems[0].BackColor = Color.CornflowerBlue;
        }

        private void bDeletePost_Click(object sender, EventArgs e)
        {
            if (!MainForm.UserIsAdmin)
            {
                MessageBox.Show(@"Недостаточно прав", @"Ошибка доступа", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (lvPosts.SelectedItems.Count == 0)
            {
                MessageBox.Show(@"Должность не выбрана", @"Ошибка выбора", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                DataBaseController.DeletePostFromDataBase(_posts[lvPosts.SelectedIndices[0]]);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            UpdatePostList();
        }

        private void bSavePostChange_Click(object sender, EventArgs e)
        {
            if (!MainForm.UserIsAdmin)
            {
                MessageBox.Show(@"Недостаточно прав", @"Ошибка доступа", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (lvPosts.SelectedItems.Count == 0)
            {
                MessageBox.Show(@"Должность не выбрана", @"Ошибка выбора", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (tbPostName.TextLength == 0)
            {
                MessageBox.Show(@"Название введено неверно", @"Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _posts[lvPosts.SelectedIndices[0]].Name = tbPostName.Text;
            _posts[lvPosts.SelectedIndices[0]].Duty = tbPostDuty.Text;
            try
            {
                DataBaseController.ChangePostFilds(_posts[lvPosts.SelectedIndices[0]]);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            UpdatePostList();
        }

        private void bAddWorker_Click(object sender, EventArgs e)
        {
            if (!MainForm.UserIsAdmin)
            {
                MessageBox.Show(@"Недостаточно прав", @"Ошибка доступа", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (tbName.TextLength == 0 || cbPosts.SelectedIndex == -1 || cbShops.SelectedIndex == -1)
            {
                MessageBox.Show(@"Неверные данные", @"Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var newWorker = new Worker
            {
                Name = tbName.Text,
                Phone = tbPhone.TextLength == 0 ? "Не указан" : tbPhone.Text,
                PostUuid = _posts[cbPosts.SelectedIndex].Uuid,
                ShopUuid = _shops[cbShops.SelectedIndex].Uuid
            };
            try
            {
                DataBaseController.AddWorkerToDataBase(newWorker);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            UpdateWorkerList();
        }

        private void bAddPost_Click(object sender, EventArgs e)
        {
            if (!MainForm.UserIsAdmin)
            {
                MessageBox.Show(@"Недостаточно прав", @"Ошибка доступа", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (tbPostName.TextLength == 0)
            {
                MessageBox.Show(@"Название введено неверно", @"Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                DataBaseController.AddPostToDataBase(new Post
                {
                    Name = tbPostName.Text,
                    Duty = tbPostDuty.TextLength == 0 ? "None" : tbPostDuty.Text
                });

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            UpdatePostList();
        }
    }
}

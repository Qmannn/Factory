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
    public partial class ShopsForm : Form
    {
        private List<Shop> _shops;

        public ShopsForm()
        {
            InitializeComponent();
        }

        private void ShopsForm_Load(object sender, EventArgs e)
        {
            UpdateShopList();
        }

        private void UpdateShopList()
        {
            lvShops.Items.Clear();
            try
            {
                _shops = DataBaseController.GetShops();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            lvShops.BeginUpdate();
            foreach (var shop in _shops)
            {
                var lvItem = new ListViewItem();
                lvItem.Text = shop.Name;
                lvItem.SubItems.Add(shop.Description);
                lvShops.Items.Add(lvItem);
            }
            lvShops.EndUpdate();
            tbShopName.Text = "";
            tbDescription.Text = "";
        }

        private void lvShops_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbShopName.Text = "";
            tbDescription.Text = "";
            if (lvShops.SelectedIndices.Count == 0)
            {
                foreach (ListViewItem item in lvShops.Items)
                {
                    item.BackColor = Color.White;
                }
                return;
            }
            tbShopName.Text = _shops[lvShops.SelectedIndices[0]].Name;
            tbDescription.Text = _shops[lvShops.SelectedIndices[0]].Description;
            foreach (ListViewItem item in lvShops.Items)
            {
                item.BackColor = Color.White;
            }
            if (lvShops.SelectedItems.Count > 0)
                lvShops.SelectedItems[0].BackColor = Color.CornflowerBlue;
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            if (lvShops.SelectedItems.Count == 0)
            {
                MessageBox.Show(@"Цех не выбран", @"Ошибка выбора", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (tbShopName.TextLength == 0)
            {
                MessageBox.Show(@"Имя цеха введено неверно", @"Ошибка выбора", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            _shops[lvShops.SelectedIndices[0]].Name = tbShopName.Text;
            _shops[lvShops.SelectedIndices[0]].Description = tbDescription.TextLength == 0 ? "NONE" : tbDescription.Text;
            try
            {
                DataBaseController.ChangeShopFields(_shops[lvShops.SelectedIndices[0]]);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            UpdateShopList();
        }

        private void bDeleteShop_Click(object sender, EventArgs e)
        {
            if (lvShops.SelectedItems.Count == 0)
            {
                MessageBox.Show(@"Цех не выбран", @"Ошибка выбора", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                DataBaseController.DeleteShopFromDataBase(_shops[lvShops.SelectedIndices[0]]);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            UpdateShopList();
        }

        private void bAddShop_Click(object sender, EventArgs e)
        {
            if (tbNewName.TextLength == 0)
            {
                MessageBox.Show(@"Неверное имя", @"Ошибка выбора", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var newShop = new Shop
            {
                Name = tbNewName.Text,
                Description = tbNewDescription.TextLength == 0 ? "NONE" : tbNewDescription.Text
            };
            try
            {
                DataBaseController.AddShopToShopLIst(newShop);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            UpdateShopList();
        }

    }
}

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Factory.Controls;
using Factory.ObjectClasses;

namespace Factory.UserForms.GettersForms
{
    public partial class GetNewComponent : Form
    {
        public static Product ForProduct { get; set; }
        public static Component SelectComponent { get; set; }

        private List<Component> _currentComptList;
        private List<Shop> _currentShopList; 

        public GetNewComponent()
        {
            InitializeComponent();
        }

        private void GetNewComponent_Load(object sender, EventArgs e)
        {
            if (ForProduct == null)
            {
                MessageBox.Show(@"Неизвестный продукт", @"Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
                return;
            }
            try
            {
            _currentComptList = DataBaseController.GetNewComponentsForProduct(ForProduct);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (_currentComptList.Count == 0)
            {
                MessageBox.Show(@"Нет доступных для продукта компонентов", @"Нет компонентов", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                SelectComponent = null;
                Visible = false;
                Close();
            }
            foreach (var product in _currentComptList)
            {
                var lvItem = new ListViewItem();
                lvItem.Text = product.Name;
                lvItem.SubItems.Add(product.Price);
                lvItem.SubItems.Add(product.Description);
                lvComponents.Items.Add(lvItem);
            }
            try
            {
            _currentShopList = DataBaseController.GetShops();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            foreach (var shop in _currentShopList)
            {
                var lvItem = new ListViewItem();
                lvItem.Text = shop.Name;
                lvItem.SubItems.Add(shop.Description);
                lvShops.Items.Add(lvItem);
            }
        }

        private void bDone_Click(object sender, EventArgs e)
        {
            if (lvComponents.SelectedIndices.Count == 0 || lvShops.SelectedIndices.Count == 0)
            {
                MessageBox.Show(@"Не выбран компонент или цех сборки", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _currentComptList[lvComponents.SelectedIndices[0]].ShopUuid = _currentShopList[lvShops.SelectedIndices[0]].Uuid;
            SelectComponent = _currentComptList[lvComponents.SelectedIndices[0]];
            Close();
        }

        private void lvComponents_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvComponents.SelectedIndices.Count == 0)
            {
                foreach (ListViewItem item in lvComponents.Items)
                {
                    item.BackColor = Color.White;
                }
                return;
            }
            if (lvComponents.SelectedItems.Count > 0)
                lvComponents.SelectedItems[0].BackColor = Color.CornflowerBlue;

        }

        private void lvShops_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvShops.SelectedIndices.Count == 0)
            {
                foreach (ListViewItem item in lvShops.Items)
                {
                    item.BackColor = Color.White;
                }
                return;
            }
            if (lvShops.SelectedItems.Count > 0)
                lvShops.SelectedItems[0].BackColor = Color.CornflowerBlue;
        }

    }
}

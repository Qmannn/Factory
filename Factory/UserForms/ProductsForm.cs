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
using Factory.UserForms.GettersForms;

namespace Factory.UserForms
{
    public partial class ProductsForm : Form
    {
        private List<Product> _currentProductList;
        private List<ObjectClasses.Component> _componentsList;

        public ProductsForm()
        {
            InitializeComponent();
        }

        private void ProductsForm_Load(object sender, EventArgs e)
        {
            UpdateProductList();
        }

        /// <summary>
        /// Обновление списка продуктов
        /// </summary>
        private void UpdateProductList()
        {
            lvProducts.Items.Clear();
            try
            {
                _currentProductList = DataBaseController.GetProductList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            lvProducts.BeginUpdate();
            foreach (var product in _currentProductList)
            {
                var lvItem = new ListViewItem();
                lvItem.Text = product.Name;
                lvItem.SubItems.Add(product.Price);
                lvItem.SubItems.Add(product.Description);
                lvProducts.Items.Add(lvItem);
            }
            lvProducts.EndUpdate();
        }

        private void lvProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            lvComponents.Items.Clear();
            if (lvProducts.SelectedIndices.Count == 0)
            {
                foreach (ListViewItem item in lvProducts.Items)
                {
                    item.BackColor = Color.White;
                }
                return;
            }
            try
            {
                _componentsList = DataBaseController.GetComponentList(_currentProductList[lvProducts.SelectedIndices[0]]);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            foreach (var component in _componentsList)
            {
                var lvItem = new ListViewItem();
                lvItem.Text = component.Name;
                lvItem.SubItems.Add(component.Price);
                lvItem.SubItems.Add(component.Count);
                lvItem.SubItems.Add(component.ShopName);
                lvComponents.Items.Add(lvItem);
            }
            foreach (ListViewItem item in lvProducts.Items)
            {
                item.BackColor = Color.White;
            }
            if (lvProducts.SelectedItems.Count > 0)
                lvProducts.SelectedItems[0].BackColor = Color.CornflowerBlue;
        }

        private void lvComponents_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lvComponents.Items)
            {
                item.BackColor = Color.White;
            }
            if (lvComponents.SelectedItems.Count > 0)
                lvComponents.SelectedItems[0].BackColor = Color.CornflowerBlue;
        }

        private void bRenameProduct_Click(object sender, EventArgs e)
        {
            if (lvProducts.SelectedItems.Count == 0)
            {
                MessageBox.Show(@"Продукт не выбран", @"Ошибка выбора", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            GetNewName.NewName = _currentProductList[lvProducts.SelectedIndices[0]].Name;
            new GetNewName().ShowDialog();
            _currentProductList[lvProducts.SelectedIndices[0]].Name = GetNewName.NewName;
            try
            {
                DataBaseController.ChangeProductFields(_currentProductList[lvProducts.SelectedIndices[0]]);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            UpdateProductList();
        }

        private void bAddComponent_Click(object sender, EventArgs e)
        {
            if (lvProducts.SelectedItems.Count == 0)
            {
                MessageBox.Show(@"Продукт не выбран", @"Ошибка выбора", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            GetNewComponent.ForProduct = _currentProductList[lvProducts.SelectedIndices[0]];
            new GetNewComponent().ShowDialog();
            if (GetNewComponent.SelectComponent != null)
            {
                try
                {
                    DataBaseController.AddComponentToProduct(GetNewComponent.ForProduct, GetNewComponent.SelectComponent);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, @"Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            GetNewComponent.SelectComponent = null;
            UpdateProductList();
            lvComponents.Items.Clear();
        }

        private void bChangeCompCount_Click(object sender, EventArgs e)
        {
            if (lvProducts.SelectedIndices.Count == 0)
            {
                MessageBox.Show(@"Продукт не выбран", @"Ошибка выбора", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (lvComponents.SelectedIndices.Count == 0)
            {
                MessageBox.Show(@"Компонент не выбран", @"Ошибка выбора", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int compCount;
            int.TryParse(_componentsList[lvComponents.SelectedIndices[0]].Count, out compCount);
            GetNumberForm.Value = compCount;
            new GetNumberForm().ShowDialog();
            _componentsList[lvComponents.SelectedIndices[0]].Count = GetNumberForm.Value.ToString();
            try
            {
                DataBaseController.UpdateComponentCount(_currentProductList[lvProducts.SelectedIndices[0]],
                    _componentsList[lvComponents.SelectedIndices[0]]);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            UpdateProductList();
            lvComponents.Items.Clear();
        }

        private void bDeleteComp_Click(object sender, EventArgs e)
        {
            if (lvComponents.SelectedIndices.Count == 0)
            {
                MessageBox.Show(@"Компонент не выбран", @"Ошибка выбора", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                DataBaseController.DeleteCoponentFromProduct(_currentProductList[lvProducts.SelectedIndices[0]],
                    _componentsList[lvComponents.SelectedIndices[0]]);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            UpdateProductList();
            lvComponents.Items.Clear();
        }

        private void bAddCompFromProd_Click(object sender, EventArgs e)
        {
            if (lvProducts.SelectedItems.Count == 0)
            {
                MessageBox.Show(@"Продукт не выбран", @"Ошибка выбора", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var newComponent = new ObjectClasses.Component
            {
                Name = _currentProductList[lvProducts.SelectedIndices[0]].Name,
                Price = _currentProductList[lvProducts.SelectedIndices[0]].Price,
                Description = _currentProductList[lvProducts.SelectedIndices[0]].Description
            };
            try
            {
                DataBaseController.AddComponentToComponentList(newComponent);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bAddProduct_Click(object sender, EventArgs e)
        {
            if (tbProductName.TextLength == 0)
            {
                MessageBox.Show(@"Имя продукта не введено", @"Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var newProduct = new Product
            {
                Name = tbProductName.Text,
                Description = tbDescription.TextLength == 0 ? "NONE" : tbDescription.Text
            };
            try
            {
                DataBaseController.AddProductToProductList(newProduct);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            UpdateProductList();
        }

        private void bDeleteProduct_Click(object sender, EventArgs e)
        {
            if (lvProducts.SelectedItems.Count == 0)
            {
                MessageBox.Show(@"Продукт не выбран", @"Ошибка выбора", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                DataBaseController.DeleteProduct(new Product
                {
                    Uuid = _currentProductList[lvProducts.SelectedIndices[0]].GetUuid()
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            lvComponents.Items.Clear();
            UpdateProductList();
        }
    }
}

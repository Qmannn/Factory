using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Factory.Controls;
using Factory.ObjectClasses;

namespace Factory.UserForms
{
    public partial class ComponentsForm : Form
    {
        private List<ObjectClasses.Component> _components; 

        public ComponentsForm()
        {
            InitializeComponent();
        }

        private void ComponentsForm_Load(object sender, EventArgs e)
        {
            UpdateComponentList();
        }

        private void UpdateComponentList()
        {
            lvComponents.Items.Clear();
            try
            {
            _components = DataBaseController.GetComponentList();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            lvComponents.BeginUpdate();
            foreach (var component in _components)
            {
                var lvItem = new ListViewItem();
                lvItem.Text = component.Name;
                lvItem.SubItems.Add(component.Price);
                lvItem.SubItems.Add(component.Description);
                lvComponents.Items.Add(lvItem);
            }
            lvComponents.EndUpdate();
            tbComponentName.Text = "";
            tbDescription.Text = "";
            nudPrice.Value = 0;
        }

        private void UpdateProductWitsComponentList()
        {
            lvProducts.Items.Clear();
            if (lvComponents.SelectedItems.Count == 0)
            {
                return;
            }
            List<Product> productList = new List<Product>();
            try
            {
            productList  = DataBaseController.GetProductsWithComponent(_components[lvComponents.SelectedIndices[0]]);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            lvProducts.BeginUpdate();
            foreach (var product in productList)
            {
                var lvItem = new ListViewItem();
                lvItem.Text = product.Name;
                lvItem.SubItems.Add(product.Price);
                lvItem.SubItems.Add(product.Description);
                lvProducts.Items.Add(lvItem);
            }
            lvProducts.EndUpdate();
        }

        private void lvComponents_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbComponentName.Text = "";
            tbDescription.Text = "";
            nudPrice.Value = 0;
            if (lvComponents.SelectedIndices.Count == 0)
            {
                foreach (ListViewItem item in lvComponents.Items)
                {
                    item.BackColor = Color.White;
                }
                return;
            }
            tbComponentName.Text = _components[lvComponents.SelectedIndices[0]].Name;
            tbDescription.Text = _components[lvComponents.SelectedIndices[0]].Description;
            int compPrice;
            int.TryParse(_components[lvComponents.SelectedIndices[0]].Price, out compPrice);
            nudPrice.Value = compPrice;
            UpdateProductWitsComponentList();
            foreach (ListViewItem item in lvComponents.Items)
            {
                item.BackColor = Color.White;
            }
            if (lvComponents.SelectedItems.Count > 0)
                lvComponents.SelectedItems[0].BackColor = Color.CornflowerBlue;
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            if (lvComponents.SelectedItems.Count == 0)
            {
                MessageBox.Show(@"Компонент не выбран", @"Ошибка выбора", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (tbComponentName.TextLength == 0)
            {
                MessageBox.Show(@"Имя указано неверно", @"Ошибка выбора", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _components[lvComponents.SelectedIndices[0]].Name = tbComponentName.Text;
            _components[lvComponents.SelectedIndices[0]].Description = tbDescription.TextLength == 0 ? "NONE" : tbDescription.Text;
            _components[lvComponents.SelectedIndices[0]].Price = nudPrice.Value.ToString(CultureInfo.InvariantCulture);
            try
            {
                DataBaseController.ChangeComponentFields(_components[lvComponents.SelectedIndices[0]]);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            UpdateComponentList();
            
        }

        private void bAddNewComponent_Click(object sender, EventArgs e)
        {
            if (tbNewName.TextLength == 0)
            {
                MessageBox.Show(@"Имя указано неверно", @"Ошибка выбора", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var newComponent = new ObjectClasses.Component
            {
                Name = tbNewName.Text,
                Price = nudNewPrice.Value.ToString(CultureInfo.InvariantCulture),
                Description = tbDescriptionNewComponent.TextLength == 0 ? "NONE" : tbDescriptionNewComponent.Text
            };
            try
            {
            DataBaseController.AddComponentToComponentList(newComponent);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            UpdateComponentList();
        }

        private void bDeleteComponent_Click(object sender, EventArgs e)
        {
            if (lvComponents.SelectedItems.Count == 0)
            {
                MessageBox.Show(@"Компонент не выбран", @"Ошибка выбора", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                DataBaseController.DeleteComponentFromDataBase(_components[lvComponents.SelectedIndices[0]]);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            UpdateComponentList();
        }
    }
}

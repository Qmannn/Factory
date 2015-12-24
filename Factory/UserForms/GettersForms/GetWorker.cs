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

namespace Factory.UserForms.GettersForms
{
    public partial class GetWorker : Form
    {
        private List<Worker> _workerList;
        public static Worker SelectedWorker;

        public GetWorker()
        {
            InitializeComponent();
        }

        private void UpdateWorkerList()
        {
            lvWorkers.Items.Clear();
            try
            {
                _workerList = DataBaseController.GetNotRegisterWorkerList();

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

        private void GetWorker_Load(object sender, EventArgs e)
        {
            SelectedWorker = null;
            UpdateWorkerList();
        }

        private void bSelect_Click(object sender, EventArgs e)
        {
            if (lvWorkers.SelectedItems.Count == 0)
            {
                MessageBox.Show(@"Сотрудник не выбран", @"Ошибка выбора", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            SelectedWorker = _workerList[lvWorkers.SelectedIndices[0]];
            Close();
        }
    }
}

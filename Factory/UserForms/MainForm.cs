using System;
using System.Windows.Forms;
using Factory.Controls;
using Factory.ObjectClasses;

namespace Factory.UserForms
{
    public partial class MainForm : Form
    {
        public static bool UserIsAdmin;

        public static Worker CurrentWorker { get; set; }
        public static User CurrenUser { get; set; }
        public MainForm()
        {
            InitializeComponent();
        }

        private void UpdateFactoryInfo()
        {
            var strings = DataBaseController.GetAboutFactory();
            if (strings != null)
            {
                lWorkersCount.Text = strings[0];
                lUsersCount.Text = strings[1];
                lProdCount.Text = strings[2];
                lShopsCount.Text = strings[3];
                lComponentCount.Text = strings[4];
            }
        }

        private void bProducts_Click(object sender, EventArgs e)
        {
            new ProductsForm().ShowDialog();
            UpdateFactoryInfo();
        }

        private void bComponents_Click(object sender, EventArgs e)
        {
            new ComponentsForm().ShowDialog();
            UpdateFactoryInfo();
        }

        private void bShops_Click(object sender, EventArgs e)
        {
            new ShopsForm().ShowDialog();
            UpdateFactoryInfo();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            lbUserName.Text = CurrentWorker.Name;
            lStatus.Text = UserIsAdmin ? "Администратор" : "Пользователь";
            lPost.Text = CurrentWorker.Post;
            UpdateFactoryInfo();
        }

        private void bWorkers_Click(object sender, EventArgs e)
        {
            new WorkersForm().ShowDialog();
            UpdateFactoryInfo();
        }

        private void bUsers_Click(object sender, EventArgs e)
        {
            new UsersForm().ShowDialog();
            UpdateFactoryInfo();
        }

        private void bSessions_Click(object sender, EventArgs e)
        {
            if (!UserIsAdmin)
            {
                MessageBox.Show(@"Недостаточно прав", @"Ошибка доступа", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            new SessionsForm().ShowDialog();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DataBaseController.WriteSession(CurrenUser, "Сессия закрыта");
        }
    }
}

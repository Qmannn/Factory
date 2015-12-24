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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void bLogin_Click(object sender, EventArgs e)
        {
            if (tbLogin.TextLength == 0 || tbPass.TextLength == 0)
            {
                MessageBox.Show(@"Поля не могут быть пустыми", @"Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                Program.IsAuthenticated = DataBaseController.Authentication(new User
                {
                    Login = tbLogin.Text,
                    Pass = tbPass.Text
                });
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}

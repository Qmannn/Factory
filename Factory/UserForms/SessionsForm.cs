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

namespace Factory.UserForms
{
    public partial class SessionsForm : Form
    {
        public SessionsForm()
        {
            InitializeComponent();
        }

        private void SessionsForm_Load(object sender, EventArgs e)
        {
            dgSessions.DataSource = DataBaseController.GetSessionDataSet().Tables[0];
        }
    }
}

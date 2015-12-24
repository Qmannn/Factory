using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Factory.UserForms.GettersForms
{
    public partial class GetNewName : Form
    {
        public static string NewName { get; set; }

        public static bool IsChanged { get; set; }

        public GetNewName()
        {
            InitializeComponent();
        }

        private void bApply_Click(object sender, EventArgs e)
        {
            IsChanged = false;
            NewName = tbNewName.Text;
            Close();
        }

        private void GetNewName_Load(object sender, EventArgs e)
        {
            tbNewName.Text = NewName;
            IsChanged = true;
        }
    }
}

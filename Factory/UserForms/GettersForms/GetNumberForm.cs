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
    public partial class GetNumberForm : Form
    {
        public static int Value { get; set; }
        public GetNumberForm()
        {
            InitializeComponent();
        }

        private void bApply_Click(object sender, EventArgs e)
        {
            if (nudNumber.Value < 1)
            {
                MessageBox.Show(@"Введено невенрное значение");
                return;
            }
            try
            {
                Value = (int)nudNumber.Value;
            }
            catch (Exception)
            {
                MessageBox.Show(@"Введено невенрное значение");
                return;
            }
            Close();
        }

        private void GetNumberForm_Load(object sender, EventArgs e)
        {
            nudNumber.Value = Value == 0 ? 1 : Value;
        }
    }
}

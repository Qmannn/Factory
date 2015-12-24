using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Factory.Controls;
using Factory.ObjectClasses;
using Factory.UserForms;

namespace Factory
{
    static class Program
    {
        public static bool IsAuthenticated = false;
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                DataBaseController.Connect();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                var result = MessageBox.Show(@"Подключение к базе данных не удалось. " + Environment.NewLine +
                                @"Создать шаблонный файл конфигурации DataBaseConfig.cfg?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                switch (result)
                {
                    case DialogResult.Yes:
                    {
                        DataBaseController.CreatePatternConfigFile();
                        break;
                    }
                    case DialogResult.No:
                    {
                        break;
                    }
                }

                return;
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
            if (IsAuthenticated)
            { 
                try
                {
                    DataBaseController.WriteSession(MainForm.CurrenUser);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                } 
                Application.Run(new MainForm());
            }
        }
    }
}

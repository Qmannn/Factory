namespace Factory.UserForms
{
    partial class UsersForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lvUsers = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bAddUser = new System.Windows.Forms.Button();
            this.bSave = new System.Windows.Forms.Button();
            this.bDeleteAccount = new System.Windows.Forms.Button();
            this.bSelectWorker = new System.Windows.Forms.Button();
            this.chbIsAdmin = new System.Windows.Forms.CheckBox();
            this.tbWorkerName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbPass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lvUsers);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(846, 200);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Пользователи";
            // 
            // lvUsers
            // 
            this.lvUsers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader3,
            this.columnHeader1});
            this.lvUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvUsers.FullRowSelect = true;
            this.lvUsers.GridLines = true;
            this.lvUsers.Location = new System.Drawing.Point(3, 19);
            this.lvUsers.MultiSelect = false;
            this.lvUsers.Name = "lvUsers";
            this.lvUsers.Size = new System.Drawing.Size(840, 178);
            this.lvUsers.TabIndex = 3;
            this.lvUsers.UseCompatibleStateImageBehavior = false;
            this.lvUsers.View = System.Windows.Forms.View.Details;
            this.lvUsers.SelectedIndexChanged += new System.EventHandler(this.lvUsers_SelectedIndexChanged);
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Логин";
            this.columnHeader5.Width = 307;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Имя сотрудника";
            this.columnHeader3.Width = 203;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Статус администратора";
            this.columnHeader1.Width = 150;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bAddUser);
            this.groupBox2.Controls.Add(this.bSave);
            this.groupBox2.Controls.Add(this.bDeleteAccount);
            this.groupBox2.Controls.Add(this.bSelectWorker);
            this.groupBox2.Controls.Add(this.chbIsAdmin);
            this.groupBox2.Controls.Add(this.tbWorkerName);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.tbPass);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.tbLogin);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(0, 208);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(846, 147);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Управление";
            // 
            // bAddUser
            // 
            this.bAddUser.Location = new System.Drawing.Point(436, 85);
            this.bAddUser.Name = "bAddUser";
            this.bAddUser.Size = new System.Drawing.Size(177, 44);
            this.bAddUser.TabIndex = 3;
            this.bAddUser.Text = "Зарегистрировать";
            this.bAddUser.UseVisualStyleBackColor = true;
            this.bAddUser.Click += new System.EventHandler(this.bAddUser_Click);
            // 
            // bSave
            // 
            this.bSave.Location = new System.Drawing.Point(621, 35);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(211, 44);
            this.bSave.TabIndex = 3;
            this.bSave.Text = "Сохранить изменения";
            this.bSave.UseVisualStyleBackColor = true;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // bDeleteAccount
            // 
            this.bDeleteAccount.Location = new System.Drawing.Point(621, 85);
            this.bDeleteAccount.Name = "bDeleteAccount";
            this.bDeleteAccount.Size = new System.Drawing.Size(211, 44);
            this.bDeleteAccount.TabIndex = 3;
            this.bDeleteAccount.Text = "Удалить аккаунт сотрудника";
            this.bDeleteAccount.UseVisualStyleBackColor = true;
            this.bDeleteAccount.Click += new System.EventHandler(this.bDeleteAccount_Click);
            // 
            // bSelectWorker
            // 
            this.bSelectWorker.Location = new System.Drawing.Point(17, 89);
            this.bSelectWorker.Name = "bSelectWorker";
            this.bSelectWorker.Size = new System.Drawing.Size(194, 44);
            this.bSelectWorker.TabIndex = 3;
            this.bSelectWorker.Text = "Выбрать сотрудника для регистрации";
            this.bSelectWorker.UseVisualStyleBackColor = true;
            this.bSelectWorker.Click += new System.EventHandler(this.bSelectWorker_Click);
            // 
            // chbIsAdmin
            // 
            this.chbIsAdmin.AutoSize = true;
            this.chbIsAdmin.Location = new System.Drawing.Point(219, 113);
            this.chbIsAdmin.Name = "chbIsAdmin";
            this.chbIsAdmin.Size = new System.Drawing.Size(152, 19);
            this.chbIsAdmin.TabIndex = 2;
            this.chbIsAdmin.Text = "Статус администратора";
            this.chbIsAdmin.UseVisualStyleBackColor = true;
            // 
            // tbWorkerName
            // 
            this.tbWorkerName.Location = new System.Drawing.Point(17, 37);
            this.tbWorkerName.Name = "tbWorkerName";
            this.tbWorkerName.ReadOnly = true;
            this.tbWorkerName.Size = new System.Drawing.Size(193, 23);
            this.tbWorkerName.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Имя сотрудника";
            // 
            // tbPass
            // 
            this.tbPass.Location = new System.Drawing.Point(219, 77);
            this.tbPass.Name = "tbPass";
            this.tbPass.Size = new System.Drawing.Size(209, 23);
            this.tbPass.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(216, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Новый пароль";
            // 
            // tbLogin
            // 
            this.tbLogin.Location = new System.Drawing.Point(218, 35);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(210, 23);
            this.tbLogin.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(215, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Логин";
            // 
            // UsersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(846, 355);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "UsersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Пользователи приложения";
            this.Load += new System.EventHandler(this.UsersForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView lvUsers;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chbIsAdmin;
        private System.Windows.Forms.TextBox tbWorkerName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbPass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bSave;
        private System.Windows.Forms.Button bDeleteAccount;
        private System.Windows.Forms.Button bSelectWorker;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Button bAddUser;
    }
}
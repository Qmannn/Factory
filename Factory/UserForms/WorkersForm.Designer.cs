namespace Factory.UserForms
{
    partial class WorkersForm
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
            this.lvWorkers = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.bDismissal = new System.Windows.Forms.Button();
            this.bSave = new System.Windows.Forms.Button();
            this.cbPosts = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.cbShops = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.lvPosts = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbPostName = new System.Windows.Forms.TextBox();
            this.tbPostDuty = new System.Windows.Forms.TextBox();
            this.bSavePostChange = new System.Windows.Forms.Button();
            this.bDeletePost = new System.Windows.Forms.Button();
            this.bAddWorker = new System.Windows.Forms.Button();
            this.bAddPost = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lvWorkers);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(803, 182);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Работники фабрики";
            // 
            // lvWorkers
            // 
            this.lvWorkers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader1,
            this.columnHeader2});
            this.lvWorkers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvWorkers.FullRowSelect = true;
            this.lvWorkers.GridLines = true;
            this.lvWorkers.Location = new System.Drawing.Point(3, 19);
            this.lvWorkers.MultiSelect = false;
            this.lvWorkers.Name = "lvWorkers";
            this.lvWorkers.Size = new System.Drawing.Size(797, 160);
            this.lvWorkers.TabIndex = 3;
            this.lvWorkers.UseCompatibleStateImageBehavior = false;
            this.lvWorkers.View = System.Windows.Forms.View.Details;
            this.lvWorkers.SelectedIndexChanged += new System.EventHandler(this.lvWorkers_SelectedIndexChanged);
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Имя сотрудника";
            this.columnHeader3.Width = 203;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Должность";
            this.columnHeader4.Width = 170;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Телефон";
            this.columnHeader1.Width = 184;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Цех";
            this.columnHeader2.Width = 113;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabControl1.Location = new System.Drawing.Point(0, 207);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(803, 175);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tbName);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.tbPhone);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.cbShops);
            this.tabPage1.Controls.Add(this.cbPosts);
            this.tabPage1.Controls.Add(this.bAddWorker);
            this.tabPage1.Controls.Add(this.bSave);
            this.tabPage1.Controls.Add(this.bDismissal);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(795, 147);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Личное дело сотрудника";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "* Клик по сотруднику для выбора";
            // 
            // bDismissal
            // 
            this.bDismissal.Location = new System.Drawing.Point(565, 100);
            this.bDismissal.Name = "bDismissal";
            this.bDismissal.Size = new System.Drawing.Size(218, 38);
            this.bDismissal.TabIndex = 1;
            this.bDismissal.Text = "Уволить";
            this.bDismissal.UseVisualStyleBackColor = true;
            this.bDismissal.Click += new System.EventHandler(this.bDismissal_Click);
            // 
            // bSave
            // 
            this.bSave.Location = new System.Drawing.Point(565, 54);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(218, 38);
            this.bSave.TabIndex = 1;
            this.bSave.Text = "Сохранить изменения";
            this.bSave.UseVisualStyleBackColor = true;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // cbPosts
            // 
            this.cbPosts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPosts.FormattingEnabled = true;
            this.cbPosts.Location = new System.Drawing.Point(13, 22);
            this.cbPosts.Name = "cbPosts";
            this.cbPosts.Size = new System.Drawing.Size(184, 23);
            this.cbPosts.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Должность";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(294, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Телефон";
            // 
            // tbPhone
            // 
            this.tbPhone.Location = new System.Drawing.Point(297, 73);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(206, 23);
            this.tbPhone.TabIndex = 4;
            // 
            // cbShops
            // 
            this.cbShops.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbShops.FormattingEnabled = true;
            this.cbShops.Location = new System.Drawing.Point(13, 73);
            this.cbShops.Name = "cbShops";
            this.cbShops.Size = new System.Drawing.Size(184, 23);
            this.cbShops.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Цех";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(294, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 15);
            this.label5.TabIndex = 3;
            this.label5.Text = "Имя";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(297, 23);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(206, 23);
            this.tbName.TabIndex = 4;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.bDeletePost);
            this.tabPage3.Controls.Add(this.bAddPost);
            this.tabPage3.Controls.Add(this.bSavePostChange);
            this.tabPage3.Controls.Add(this.tbPostDuty);
            this.tabPage3.Controls.Add(this.tbPostName);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.lvPosts);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(795, 149);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Список должностей";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // lvPosts
            // 
            this.lvPosts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6});
            this.lvPosts.Dock = System.Windows.Forms.DockStyle.Left;
            this.lvPosts.FullRowSelect = true;
            this.lvPosts.GridLines = true;
            this.lvPosts.Location = new System.Drawing.Point(3, 3);
            this.lvPosts.MultiSelect = false;
            this.lvPosts.Name = "lvPosts";
            this.lvPosts.ShowItemToolTips = true;
            this.lvPosts.Size = new System.Drawing.Size(384, 143);
            this.lvPosts.TabIndex = 2;
            this.lvPosts.UseCompatibleStateImageBehavior = false;
            this.lvPosts.View = System.Windows.Forms.View.Details;
            this.lvPosts.SelectedIndexChanged += new System.EventHandler(this.lvPosts_SelectedIndexChanged);
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Должность";
            this.columnHeader5.Width = 87;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Обязанности";
            this.columnHeader6.Width = 176;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(392, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 15);
            this.label6.TabIndex = 3;
            this.label6.Text = "Название";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(547, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 15);
            this.label7.TabIndex = 3;
            this.label7.Text = "Обязанности";
            // 
            // tbPostName
            // 
            this.tbPostName.Location = new System.Drawing.Point(395, 27);
            this.tbPostName.Name = "tbPostName";
            this.tbPostName.Size = new System.Drawing.Size(126, 23);
            this.tbPostName.TabIndex = 4;
            // 
            // tbPostDuty
            // 
            this.tbPostDuty.Location = new System.Drawing.Point(530, 27);
            this.tbPostDuty.Multiline = true;
            this.tbPostDuty.Name = "tbPostDuty";
            this.tbPostDuty.Size = new System.Drawing.Size(254, 59);
            this.tbPostDuty.TabIndex = 4;
            // 
            // bSavePostChange
            // 
            this.bSavePostChange.Location = new System.Drawing.Point(530, 91);
            this.bSavePostChange.Name = "bSavePostChange";
            this.bSavePostChange.Size = new System.Drawing.Size(120, 45);
            this.bSavePostChange.TabIndex = 5;
            this.bSavePostChange.Text = "Сохранить изменения";
            this.bSavePostChange.UseVisualStyleBackColor = true;
            this.bSavePostChange.Click += new System.EventHandler(this.bSavePostChange_Click);
            // 
            // bDeletePost
            // 
            this.bDeletePost.Location = new System.Drawing.Point(657, 93);
            this.bDeletePost.Name = "bDeletePost";
            this.bDeletePost.Size = new System.Drawing.Size(127, 43);
            this.bDeletePost.TabIndex = 5;
            this.bDeletePost.Text = "Удалить";
            this.bDeletePost.UseVisualStyleBackColor = true;
            this.bDeletePost.Click += new System.EventHandler(this.bDeletePost_Click);
            // 
            // bAddWorker
            // 
            this.bAddWorker.Location = new System.Drawing.Point(565, 7);
            this.bAddWorker.Name = "bAddWorker";
            this.bAddWorker.Size = new System.Drawing.Size(218, 39);
            this.bAddWorker.TabIndex = 1;
            this.bAddWorker.Text = "Принять на работу";
            this.bAddWorker.UseVisualStyleBackColor = true;
            this.bAddWorker.Click += new System.EventHandler(this.bAddWorker_Click);
            // 
            // bAddPost
            // 
            this.bAddPost.Location = new System.Drawing.Point(395, 91);
            this.bAddPost.Name = "bAddPost";
            this.bAddPost.Size = new System.Drawing.Size(127, 45);
            this.bAddPost.TabIndex = 5;
            this.bAddPost.Text = "Добавить должность";
            this.bAddPost.UseVisualStyleBackColor = true;
            this.bAddPost.Click += new System.EventHandler(this.bAddPost_Click);
            // 
            // WorkersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(803, 382);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "WorkersForm";
            this.Text = "Работники фабрики";
            this.Load += new System.EventHandler(this.WorkersForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView lvWorkers;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button bDismissal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbShops;
        private System.Windows.Forms.ComboBox cbPosts;
        private System.Windows.Forms.Button bSave;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button bDeletePost;
        private System.Windows.Forms.Button bSavePostChange;
        private System.Windows.Forms.TextBox tbPostDuty;
        private System.Windows.Forms.TextBox tbPostName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListView lvPosts;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Button bAddWorker;
        private System.Windows.Forms.Button bAddPost;
    }
}
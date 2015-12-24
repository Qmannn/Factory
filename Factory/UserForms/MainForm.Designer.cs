namespace Factory.UserForms
{
    partial class MainForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bShops = new System.Windows.Forms.Button();
            this.bComponents = new System.Windows.Forms.Button();
            this.bProducts = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bWorkers = new System.Windows.Forms.Button();
            this.bUsers = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbUserName = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lUsersCount = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lComponentCount = new System.Windows.Forms.Label();
            this.lShopsCount = new System.Windows.Forms.Label();
            this.lProdCount = new System.Windows.Forms.Label();
            this.lWorkersCount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lStatus = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lPost = new System.Windows.Forms.Label();
            this.bSessions = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bShops);
            this.groupBox1.Controls.Add(this.bComponents);
            this.groupBox1.Controls.Add(this.bProducts);
            this.groupBox1.Location = new System.Drawing.Point(271, 176);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(434, 126);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Производство";
            // 
            // bShops
            // 
            this.bShops.Location = new System.Drawing.Point(290, 22);
            this.bShops.Name = "bShops";
            this.bShops.Size = new System.Drawing.Size(136, 92);
            this.bShops.TabIndex = 0;
            this.bShops.Text = "Цеха";
            this.bShops.UseVisualStyleBackColor = true;
            this.bShops.Click += new System.EventHandler(this.bShops_Click);
            // 
            // bComponents
            // 
            this.bComponents.Location = new System.Drawing.Point(147, 22);
            this.bComponents.Name = "bComponents";
            this.bComponents.Size = new System.Drawing.Size(136, 92);
            this.bComponents.TabIndex = 0;
            this.bComponents.Text = "Компоненты";
            this.bComponents.UseVisualStyleBackColor = true;
            this.bComponents.Click += new System.EventHandler(this.bComponents_Click);
            // 
            // bProducts
            // 
            this.bProducts.Location = new System.Drawing.Point(7, 22);
            this.bProducts.Name = "bProducts";
            this.bProducts.Size = new System.Drawing.Size(133, 92);
            this.bProducts.TabIndex = 0;
            this.bProducts.Text = "Продукты";
            this.bProducts.UseVisualStyleBackColor = true;
            this.bProducts.Click += new System.EventHandler(this.bProducts_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bWorkers);
            this.groupBox2.Controls.Add(this.bUsers);
            this.groupBox2.Location = new System.Drawing.Point(19, 176);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(246, 126);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Персонал";
            // 
            // bWorkers
            // 
            this.bWorkers.Location = new System.Drawing.Point(8, 72);
            this.bWorkers.Name = "bWorkers";
            this.bWorkers.Size = new System.Drawing.Size(232, 43);
            this.bWorkers.TabIndex = 0;
            this.bWorkers.Text = "Все работники фабрики";
            this.bWorkers.UseVisualStyleBackColor = true;
            this.bWorkers.Click += new System.EventHandler(this.bWorkers_Click);
            // 
            // bUsers
            // 
            this.bUsers.Location = new System.Drawing.Point(7, 22);
            this.bUsers.Name = "bUsers";
            this.bUsers.Size = new System.Drawing.Size(232, 43);
            this.bUsers.TabIndex = 0;
            this.bUsers.Text = "Пользователи программы";
            this.bUsers.UseVisualStyleBackColor = true;
            this.bUsers.Click += new System.EventHandler(this.bUsers_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(15, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Здравствуйте, ";
            // 
            // lbUserName
            // 
            this.lbUserName.AutoSize = true;
            this.lbUserName.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbUserName.Location = new System.Drawing.Point(136, 15);
            this.lbUserName.Name = "lbUserName";
            this.lbUserName.Size = new System.Drawing.Size(172, 20);
            this.lbUserName.TabIndex = 1;
            this.lbUserName.Text = "ИМЯ ПОЛЬЗОВАТЕЛЯ";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lUsersCount);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.lComponentCount);
            this.groupBox3.Controls.Add(this.lShopsCount);
            this.groupBox3.Controls.Add(this.lProdCount);
            this.groupBox3.Controls.Add(this.lWorkersCount);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(19, 104);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(678, 66);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Информация о фабрике";
            // 
            // lUsersCount
            // 
            this.lUsersCount.AutoSize = true;
            this.lUsersCount.Location = new System.Drawing.Point(175, 34);
            this.lUsersCount.Name = "lUsersCount";
            this.lUsersCount.Size = new System.Drawing.Size(45, 15);
            this.lUsersCount.TabIndex = 1;
            this.lUsersCount.Text = "USERS";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(458, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "Компонентов всего: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(274, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 15);
            this.label7.TabIndex = 1;
            this.label7.Text = "Цехов: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(274, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 15);
            this.label6.TabIndex = 1;
            this.label6.Text = "Продуктов всего: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Пользователей программы: ";
            // 
            // lComponentCount
            // 
            this.lComponentCount.AutoSize = true;
            this.lComponentCount.Location = new System.Drawing.Point(582, 19);
            this.lComponentCount.Name = "lComponentCount";
            this.lComponentCount.Size = new System.Drawing.Size(88, 15);
            this.lComponentCount.TabIndex = 1;
            this.lComponentCount.Text = "COMPONENTS";
            // 
            // lShopsCount
            // 
            this.lShopsCount.AutoSize = true;
            this.lShopsCount.Location = new System.Drawing.Point(328, 34);
            this.lShopsCount.Name = "lShopsCount";
            this.lShopsCount.Size = new System.Drawing.Size(46, 15);
            this.lShopsCount.TabIndex = 1;
            this.lShopsCount.Text = "SHOPS";
            // 
            // lProdCount
            // 
            this.lProdCount.AutoSize = true;
            this.lProdCount.Location = new System.Drawing.Point(385, 19);
            this.lProdCount.Name = "lProdCount";
            this.lProdCount.Size = new System.Drawing.Size(67, 15);
            this.lProdCount.TabIndex = 1;
            this.lProdCount.Text = "PRODUCTS";
            // 
            // lWorkersCount
            // 
            this.lWorkersCount.AutoSize = true;
            this.lWorkersCount.Location = new System.Drawing.Point(128, 19);
            this.lWorkersCount.Name = "lWorkersCount";
            this.lWorkersCount.Size = new System.Drawing.Size(64, 15);
            this.lWorkersCount.TabIndex = 1;
            this.lWorkersCount.Text = "WORKERS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Сотрудников всего: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(16, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ваш статус: ";
            // 
            // lStatus
            // 
            this.lStatus.AutoSize = true;
            this.lStatus.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lStatus.Location = new System.Drawing.Point(118, 44);
            this.lStatus.Name = "lStatus";
            this.lStatus.Size = new System.Drawing.Size(68, 20);
            this.lStatus.TabIndex = 1;
            this.lStatus.Text = "СТАТУС";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(16, 69);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(135, 20);
            this.label9.TabIndex = 1;
            this.label9.Text = "Ваша должность: ";
            // 
            // lPost
            // 
            this.lPost.AutoSize = true;
            this.lPost.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lPost.Location = new System.Drawing.Point(150, 69);
            this.lPost.Name = "lPost";
            this.lPost.Size = new System.Drawing.Size(109, 20);
            this.lPost.TabIndex = 1;
            this.lPost.Text = "ДОЛЖНОСТЬ";
            // 
            // bSessions
            // 
            this.bSessions.Location = new System.Drawing.Point(492, 15);
            this.bSessions.Name = "bSessions";
            this.bSessions.Size = new System.Drawing.Size(196, 49);
            this.bSessions.TabIndex = 3;
            this.bSessions.Text = "Просмотреть список сессий";
            this.bSessions.UseVisualStyleBackColor = true;
            this.bSessions.Click += new System.EventHandler(this.bSessions_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(717, 312);
            this.Controls.Add(this.bSessions);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.lbUserName);
            this.Controls.Add(this.lPost);
            this.Controls.Add(this.lStatus);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.Text = "Фабрика";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbUserName;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button bComponents;
        private System.Windows.Forms.Button bProducts;
        private System.Windows.Forms.Button bWorkers;
        private System.Windows.Forms.Button bUsers;
        private System.Windows.Forms.Button bShops;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lUsersCount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lComponentCount;
        private System.Windows.Forms.Label lShopsCount;
        private System.Windows.Forms.Label lProdCount;
        private System.Windows.Forms.Label lWorkersCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lStatus;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lPost;
        private System.Windows.Forms.Button bSessions;
    }
}


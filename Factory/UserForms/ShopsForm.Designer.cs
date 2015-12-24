namespace Factory.UserForms
{
    partial class ShopsForm
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
            this.lvShops = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.bDeleteShop = new System.Windows.Forms.Button();
            this.bSave = new System.Windows.Forms.Button();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.tbShopName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.bAddShop = new System.Windows.Forms.Button();
            this.tbNewDescription = new System.Windows.Forms.TextBox();
            this.tbNewName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lvShops);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(695, 170);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Цеха фабрики";
            // 
            // lvShops
            // 
            this.lvShops.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lvShops.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvShops.FullRowSelect = true;
            this.lvShops.GridLines = true;
            this.lvShops.Location = new System.Drawing.Point(3, 19);
            this.lvShops.MultiSelect = false;
            this.lvShops.Name = "lvShops";
            this.lvShops.ShowItemToolTips = true;
            this.lvShops.Size = new System.Drawing.Size(689, 148);
            this.lvShops.TabIndex = 1;
            this.lvShops.UseCompatibleStateImageBehavior = false;
            this.lvShops.View = System.Windows.Forms.View.Details;
            this.lvShops.SelectedIndexChanged += new System.EventHandler(this.lvShops_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "НАЗВАНИЕ ЦЕХА";
            this.columnHeader1.Width = 240;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "ОПИСАНИЕ ЦЕХА";
            this.columnHeader2.Width = 234;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabControl1.Location = new System.Drawing.Point(0, 192);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(695, 204);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.bDeleteShop);
            this.tabPage1.Controls.Add(this.bSave);
            this.tabPage1.Controls.Add(this.tbDescription);
            this.tabPage1.Controls.Add(this.tbShopName);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(687, 178);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Параметры цеха";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // bDeleteShop
            // 
            this.bDeleteShop.Location = new System.Drawing.Point(499, 130);
            this.bDeleteShop.Name = "bDeleteShop";
            this.bDeleteShop.Size = new System.Drawing.Size(177, 35);
            this.bDeleteShop.TabIndex = 6;
            this.bDeleteShop.Text = "Снести цех";
            this.bDeleteShop.UseVisualStyleBackColor = true;
            this.bDeleteShop.Click += new System.EventHandler(this.bDeleteShop_Click);
            // 
            // bSave
            // 
            this.bSave.Location = new System.Drawing.Point(315, 130);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(177, 35);
            this.bSave.TabIndex = 6;
            this.bSave.Text = "Сохранить изменения";
            this.bSave.UseVisualStyleBackColor = true;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // tbDescription
            // 
            this.tbDescription.Location = new System.Drawing.Point(191, 22);
            this.tbDescription.Multiline = true;
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(485, 101);
            this.tbDescription.TabIndex = 4;
            // 
            // tbShopName
            // 
            this.tbShopName.Location = new System.Drawing.Point(9, 22);
            this.tbShopName.Name = "tbShopName";
            this.tbShopName.Size = new System.Drawing.Size(174, 23);
            this.tbShopName.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(188, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Описание цеха";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Название цеха:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.bAddShop);
            this.tabPage2.Controls.Add(this.tbNewDescription);
            this.tabPage2.Controls.Add(this.tbNewName);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(687, 176);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Добавление нового цеха";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // bAddShop
            // 
            this.bAddShop.Location = new System.Drawing.Point(499, 133);
            this.bAddShop.Name = "bAddShop";
            this.bAddShop.Size = new System.Drawing.Size(177, 35);
            this.bAddShop.TabIndex = 11;
            this.bAddShop.Text = "Добавить цех";
            this.bAddShop.UseVisualStyleBackColor = true;
            this.bAddShop.Click += new System.EventHandler(this.bAddShop_Click);
            // 
            // tbNewDescription
            // 
            this.tbNewDescription.Location = new System.Drawing.Point(191, 24);
            this.tbNewDescription.Multiline = true;
            this.tbNewDescription.Name = "tbNewDescription";
            this.tbNewDescription.Size = new System.Drawing.Size(485, 101);
            this.tbNewDescription.TabIndex = 9;
            // 
            // tbNewName
            // 
            this.tbNewName.Location = new System.Drawing.Point(9, 24);
            this.tbNewName.Name = "tbNewName";
            this.tbNewName.Size = new System.Drawing.Size(174, 23);
            this.tbNewName.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(188, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Описание цеха";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Название цеха:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "* Клик по цеху для выбора";
            // 
            // ShopsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(695, 396);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ShopsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Цеха";
            this.Load += new System.EventHandler(this.ShopsForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView lvShops;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bSave;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.TextBox tbShopName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bDeleteShop;
        private System.Windows.Forms.Button bAddShop;
        private System.Windows.Forms.TextBox tbNewDescription;
        private System.Windows.Forms.TextBox tbNewName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}
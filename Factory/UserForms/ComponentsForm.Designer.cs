namespace Factory.UserForms
{
    partial class ComponentsForm
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
            this.lvComponents = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.bDeleteComponent = new System.Windows.Forms.Button();
            this.bSave = new System.Windows.Forms.Button();
            this.nudPrice = new System.Windows.Forms.NumericUpDown();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.tbComponentName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lvProducts = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.bAddNewComponent = new System.Windows.Forms.Button();
            this.nudNewPrice = new System.Windows.Forms.NumericUpDown();
            this.tbDescriptionNewComponent = new System.Windows.Forms.TextBox();
            this.tbNewName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrice)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNewPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lvComponents);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(717, 182);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Сущствующие компоненты";
            // 
            // lvComponents
            // 
            this.lvComponents.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader1});
            this.lvComponents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvComponents.FullRowSelect = true;
            this.lvComponents.GridLines = true;
            this.lvComponents.Location = new System.Drawing.Point(3, 19);
            this.lvComponents.MultiSelect = false;
            this.lvComponents.Name = "lvComponents";
            this.lvComponents.Size = new System.Drawing.Size(711, 160);
            this.lvComponents.TabIndex = 3;
            this.lvComponents.UseCompatibleStateImageBehavior = false;
            this.lvComponents.View = System.Windows.Forms.View.Details;
            this.lvComponents.SelectedIndexChanged += new System.EventHandler(this.lvComponents_SelectedIndexChanged);
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Название компонента";
            this.columnHeader3.Width = 136;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Цена компонента";
            this.columnHeader4.Width = 116;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Описание";
            this.columnHeader1.Width = 320;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabControl1.Location = new System.Drawing.Point(0, 204);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(717, 222);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.bDeleteComponent);
            this.tabPage1.Controls.Add(this.bSave);
            this.tabPage1.Controls.Add(this.nudPrice);
            this.tabPage1.Controls.Add(this.tbDescription);
            this.tabPage1.Controls.Add(this.tbComponentName);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(709, 196);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Настройка компонента";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // bDeleteComponent
            // 
            this.bDeleteComponent.Location = new System.Drawing.Point(503, 138);
            this.bDeleteComponent.Name = "bDeleteComponent";
            this.bDeleteComponent.Size = new System.Drawing.Size(196, 44);
            this.bDeleteComponent.TabIndex = 3;
            this.bDeleteComponent.Text = "Удалить компонент";
            this.bDeleteComponent.UseVisualStyleBackColor = true;
            this.bDeleteComponent.Click += new System.EventHandler(this.bDeleteComponent_Click);
            // 
            // bSave
            // 
            this.bSave.Location = new System.Drawing.Point(300, 138);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(196, 44);
            this.bSave.TabIndex = 3;
            this.bSave.Text = "Сохранить изменения";
            this.bSave.UseVisualStyleBackColor = true;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // nudPrice
            // 
            this.nudPrice.Location = new System.Drawing.Point(16, 72);
            this.nudPrice.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.nudPrice.Name = "nudPrice";
            this.nudPrice.Size = new System.Drawing.Size(174, 23);
            this.nudPrice.TabIndex = 2;
            // 
            // tbDescription
            // 
            this.tbDescription.Location = new System.Drawing.Point(197, 27);
            this.tbDescription.Multiline = true;
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(501, 104);
            this.tbDescription.TabIndex = 1;
            // 
            // tbComponentName
            // 
            this.tbComponentName.Location = new System.Drawing.Point(16, 27);
            this.tbComponentName.Name = "tbComponentName";
            this.tbComponentName.Size = new System.Drawing.Size(173, 23);
            this.tbComponentName.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Цена";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(197, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Описание";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Название";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(709, 194);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Просмотр использующих подуктов";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lvProducts);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(703, 188);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Продукты, в производстве которых используется выбранный компонент";
            // 
            // lvProducts
            // 
            this.lvProducts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader5,
            this.columnHeader7});
            this.lvProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvProducts.FullRowSelect = true;
            this.lvProducts.GridLines = true;
            this.lvProducts.Location = new System.Drawing.Point(3, 19);
            this.lvProducts.MultiSelect = false;
            this.lvProducts.Name = "lvProducts";
            this.lvProducts.ShowItemToolTips = true;
            this.lvProducts.Size = new System.Drawing.Size(697, 166);
            this.lvProducts.TabIndex = 1;
            this.lvProducts.UseCompatibleStateImageBehavior = false;
            this.lvProducts.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "НАЗВАНИЕ ПРОДУКТА";
            this.columnHeader2.Width = 152;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "СУММАРНАЯ СТОИМОСТЬ КОМПОНЕНТ";
            this.columnHeader5.Width = 232;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "ОПИСАНИЕ";
            this.columnHeader7.Width = 184;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.bAddNewComponent);
            this.tabPage3.Controls.Add(this.nudNewPrice);
            this.tabPage3.Controls.Add(this.tbDescriptionNewComponent);
            this.tabPage3.Controls.Add(this.tbNewName);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(709, 196);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Добавление нового компонента";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // bAddNewComponent
            // 
            this.bAddNewComponent.Location = new System.Drawing.Point(500, 140);
            this.bAddNewComponent.Name = "bAddNewComponent";
            this.bAddNewComponent.Size = new System.Drawing.Size(196, 44);
            this.bAddNewComponent.TabIndex = 10;
            this.bAddNewComponent.Text = "Создать компонент";
            this.bAddNewComponent.UseVisualStyleBackColor = true;
            this.bAddNewComponent.Click += new System.EventHandler(this.bAddNewComponent_Click);
            // 
            // nudNewPrice
            // 
            this.nudNewPrice.Location = new System.Drawing.Point(14, 73);
            this.nudNewPrice.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.nudNewPrice.Name = "nudNewPrice";
            this.nudNewPrice.Size = new System.Drawing.Size(174, 23);
            this.nudNewPrice.TabIndex = 9;
            // 
            // tbDescriptionNewComponent
            // 
            this.tbDescriptionNewComponent.Location = new System.Drawing.Point(195, 28);
            this.tbDescriptionNewComponent.Multiline = true;
            this.tbDescriptionNewComponent.Name = "tbDescriptionNewComponent";
            this.tbDescriptionNewComponent.Size = new System.Drawing.Size(501, 104);
            this.tbDescriptionNewComponent.TabIndex = 7;
            // 
            // tbNewName
            // 
            this.tbNewName.Location = new System.Drawing.Point(14, 28);
            this.tbNewName.Name = "tbNewName";
            this.tbNewName.Size = new System.Drawing.Size(173, 23);
            this.tbNewName.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Цена";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(195, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Описание";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "Название";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "* Клик по компоненту для выбора";
            // 
            // ComponentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(717, 426);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ComponentsForm";
            this.Text = "Компоненты продуктов";
            this.Load += new System.EventHandler(this.ComponentsForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrice)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNewPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView lvComponents;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Button bSave;
        private System.Windows.Forms.NumericUpDown nudPrice;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.TextBox tbComponentName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bDeleteComponent;
        private System.Windows.Forms.ListView lvProducts;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.Button bAddNewComponent;
        private System.Windows.Forms.NumericUpDown nudNewPrice;
        private System.Windows.Forms.TextBox tbDescriptionNewComponent;
        private System.Windows.Forms.TextBox tbNewName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}
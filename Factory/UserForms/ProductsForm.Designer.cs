namespace Factory.UserForms
{
    partial class ProductsForm
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
            this.lvProducts = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bDeleteProduct = new System.Windows.Forms.Button();
            this.bDeleteComp = new System.Windows.Forms.Button();
            this.bRenameProduct = new System.Windows.Forms.Button();
            this.bAddCompFromProd = new System.Windows.Forms.Button();
            this.bChangeCompCount = new System.Windows.Forms.Button();
            this.bAddComponent = new System.Windows.Forms.Button();
            this.lvComponents = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.bAddProduct = new System.Windows.Forms.Button();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.tbProductName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lvProducts);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(794, 224);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Производимые продукты";
            // 
            // lvProducts
            // 
            this.lvProducts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader7});
            this.lvProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvProducts.FullRowSelect = true;
            this.lvProducts.GridLines = true;
            this.lvProducts.Location = new System.Drawing.Point(3, 19);
            this.lvProducts.MultiSelect = false;
            this.lvProducts.Name = "lvProducts";
            this.lvProducts.ShowItemToolTips = true;
            this.lvProducts.Size = new System.Drawing.Size(788, 202);
            this.lvProducts.TabIndex = 0;
            this.lvProducts.UseCompatibleStateImageBehavior = false;
            this.lvProducts.View = System.Windows.Forms.View.Details;
            this.lvProducts.SelectedIndexChanged += new System.EventHandler(this.lvProducts_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "НАЗВАНИЕ ПРОДУКТА";
            this.columnHeader1.Width = 240;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "СУММАРНАЯ СТОИМОСТЬ КОМПОНЕНТ";
            this.columnHeader2.Width = 235;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "ОПИСАНИЕ";
            this.columnHeader7.Width = 237;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabControl1.Location = new System.Drawing.Point(0, 245);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(794, 260);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.lvComponents);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(786, 232);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Компоненты выбранного продукта";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bDeleteProduct);
            this.groupBox2.Controls.Add(this.bDeleteComp);
            this.groupBox2.Controls.Add(this.bRenameProduct);
            this.groupBox2.Controls.Add(this.bAddCompFromProd);
            this.groupBox2.Controls.Add(this.bChangeCompCount);
            this.groupBox2.Controls.Add(this.bAddComponent);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox2.Location = new System.Drawing.Point(474, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(309, 226);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Управление";
            // 
            // bDeleteProduct
            // 
            this.bDeleteProduct.Location = new System.Drawing.Point(180, 70);
            this.bDeleteProduct.Name = "bDeleteProduct";
            this.bDeleteProduct.Size = new System.Drawing.Size(122, 44);
            this.bDeleteProduct.TabIndex = 9;
            this.bDeleteProduct.Text = "Удалить продукт";
            this.bDeleteProduct.UseVisualStyleBackColor = true;
            this.bDeleteProduct.Click += new System.EventHandler(this.bDeleteProduct_Click);
            // 
            // bDeleteComp
            // 
            this.bDeleteComp.Location = new System.Drawing.Point(7, 172);
            this.bDeleteComp.Name = "bDeleteComp";
            this.bDeleteComp.Size = new System.Drawing.Size(295, 44);
            this.bDeleteComp.TabIndex = 4;
            this.bDeleteComp.Text = "Не использовать выдеенный компонент при производстве";
            this.bDeleteComp.UseVisualStyleBackColor = true;
            this.bDeleteComp.Click += new System.EventHandler(this.bDeleteComp_Click);
            // 
            // bRenameProduct
            // 
            this.bRenameProduct.Location = new System.Drawing.Point(7, 22);
            this.bRenameProduct.Name = "bRenameProduct";
            this.bRenameProduct.Size = new System.Drawing.Size(166, 42);
            this.bRenameProduct.TabIndex = 5;
            this.bRenameProduct.Text = "Переименовать продукт";
            this.bRenameProduct.UseVisualStyleBackColor = true;
            this.bRenameProduct.Click += new System.EventHandler(this.bRenameProduct_Click);
            // 
            // bAddCompFromProd
            // 
            this.bAddCompFromProd.Location = new System.Drawing.Point(7, 70);
            this.bAddCompFromProd.Name = "bAddCompFromProd";
            this.bAddCompFromProd.Size = new System.Drawing.Size(166, 44);
            this.bAddCompFromProd.TabIndex = 6;
            this.bAddCompFromProd.Text = "Создать компонент на основе продукта";
            this.bAddCompFromProd.UseVisualStyleBackColor = true;
            this.bAddCompFromProd.Click += new System.EventHandler(this.bAddCompFromProd_Click);
            // 
            // bChangeCompCount
            // 
            this.bChangeCompCount.Location = new System.Drawing.Point(7, 121);
            this.bChangeCompCount.Name = "bChangeCompCount";
            this.bChangeCompCount.Size = new System.Drawing.Size(295, 44);
            this.bChangeCompCount.TabIndex = 7;
            this.bChangeCompCount.Text = "Изменить количество выделенных компонентов в продукте";
            this.bChangeCompCount.UseVisualStyleBackColor = true;
            this.bChangeCompCount.Click += new System.EventHandler(this.bChangeCompCount_Click);
            // 
            // bAddComponent
            // 
            this.bAddComponent.Location = new System.Drawing.Point(177, 22);
            this.bAddComponent.Name = "bAddComponent";
            this.bAddComponent.Size = new System.Drawing.Size(126, 42);
            this.bAddComponent.TabIndex = 8;
            this.bAddComponent.Text = "Добавить компонент";
            this.bAddComponent.UseVisualStyleBackColor = true;
            this.bAddComponent.Click += new System.EventHandler(this.bAddComponent_Click);
            // 
            // lvComponents
            // 
            this.lvComponents.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lvComponents.Dock = System.Windows.Forms.DockStyle.Left;
            this.lvComponents.FullRowSelect = true;
            this.lvComponents.GridLines = true;
            this.lvComponents.Location = new System.Drawing.Point(3, 3);
            this.lvComponents.MultiSelect = false;
            this.lvComponents.Name = "lvComponents";
            this.lvComponents.Size = new System.Drawing.Size(472, 226);
            this.lvComponents.TabIndex = 2;
            this.lvComponents.UseCompatibleStateImageBehavior = false;
            this.lvComponents.View = System.Windows.Forms.View.Details;
            this.lvComponents.SelectedIndexChanged += new System.EventHandler(this.lvComponents_SelectedIndexChanged);
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Название компонента";
            this.columnHeader3.Width = 130;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Цена компонента";
            this.columnHeader4.Width = 112;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Количетство компонентов в продукте";
            this.columnHeader5.Width = 134;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Цех установки";
            this.columnHeader6.Width = 122;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.bAddProduct);
            this.tabPage2.Controls.Add(this.tbDescription);
            this.tabPage2.Controls.Add(this.tbProductName);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(786, 232);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Добавление нового продукта";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // bAddProduct
            // 
            this.bAddProduct.Location = new System.Drawing.Point(565, 183);
            this.bAddProduct.Name = "bAddProduct";
            this.bAddProduct.Size = new System.Drawing.Size(211, 37);
            this.bAddProduct.TabIndex = 2;
            this.bAddProduct.Text = "Добавить";
            this.bAddProduct.UseVisualStyleBackColor = true;
            this.bAddProduct.Click += new System.EventHandler(this.bAddProduct_Click);
            // 
            // tbDescription
            // 
            this.tbDescription.Location = new System.Drawing.Point(234, 53);
            this.tbDescription.Multiline = true;
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(541, 106);
            this.tbDescription.TabIndex = 1;
            // 
            // tbProductName
            // 
            this.tbProductName.Location = new System.Drawing.Point(13, 53);
            this.tbProductName.Name = "tbProductName";
            this.tbProductName.Size = new System.Drawing.Size(210, 23);
            this.tbProductName.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(231, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Описание продукта";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Имя нового продукта:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 227);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "* Клик по продукту для просмотра его компонент";
            // 
            // ProductsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(794, 505);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "ProductsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Продукты";
            this.Load += new System.EventHandler(this.ProductsForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListView lvProducts;
        private System.Windows.Forms.ListView lvComponents;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Button bAddProduct;
        private System.Windows.Forms.TextBox tbProductName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button bDeleteProduct;
        private System.Windows.Forms.Button bDeleteComp;
        private System.Windows.Forms.Button bRenameProduct;
        private System.Windows.Forms.Button bAddCompFromProd;
        private System.Windows.Forms.Button bChangeCompCount;
        private System.Windows.Forms.Button bAddComponent;
    }
}
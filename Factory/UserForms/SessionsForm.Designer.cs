namespace Factory.UserForms
{
    partial class SessionsForm
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
            this.dgSessions = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgSessions)).BeginInit();
            this.SuspendLayout();
            // 
            // dgSessions
            // 
            this.dgSessions.AllowUserToAddRows = false;
            this.dgSessions.AllowUserToDeleteRows = false;
            this.dgSessions.AllowUserToOrderColumns = true;
            this.dgSessions.BackgroundColor = System.Drawing.Color.White;
            this.dgSessions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSessions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgSessions.Location = new System.Drawing.Point(0, 0);
            this.dgSessions.Name = "dgSessions";
            this.dgSessions.ReadOnly = true;
            this.dgSessions.Size = new System.Drawing.Size(622, 300);
            this.dgSessions.TabIndex = 2;
            // 
            // SessionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 300);
            this.Controls.Add(this.dgSessions);
            this.Name = "SessionsForm";
            this.Text = "Просмотр пользовательских сессий";
            this.Load += new System.EventHandler(this.SessionsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgSessions)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgSessions;
    }
}
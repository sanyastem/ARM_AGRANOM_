namespace ARM_AGRANOM_
{
    partial class MainWindow
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
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.главноеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAdmin = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // Menu
            // 
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.главноеToolStripMenuItem,
            this.btnAdmin});
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(825, 24);
            this.Menu.TabIndex = 0;
            this.Menu.Text = "menuStrip1";
            // 
            // главноеToolStripMenuItem
            // 
            this.главноеToolStripMenuItem.Name = "главноеToolStripMenuItem";
            this.главноеToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.главноеToolStripMenuItem.Text = "Главное";
            // 
            // btnAdmin
            // 
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(106, 20);
            this.btnAdmin.Text = "Администратор";
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(825, 481);
            this.Controls.Add(this.Menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.Menu;
            this.Name = "MainWindow";
            this.Text = "Главное окно";
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem главноеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnAdmin;
    }
}


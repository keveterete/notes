namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));

            this.listWithFiles = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ССreate = new System.Windows.Forms.ToolStripMenuItem();
            this.Delete = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewFile = new System.Windows.Forms.ToolStripMenuItem();
            this.setting = new System.Windows.Forms.ToolStripMenuItem();
            this.Sorting = new System.Windows.Forms.Button();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.поДатеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // listWithFiles
            // 
            this.listWithFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listWithFiles.ContextMenuStrip = this.contextMenuStrip1;
            this.listWithFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listWithFiles.FormattingEnabled = true;
            this.listWithFiles.ItemHeight = 22;
            this.listWithFiles.Location = new System.Drawing.Point(0, 49);
            this.listWithFiles.Margin = new System.Windows.Forms.Padding(2);
            this.listWithFiles.Name = "listWithFiles";
            this.listWithFiles.Size = new System.Drawing.Size(762, 422);
            this.listWithFiles.TabIndex = 4;
            this.listWithFiles.DoubleClick += new System.EventHandler(this.openfile_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ССreate,
            this.Delete});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(165, 48);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // ССreate
            // 
            this.ССreate.Name = "ССreate";
            this.ССreate.Size = new System.Drawing.Size(164, 22);
            this.ССreate.Text = "Создать заметку";
            this.ССreate.Click += new System.EventHandler(this.button1_Click);
            // 
            // Delete
            // 
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(164, 22);
            this.Delete.Text = "Удалить заметку";
            this.Delete.Click += new System.EventHandler(this.delet_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu,
            this.setting});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(762, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Menu
            // 
            this.Menu.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewFile});
            this.Menu.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Menu.ImageTransparentColor = System.Drawing.Color.White;
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(48, 20);
            this.Menu.Text = "Файл";
            // 
            // addNewFile
            // 
            this.addNewFile.Name = "addNewFile";
            this.addNewFile.Size = new System.Drawing.Size(163, 22);
            this.addNewFile.Text = "Создать заметку";
            this.addNewFile.Click += new System.EventHandler(this.button1_Click);
            // 
            // setting
            // 
            this.setting.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.setting.Name = "setting";
            this.setting.Size = new System.Drawing.Size(79, 20);
            this.setting.Text = "Настройки";
            // 
            // Sorting
            // 
            this.Sorting.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Sorting.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Sorting.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Sorting.ForeColor = System.Drawing.Color.Black;
            this.Sorting.Location = new System.Drawing.Point(662, 24);
            this.Sorting.MaximumSize = new System.Drawing.Size(50, 100);
            this.Sorting.MinimumSize = new System.Drawing.Size(100, 10);
            this.Sorting.Name = "Sorting";
            this.Sorting.Size = new System.Drawing.Size(100, 25);
            this.Sorting.TabIndex = 6;
            this.Sorting.Text = "Сортировка";
            this.Sorting.UseVisualStyleBackColor = true;
            this.Sorting.Click += new System.EventHandler(this.Sort);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поДатеToolStripMenuItem,
            this.поToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(181, 70);
            // 
            // поДатеToolStripMenuItem
            // 
            this.поДатеToolStripMenuItem.Name = "поДатеToolStripMenuItem";
            this.поДатеToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.поДатеToolStripMenuItem.Text = "По дате";
            // 
            // поToolStripMenuItem
            // 
            this.поToolStripMenuItem.Name = "поToolStripMenuItem";
            this.поToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.поToolStripMenuItem.Text = "По имени";

            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(762, 488);
            this.Controls.Add(this.Sorting);
            this.Controls.Add(this.listWithFiles);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.DarkRed;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Note";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        private System.Windows.Forms.ListBox listWithFiles;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private new System.Windows.Forms.ToolStripMenuItem Menu; // Тут предупреждение, я не понимаю его
        private System.Windows.Forms.ToolStripMenuItem addNewFile;
        private System.Windows.Forms.ToolStripMenuItem setting;
        private System.Windows.Forms.Button Sorting;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ССreate;
        private System.Windows.Forms.ToolStripMenuItem Delete;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem поДатеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поToolStripMenuItem;

    }
}
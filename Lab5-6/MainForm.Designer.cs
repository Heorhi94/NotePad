namespace Lab5_6
{
    partial class mainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param path="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
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
            this.tWay = new System.Windows.Forms.TextBox();
            this.tFileText = new System.Windows.Forms.TextBox();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.fIleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.readToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.decoratorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.compressionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.encryptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.bOpen = new System.Windows.Forms.Button();
            this.decompressionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.decryptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // tWay
            // 
            this.tWay.Location = new System.Drawing.Point(48, 43);
            this.tWay.Name = "tWay";
            this.tWay.Size = new System.Drawing.Size(371, 22);
            this.tWay.TabIndex = 1;
            this.tWay.TextChanged += new System.EventHandler(this.tWay_TextChanged);
            // 
            // tFileText
            // 
            this.tFileText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tFileText.Location = new System.Drawing.Point(12, 79);
            this.tFileText.Multiline = true;
            this.tFileText.Name = "tFileText";
            this.tFileText.Size = new System.Drawing.Size(488, 262);
            this.tFileText.TabIndex = 1;
            // 
            // menu
            // 
            this.menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fIleToolStripMenuItem,
            this.decoratorsToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(512, 28);
            this.menu.TabIndex = 11;
            // 
            // fIleToolStripMenuItem
            // 
            this.fIleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.readToolStripMenuItem,
            this.saveToolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.fIleToolStripMenuItem.Name = "fIleToolStripMenuItem";
            this.fIleToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fIleToolStripMenuItem.Text = "FIle";
            // 
            // readToolStripMenuItem
            // 
            this.readToolStripMenuItem.Name = "readToolStripMenuItem";
            this.readToolStripMenuItem.Size = new System.Drawing.Size(126, 26);
            this.readToolStripMenuItem.Text = "Read";
            this.readToolStripMenuItem.Click += new System.EventHandler(this.readToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem1
            // 
            this.saveToolStripMenuItem1.Name = "saveToolStripMenuItem1";
            this.saveToolStripMenuItem1.Size = new System.Drawing.Size(126, 26);
            this.saveToolStripMenuItem1.Text = "Save";
            this.saveToolStripMenuItem1.Click += new System.EventHandler(this.saveToolStripMenuItem1_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(126, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // decoratorsToolStripMenuItem
            // 
            this.decoratorsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.compressionToolStripMenuItem,
            this.encryptToolStripMenuItem,
            this.decompressionToolStripMenuItem,
            this.decryptToolStripMenuItem});
            this.decoratorsToolStripMenuItem.Name = "decoratorsToolStripMenuItem";
            this.decoratorsToolStripMenuItem.Size = new System.Drawing.Size(96, 24);
            this.decoratorsToolStripMenuItem.Text = "Decorators";
            // 
            // compressionToolStripMenuItem
            // 
            this.compressionToolStripMenuItem.Name = "compressionToolStripMenuItem";
            this.compressionToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.compressionToolStripMenuItem.Text = "Compression";
            this.compressionToolStripMenuItem.Click += new System.EventHandler(this.compressionToolStripMenuItem_Click);
            // 
            // encryptToolStripMenuItem
            // 
            this.encryptToolStripMenuItem.Name = "encryptToolStripMenuItem";
            this.encryptToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.encryptToolStripMenuItem.Text = "Encrypt";
            this.encryptToolStripMenuItem.Click += new System.EventHandler(this.encryptToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(-1, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Path";
            // 
            // bOpen
            // 
            this.bOpen.Location = new System.Drawing.Point(425, 39);
            this.bOpen.Name = "bOpen";
            this.bOpen.Size = new System.Drawing.Size(75, 30);
            this.bOpen.TabIndex = 13;
            this.bOpen.Text = "Open";
            this.bOpen.UseVisualStyleBackColor = true;
            this.bOpen.Click += new System.EventHandler(this.bOpen_Click_1);
            // 
            // decompressionToolStripMenuItem
            // 
            this.decompressionToolStripMenuItem.Name = "decompressionToolStripMenuItem";
            this.decompressionToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.decompressionToolStripMenuItem.Text = "Decompression";
            this.decompressionToolStripMenuItem.Click += new System.EventHandler(this.decompressionToolStripMenuItem_Click);
            // 
            // decryptToolStripMenuItem
            // 
            this.decryptToolStripMenuItem.Name = "decryptToolStripMenuItem";
            this.decryptToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.decryptToolStripMenuItem.Text = "Decrypt";
            this.decryptToolStripMenuItem.Click += new System.EventHandler(this.decryptToolStripMenuItem_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(512, 353);
            this.Controls.Add(this.bOpen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tFileText);
            this.Controls.Add(this.tWay);
            this.Controls.Add(this.menu);
            this.MainMenuStrip = this.menu;
            this.MaximumSize = new System.Drawing.Size(530, 400);
            this.MinimumSize = new System.Drawing.Size(530, 400);
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lab5";
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tFileText;
        public System.Windows.Forms.TextBox tWay;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem fIleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem decoratorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem compressionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem encryptToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem readToolStripMenuItem;
        private System.Windows.Forms.Button bOpen;
        private System.Windows.Forms.ToolStripMenuItem decompressionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem decryptToolStripMenuItem;
    }
}


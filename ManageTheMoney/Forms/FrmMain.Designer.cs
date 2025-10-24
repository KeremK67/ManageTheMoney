namespace ManageTheMoney
{
    partial class FrmMain
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.MsMenus = new System.Windows.Forms.MenuStrip();
            this.TsmiMainMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiScenarios = new System.Windows.Forms.ToolStripMenuItem();
            this.PnlContent = new System.Windows.Forms.Panel();
            this.MsMenus.SuspendLayout();
            this.SuspendLayout();
            // 
            // MsMenus
            // 
            this.MsMenus.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.MsMenus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsmiMainMenu,
            this.TsmiScenarios});
            this.MsMenus.Location = new System.Drawing.Point(0, 0);
            this.MsMenus.Name = "MsMenus";
            this.MsMenus.Size = new System.Drawing.Size(1584, 24);
            this.MsMenus.TabIndex = 0;
            this.MsMenus.Text = "menuStrip1";
            // 
            // TsmiMainMenu
            // 
            this.TsmiMainMenu.Name = "TsmiMainMenu";
            this.TsmiMainMenu.Size = new System.Drawing.Size(74, 20);
            this.TsmiMainMenu.Text = "Ana Menü";
            this.TsmiMainMenu.Click += new System.EventHandler(this.TsmiMainMenu_Click);
            // 
            // TsmiScenarios
            // 
            this.TsmiScenarios.Name = "TsmiScenarios";
            this.TsmiScenarios.Size = new System.Drawing.Size(74, 20);
            this.TsmiScenarios.Text = "Senaryolar";
            this.TsmiScenarios.Click += new System.EventHandler(this.TsmiScenarios_Click);
            // 
            // PnlContent
            // 
            this.PnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlContent.Location = new System.Drawing.Point(0, 24);
            this.PnlContent.Name = "PnlContent";
            this.PnlContent.Size = new System.Drawing.Size(1584, 837);
            this.PnlContent.TabIndex = 1;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1584, 861);
            this.Controls.Add(this.PnlContent);
            this.Controls.Add(this.MsMenus);
            this.MainMenuStrip = this.MsMenus;
            this.Name = "FrmMain";
            this.Text = "Paranı Yönet";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.Resize += new System.EventHandler(this.FrmMain_Resize);
            this.MsMenus.ResumeLayout(false);
            this.MsMenus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MsMenus;
        private System.Windows.Forms.ToolStripMenuItem TsmiMainMenu;
        private System.Windows.Forms.ToolStripMenuItem TsmiScenarios;
        private System.Windows.Forms.Panel PnlContent;
    }
}


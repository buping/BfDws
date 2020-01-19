namespace BfDwsForm
{
    partial class DwsForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemCameraCfg = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemVolCfg = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemWeightCfg = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStripMain = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelCamera = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelVol = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelWeight = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStripMain.SuspendLayout();
            this.statusStripMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripMain
            // 
            this.menuStripMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.设置ToolStripMenuItem,
            this.帮助ToolStripMenuItem});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(1343, 28);
            this.menuStripMain.TabIndex = 0;
            this.menuStripMain.Text = "menuStrip1";
            // 
            // 设置ToolStripMenuItem
            // 
            this.设置ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemCameraCfg,
            this.ToolStripMenuItemVolCfg,
            this.ToolStripMenuItemWeightCfg});
            this.设置ToolStripMenuItem.Name = "设置ToolStripMenuItem";
            this.设置ToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.设置ToolStripMenuItem.Text = "设置";
            // 
            // ToolStripMenuItemCameraCfg
            // 
            this.ToolStripMenuItemCameraCfg.Name = "ToolStripMenuItemCameraCfg";
            this.ToolStripMenuItemCameraCfg.Size = new System.Drawing.Size(224, 26);
            this.ToolStripMenuItemCameraCfg.Text = "读码相机";
            this.ToolStripMenuItemCameraCfg.Click += new System.EventHandler(this.ToolStripMenuItemCameraCfg_Click);
            // 
            // ToolStripMenuItemVolCfg
            // 
            this.ToolStripMenuItemVolCfg.Name = "ToolStripMenuItemVolCfg";
            this.ToolStripMenuItemVolCfg.Size = new System.Drawing.Size(224, 26);
            this.ToolStripMenuItemVolCfg.Text = "体积相机";
            // 
            // ToolStripMenuItemWeightCfg
            // 
            this.ToolStripMenuItemWeightCfg.Name = "ToolStripMenuItemWeightCfg";
            this.ToolStripMenuItemWeightCfg.Size = new System.Drawing.Size(224, 26);
            this.ToolStripMenuItemWeightCfg.Text = "重量秤";
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemAbout});
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.帮助ToolStripMenuItem.Text = "帮助";
            // 
            // ToolStripMenuItemAbout
            // 
            this.ToolStripMenuItemAbout.Name = "ToolStripMenuItemAbout";
            this.ToolStripMenuItemAbout.Size = new System.Drawing.Size(224, 26);
            this.ToolStripMenuItemAbout.Text = "关于";
            // 
            // statusStripMain
            // 
            this.statusStripMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelCamera,
            this.toolStripStatusLabelVol,
            this.toolStripStatusLabelWeight});
            this.statusStripMain.Location = new System.Drawing.Point(0, 661);
            this.statusStripMain.Name = "statusStripMain";
            this.statusStripMain.Size = new System.Drawing.Size(1343, 26);
            this.statusStripMain.TabIndex = 1;
            this.statusStripMain.Text = "statusStrip1";
            // 
            // toolStripStatusLabelCamera
            // 
            this.toolStripStatusLabelCamera.Name = "toolStripStatusLabelCamera";
            this.toolStripStatusLabelCamera.Size = new System.Drawing.Size(114, 20);
            this.toolStripStatusLabelCamera.Text = "读码相机状态：";
            // 
            // toolStripStatusLabelVol
            // 
            this.toolStripStatusLabelVol.Name = "toolStripStatusLabelVol";
            this.toolStripStatusLabelVol.Size = new System.Drawing.Size(114, 20);
            this.toolStripStatusLabelVol.Text = "体积相机状态：";
            // 
            // toolStripStatusLabelWeight
            // 
            this.toolStripStatusLabelWeight.Name = "toolStripStatusLabelWeight";
            this.toolStripStatusLabelWeight.Size = new System.Drawing.Size(84, 20);
            this.toolStripStatusLabelWeight.Text = "重量秤状态";
            // 
            // DwsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1343, 687);
            this.Controls.Add(this.statusStripMain);
            this.Controls.Add(this.menuStripMain);
            this.MainMenuStrip = this.menuStripMain;
            this.Name = "DwsForm";
            this.Text = "体积称重一体平台";
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.statusStripMain.ResumeLayout(false);
            this.statusStripMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem 设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemCameraCfg;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemVolCfg;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemWeightCfg;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemAbout;
        private System.Windows.Forms.StatusStrip statusStripMain;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelCamera;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelVol;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelWeight;
    }
}


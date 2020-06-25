namespace YKT.RubberTraceSystem.Windows
{
    partial class MainForm
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
            this.msMain = new System.Windows.Forms.MenuStrip();
            this.生产过程ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.胶料出片ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帘布剪裁ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.工件成型ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.仓库ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.胶料入库ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帘布入库ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.报表ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.生产报表ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.基础资料ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // msMain
            // 
            this.msMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.生产过程ToolStripMenuItem,
            this.仓库ToolStripMenuItem,
            this.报表ToolStripMenuItem,
            this.基础资料ToolStripMenuItem,
            this.关于ToolStripMenuItem});
            this.msMain.Location = new System.Drawing.Point(0, 0);
            this.msMain.Name = "msMain";
            this.msMain.Size = new System.Drawing.Size(800, 24);
            this.msMain.TabIndex = 1;
            this.msMain.Text = "menuStrip1";
            // 
            // 生产过程ToolStripMenuItem
            // 
            this.生产过程ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.胶料出片ToolStripMenuItem,
            this.帘布剪裁ToolStripMenuItem,
            this.工件成型ToolStripMenuItem});
            this.生产过程ToolStripMenuItem.Name = "生产过程ToolStripMenuItem";
            this.生产过程ToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.生产过程ToolStripMenuItem.Text = "生产过程";
            // 
            // 胶料出片ToolStripMenuItem
            // 
            this.胶料出片ToolStripMenuItem.Name = "胶料出片ToolStripMenuItem";
            this.胶料出片ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.胶料出片ToolStripMenuItem.Text = "胶料出片";
            this.胶料出片ToolStripMenuItem.Click += new System.EventHandler(this.胶料出片ToolStripMenuItem_Click);
            // 
            // 帘布剪裁ToolStripMenuItem
            // 
            this.帘布剪裁ToolStripMenuItem.Name = "帘布剪裁ToolStripMenuItem";
            this.帘布剪裁ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.帘布剪裁ToolStripMenuItem.Text = "帘布剪裁";
            this.帘布剪裁ToolStripMenuItem.Click += new System.EventHandler(this.帘布剪裁ToolStripMenuItem_Click);
            // 
            // 工件成型ToolStripMenuItem
            // 
            this.工件成型ToolStripMenuItem.Name = "工件成型ToolStripMenuItem";
            this.工件成型ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.工件成型ToolStripMenuItem.Text = "工件成型";
            this.工件成型ToolStripMenuItem.Click += new System.EventHandler(this.工件成型ToolStripMenuItem_Click);
            // 
            // 仓库ToolStripMenuItem
            // 
            this.仓库ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.胶料入库ToolStripMenuItem,
            this.帘布入库ToolStripMenuItem});
            this.仓库ToolStripMenuItem.Name = "仓库ToolStripMenuItem";
            this.仓库ToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.仓库ToolStripMenuItem.Text = "仓库";
            // 
            // 胶料入库ToolStripMenuItem
            // 
            this.胶料入库ToolStripMenuItem.Name = "胶料入库ToolStripMenuItem";
            this.胶料入库ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.胶料入库ToolStripMenuItem.Text = "胶料入库";
            this.胶料入库ToolStripMenuItem.Click += new System.EventHandler(this.胶料入库ToolStripMenuItem_Click);
            // 
            // 帘布入库ToolStripMenuItem
            // 
            this.帘布入库ToolStripMenuItem.Name = "帘布入库ToolStripMenuItem";
            this.帘布入库ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.帘布入库ToolStripMenuItem.Text = "帘布入库";
            this.帘布入库ToolStripMenuItem.Click += new System.EventHandler(this.帘布入库ToolStripMenuItem_Click);
            // 
            // 报表ToolStripMenuItem
            // 
            this.报表ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.生产报表ToolStripMenuItem});
            this.报表ToolStripMenuItem.Name = "报表ToolStripMenuItem";
            this.报表ToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.报表ToolStripMenuItem.Text = "报表";
            // 
            // 生产报表ToolStripMenuItem
            // 
            this.生产报表ToolStripMenuItem.Name = "生产报表ToolStripMenuItem";
            this.生产报表ToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.生产报表ToolStripMenuItem.Text = "生产报表";
            // 
            // 基础资料ToolStripMenuItem
            // 
            this.基础资料ToolStripMenuItem.Name = "基础资料ToolStripMenuItem";
            this.基础资料ToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.基础资料ToolStripMenuItem.Text = "基础资料";
            this.基础资料ToolStripMenuItem.Click += new System.EventHandler(this.基础资料ToolStripMenuItem_Click);
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.关于ToolStripMenuItem.Text = "关于";
            this.关于ToolStripMenuItem.Click += new System.EventHandler(this.关于ToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.msMain);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.msMain;
            this.Name = "MainForm";
            this.Text = "溢康通橡胶追溯系统";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.msMain.ResumeLayout(false);
            this.msMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msMain;
        private System.Windows.Forms.ToolStripMenuItem 生产过程ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 仓库ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 报表ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 生产报表ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 基础资料ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 胶料出片ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帘布剪裁ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 工件成型ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 胶料入库ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帘布入库ToolStripMenuItem;
    }
}
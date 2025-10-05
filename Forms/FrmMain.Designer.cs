namespace MasterPrototype
{
    partial class FrmMain
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.共通ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemTools = new System.Windows.Forms.ToolStripMenuItem();
            this.データコピーToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.リスト出力ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ユーザ一覧ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.共通ToolStripMenuItem,
            this.MenuItemTools,
            this.リスト出力ToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1298, 40);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // 共通ToolStripMenuItem
            // 
            this.共通ToolStripMenuItem.Name = "共通ToolStripMenuItem";
            this.共通ToolStripMenuItem.Size = new System.Drawing.Size(82, 36);
            this.共通ToolStripMenuItem.Text = "共通";
            // 
            // MenuItemTools
            // 
            this.MenuItemTools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.データコピーToolStripMenuItem});
            this.MenuItemTools.Name = "MenuItemTools";
            this.MenuItemTools.Size = new System.Drawing.Size(114, 36);
            this.MenuItemTools.Text = "ツール(&T)";
            // 
            // データコピーToolStripMenuItem
            // 
            this.データコピーToolStripMenuItem.Name = "データコピーToolStripMenuItem";
            this.データコピーToolStripMenuItem.Size = new System.Drawing.Size(248, 44);
            this.データコピーToolStripMenuItem.Text = "データコピー";
            this.データコピーToolStripMenuItem.Click += new System.EventHandler(this.mnuToolsCopyData);
            // 
            // リスト出力ToolStripMenuItem
            // 
            this.リスト出力ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ユーザ一覧ToolStripMenuItem});
            this.リスト出力ToolStripMenuItem.Name = "リスト出力ToolStripMenuItem";
            this.リスト出力ToolStripMenuItem.Size = new System.Drawing.Size(134, 36);
            this.リスト出力ToolStripMenuItem.Text = "リスト出力";
            // 
            // ユーザ一覧ToolStripMenuItem
            // 
            this.ユーザ一覧ToolStripMenuItem.Name = "ユーザ一覧ToolStripMenuItem";
            this.ユーザ一覧ToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.ユーザ一覧ToolStripMenuItem.Text = "ユーザ一覧";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1298, 217);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "FrmMain";
            this.Text = "マスタ管理システム(プロトタイプ版)";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem 共通ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuItemTools;
        private System.Windows.Forms.ToolStripMenuItem データコピーToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem リスト出力ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ユーザ一覧ToolStripMenuItem;
    }
}


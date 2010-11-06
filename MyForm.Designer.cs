namespace Aont
{
    partial class MyForm
    {
        /// <summary>
        /// 必要なデザイナ変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナで生成されたコード

        /// <summary>
        /// デザイナ サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディタで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gameGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.changeSizeSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showClickCheckCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpHToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.versionVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameGToolStripMenuItem,
            this.helpHToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(292, 26);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gameGToolStripMenuItem
            // 
            this.gameGToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startSToolStripMenuItem,
            this.toolStripSeparator2,
            this.changeSizeSToolStripMenuItem,
            this.showClickCheckCToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.gameGToolStripMenuItem.Name = "gameGToolStripMenuItem";
            this.gameGToolStripMenuItem.Size = new System.Drawing.Size(74, 22);
            this.gameGToolStripMenuItem.Text = "Game(&G)";
            // 
            // startSToolStripMenuItem
            // 
            this.startSToolStripMenuItem.Name = "startSToolStripMenuItem";
            this.startSToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.startSToolStripMenuItem.Text = "Start(&N)";
            this.startSToolStripMenuItem.Click += new System.EventHandler(this.startSToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(193, 6);
            // 
            // changeSizeSToolStripMenuItem
            // 
            this.changeSizeSToolStripMenuItem.Name = "changeSizeSToolStripMenuItem";
            this.changeSizeSToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.changeSizeSToolStripMenuItem.Text = "Change Size(&S)";
            this.changeSizeSToolStripMenuItem.Click += new System.EventHandler(this.changeSizeSToolStripMenuItem_Click);
            // 
            // showClickCheckCToolStripMenuItem
            // 
            this.showClickCheckCToolStripMenuItem.Name = "showClickCheckCToolStripMenuItem";
            this.showClickCheckCToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.showClickCheckCToolStripMenuItem.Text = "Show Click Check(&C)";
            this.showClickCheckCToolStripMenuItem.Click += new System.EventHandler(this.showClickCheckCToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(193, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.exitToolStripMenuItem.Text = "Exit(&X)";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpHToolStripMenuItem
            // 
            this.helpHToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.versionVToolStripMenuItem});
            this.helpHToolStripMenuItem.Name = "helpHToolStripMenuItem";
            this.helpHToolStripMenuItem.Size = new System.Drawing.Size(65, 22);
            this.helpHToolStripMenuItem.Text = "Help(&H)";
            // 
            // versionVToolStripMenuItem
            // 
            this.versionVToolStripMenuItem.Name = "versionVToolStripMenuItem";
            this.versionVToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.versionVToolStripMenuItem.Text = "Version(&V)";
            this.versionVToolStripMenuItem.Click += new System.EventHandler(this.versionVToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(292, 240);
            this.panel1.TabIndex = 2;
            // 
            // MyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(292, 266);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MyForm";
            this.Text = "Game1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem gameGToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startSToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem changeSizeSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showClickCheckCToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem helpHToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem versionVToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;


    }
}


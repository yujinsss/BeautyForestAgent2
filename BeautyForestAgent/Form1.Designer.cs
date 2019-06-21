namespace BeautyForestAgent
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.btnTray = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ntiTray = new System.Windows.Forms.NotifyIcon(this.components);
            this.cmsMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.폼보이기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.끝내기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.cmsMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(13, 279);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(466, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "(주)미림스쿨 - Beauty Forest Agent v0.2 by [학번] [이름]";
            // 
            // btnTray
            // 
            this.btnTray.Location = new System.Drawing.Point(702, 275);
            this.btnTray.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTray.Name = "btnTray";
            this.btnTray.Size = new System.Drawing.Size(30, 18);
            this.btnTray.TabIndex = 2;
            this.btnTray.Text = "▼";
            this.btnTray.UseVisualStyleBackColor = true;
            this.btnTray.Click += new System.EventHandler(this.BtnTray_Click);
            // 
            // btnModify
            // 
            this.btnModify.BackColor = System.Drawing.Color.Yellow;
            this.btnModify.Location = new System.Drawing.Point(628, 30);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(46, 20);
            this.btnModify.TabIndex = 3;
            this.btnModify.Text = "수정";
            this.btnModify.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Chartreuse;
            this.btnAdd.Location = new System.Drawing.Point(677, 30);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(46, 20);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "추가";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BeautyForestAgent.Properties.Resources.demo;
            this.pictureBox1.Location = new System.Drawing.Point(5, 28);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(727, 239);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // ntiTray
            // 
            this.ntiTray.ContextMenuStrip = this.cmsMenu;
            this.ntiTray.Icon = ((System.Drawing.Icon)(resources.GetObject("ntiTray.Icon")));
            this.ntiTray.Text = "Beauty Forest Agen";
            this.ntiTray.Visible = true;
            this.ntiTray.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.NtiTray_MouseDoubleClick);
            // 
            // cmsMenu
            // 
            this.cmsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.폼보이기ToolStripMenuItem,
            this.끝내기ToolStripMenuItem});
            this.cmsMenu.Name = "cmsMenu";
            this.cmsMenu.Size = new System.Drawing.Size(127, 48);
            // 
            // 폼보이기ToolStripMenuItem
            // 
            this.폼보이기ToolStripMenuItem.Name = "폼보이기ToolStripMenuItem";
            this.폼보이기ToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.폼보이기ToolStripMenuItem.Text = "폼 보이기";
            this.폼보이기ToolStripMenuItem.Click += new System.EventHandler(this.폼보이기ToolStripMenuItem_Click);
            // 
            // 끝내기ToolStripMenuItem
            // 
            this.끝내기ToolStripMenuItem.Name = "끝내기ToolStripMenuItem";
            this.끝내기ToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.끝내기ToolStripMenuItem.Text = "끝내기";
            this.끝내기ToolStripMenuItem.Click += new System.EventHandler(this.끝내기ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 323);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.btnTray);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Beauty Forest Agent v0.2 by [학번] [이름]";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.cmsMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTray;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.NotifyIcon ntiTray;
        private System.Windows.Forms.ContextMenuStrip cmsMenu;
        private System.Windows.Forms.ToolStripMenuItem 폼보이기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 끝내기ToolStripMenuItem;
    }
}


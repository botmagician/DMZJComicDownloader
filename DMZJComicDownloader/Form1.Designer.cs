namespace DMZJComicDownloader
{
    partial class Form1
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
            this.comicOptions = new System.Windows.Forms.GroupBox();
            this.toolOptions = new System.Windows.Forms.GroupBox();
            this.taskStatus = new System.Windows.Forms.GroupBox();
            this.ctrlPanel = new System.Windows.Forms.Panel();
            this.inforPanel = new System.Windows.Forms.Panel();
            this.taskConsole = new System.Windows.Forms.TextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.taskStatus.SuspendLayout();
            this.inforPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // comicOptions
            // 
            this.comicOptions.Location = new System.Drawing.Point(13, 13);
            this.comicOptions.Name = "comicOptions";
            this.comicOptions.Size = new System.Drawing.Size(457, 256);
            this.comicOptions.TabIndex = 0;
            this.comicOptions.TabStop = false;
            this.comicOptions.Text = "漫画选项";
            // 
            // toolOptions
            // 
            this.toolOptions.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.toolOptions.Location = new System.Drawing.Point(484, 13);
            this.toolOptions.Name = "toolOptions";
            this.toolOptions.Size = new System.Drawing.Size(385, 255);
            this.toolOptions.TabIndex = 1;
            this.toolOptions.TabStop = false;
            this.toolOptions.Text = "toolOptions";
            // 
            // taskStatus
            // 
            this.taskStatus.Controls.Add(this.inforPanel);
            this.taskStatus.Controls.Add(this.ctrlPanel);
            this.taskStatus.Location = new System.Drawing.Point(12, 291);
            this.taskStatus.Name = "taskStatus";
            this.taskStatus.Size = new System.Drawing.Size(856, 238);
            this.taskStatus.TabIndex = 2;
            this.taskStatus.TabStop = false;
            this.taskStatus.Text = "任务状态";
            // 
            // ctrlPanel
            // 
            this.ctrlPanel.Location = new System.Drawing.Point(12, 24);
            this.ctrlPanel.Name = "ctrlPanel";
            this.ctrlPanel.Size = new System.Drawing.Size(214, 192);
            this.ctrlPanel.TabIndex = 0;
            // 
            // inforPanel
            // 
            this.inforPanel.Controls.Add(this.progressBar1);
            this.inforPanel.Controls.Add(this.taskConsole);
            this.inforPanel.Location = new System.Drawing.Point(256, 24);
            this.inforPanel.Name = "inforPanel";
            this.inforPanel.Size = new System.Drawing.Size(581, 191);
            this.inforPanel.TabIndex = 1;
            // 
            // taskConsole
            // 
            this.taskConsole.BackColor = System.Drawing.Color.White;
            this.taskConsole.Location = new System.Drawing.Point(3, 109);
            this.taskConsole.Multiline = true;
            this.taskConsole.Name = "taskConsole";
            this.taskConsole.ReadOnly = true;
            this.taskConsole.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.taskConsole.Size = new System.Drawing.Size(575, 79);
            this.taskConsole.TabIndex = 0;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(216, 43);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(362, 37);
            this.progressBar1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 530);
            this.Controls.Add(this.taskStatus);
            this.Controls.Add(this.toolOptions);
            this.Controls.Add(this.comicOptions);
            this.Name = "Form1";
            this.Text = "Form1";
            this.taskStatus.ResumeLayout(false);
            this.inforPanel.ResumeLayout(false);
            this.inforPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox comicOptions;
        private System.Windows.Forms.GroupBox toolOptions;
        private System.Windows.Forms.GroupBox taskStatus;
        private System.Windows.Forms.Panel inforPanel;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TextBox taskConsole;
        private System.Windows.Forms.Panel ctrlPanel;
    }
}


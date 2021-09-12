namespace DMZJComicDownloader
{
    partial class MainForm
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.urlPanel = new System.Windows.Forms.Panel();
            this.urlTextBox = new System.Windows.Forms.TextBox();
            this.urlLabel = new System.Windows.Forms.Label();
            this.savePanel = new System.Windows.Forms.Panel();
            this.findFolderButton = new System.Windows.Forms.Button();
            this.saveTextBox = new System.Windows.Forms.TextBox();
            this.saveLabel = new System.Windows.Forms.Label();
            this.getInfoButton = new System.Windows.Forms.Button();
            this.setComicInfoButton = new System.Windows.Forms.Button();
            this.taskStatus = new System.Windows.Forms.GroupBox();
            this.ctrlPanel = new System.Windows.Forms.Panel();
            this.quitButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.comicInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.comicInfoTextBox = new System.Windows.Forms.TextBox();
            this.comicOptions.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.urlPanel.SuspendLayout();
            this.savePanel.SuspendLayout();
            this.taskStatus.SuspendLayout();
            this.ctrlPanel.SuspendLayout();
            this.comicInfoGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // comicOptions
            // 
            this.comicOptions.Controls.Add(this.flowLayoutPanel1);
            this.comicOptions.Location = new System.Drawing.Point(20, 20);
            this.comicOptions.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comicOptions.Name = "comicOptions";
            this.comicOptions.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comicOptions.Size = new System.Drawing.Size(666, 225);
            this.comicOptions.TabIndex = 0;
            this.comicOptions.TabStop = false;
            this.comicOptions.Text = "漫画选项";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.urlPanel);
            this.flowLayoutPanel1.Controls.Add(this.savePanel);
            this.flowLayoutPanel1.Controls.Add(this.getInfoButton);
            this.flowLayoutPanel1.Controls.Add(this.setComicInfoButton);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(4, 25);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(658, 196);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // urlPanel
            // 
            this.urlPanel.Controls.Add(this.urlTextBox);
            this.urlPanel.Controls.Add(this.urlLabel);
            this.urlPanel.Location = new System.Drawing.Point(4, 4);
            this.urlPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.urlPanel.Name = "urlPanel";
            this.urlPanel.Size = new System.Drawing.Size(646, 48);
            this.urlPanel.TabIndex = 0;
            // 
            // urlTextBox
            // 
            this.urlTextBox.Location = new System.Drawing.Point(93, 9);
            this.urlTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.urlTextBox.Name = "urlTextBox";
            this.urlTextBox.Size = new System.Drawing.Size(547, 28);
            this.urlTextBox.TabIndex = 1;
            this.urlTextBox.TextChanged += new System.EventHandler(this.urlTextBox_TextChanged);
            // 
            // urlLabel
            // 
            this.urlLabel.AutoSize = true;
            this.urlLabel.Location = new System.Drawing.Point(4, 14);
            this.urlLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.urlLabel.Name = "urlLabel";
            this.urlLabel.Size = new System.Drawing.Size(80, 18);
            this.urlLabel.TabIndex = 0;
            this.urlLabel.Text = "漫画地址";
            // 
            // savePanel
            // 
            this.savePanel.Controls.Add(this.findFolderButton);
            this.savePanel.Controls.Add(this.saveTextBox);
            this.savePanel.Controls.Add(this.saveLabel);
            this.savePanel.Location = new System.Drawing.Point(4, 60);
            this.savePanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.savePanel.Name = "savePanel";
            this.savePanel.Size = new System.Drawing.Size(646, 46);
            this.savePanel.TabIndex = 2;
            // 
            // findFolderButton
            // 
            this.findFolderButton.Location = new System.Drawing.Point(513, 8);
            this.findFolderButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.findFolderButton.Name = "findFolderButton";
            this.findFolderButton.Size = new System.Drawing.Size(129, 34);
            this.findFolderButton.TabIndex = 2;
            this.findFolderButton.Text = "点我寻找地址";
            this.findFolderButton.UseVisualStyleBackColor = true;
            this.findFolderButton.Click += new System.EventHandler(this.findFolderButton_Click);
            // 
            // saveTextBox
            // 
            this.saveTextBox.Location = new System.Drawing.Point(93, 8);
            this.saveTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.saveTextBox.Name = "saveTextBox";
            this.saveTextBox.ReadOnly = true;
            this.saveTextBox.Size = new System.Drawing.Size(409, 28);
            this.saveTextBox.TabIndex = 1;
            this.saveTextBox.TextChanged += new System.EventHandler(this.saveTextBox_TextChanged);
            // 
            // saveLabel
            // 
            this.saveLabel.AutoSize = true;
            this.saveLabel.Location = new System.Drawing.Point(4, 15);
            this.saveLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.saveLabel.Name = "saveLabel";
            this.saveLabel.Size = new System.Drawing.Size(80, 18);
            this.saveLabel.TabIndex = 0;
            this.saveLabel.Text = "储存位置";
            // 
            // getInfoButton
            // 
            this.getInfoButton.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.getInfoButton.Location = new System.Drawing.Point(4, 114);
            this.getInfoButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.getInfoButton.Name = "getInfoButton";
            this.getInfoButton.Size = new System.Drawing.Size(303, 52);
            this.getInfoButton.TabIndex = 3;
            this.getInfoButton.Text = "获取漫画信息";
            this.getInfoButton.UseVisualStyleBackColor = true;
            this.getInfoButton.Click += new System.EventHandler(this.getInfoButton_Click);
            // 
            // setComicInfoButton
            // 
            this.setComicInfoButton.Location = new System.Drawing.Point(315, 114);
            this.setComicInfoButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.setComicInfoButton.Name = "setComicInfoButton";
            this.setComicInfoButton.Size = new System.Drawing.Size(332, 52);
            this.setComicInfoButton.TabIndex = 4;
            this.setComicInfoButton.Text = "修改漫画信息";
            this.setComicInfoButton.UseVisualStyleBackColor = true;
            this.setComicInfoButton.Click += new System.EventHandler(this.setComicInfoButton_Click);
            // 
            // taskStatus
            // 
            this.taskStatus.Controls.Add(this.comicInfoGroupBox);
            this.taskStatus.Controls.Add(this.ctrlPanel);
            this.taskStatus.Location = new System.Drawing.Point(18, 254);
            this.taskStatus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.taskStatus.Name = "taskStatus";
            this.taskStatus.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.taskStatus.Size = new System.Drawing.Size(777, 326);
            this.taskStatus.TabIndex = 2;
            this.taskStatus.TabStop = false;
            this.taskStatus.Text = "任务状态";
            // 
            // ctrlPanel
            // 
            this.ctrlPanel.Controls.Add(this.quitButton);
            this.ctrlPanel.Controls.Add(this.stopButton);
            this.ctrlPanel.Controls.Add(this.startButton);
            this.ctrlPanel.Location = new System.Drawing.Point(18, 36);
            this.ctrlPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ctrlPanel.Name = "ctrlPanel";
            this.ctrlPanel.Size = new System.Drawing.Size(281, 206);
            this.ctrlPanel.TabIndex = 0;
            // 
            // quitButton
            // 
            this.quitButton.Location = new System.Drawing.Point(4, 142);
            this.quitButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(272, 60);
            this.quitButton.TabIndex = 2;
            this.quitButton.Text = "退出";
            this.quitButton.UseVisualStyleBackColor = true;
            this.quitButton.Click += new System.EventHandler(this.quitButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.Location = new System.Drawing.Point(4, 74);
            this.stopButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(272, 60);
            this.stopButton.TabIndex = 1;
            this.stopButton.Text = "强制停止";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(4, 4);
            this.startButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(272, 60);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "开始";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // comicInfoGroupBox
            // 
            this.comicInfoGroupBox.Controls.Add(this.comicInfoTextBox);
            this.comicInfoGroupBox.Location = new System.Drawing.Point(321, 29);
            this.comicInfoGroupBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comicInfoGroupBox.Name = "comicInfoGroupBox";
            this.comicInfoGroupBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comicInfoGroupBox.Size = new System.Drawing.Size(463, 220);
            this.comicInfoGroupBox.TabIndex = 3;
            this.comicInfoGroupBox.TabStop = false;
            this.comicInfoGroupBox.Text = "漫画信息";
            // 
            // comicInfoTextBox
            // 
            this.comicInfoTextBox.BackColor = System.Drawing.Color.White;
            this.comicInfoTextBox.Location = new System.Drawing.Point(9, 30);
            this.comicInfoTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comicInfoTextBox.Multiline = true;
            this.comicInfoTextBox.Name = "comicInfoTextBox";
            this.comicInfoTextBox.ReadOnly = true;
            this.comicInfoTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.comicInfoTextBox.Size = new System.Drawing.Size(422, 180);
            this.comicInfoTextBox.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 594);
            this.Controls.Add(this.taskStatus);
            this.Controls.Add(this.comicOptions);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.comicOptions.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.urlPanel.ResumeLayout(false);
            this.urlPanel.PerformLayout();
            this.savePanel.ResumeLayout(false);
            this.savePanel.PerformLayout();
            this.taskStatus.ResumeLayout(false);
            this.ctrlPanel.ResumeLayout(false);
            this.comicInfoGroupBox.ResumeLayout(false);
            this.comicInfoGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox comicOptions;
        private System.Windows.Forms.GroupBox taskStatus;
        private System.Windows.Forms.Panel ctrlPanel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel urlPanel;
        private System.Windows.Forms.TextBox urlTextBox;
        private System.Windows.Forms.Label urlLabel;
        private System.Windows.Forms.Panel savePanel;
        private System.Windows.Forms.Button findFolderButton;
        private System.Windows.Forms.TextBox saveTextBox;
        private System.Windows.Forms.Label saveLabel;
        private System.Windows.Forms.Button quitButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button getInfoButton;
        private System.Windows.Forms.GroupBox comicInfoGroupBox;
        private System.Windows.Forms.TextBox comicInfoTextBox;
        private System.Windows.Forms.Button setComicInfoButton;
    }
}


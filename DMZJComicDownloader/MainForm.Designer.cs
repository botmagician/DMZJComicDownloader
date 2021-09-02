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
            this.namePanel = new System.Windows.Forms.Panel();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.savePanel = new System.Windows.Forms.Panel();
            this.findFolderButton = new System.Windows.Forms.Button();
            this.saveTextBox = new System.Windows.Forms.TextBox();
            this.saveLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.toolOptions = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.chooseBrowserLabel = new System.Windows.Forms.Label();
            this.taskStatus = new System.Windows.Forms.GroupBox();
            this.inforPanel = new System.Windows.Forms.Panel();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.taskConsole = new System.Windows.Forms.TextBox();
            this.ctrlPanel = new System.Windows.Forms.Panel();
            this.startButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.quitButton = new System.Windows.Forms.Button();
            this.summaryTextBox = new System.Windows.Forms.TextBox();
            this.summaryLabel = new System.Windows.Forms.Label();
            this.consoleLabel = new System.Windows.Forms.Label();
            this.setProxyButton = new System.Windows.Forms.Button();
            this.comicOptions.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.urlPanel.SuspendLayout();
            this.namePanel.SuspendLayout();
            this.savePanel.SuspendLayout();
            this.toolOptions.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.taskStatus.SuspendLayout();
            this.inforPanel.SuspendLayout();
            this.ctrlPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // comicOptions
            // 
            this.comicOptions.Controls.Add(this.flowLayoutPanel1);
            this.comicOptions.Location = new System.Drawing.Point(13, 13);
            this.comicOptions.Name = "comicOptions";
            this.comicOptions.Size = new System.Drawing.Size(444, 164);
            this.comicOptions.TabIndex = 0;
            this.comicOptions.TabStop = false;
            this.comicOptions.Text = "漫画选项";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.urlPanel);
            this.flowLayoutPanel1.Controls.Add(this.namePanel);
            this.flowLayoutPanel1.Controls.Add(this.savePanel);
            this.flowLayoutPanel1.Controls.Add(this.button1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 17);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(438, 144);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // urlPanel
            // 
            this.urlPanel.Controls.Add(this.urlTextBox);
            this.urlPanel.Controls.Add(this.urlLabel);
            this.urlPanel.Location = new System.Drawing.Point(3, 3);
            this.urlPanel.Name = "urlPanel";
            this.urlPanel.Size = new System.Drawing.Size(431, 32);
            this.urlPanel.TabIndex = 0;
            // 
            // urlTextBox
            // 
            this.urlTextBox.Location = new System.Drawing.Point(62, 6);
            this.urlTextBox.Name = "urlTextBox";
            this.urlTextBox.Size = new System.Drawing.Size(366, 21);
            this.urlTextBox.TabIndex = 1;
            // 
            // urlLabel
            // 
            this.urlLabel.AutoSize = true;
            this.urlLabel.Location = new System.Drawing.Point(3, 9);
            this.urlLabel.Name = "urlLabel";
            this.urlLabel.Size = new System.Drawing.Size(53, 12);
            this.urlLabel.TabIndex = 0;
            this.urlLabel.Text = "漫画地址";
            // 
            // namePanel
            // 
            this.namePanel.Controls.Add(this.nameTextBox);
            this.namePanel.Controls.Add(this.nameLabel);
            this.namePanel.Location = new System.Drawing.Point(3, 41);
            this.namePanel.Name = "namePanel";
            this.namePanel.Size = new System.Drawing.Size(431, 30);
            this.namePanel.TabIndex = 1;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(62, 3);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(366, 21);
            this.nameTextBox.TabIndex = 1;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(3, 6);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(53, 12);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "漫画名称";
            // 
            // savePanel
            // 
            this.savePanel.Controls.Add(this.findFolderButton);
            this.savePanel.Controls.Add(this.saveTextBox);
            this.savePanel.Controls.Add(this.saveLabel);
            this.savePanel.Location = new System.Drawing.Point(3, 77);
            this.savePanel.Name = "savePanel";
            this.savePanel.Size = new System.Drawing.Size(431, 31);
            this.savePanel.TabIndex = 2;
            // 
            // findFolderButton
            // 
            this.findFolderButton.Location = new System.Drawing.Point(342, 5);
            this.findFolderButton.Name = "findFolderButton";
            this.findFolderButton.Size = new System.Drawing.Size(86, 23);
            this.findFolderButton.TabIndex = 2;
            this.findFolderButton.Text = "点我寻找地址";
            this.findFolderButton.UseVisualStyleBackColor = true;
            // 
            // saveTextBox
            // 
            this.saveTextBox.Location = new System.Drawing.Point(62, 5);
            this.saveTextBox.Name = "saveTextBox";
            this.saveTextBox.Size = new System.Drawing.Size(274, 21);
            this.saveTextBox.TabIndex = 1;
            this.saveTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // saveLabel
            // 
            this.saveLabel.AutoSize = true;
            this.saveLabel.Location = new System.Drawing.Point(3, 10);
            this.saveLabel.Name = "saveLabel";
            this.saveLabel.Size = new System.Drawing.Size(53, 12);
            this.saveLabel.TabIndex = 0;
            this.saveLabel.Text = "储存位置";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 114);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // toolOptions
            // 
            this.toolOptions.Controls.Add(this.flowLayoutPanel2);
            this.toolOptions.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.toolOptions.Location = new System.Drawing.Point(463, 13);
            this.toolOptions.Name = "toolOptions";
            this.toolOptions.Size = new System.Drawing.Size(188, 164);
            this.toolOptions.TabIndex = 1;
            this.toolOptions.TabStop = false;
            this.toolOptions.Text = "toolOptions";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.setProxyButton);
            this.flowLayoutPanel2.Controls.Add(this.panel1);
            this.flowLayoutPanel2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 17);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(182, 144);
            this.flowLayoutPanel2.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.chooseBrowserLabel);
            this.panel1.Location = new System.Drawing.Point(3, 67);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(173, 37);
            this.panel1.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Firfox",
            "Chrome",
            "Edge"});
            this.comboBox1.Location = new System.Drawing.Point(77, 7);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(89, 20);
            this.comboBox1.TabIndex = 1;
            // 
            // chooseBrowserLabel
            // 
            this.chooseBrowserLabel.AutoSize = true;
            this.chooseBrowserLabel.Location = new System.Drawing.Point(6, 10);
            this.chooseBrowserLabel.Name = "chooseBrowserLabel";
            this.chooseBrowserLabel.Size = new System.Drawing.Size(65, 12);
            this.chooseBrowserLabel.TabIndex = 0;
            this.chooseBrowserLabel.Text = "选择浏览器";
            // 
            // taskStatus
            // 
            this.taskStatus.Controls.Add(this.inforPanel);
            this.taskStatus.Controls.Add(this.ctrlPanel);
            this.taskStatus.Location = new System.Drawing.Point(13, 183);
            this.taskStatus.Name = "taskStatus";
            this.taskStatus.Size = new System.Drawing.Size(794, 217);
            this.taskStatus.TabIndex = 2;
            this.taskStatus.TabStop = false;
            this.taskStatus.Text = "任务状态";
            // 
            // inforPanel
            // 
            this.inforPanel.Controls.Add(this.consoleLabel);
            this.inforPanel.Controls.Add(this.summaryLabel);
            this.inforPanel.Controls.Add(this.summaryTextBox);
            this.inforPanel.Controls.Add(this.progressBar1);
            this.inforPanel.Controls.Add(this.taskConsole);
            this.inforPanel.Location = new System.Drawing.Point(205, 20);
            this.inforPanel.Name = "inforPanel";
            this.inforPanel.Size = new System.Drawing.Size(581, 191);
            this.inforPanel.TabIndex = 1;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(160, 29);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(362, 37);
            this.progressBar1.TabIndex = 1;
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
            // ctrlPanel
            // 
            this.ctrlPanel.Controls.Add(this.quitButton);
            this.ctrlPanel.Controls.Add(this.stopButton);
            this.ctrlPanel.Controls.Add(this.startButton);
            this.ctrlPanel.Location = new System.Drawing.Point(12, 24);
            this.ctrlPanel.Name = "ctrlPanel";
            this.ctrlPanel.Size = new System.Drawing.Size(187, 143);
            this.ctrlPanel.TabIndex = 0;
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(3, 3);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(181, 40);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "开始";
            this.startButton.UseVisualStyleBackColor = true;
            // 
            // stopButton
            // 
            this.stopButton.Location = new System.Drawing.Point(3, 49);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(181, 40);
            this.stopButton.TabIndex = 1;
            this.stopButton.Text = "结束";
            this.stopButton.UseVisualStyleBackColor = true;
            // 
            // quitButton
            // 
            this.quitButton.Location = new System.Drawing.Point(3, 95);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(181, 40);
            this.quitButton.TabIndex = 2;
            this.quitButton.Text = "退出";
            this.quitButton.UseVisualStyleBackColor = true;
            // 
            // summaryTextBox
            // 
            this.summaryTextBox.Location = new System.Drawing.Point(0, 18);
            this.summaryTextBox.Multiline = true;
            this.summaryTextBox.Name = "summaryTextBox";
            this.summaryTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.summaryTextBox.Size = new System.Drawing.Size(154, 65);
            this.summaryTextBox.TabIndex = 2;
            // 
            // summaryLabel
            // 
            this.summaryLabel.AutoSize = true;
            this.summaryLabel.Location = new System.Drawing.Point(1, 3);
            this.summaryLabel.Name = "summaryLabel";
            this.summaryLabel.Size = new System.Drawing.Size(53, 12);
            this.summaryLabel.TabIndex = 3;
            this.summaryLabel.Text = "任务概述";
            // 
            // consoleLabel
            // 
            this.consoleLabel.AutoSize = true;
            this.consoleLabel.Location = new System.Drawing.Point(3, 95);
            this.consoleLabel.Name = "consoleLabel";
            this.consoleLabel.Size = new System.Drawing.Size(53, 12);
            this.consoleLabel.TabIndex = 4;
            this.consoleLabel.Text = "任务信息";
            // 
            // setProxyButton
            // 
            this.setProxyButton.Location = new System.Drawing.Point(3, 3);
            this.setProxyButton.Name = "setProxyButton";
            this.setProxyButton.Size = new System.Drawing.Size(117, 58);
            this.setProxyButton.TabIndex = 3;
            this.setProxyButton.Text = "设置代理";
            this.setProxyButton.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 406);
            this.Controls.Add(this.taskStatus);
            this.Controls.Add(this.toolOptions);
            this.Controls.Add(this.comicOptions);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.comicOptions.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.urlPanel.ResumeLayout(false);
            this.urlPanel.PerformLayout();
            this.namePanel.ResumeLayout(false);
            this.namePanel.PerformLayout();
            this.savePanel.ResumeLayout(false);
            this.savePanel.PerformLayout();
            this.toolOptions.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.taskStatus.ResumeLayout(false);
            this.inforPanel.ResumeLayout(false);
            this.inforPanel.PerformLayout();
            this.ctrlPanel.ResumeLayout(false);
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
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel urlPanel;
        private System.Windows.Forms.TextBox urlTextBox;
        private System.Windows.Forms.Label urlLabel;
        private System.Windows.Forms.Panel namePanel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Panel savePanel;
        private System.Windows.Forms.Button findFolderButton;
        private System.Windows.Forms.TextBox saveTextBox;
        private System.Windows.Forms.Label saveLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label chooseBrowserLabel;
        private System.Windows.Forms.Label summaryLabel;
        private System.Windows.Forms.TextBox summaryTextBox;
        private System.Windows.Forms.Button quitButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label consoleLabel;
        private System.Windows.Forms.Button setProxyButton;
    }
}


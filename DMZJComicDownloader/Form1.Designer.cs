﻿namespace DMZJComicDownloader
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.urlPanel = new System.Windows.Forms.Panel();
            this.urlTextBox = new System.Windows.Forms.TextBox();
            this.urlLabel = new System.Windows.Forms.Label();
            this.namePanel = new System.Windows.Forms.Panel();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.savePanel = new System.Windows.Forms.Panel();
            this.findFolderButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.saveLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.toolOptions = new System.Windows.Forms.GroupBox();
            this.taskStatus = new System.Windows.Forms.GroupBox();
            this.inforPanel = new System.Windows.Forms.Panel();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.taskConsole = new System.Windows.Forms.TextBox();
            this.ctrlPanel = new System.Windows.Forms.Panel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.proxyPanel = new System.Windows.Forms.Panel();
            this.proxySettingPanel = new System.Windows.Forms.Panel();
            this.useProxyLabel = new System.Windows.Forms.Label();
            this.useProxyCheckBox = new System.Windows.Forms.CheckBox();
            this.proxyListBox = new System.Windows.Forms.ListBox();
            this.addProxyButton = new System.Windows.Forms.Button();
            this.removeProxyButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chooseBrowserLabel = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.comicOptions.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.urlPanel.SuspendLayout();
            this.namePanel.SuspendLayout();
            this.savePanel.SuspendLayout();
            this.toolOptions.SuspendLayout();
            this.taskStatus.SuspendLayout();
            this.inforPanel.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.proxyPanel.SuspendLayout();
            this.proxySettingPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comicOptions
            // 
            this.comicOptions.Controls.Add(this.flowLayoutPanel1);
            this.comicOptions.Location = new System.Drawing.Point(13, 13);
            this.comicOptions.Name = "comicOptions";
            this.comicOptions.Size = new System.Drawing.Size(465, 272);
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
            this.flowLayoutPanel1.Size = new System.Drawing.Size(459, 252);
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
            this.savePanel.Controls.Add(this.textBox1);
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(62, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(274, 21);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
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
            this.toolOptions.Location = new System.Drawing.Point(484, 13);
            this.toolOptions.Name = "toolOptions";
            this.toolOptions.Size = new System.Drawing.Size(385, 214);
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
            // inforPanel
            // 
            this.inforPanel.Controls.Add(this.progressBar1);
            this.inforPanel.Controls.Add(this.taskConsole);
            this.inforPanel.Location = new System.Drawing.Point(256, 24);
            this.inforPanel.Name = "inforPanel";
            this.inforPanel.Size = new System.Drawing.Size(581, 191);
            this.inforPanel.TabIndex = 1;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(216, 43);
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
            this.ctrlPanel.Location = new System.Drawing.Point(12, 24);
            this.ctrlPanel.Name = "ctrlPanel";
            this.ctrlPanel.Size = new System.Drawing.Size(214, 192);
            this.ctrlPanel.TabIndex = 0;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.proxyPanel);
            this.flowLayoutPanel2.Controls.Add(this.saveButton);
            this.flowLayoutPanel2.Controls.Add(this.panel1);
            this.flowLayoutPanel2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 17);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(379, 194);
            this.flowLayoutPanel2.TabIndex = 0;
            // 
            // proxyPanel
            // 
            this.proxyPanel.Controls.Add(this.useProxyCheckBox);
            this.proxyPanel.Controls.Add(this.useProxyLabel);
            this.proxyPanel.Controls.Add(this.proxySettingPanel);
            this.proxyPanel.Location = new System.Drawing.Point(3, 3);
            this.proxyPanel.Name = "proxyPanel";
            this.proxyPanel.Size = new System.Drawing.Size(181, 144);
            this.proxyPanel.TabIndex = 0;
            // 
            // proxySettingPanel
            // 
            this.proxySettingPanel.Controls.Add(this.removeProxyButton);
            this.proxySettingPanel.Controls.Add(this.addProxyButton);
            this.proxySettingPanel.Controls.Add(this.proxyListBox);
            this.proxySettingPanel.Location = new System.Drawing.Point(0, 30);
            this.proxySettingPanel.Name = "proxySettingPanel";
            this.proxySettingPanel.Size = new System.Drawing.Size(180, 111);
            this.proxySettingPanel.TabIndex = 0;
            this.proxySettingPanel.Visible = false;
            // 
            // useProxyLabel
            // 
            this.useProxyLabel.AutoSize = true;
            this.useProxyLabel.Location = new System.Drawing.Point(3, 10);
            this.useProxyLabel.Name = "useProxyLabel";
            this.useProxyLabel.Size = new System.Drawing.Size(77, 12);
            this.useProxyLabel.TabIndex = 1;
            this.useProxyLabel.Text = "是否使用代理";
            // 
            // useProxyCheckBox
            // 
            this.useProxyCheckBox.AutoSize = true;
            this.useProxyCheckBox.Location = new System.Drawing.Point(86, 9);
            this.useProxyCheckBox.Name = "useProxyCheckBox";
            this.useProxyCheckBox.Size = new System.Drawing.Size(15, 14);
            this.useProxyCheckBox.TabIndex = 2;
            this.useProxyCheckBox.UseVisualStyleBackColor = true;
            // 
            // proxyListBox
            // 
            this.proxyListBox.FormattingEnabled = true;
            this.proxyListBox.ItemHeight = 12;
            this.proxyListBox.Location = new System.Drawing.Point(1, 3);
            this.proxyListBox.Name = "proxyListBox";
            this.proxyListBox.Size = new System.Drawing.Size(179, 76);
            this.proxyListBox.TabIndex = 0;
            // 
            // addProxyButton
            // 
            this.addProxyButton.Location = new System.Drawing.Point(3, 85);
            this.addProxyButton.Name = "addProxyButton";
            this.addProxyButton.Size = new System.Drawing.Size(75, 23);
            this.addProxyButton.TabIndex = 1;
            this.addProxyButton.Text = "添加代理";
            this.addProxyButton.UseVisualStyleBackColor = true;
            // 
            // removeProxyButton
            // 
            this.removeProxyButton.Location = new System.Drawing.Point(95, 85);
            this.removeProxyButton.Name = "removeProxyButton";
            this.removeProxyButton.Size = new System.Drawing.Size(73, 22);
            this.removeProxyButton.TabIndex = 2;
            this.removeProxyButton.Text = "移除代理";
            this.removeProxyButton.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.chooseBrowserLabel);
            this.panel1.Location = new System.Drawing.Point(3, 153);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(173, 37);
            this.panel1.TabIndex = 1;
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
            // saveButton
            // 
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.Location = new System.Drawing.Point(190, 3);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(117, 59);
            this.saveButton.TabIndex = 2;
            this.saveButton.Text = "保存";
            this.saveButton.UseVisualStyleBackColor = true;
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
            this.comicOptions.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.urlPanel.ResumeLayout(false);
            this.urlPanel.PerformLayout();
            this.namePanel.ResumeLayout(false);
            this.namePanel.PerformLayout();
            this.savePanel.ResumeLayout(false);
            this.savePanel.PerformLayout();
            this.toolOptions.ResumeLayout(false);
            this.taskStatus.ResumeLayout(false);
            this.inforPanel.ResumeLayout(false);
            this.inforPanel.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.proxyPanel.ResumeLayout(false);
            this.proxyPanel.PerformLayout();
            this.proxySettingPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label saveLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Panel proxyPanel;
        private System.Windows.Forms.CheckBox useProxyCheckBox;
        private System.Windows.Forms.Label useProxyLabel;
        private System.Windows.Forms.Panel proxySettingPanel;
        private System.Windows.Forms.Button removeProxyButton;
        private System.Windows.Forms.Button addProxyButton;
        private System.Windows.Forms.ListBox proxyListBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label chooseBrowserLabel;
        private System.Windows.Forms.Button saveButton;
    }
}


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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.urlPanel = new System.Windows.Forms.Panel();
            this.urlLabel = new System.Windows.Forms.Label();
            this.urlTextBox = new System.Windows.Forms.TextBox();
            this.namePanel = new System.Windows.Forms.Panel();
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.savePanel = new System.Windows.Forms.Panel();
            this.saveLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.findFolderButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.beginLabel = new System.Windows.Forms.Label();
            this.endLabel = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.comicOptions.SuspendLayout();
            this.taskStatus.SuspendLayout();
            this.inforPanel.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.urlPanel.SuspendLayout();
            this.namePanel.SuspendLayout();
            this.savePanel.SuspendLayout();
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
            // toolOptions
            // 
            this.toolOptions.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.toolOptions.Location = new System.Drawing.Point(484, 13);
            this.toolOptions.Name = "toolOptions";
            this.toolOptions.Size = new System.Drawing.Size(385, 272);
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
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.urlPanel);
            this.flowLayoutPanel1.Controls.Add(this.namePanel);
            this.flowLayoutPanel1.Controls.Add(this.savePanel);
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(11, 20);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(448, 246);
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
            // urlLabel
            // 
            this.urlLabel.AutoSize = true;
            this.urlLabel.Location = new System.Drawing.Point(3, 9);
            this.urlLabel.Name = "urlLabel";
            this.urlLabel.Size = new System.Drawing.Size(53, 12);
            this.urlLabel.TabIndex = 0;
            this.urlLabel.Text = "漫画地址";
            // 
            // urlTextBox
            // 
            this.urlTextBox.Location = new System.Drawing.Point(62, 6);
            this.urlTextBox.Name = "urlTextBox";
            this.urlTextBox.Size = new System.Drawing.Size(366, 21);
            this.urlTextBox.TabIndex = 1;
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
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(3, 6);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(53, 12);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "漫画名称";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(62, 3);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(366, 21);
            this.nameTextBox.TabIndex = 1;
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
            // saveLabel
            // 
            this.saveLabel.AutoSize = true;
            this.saveLabel.Location = new System.Drawing.Point(3, 10);
            this.saveLabel.Name = "saveLabel";
            this.saveLabel.Size = new System.Drawing.Size(53, 12);
            this.saveLabel.TabIndex = 0;
            this.saveLabel.Text = "储存位置";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(62, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(274, 21);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
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
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.endLabel);
            this.panel1.Controls.Add(this.beginLabel);
            this.panel1.Location = new System.Drawing.Point(3, 114);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(170, 78);
            this.panel1.TabIndex = 3;
            // 
            // beginLabel
            // 
            this.beginLabel.AutoSize = true;
            this.beginLabel.Location = new System.Drawing.Point(3, 11);
            this.beginLabel.Name = "beginLabel";
            this.beginLabel.Size = new System.Drawing.Size(53, 12);
            this.beginLabel.TabIndex = 0;
            this.beginLabel.Text = "开始页数";
            // 
            // endLabel
            // 
            this.endLabel.AutoSize = true;
            this.endLabel.Location = new System.Drawing.Point(3, 48);
            this.endLabel.Name = "endLabel";
            this.endLabel.Size = new System.Drawing.Size(53, 12);
            this.endLabel.TabIndex = 1;
            this.endLabel.Text = "结束页数";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(62, 8);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(74, 21);
            this.textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(62, 45);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(74, 21);
            this.textBox3.TabIndex = 3;
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
            this.taskStatus.ResumeLayout(false);
            this.inforPanel.ResumeLayout(false);
            this.inforPanel.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.urlPanel.ResumeLayout(false);
            this.urlPanel.PerformLayout();
            this.namePanel.ResumeLayout(false);
            this.namePanel.PerformLayout();
            this.savePanel.ResumeLayout(false);
            this.savePanel.PerformLayout();
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label endLabel;
        private System.Windows.Forms.Label beginLabel;
    }
}


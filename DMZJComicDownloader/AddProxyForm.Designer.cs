namespace DMZJComicDownloader
{
    partial class AddProxyForm
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.noProxyRadioButton = new System.Windows.Forms.RadioButton();
            this.autoDetectRadioButton = new System.Windows.Forms.RadioButton();
            this.useSysRadioButton = new System.Windows.Forms.RadioButton();
            this.userSettingRadioButton = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.httpProxyLabel = new System.Windows.Forms.Label();
            this.httpIPTextBox = new System.Windows.Forms.TextBox();
            this.httpPortLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.httpsPortTextBox = new System.Windows.Forms.TextBox();
            this.httpsPortLabel = new System.Windows.Forms.Label();
            this.httpsIPtextBox = new System.Windows.Forms.TextBox();
            this.httpsProxyLabel = new System.Windows.Forms.Label();
            this.socksPortTextBox = new System.Windows.Forms.TextBox();
            this.socksPortLabel = new System.Windows.Forms.Label();
            this.SocksIPtextBox = new System.Windows.Forms.TextBox();
            this.SocksLabel = new System.Windows.Forms.Label();
            this.saveProxySettingButton = new System.Windows.Forms.Button();
            this.cancelProxySettingButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(13, 13);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(161, 12);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "配置访问互联网的代理服务器";
            // 
            // noProxyRadioButton
            // 
            this.noProxyRadioButton.AutoSize = true;
            this.noProxyRadioButton.Location = new System.Drawing.Point(15, 38);
            this.noProxyRadioButton.Name = "noProxyRadioButton";
            this.noProxyRadioButton.Size = new System.Drawing.Size(119, 16);
            this.noProxyRadioButton.TabIndex = 1;
            this.noProxyRadioButton.TabStop = true;
            this.noProxyRadioButton.Text = "不使用代理服务器";
            this.noProxyRadioButton.UseVisualStyleBackColor = true;
            // 
            // autoDetectRadioButton
            // 
            this.autoDetectRadioButton.AutoSize = true;
            this.autoDetectRadioButton.Location = new System.Drawing.Point(15, 60);
            this.autoDetectRadioButton.Name = "autoDetectRadioButton";
            this.autoDetectRadioButton.Size = new System.Drawing.Size(167, 16);
            this.autoDetectRadioButton.TabIndex = 2;
            this.autoDetectRadioButton.TabStop = true;
            this.autoDetectRadioButton.Text = "自动检测此网络的代理设置";
            this.autoDetectRadioButton.UseVisualStyleBackColor = true;
            // 
            // useSysRadioButton
            // 
            this.useSysRadioButton.AutoSize = true;
            this.useSysRadioButton.Location = new System.Drawing.Point(15, 82);
            this.useSysRadioButton.Name = "useSysRadioButton";
            this.useSysRadioButton.Size = new System.Drawing.Size(119, 16);
            this.useSysRadioButton.TabIndex = 3;
            this.useSysRadioButton.TabStop = true;
            this.useSysRadioButton.Text = "使用系统代理设置";
            this.useSysRadioButton.UseVisualStyleBackColor = true;
            // 
            // userSettingRadioButton
            // 
            this.userSettingRadioButton.AutoSize = true;
            this.userSettingRadioButton.Location = new System.Drawing.Point(15, 104);
            this.userSettingRadioButton.Name = "userSettingRadioButton";
            this.userSettingRadioButton.Size = new System.Drawing.Size(95, 16);
            this.userSettingRadioButton.TabIndex = 4;
            this.userSettingRadioButton.TabStop = true;
            this.userSettingRadioButton.Text = "手动配置代理";
            this.userSettingRadioButton.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.socksPortTextBox);
            this.panel1.Controls.Add(this.socksPortLabel);
            this.panel1.Controls.Add(this.SocksIPtextBox);
            this.panel1.Controls.Add(this.SocksLabel);
            this.panel1.Controls.Add(this.httpsPortTextBox);
            this.panel1.Controls.Add(this.httpsPortLabel);
            this.panel1.Controls.Add(this.httpsIPtextBox);
            this.panel1.Controls.Add(this.httpsProxyLabel);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.httpPortLabel);
            this.panel1.Controls.Add(this.httpIPTextBox);
            this.panel1.Controls.Add(this.httpProxyLabel);
            this.panel1.Location = new System.Drawing.Point(35, 126);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(345, 120);
            this.panel1.TabIndex = 5;
            this.panel1.Visible = false;
            // 
            // httpProxyLabel
            // 
            this.httpProxyLabel.AutoSize = true;
            this.httpProxyLabel.Location = new System.Drawing.Point(3, 10);
            this.httpProxyLabel.Name = "httpProxyLabel";
            this.httpProxyLabel.Size = new System.Drawing.Size(53, 12);
            this.httpProxyLabel.TabIndex = 0;
            this.httpProxyLabel.Text = "HTTP代理";
            // 
            // httpIPTextBox
            // 
            this.httpIPTextBox.Location = new System.Drawing.Point(62, 3);
            this.httpIPTextBox.Name = "httpIPTextBox";
            this.httpIPTextBox.Size = new System.Drawing.Size(164, 21);
            this.httpIPTextBox.TabIndex = 1;
            // 
            // httpPortLabel
            // 
            this.httpPortLabel.AutoSize = true;
            this.httpPortLabel.Location = new System.Drawing.Point(232, 10);
            this.httpPortLabel.Name = "httpPortLabel";
            this.httpPortLabel.Size = new System.Drawing.Size(29, 12);
            this.httpPortLabel.TabIndex = 2;
            this.httpPortLabel.Text = "端口";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(267, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(58, 21);
            this.textBox1.TabIndex = 3;
            // 
            // httpsPortTextBox
            // 
            this.httpsPortTextBox.Location = new System.Drawing.Point(267, 41);
            this.httpsPortTextBox.Name = "httpsPortTextBox";
            this.httpsPortTextBox.Size = new System.Drawing.Size(58, 21);
            this.httpsPortTextBox.TabIndex = 7;
            // 
            // httpsPortLabel
            // 
            this.httpsPortLabel.AutoSize = true;
            this.httpsPortLabel.Location = new System.Drawing.Point(232, 48);
            this.httpsPortLabel.Name = "httpsPortLabel";
            this.httpsPortLabel.Size = new System.Drawing.Size(29, 12);
            this.httpsPortLabel.TabIndex = 6;
            this.httpsPortLabel.Text = "端口";
            // 
            // httpsIPtextBox
            // 
            this.httpsIPtextBox.Location = new System.Drawing.Point(62, 41);
            this.httpsIPtextBox.Name = "httpsIPtextBox";
            this.httpsIPtextBox.Size = new System.Drawing.Size(164, 21);
            this.httpsIPtextBox.TabIndex = 5;
            // 
            // httpsProxyLabel
            // 
            this.httpsProxyLabel.AutoSize = true;
            this.httpsProxyLabel.Location = new System.Drawing.Point(3, 48);
            this.httpsProxyLabel.Name = "httpsProxyLabel";
            this.httpsProxyLabel.Size = new System.Drawing.Size(59, 12);
            this.httpsProxyLabel.TabIndex = 4;
            this.httpsProxyLabel.Text = "HTTPS代理";
            // 
            // socksPortTextBox
            // 
            this.socksPortTextBox.Location = new System.Drawing.Point(267, 78);
            this.socksPortTextBox.Name = "socksPortTextBox";
            this.socksPortTextBox.Size = new System.Drawing.Size(58, 21);
            this.socksPortTextBox.TabIndex = 11;
            // 
            // socksPortLabel
            // 
            this.socksPortLabel.AutoSize = true;
            this.socksPortLabel.Location = new System.Drawing.Point(232, 85);
            this.socksPortLabel.Name = "socksPortLabel";
            this.socksPortLabel.Size = new System.Drawing.Size(29, 12);
            this.socksPortLabel.TabIndex = 10;
            this.socksPortLabel.Text = "端口";
            // 
            // SocksIPtextBox
            // 
            this.SocksIPtextBox.Location = new System.Drawing.Point(62, 78);
            this.SocksIPtextBox.Name = "SocksIPtextBox";
            this.SocksIPtextBox.Size = new System.Drawing.Size(164, 21);
            this.SocksIPtextBox.TabIndex = 9;
            // 
            // SocksLabel
            // 
            this.SocksLabel.AutoSize = true;
            this.SocksLabel.Location = new System.Drawing.Point(3, 85);
            this.SocksLabel.Name = "SocksLabel";
            this.SocksLabel.Size = new System.Drawing.Size(59, 12);
            this.SocksLabel.TabIndex = 8;
            this.SocksLabel.Text = "Socks代理";
            // 
            // saveProxySettingButton
            // 
            this.saveProxySettingButton.Location = new System.Drawing.Point(107, 254);
            this.saveProxySettingButton.Name = "saveProxySettingButton";
            this.saveProxySettingButton.Size = new System.Drawing.Size(75, 23);
            this.saveProxySettingButton.TabIndex = 6;
            this.saveProxySettingButton.Text = "确定";
            this.saveProxySettingButton.UseVisualStyleBackColor = true;
            // 
            // cancelProxySettingButton
            // 
            this.cancelProxySettingButton.Location = new System.Drawing.Point(205, 254);
            this.cancelProxySettingButton.Name = "cancelProxySettingButton";
            this.cancelProxySettingButton.Size = new System.Drawing.Size(75, 23);
            this.cancelProxySettingButton.TabIndex = 7;
            this.cancelProxySettingButton.Text = "取消";
            this.cancelProxySettingButton.UseVisualStyleBackColor = true;
            // 
            // AddProxyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 294);
            this.Controls.Add(this.cancelProxySettingButton);
            this.Controls.Add(this.saveProxySettingButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.userSettingRadioButton);
            this.Controls.Add(this.useSysRadioButton);
            this.Controls.Add(this.autoDetectRadioButton);
            this.Controls.Add(this.noProxyRadioButton);
            this.Controls.Add(this.titleLabel);
            this.Name = "AddProxyForm";
            this.Text = "AddProxyForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.RadioButton noProxyRadioButton;
        private System.Windows.Forms.RadioButton autoDetectRadioButton;
        private System.Windows.Forms.RadioButton useSysRadioButton;
        private System.Windows.Forms.RadioButton userSettingRadioButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox httpsPortTextBox;
        private System.Windows.Forms.Label httpsPortLabel;
        private System.Windows.Forms.TextBox httpsIPtextBox;
        private System.Windows.Forms.Label httpsProxyLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label httpPortLabel;
        private System.Windows.Forms.TextBox httpIPTextBox;
        private System.Windows.Forms.Label httpProxyLabel;
        private System.Windows.Forms.TextBox socksPortTextBox;
        private System.Windows.Forms.Label socksPortLabel;
        private System.Windows.Forms.TextBox SocksIPtextBox;
        private System.Windows.Forms.Label SocksLabel;
        private System.Windows.Forms.Button saveProxySettingButton;
        private System.Windows.Forms.Button cancelProxySettingButton;
    }
}
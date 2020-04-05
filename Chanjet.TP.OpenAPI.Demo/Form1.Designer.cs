namespace Chanjet.TP.OpenAPI.Demo
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtArgs = new System.Windows.Forms.TextBox();
            this.lstRestResourceMethod = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtResourceName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbEncoder = new System.Windows.Forms.CheckBox();
            this.btnPOST = new System.Windows.Forms.Button();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.textBoxOrgId = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPassWord = new System.Windows.Forms.TextBox();
            this.txtLoginDate = new System.Windows.Forms.TextBox();
            this.btnConnectTest = new System.Windows.Forms.Button();
            this.txtAccountNum = new System.Windows.Forms.TextBox();
            this.txtAppKey = new System.Windows.Forms.TextBox();
            this.btnGetToken = new System.Windows.Forms.Button();
            this.txtAppSecret = new System.Windows.Forms.TextBox();
            this.cmServerURL = new System.Windows.Forms.ComboBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnOthFeatures = new System.Windows.Forms.Button();
            this.btnV2LoginWithUserPwd = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lblPriKey = new System.Windows.Forms.Label();
            this.txtPriKeyPath = new System.Windows.Forms.TextBox();
            this.groupBox4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtArgs);
            this.groupBox4.Controls.Add(this.lstRestResourceMethod);
            this.groupBox4.Controls.Add(this.panel1);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox4.Location = new System.Drawing.Point(0, 155);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(1243, 478);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            // 
            // txtArgs
            // 
            this.txtArgs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtArgs.Location = new System.Drawing.Point(253, 62);
            this.txtArgs.Margin = new System.Windows.Forms.Padding(4);
            this.txtArgs.MaxLength = 32767000;
            this.txtArgs.Multiline = true;
            this.txtArgs.Name = "txtArgs";
            this.txtArgs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtArgs.Size = new System.Drawing.Size(986, 412);
            this.txtArgs.TabIndex = 13;
            this.txtArgs.TextChanged += new System.EventHandler(this.txtArgs_TextChanged);
            // 
            // lstRestResourceMethod
            // 
            this.lstRestResourceMethod.Dock = System.Windows.Forms.DockStyle.Left;
            this.lstRestResourceMethod.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lstRestResourceMethod.FormattingEnabled = true;
            this.lstRestResourceMethod.ItemHeight = 20;
            this.lstRestResourceMethod.Items.AddRange(new object[] {
            "8.2 基础信息接口",
            "  8.2.1 存货查询",
            "  8.2.2 品牌查询",
            "  8.2.3 自由项类型查询",
            "  8.2.4 自由项查询",
            "  8.2.5 仓库档案查询",
            "  8.2.6 条码对照查询",
            "  8.2.7 草稿查询",
            "8.3 供应链接口",
            "  8.3.1 销货单",
            "    8.3.1.1 创建",
            "    8.3.1.2 批量创建",
            "  8.3.2 其它出库单",
            "    8.3.2.1 创建",
            "    8.3.2.2 批量创建",
            "  8.3.3 现存量",
            "8.4 财务接口",
            "  8.4.1 凭证",
            "    8.4.1.1 创建",
            "    8.4.1.2 批量创建"});
            this.lstRestResourceMethod.Location = new System.Drawing.Point(4, 62);
            this.lstRestResourceMethod.Margin = new System.Windows.Forms.Padding(4);
            this.lstRestResourceMethod.Name = "lstRestResourceMethod";
            this.lstRestResourceMethod.Size = new System.Drawing.Size(249, 412);
            this.lstRestResourceMethod.TabIndex = 12;
            this.lstRestResourceMethod.SelectedIndexChanged += new System.EventHandler(this.lstRestResourceMethod_SelectedIndexChanged);
            this.lstRestResourceMethod.DoubleClick += new System.EventHandler(this.lstRestResourceMethod_DoubleClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtResourceName);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.cbEncoder);
            this.panel1.Controls.Add(this.btnPOST);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(4, 22);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1235, 40);
            this.panel1.TabIndex = 16;
            // 
            // txtResourceName
            // 
            this.txtResourceName.Location = new System.Drawing.Point(12, 8);
            this.txtResourceName.Margin = new System.Windows.Forms.Padding(4);
            this.txtResourceName.Name = "txtResourceName";
            this.txtResourceName.Size = new System.Drawing.Size(237, 25);
            this.txtResourceName.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(259, 11);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "参数：";
            // 
            // cbEncoder
            // 
            this.cbEncoder.AutoSize = true;
            this.cbEncoder.Location = new System.Drawing.Point(755, 12);
            this.cbEncoder.Margin = new System.Windows.Forms.Padding(4);
            this.cbEncoder.Name = "cbEncoder";
            this.cbEncoder.Size = new System.Drawing.Size(101, 19);
            this.cbEncoder.TabIndex = 14;
            this.cbEncoder.Text = "UrlEncode";
            this.cbEncoder.UseVisualStyleBackColor = true;
            this.cbEncoder.CheckedChanged += new System.EventHandler(this.cbEncoder_CheckedChanged);
            // 
            // btnPOST
            // 
            this.btnPOST.Location = new System.Drawing.Point(556, 4);
            this.btnPOST.Margin = new System.Windows.Forms.Padding(4);
            this.btnPOST.Name = "btnPOST";
            this.btnPOST.Size = new System.Drawing.Size(143, 31);
            this.btnPOST.TabIndex = 14;
            this.btnPOST.Text = "POST";
            this.btnPOST.UseVisualStyleBackColor = true;
            this.btnPOST.Click += new System.EventHandler(this.btnPOST_Click);
            // 
            // txtLog
            // 
            this.txtLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLog.Location = new System.Drawing.Point(0, 637);
            this.txtLog.Margin = new System.Windows.Forms.Padding(4);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLog.Size = new System.Drawing.Size(1243, 168);
            this.txtLog.TabIndex = 16;
            this.txtLog.Text = "请求/响应：";
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Location = new System.Drawing.Point(0, 633);
            this.splitter1.Margin = new System.Windows.Forms.Padding(4);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(1243, 4);
            this.splitter1.TabIndex = 20;
            this.splitter1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(302, 68);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "密码：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 68);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "用户名：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 112);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "OrgId：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(525, 68);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "账套号：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(493, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "服务器地址：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(752, 68);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 15);
            this.label8.TabIndex = 0;
            this.label8.Text = "日期：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(48, 21);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 15);
            this.label9.TabIndex = 0;
            this.label9.Text = "AppKey：";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(129, 64);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(4);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(124, 25);
            this.txtUserName.TabIndex = 5;
            this.txtUserName.Text = "demo";
            // 
            // textBoxOrgId
            // 
            this.textBoxOrgId.Location = new System.Drawing.Point(129, 108);
            this.textBoxOrgId.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxOrgId.Name = "textBoxOrgId";
            this.textBoxOrgId.Size = new System.Drawing.Size(124, 25);
            this.textBoxOrgId.TabIndex = 5;
            this.textBoxOrgId.Text = "90009444367";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(278, 21);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 15);
            this.label10.TabIndex = 1;
            this.label10.Text = "AppSecret：";
            // 
            // txtPassWord
            // 
            this.txtPassWord.Location = new System.Drawing.Point(365, 64);
            this.txtPassWord.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassWord.Name = "txtPassWord";
            this.txtPassWord.PasswordChar = '*';
            this.txtPassWord.Size = new System.Drawing.Size(96, 25);
            this.txtPassWord.TabIndex = 6;
            // 
            // txtLoginDate
            // 
            this.txtLoginDate.Location = new System.Drawing.Point(800, 64);
            this.txtLoginDate.Margin = new System.Windows.Forms.Padding(4);
            this.txtLoginDate.Name = "txtLoginDate";
            this.txtLoginDate.Size = new System.Drawing.Size(140, 25);
            this.txtLoginDate.TabIndex = 8;
            // 
            // btnConnectTest
            // 
            this.btnConnectTest.Location = new System.Drawing.Point(1082, 14);
            this.btnConnectTest.Margin = new System.Windows.Forms.Padding(4);
            this.btnConnectTest.Name = "btnConnectTest";
            this.btnConnectTest.Size = new System.Drawing.Size(93, 31);
            this.btnConnectTest.TabIndex = 4;
            this.btnConnectTest.Text = "连接测试";
            this.btnConnectTest.UseVisualStyleBackColor = true;
            this.btnConnectTest.Click += new System.EventHandler(this.btnConnectTest_Click);
            // 
            // txtAccountNum
            // 
            this.txtAccountNum.Location = new System.Drawing.Point(601, 64);
            this.txtAccountNum.Margin = new System.Windows.Forms.Padding(4);
            this.txtAccountNum.Name = "txtAccountNum";
            this.txtAccountNum.Size = new System.Drawing.Size(141, 25);
            this.txtAccountNum.TabIndex = 7;
            this.txtAccountNum.Text = "1";
            // 
            // txtAppKey
            // 
            this.txtAppKey.Location = new System.Drawing.Point(129, 18);
            this.txtAppKey.Margin = new System.Windows.Forms.Padding(4);
            this.txtAppKey.Name = "txtAppKey";
            this.txtAppKey.Size = new System.Drawing.Size(124, 25);
            this.txtAppKey.TabIndex = 1;
            this.txtAppKey.Text = "138750dc-aa1a-419a-8c92-7e1966fcd6fe";
            // 
            // btnGetToken
            // 
            this.btnGetToken.Location = new System.Drawing.Point(968, 59);
            this.btnGetToken.Margin = new System.Windows.Forms.Padding(4);
            this.btnGetToken.Name = "btnGetToken";
            this.btnGetToken.Size = new System.Drawing.Size(97, 31);
            this.btnGetToken.TabIndex = 9;
            this.btnGetToken.Text = "v1登录";
            this.btnGetToken.UseVisualStyleBackColor = true;
            this.btnGetToken.Click += new System.EventHandler(this.btnGetToken_Click);
            // 
            // txtAppSecret
            // 
            this.txtAppSecret.Location = new System.Drawing.Point(365, 18);
            this.txtAppSecret.Margin = new System.Windows.Forms.Padding(4);
            this.txtAppSecret.Name = "txtAppSecret";
            this.txtAppSecret.Size = new System.Drawing.Size(96, 25);
            this.txtAppSecret.TabIndex = 2;
            this.txtAppSecret.Text = "ifsapb";
            // 
            // cmServerURL
            // 
            this.cmServerURL.FormattingEnabled = true;
            this.cmServerURL.Items.AddRange(new object[] {
            "http://localhost:8080/TPlus/api/v2/",
            "http://127.0.0.1/TPlus/api/v1/",
            "http://demo.chanjet.com/TPlus116/api/v1/"});
            this.cmServerURL.Location = new System.Drawing.Point(601, 18);
            this.cmServerURL.Margin = new System.Windows.Forms.Padding(4);
            this.cmServerURL.Name = "cmServerURL";
            this.cmServerURL.Size = new System.Drawing.Size(436, 23);
            this.cmServerURL.TabIndex = 3;
            this.cmServerURL.Text = "http://localhost:8083/TPlus/api/v2/";
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(1082, 59);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(93, 31);
            this.btnLogout.TabIndex = 10;
            this.btnLogout.Text = "注销";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtPriKeyPath);
            this.groupBox2.Controls.Add(this.lblPriKey);
            this.groupBox2.Controls.Add(this.btnOthFeatures);
            this.groupBox2.Controls.Add(this.btnLogout);
            this.groupBox2.Controls.Add(this.cmServerURL);
            this.groupBox2.Controls.Add(this.txtAppSecret);
            this.groupBox2.Controls.Add(this.btnV2LoginWithUserPwd);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.btnGetToken);
            this.groupBox2.Controls.Add(this.txtAppKey);
            this.groupBox2.Controls.Add(this.txtAccountNum);
            this.groupBox2.Controls.Add(this.btnConnectTest);
            this.groupBox2.Controls.Add(this.txtLoginDate);
            this.groupBox2.Controls.Add(this.txtPassWord);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.textBoxOrgId);
            this.groupBox2.Controls.Add(this.txtUserName);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(1243, 155);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // btnOthFeatures
            // 
            this.btnOthFeatures.Location = new System.Drawing.Point(1082, 106);
            this.btnOthFeatures.Margin = new System.Windows.Forms.Padding(4);
            this.btnOthFeatures.Name = "btnOthFeatures";
            this.btnOthFeatures.Size = new System.Drawing.Size(93, 31);
            this.btnOthFeatures.TabIndex = 11;
            this.btnOthFeatures.Text = "其他功能";
            this.btnOthFeatures.UseVisualStyleBackColor = true;
            this.btnOthFeatures.Visible = false;
            this.btnOthFeatures.Click += new System.EventHandler(this.btnOthFeatures_Click);
            // 
            // btnV2LoginWithUserPwd
            // 
            this.btnV2LoginWithUserPwd.Location = new System.Drawing.Point(941, 107);
            this.btnV2LoginWithUserPwd.Margin = new System.Windows.Forms.Padding(4);
            this.btnV2LoginWithUserPwd.Name = "btnV2LoginWithUserPwd";
            this.btnV2LoginWithUserPwd.Size = new System.Drawing.Size(124, 31);
            this.btnV2LoginWithUserPwd.TabIndex = 9;
            this.btnV2LoginWithUserPwd.Text = "v2 用户名登录";
            this.btnV2LoginWithUserPwd.UseVisualStyleBackColor = true;
            this.btnV2LoginWithUserPwd.Click += new System.EventHandler(this.btnV2LoginWithUserPwd_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(316, 105);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 31);
            this.button1.TabIndex = 9;
            this.button1.Text = "v2 OrgId登录";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblPriKey
            // 
            this.lblPriKey.AutoSize = true;
            this.lblPriKey.Location = new System.Drawing.Point(509, 115);
            this.lblPriKey.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPriKey.Name = "lblPriKey";
            this.lblPriKey.Size = new System.Drawing.Size(82, 15);
            this.lblPriKey.TabIndex = 12;
            this.lblPriKey.Text = "私钥地址：";
            // 
            // txtPriKeyPath
            // 
            this.txtPriKeyPath.Location = new System.Drawing.Point(601, 111);
            this.txtPriKeyPath.Margin = new System.Windows.Forms.Padding(4);
            this.txtPriKeyPath.Name = "txtPriKeyPath";
            this.txtPriKeyPath.Size = new System.Drawing.Size(326, 25);
            this.txtPriKeyPath.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1243, 805);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "T+开放接口示例";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtArgs;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.Button btnPOST;
        private System.Windows.Forms.CheckBox cbEncoder;
        private System.Windows.Forms.ListBox lstRestResourceMethod;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.TextBox txtResourceName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox textBoxOrgId;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtPassWord;
        private System.Windows.Forms.TextBox txtLoginDate;
        private System.Windows.Forms.Button btnConnectTest;
        private System.Windows.Forms.TextBox txtAccountNum;
        private System.Windows.Forms.TextBox txtAppKey;
        private System.Windows.Forms.Button btnGetToken;
        private System.Windows.Forms.TextBox txtAppSecret;
        private System.Windows.Forms.ComboBox cmServerURL;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnOthFeatures;
        private System.Windows.Forms.Button btnV2LoginWithUserPwd;
        private System.Windows.Forms.TextBox txtPriKeyPath;
        private System.Windows.Forms.Label lblPriKey;
    }
}


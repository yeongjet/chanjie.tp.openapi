namespace Chanjet.TP.OpenAPI.Demo
{
    partial class OtherFuncForm
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOthFeatures = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.btnV2LoginWithUserPwd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(0, 242);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(639, 239);
            this.textBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "解析";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(83, 12);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(55, 21);
            this.textBox2.TabIndex = 2;
            this.textBox2.Text = "1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(154, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "次";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnOthFeatures
            // 
            this.btnOthFeatures.Location = new System.Drawing.Point(199, 45);
            this.btnOthFeatures.Name = "btnOthFeatures";
            this.btnOthFeatures.Size = new System.Drawing.Size(93, 23);
            this.btnOthFeatures.TabIndex = 1;
            this.btnOthFeatures.Text = "云上获取证书";
            this.btnOthFeatures.UseVisualStyleBackColor = true;
            this.btnOthFeatures.Click += new System.EventHandler(this.btnOthFeatures_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(12, 47);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(181, 21);
            this.textBox3.TabIndex = 2;
            this.textBox3.Text = "138750dc-aa1a-419a-8c92-7e1966fcd6fe";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(12, 74);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(55, 21);
            this.textBox4.TabIndex = 2;
            this.textBox4.Text = "1";
            // 
            // btnV2LoginWithUserPwd
            // 
            this.btnV2LoginWithUserPwd.Location = new System.Drawing.Point(83, 72);
            this.btnV2LoginWithUserPwd.Name = "btnV2LoginWithUserPwd";
            this.btnV2LoginWithUserPwd.Size = new System.Drawing.Size(60, 23);
            this.btnV2LoginWithUserPwd.TabIndex = 1;
            this.btnV2LoginWithUserPwd.Text = "RSA加密";
            this.btnV2LoginWithUserPwd.UseVisualStyleBackColor = true;
            this.btnV2LoginWithUserPwd.Click += new System.EventHandler(this.btnV2LoginWithUserPwd_Click);
            // 
            // OtherFuncForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 480);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.btnOthFeatures);
            this.Controls.Add(this.btnV2LoginWithUserPwd);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Name = "OtherFuncForm";
            this.Text = "其他功能";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOthFeatures;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button btnV2LoginWithUserPwd;
    }
}
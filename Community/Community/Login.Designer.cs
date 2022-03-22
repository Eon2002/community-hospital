namespace Community
{
    partial class Login
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
            this.lbl_Login = new System.Windows.Forms.Label();
            this.lbl_ifPhone = new System.Windows.Forms.Label();
            this.txb_Password = new System.Windows.Forms.TextBox();
            this.txb_Phone = new System.Windows.Forms.TextBox();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.lbl_Account = new System.Windows.Forms.Label();
            this.btn_Login = new System.Windows.Forms.Button();
            this.btn_SignUp = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_Login
            // 
            this.lbl_Login.AutoSize = true;
            this.lbl_Login.BackColor = System.Drawing.Color.LightBlue;
            this.lbl_Login.Font = new System.Drawing.Font("华文行楷", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_Login.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_Login.Location = new System.Drawing.Point(357, 113);
            this.lbl_Login.Name = "lbl_Login";
            this.lbl_Login.Size = new System.Drawing.Size(72, 32);
            this.lbl_Login.TabIndex = 14;
            this.lbl_Login.Text = "Login";
            // 
            // lbl_ifPhone
            // 
            this.lbl_ifPhone.AutoSize = true;
            this.lbl_ifPhone.Location = new System.Drawing.Point(542, 182);
            this.lbl_ifPhone.Name = "lbl_ifPhone";
            this.lbl_ifPhone.Size = new System.Drawing.Size(71, 15);
            this.lbl_ifPhone.TabIndex = 13;
            this.lbl_ifPhone.Text = "[lblMsg]";
            // 
            // txb_Password
            // 
            this.txb_Password.Location = new System.Drawing.Point(299, 238);
            this.txb_Password.Name = "txb_Password";
            this.txb_Password.Size = new System.Drawing.Size(211, 25);
            this.txb_Password.TabIndex = 12;
            // 
            // txb_Phone
            // 
            this.txb_Phone.Location = new System.Drawing.Point(299, 174);
            this.txb_Phone.Name = "txb_Phone";
            this.txb_Phone.Size = new System.Drawing.Size(211, 25);
            this.txb_Phone.TabIndex = 11;
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.BackColor = System.Drawing.Color.LightBlue;
            this.lbl_Password.Font = new System.Drawing.Font("华文行楷", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_Password.ForeColor = System.Drawing.Color.Black;
            this.lbl_Password.Location = new System.Drawing.Point(176, 238);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(97, 29);
            this.lbl_Password.TabIndex = 10;
            this.lbl_Password.Text = "密码：";
            // 
            // lbl_Account
            // 
            this.lbl_Account.AutoSize = true;
            this.lbl_Account.BackColor = System.Drawing.Color.LightBlue;
            this.lbl_Account.Font = new System.Drawing.Font("华文行楷", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_Account.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_Account.Location = new System.Drawing.Point(176, 174);
            this.lbl_Account.Name = "lbl_Account";
            this.lbl_Account.Size = new System.Drawing.Size(97, 29);
            this.lbl_Account.TabIndex = 9;
            this.lbl_Account.Text = "账号：";
            this.lbl_Account.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Login
            // 
            this.btn_Login.BackColor = System.Drawing.Color.LightCyan;
            this.btn_Login.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Login.Location = new System.Drawing.Point(299, 298);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(88, 33);
            this.btn_Login.TabIndex = 8;
            this.btn_Login.Text = "登录";
            this.btn_Login.UseVisualStyleBackColor = false;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // btn_SignUp
            // 
            this.btn_SignUp.BackColor = System.Drawing.Color.LightCyan;
            this.btn_SignUp.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_SignUp.Location = new System.Drawing.Point(404, 298);
            this.btn_SignUp.Name = "btn_SignUp";
            this.btn_SignUp.Size = new System.Drawing.Size(88, 33);
            this.btn_SignUp.TabIndex = 15;
            this.btn_SignUp.Text = "注册";
            this.btn_SignUp.UseVisualStyleBackColor = false;
            this.btn_SignUp.Click += new System.EventHandler(this.btn_SignUp_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Image = global::Community.Properties.Resources.login;
            this.label1.Location = new System.Drawing.Point(296, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 15);
            this.label1.TabIndex = 16;
            this.label1.Text = "请输入电话号码";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Community.Properties.Resources.login;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_SignUp);
            this.Controls.Add(this.lbl_Login);
            this.Controls.Add(this.lbl_ifPhone);
            this.Controls.Add(this.txb_Password);
            this.Controls.Add(this.txb_Phone);
            this.Controls.Add(this.lbl_Password);
            this.Controls.Add(this.lbl_Account);
            this.Controls.Add(this.btn_Login);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Login;
        private System.Windows.Forms.Label lbl_ifPhone;
        private System.Windows.Forms.TextBox txb_Password;
        private System.Windows.Forms.TextBox txb_Phone;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.Label lbl_Account;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.Button btn_SignUp;
        private System.Windows.Forms.Label label1;
    }
}
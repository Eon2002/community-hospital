namespace Community
{
    partial class SignUp
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
            this.btn_SignUp = new System.Windows.Forms.Button();
            this.lbl_Phone = new System.Windows.Forms.Label();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.txb_Phone = new System.Windows.Forms.TextBox();
            this.txb_Password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_Tip = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_SignUp
            // 
            this.btn_SignUp.BackColor = System.Drawing.SystemColors.Info;
            this.btn_SignUp.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_SignUp.Location = new System.Drawing.Point(354, 243);
            this.btn_SignUp.Name = "btn_SignUp";
            this.btn_SignUp.Size = new System.Drawing.Size(88, 33);
            this.btn_SignUp.TabIndex = 0;
            this.btn_SignUp.Text = "注册";
            this.btn_SignUp.UseVisualStyleBackColor = false;
            this.btn_SignUp.Click += new System.EventHandler(this.btn_SignUp_Click);
            // 
            // lbl_Phone
            // 
            this.lbl_Phone.AutoSize = true;
            this.lbl_Phone.BackColor = System.Drawing.Color.LavenderBlush;
            this.lbl_Phone.Font = new System.Drawing.Font("华文行楷", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_Phone.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_Phone.Location = new System.Drawing.Point(168, 112);
            this.lbl_Phone.Name = "lbl_Phone";
            this.lbl_Phone.Size = new System.Drawing.Size(97, 29);
            this.lbl_Phone.TabIndex = 2;
            this.lbl_Phone.Text = "电话：";
            this.lbl_Phone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_Phone.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.BackColor = System.Drawing.Color.LavenderBlush;
            this.lbl_Password.Font = new System.Drawing.Font("华文行楷", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_Password.ForeColor = System.Drawing.Color.Black;
            this.lbl_Password.Location = new System.Drawing.Point(168, 176);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(97, 29);
            this.lbl_Password.TabIndex = 3;
            this.lbl_Password.Text = "密码：";
            // 
            // txb_Phone
            // 
            this.txb_Phone.Location = new System.Drawing.Point(291, 112);
            this.txb_Phone.Name = "txb_Phone";
            this.txb_Phone.Size = new System.Drawing.Size(211, 25);
            this.txb_Phone.TabIndex = 4;
            this.txb_Phone.TextChanged += new System.EventHandler(this.txb_Phone_TextChanged);
            // 
            // txb_Password
            // 
            this.txb_Password.Location = new System.Drawing.Point(291, 176);
            this.txb_Password.Name = "txb_Password";
            this.txb_Password.Size = new System.Drawing.Size(211, 25);
            this.txb_Password.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LavenderBlush;
            this.label1.Font = new System.Drawing.Font("华文行楷", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(349, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 32);
            this.label1.TabIndex = 7;
            this.label1.Text = "SignUp";
            // 
            // lbl_Tip
            // 
            this.lbl_Tip.AutoSize = true;
            this.lbl_Tip.Location = new System.Drawing.Point(564, 115);
            this.lbl_Tip.Name = "lbl_Tip";
            this.lbl_Tip.Size = new System.Drawing.Size(71, 15);
            this.lbl_Tip.TabIndex = 8;
            this.lbl_Tip.Text = "[lblMsg]";
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Community.Properties.Resources._1;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_Tip);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txb_Password);
            this.Controls.Add(this.txb_Phone);
            this.Controls.Add(this.lbl_Password);
            this.Controls.Add(this.lbl_Phone);
            this.Controls.Add(this.btn_SignUp);
            this.Name = "SignUp";
            this.Text = "注册";
            this.Load += new System.EventHandler(this.SignUp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_SignUp;
        private System.Windows.Forms.Label lbl_Phone;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.TextBox txb_Phone;
        private System.Windows.Forms.TextBox txb_Password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_Tip;
    }
}
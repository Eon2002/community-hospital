namespace Community
{
    partial class Card
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
            this.lbl_Card = new System.Windows.Forms.Label();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.txb_Name = new System.Windows.Forms.TextBox();
            this.lbl_Gender = new System.Windows.Forms.Label();
            this.rdb_Man = new System.Windows.Forms.RadioButton();
            this.rdb_Woman = new System.Windows.Forms.RadioButton();
            this.lbl_Phone = new System.Windows.Forms.Label();
            this.txb_Phone = new System.Windows.Forms.TextBox();
            this.lbl_Address = new System.Windows.Forms.Label();
            this.txb_Address = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_Card
            // 
            this.lbl_Card.AutoSize = true;
            this.lbl_Card.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_Card.Font = new System.Drawing.Font("华文行楷", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_Card.Location = new System.Drawing.Point(312, 9);
            this.lbl_Card.Name = "lbl_Card";
            this.lbl_Card.Size = new System.Drawing.Size(128, 39);
            this.lbl_Card.TabIndex = 0;
            this.lbl_Card.Text = "就诊卡";
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Font = new System.Drawing.Font("楷体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_Name.Location = new System.Drawing.Point(157, 81);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(90, 25);
            this.lbl_Name.TabIndex = 1;
            this.lbl_Name.Text = "姓名：";
            this.lbl_Name.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lbl_Name.UseMnemonic = false;
            // 
            // txb_Name
            // 
            this.txb_Name.Location = new System.Drawing.Point(253, 81);
            this.txb_Name.Name = "txb_Name";
            this.txb_Name.Size = new System.Drawing.Size(245, 25);
            this.txb_Name.TabIndex = 2;
            this.txb_Name.TextChanged += new System.EventHandler(this.txb_Name_TextChanged);
            // 
            // lbl_Gender
            // 
            this.lbl_Gender.AutoSize = true;
            this.lbl_Gender.Font = new System.Drawing.Font("楷体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_Gender.Location = new System.Drawing.Point(157, 144);
            this.lbl_Gender.Name = "lbl_Gender";
            this.lbl_Gender.Size = new System.Drawing.Size(90, 25);
            this.lbl_Gender.TabIndex = 3;
            this.lbl_Gender.Text = "性别：";
            this.lbl_Gender.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lbl_Gender.UseMnemonic = false;
            // 
            // rdb_Man
            // 
            this.rdb_Man.AutoSize = true;
            this.rdb_Man.Font = new System.Drawing.Font("楷体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rdb_Man.Location = new System.Drawing.Point(253, 140);
            this.rdb_Man.Name = "rdb_Man";
            this.rdb_Man.Size = new System.Drawing.Size(59, 29);
            this.rdb_Man.TabIndex = 4;
            this.rdb_Man.TabStop = true;
            this.rdb_Man.Text = "男";
            this.rdb_Man.UseVisualStyleBackColor = true;
            // 
            // rdb_Woman
            // 
            this.rdb_Woman.AutoSize = true;
            this.rdb_Woman.Font = new System.Drawing.Font("楷体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rdb_Woman.Location = new System.Drawing.Point(348, 140);
            this.rdb_Woman.Name = "rdb_Woman";
            this.rdb_Woman.Size = new System.Drawing.Size(59, 29);
            this.rdb_Woman.TabIndex = 5;
            this.rdb_Woman.TabStop = true;
            this.rdb_Woman.Text = "女";
            this.rdb_Woman.UseVisualStyleBackColor = true;
            // 
            // lbl_Phone
            // 
            this.lbl_Phone.AutoSize = true;
            this.lbl_Phone.Font = new System.Drawing.Font("楷体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_Phone.Location = new System.Drawing.Point(159, 209);
            this.lbl_Phone.Name = "lbl_Phone";
            this.lbl_Phone.Size = new System.Drawing.Size(90, 25);
            this.lbl_Phone.TabIndex = 6;
            this.lbl_Phone.Text = "电话：";
            // 
            // txb_Phone
            // 
            this.txb_Phone.Location = new System.Drawing.Point(253, 209);
            this.txb_Phone.Name = "txb_Phone";
            this.txb_Phone.Size = new System.Drawing.Size(245, 25);
            this.txb_Phone.TabIndex = 7;
            // 
            // lbl_Address
            // 
            this.lbl_Address.AutoSize = true;
            this.lbl_Address.Font = new System.Drawing.Font("楷体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_Address.Location = new System.Drawing.Point(161, 278);
            this.lbl_Address.Name = "lbl_Address";
            this.lbl_Address.Size = new System.Drawing.Size(90, 25);
            this.lbl_Address.TabIndex = 8;
            this.lbl_Address.Text = "地址：";
            // 
            // txb_Address
            // 
            this.txb_Address.Location = new System.Drawing.Point(253, 277);
            this.txb_Address.Name = "txb_Address";
            this.txb_Address.Size = new System.Drawing.Size(245, 25);
            this.txb_Address.TabIndex = 9;
            // 
            // Card
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Community.Properties.Resources.背景;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txb_Address);
            this.Controls.Add(this.lbl_Address);
            this.Controls.Add(this.txb_Phone);
            this.Controls.Add(this.lbl_Phone);
            this.Controls.Add(this.rdb_Woman);
            this.Controls.Add(this.rdb_Man);
            this.Controls.Add(this.lbl_Gender);
            this.Controls.Add(this.txb_Name);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.lbl_Card);
            this.Name = "Card";
            this.Text = "Card";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Card;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.TextBox txb_Name;
        private System.Windows.Forms.Label lbl_Gender;
        private System.Windows.Forms.RadioButton rdb_Man;
        private System.Windows.Forms.RadioButton rdb_Woman;
        private System.Windows.Forms.Label lbl_Phone;
        private System.Windows.Forms.TextBox txb_Phone;
        private System.Windows.Forms.Label lbl_Address;
        private System.Windows.Forms.TextBox txb_Address;
    }
}
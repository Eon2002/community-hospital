using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Community
{
    public partial class Homepage : Form
    {
        public string userId;
        public Homepage()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;                //本窗体启动位置设为屏幕中央； 
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            if(this.userId ==null)
            {
            Login login = new Login();
            login.ShowDialog();
            }
            else
            {
                Login login = new Login();
                login.ShowDialog();
            }

        }

        private void Homepage_Load(object sender, EventArgs e)
        {
            if(this.userId !=null )
            {
                this.lbl_Welcome.Text = "您好, " + this.userId;
                this.btn_Login.Text = "退出";
            }
        }

        private void 就诊卡ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Card card = new Card();
            card.ShowDialog();
        }
    }
}

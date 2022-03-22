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
    public partial class Card : Form
    {
        public string userId;
        public Card()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;                //本窗体启动位置设为屏幕中央； 
        }

        private void txb_Name_TextChanged(object sender, EventArgs e)
        {
            this.txb_Name.Text = userId;
        }
    }
}

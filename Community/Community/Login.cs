using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Community
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;                //本窗体启动位置设为屏幕中央； 
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection();                  //声明并实例化SQL连接；
            sqlConnection.ConnectionString =
                "Server=(Local);Database=Community;Integrated Security=sspi";
            SqlCommand sqlCommand = sqlConnection.CreateCommand();                                      //调用SQL连接的方法CreateCommand来创建SQL命令；该命令将绑定SQL连接；
            sqlCommand.CommandText =
                "SELECT COUNT(1) FROM tb_Patient WHERE Phone=@Phone AND Password=HASHBYTES('MD5',@Password);";   //指定SQL命令的命令文本；命令文本包含参数； 
            #region SQL参数用法1
            SqlParameter sqlParameter = new SqlParameter();                                             //声明并实例化SQL参数；
            sqlParameter.ParameterName = "@Phone";                                                         //设置SQL参数的名称；
            sqlParameter.Value = this.txb_Phone.Text.Trim();                                           //设置SQL参数的长度；
            sqlParameter.SqlDbType = SqlDbType.Char;                                                    //设置SQL参数对应的SQL Server数据类型；
            sqlParameter.Size = 10;                                                                     //设置SQL参数的长度；
            sqlCommand.Parameters.Add(sqlParameter);                                                    //向SQL命令的参数集合添加SQL参数；
            #endregion
            #region SQL参数用法2
            sqlCommand.Parameters.AddWithValue("@Password", this.txb_Password.Text.Trim());             //直接调用方法AddWithValue向SQL命令的参数集合添加参数的名称、值；SQL参数能自动识别类型，但若SQL参数被用作某函数的输入参数，则使用函数定义的参数类型作为SQL参数类型；
            sqlCommand.Parameters["@Password"].SqlDbType = SqlDbType.VarChar;                           //通过参数名称访问SQL参数，并将密码参数的类型设为变长字符串；由于HASHBYTES函数的参数为NVARCHAR，则SQL参数类型自动设为NVARCHAR；对于相同密码，VARCHAR/NVARCHAR类型所获得的散列值不同，故需手动将SQL参数类型统一设为VARCHAR;
            #endregion
            sqlConnection.Open();                                                                       //打开SQL连接；
            int rowCount = (int)sqlCommand.ExecuteScalar();
            sqlConnection.Close();
            if (rowCount == 1)                                                              //若查得所输用户号相应的1行记录；
            {
                MessageBox.Show("登录成功。");
                Card card = new Card();
                card.userId = "Select Name From tb_Patient WHERE Phone=@Phone";//传递当前用户名
                card.Show();                           //显示对象窗口
                Homepage homepage = new Homepage();
                homepage.userId = "Select Name From tb_Patient WHERE Phone=@Phone";//传递当前用户名
                homepage.Show();                           //显示对象窗口
                homepage.ShowDialog();
            }
            else                                                                            //否则；
            {
                MessageBox.Show("用户号/密码有误，请重新输入！");								//给出错误提示；
                this.txb_Password.Focus();                                                  //密码文本框获得焦点；
                this.txb_Password.SelectAll();                                              //密码文本框内所有文本被选中；
            }
        }

        private void btn_SignUp_Click(object sender, EventArgs e)
        {
            SignUp signUpForm = new SignUp();
            signUpForm.ShowDialog();
            
        }
    }
}

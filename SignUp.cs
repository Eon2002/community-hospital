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
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;                //本窗体启动位置设为屏幕中央； 
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SignUp_Load(object sender, EventArgs e)
        {

        }

        private void btn_SignUp_Click(object sender, EventArgs e)
        {
            if (this.txb_Phone.Text.Trim() == "")                                                      //若用户号文本框为空；
            {
                MessageBox.Show("用户号不能为空！");														//给出错误提示；
                this.txb_Phone.Focus();                                                                //用户号文本框获得焦点；
                return;                                                                                 //返回；
            }
            if (this.txb_Password.Text.Trim() == "")                                                    //若密码文本框为空；
            {
                MessageBox.Show("密码不能为空！");														//给出错误提示；
                this.txb_Password.Focus();                                                              //密码文本框获得焦点；
                return;
            }
                SqlConnection sqlConnection = new SqlConnection();                  //声明并实例化SQL连接；
            sqlConnection.ConnectionString =
                "Server=(Local);Database=Community;Integrated Security=sspi";
            SqlCommand sqlCommand = sqlConnection.CreateCommand();                                      //调用SQL连接的方法CreateCommand来创建SQL命令；该命令将绑定SQL连接；
            sqlCommand.CommandText =
                "INSERT tb_Patient (Phone,Password) VALUES(@Phone,HASHBYTES('MD5',@Password));";                 //指定SQL命令的命令文本；命令文本包含参数；
            sqlCommand.Parameters.AddWithValue("@Phone", this.txb_Phone.Text.Trim());                     //向SQL命令的参数集合添加参数的名称、值；
            sqlCommand.Parameters.AddWithValue("@Password", this.txb_Password.Text.Trim());
            sqlCommand.Parameters["@Password"].SqlDbType = SqlDbType.VarChar;                           //将密码参数的类型设为变长字符串；
            int rowAffected = 0;                                                                        //声明整型变量，用于保存受影响行数；
            try                                                                                         //尝试；
            {
                sqlConnection.Open();                                                                   //打开SQL连接；
                rowAffected = sqlCommand.ExecuteNonQuery();                                             //调用SQL命令的方法ExecuteNonQuery来执行命令，向数据库写入数据，并返回受影响行数；
            }
            catch (SqlException sqlEx)                                                                  //捕捉SQL异常；
            {
                if (sqlEx.Number == 2627)                                                               //若SQL异常编号为2627，则违反主键/唯一约束，即插入重复值；
                {
                    MessageBox.Show("您注册的用户号已存在，请重新输入！\n");								//给出适当的错误提示；
                }
                else
                {
                    MessageBox.Show("注册失败。请联系管理员！");
                }
            }
            finally                                                                                     //结束；
            {
                sqlConnection.Close();                                                                  //关闭SQL连接；
            }                                                                      //关闭SQL连接；
            if (rowAffected == 1)                                                                       //若成功写入1行记录；
            {
                MessageBox.Show("注册成功。");															//给出正确提示；
                Login login = new Login();
                login.ShowDialog();
            }
            else                                                                                        //否则；
            {
                MessageBox.Show("注册失败！");															//给出错误提示；
            }
        }

        private void txb_Phone_TextChanged(object sender, EventArgs e)
        {
            if (this.txb_Phone.Text.Length !=11)
            {
                this.lbl_Tip.Text = "电话未满/超出11位！请重新输入！";
                this.txb_Phone.Focus();
            }
            else
            {
                this.lbl_Tip.Text = "√";
            }
        }
    }
}

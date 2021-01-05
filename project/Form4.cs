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
using System.IO;
using System.Security.Principal;
using System.Collections;

namespace project
{
    public partial class Form4 : Form
    {

        SqlConnectionStringBuilder scsb;

        string myDBConnectionString = "";
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @".";
            scsb.InitialCatalog = "James";
            scsb.IntegratedSecurity = true;

            myDBConnectionString = scsb.ToString();

            cbclass();
        }
        private void cbclass()
        {
            SqlConnection con = new SqlConnection(myDBConnectionString);
            con.Open();
            SqlCommand cod = new SqlCommand("select class from class", con);
            SqlDataReader reader = cod.ExecuteReader();
            DataTable mydatatable = new DataTable();
            mydatatable.Load(reader);
            cboxclass.DataSource = mydatatable;
            cboxclass.DisplayMember = "class";
            reader.Close();
            con.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string account = txtname.Text;
            string password = txtpassword.Text;




            SqlConnection con = new SqlConnection(myDBConnectionString);
            con.Open();
            // string tSQL = "select * from student where name in ('" + account + "') and password in ('" + password + "')";
            string tSQL = "select * from Tstudent where name=@name and password=@password ";
            SqlCommand cmd = new SqlCommand(tSQL, con);
            cmd.Parameters.AddWithValue("@name", txtname.Text);
            cmd.Parameters.AddWithValue("@password", txtpassword.Text);
            //cmd.Parameters.AddWithValue("@class", cboxclass.Text);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                if ((bool)reader["daily"] == true)
                {
                    if ((bool)reader["admin"] == true)
                    {
                        MessageBox.Show("歡迎管理員登入");
                       
                    }
                    else
                    {
                        MessageBox.Show("歡迎值日生登入");
                    }


                }
                else
                {
                     MessageBox.Show("歡迎" + (string)reader["name"].ToString() + "登入");
                }


                //SqlDataAdapter adp = new SqlDataAdapter(cmd); 
                //DataSet da = new DataSet(); 
                //adp.Fill(da, "info"); 
                //DataTable table = da.Tables["grade"];

                ArrayList login = new ArrayList();
                login.Add((string)reader["name"]);
                login.Add((string)reader["password"]);
                login.Add((string)reader["class"]);
                login.Add((bool)reader["daily"]);
                login.Add((bool)reader["admin"]);

                GlobalVar.Log.Add(login);
                this.Hide();
                Form1 f1 = new Form1();
                f1.ShowDialog();
               // this.Show();

                //GlobalVar.list訂購單品項列表.Add(訂購單資訊);
            }
            else
            {
                MessageBox.Show("請註冊");
            }

            reader.Close();
            con.Close();

            //this.Hide();
            //Form1 f1 = new Form1();
            //f1.ShowDialog();
            //this.Show();


        }

        private void btnregister_Click(object sender, EventArgs e)
        {

            if (txtname.Text != "" && txtpassword.Text != "")
            {
                SqlConnection con = new SqlConnection(myDBConnectionString);
                con.Open();
                string tSQL = "INSERT INTO [Tstudent] (name,class,password,daily,admin) VALUES (@Nname,@Nclass,@Npassword,@Ndaily,@Nadmin) ";
                SqlCommand cmd = new SqlCommand(tSQL, con);
                cmd.Parameters.AddWithValue("@Nname", txtname.Text);
                cmd.Parameters.AddWithValue("@Nclass", cboxclass.Text);
                cmd.Parameters.AddWithValue("@Npassword", txtpassword.Text);
                cmd.Parameters.AddWithValue("@Ndaily", 0);
                cmd.Parameters.AddWithValue("@Nadmin", 0);
                //cmd.Parameters.AddWithValue("@Npassword", txtpassword.Text);
                int rows = cmd.ExecuteNonQuery(); //執行不查詢(不會回傳資料 只會回傳受影響資料筆數) 新增 刪除 修改都不會回傳資料 只有select會

                con.Dispose();
                con.Close();
                MessageBox.Show("已加入個人資料");
                MessageBox.Show("請重新登入");
                txtname.Clear();
                txtpassword.Clear();
            }
            else
            {
                MessageBox.Show("資料不可留空");
            }
        }
    }
}
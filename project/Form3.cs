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
using System.Collections;

namespace project
{
    public partial class Form3 : Form
    {

        SqlConnectionStringBuilder scsb;

        string myDBConnectionString = "";
        List<int> SearchIDs = new List<int>();
        

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @".";
            scsb.InitialCatalog = "James";
            scsb.IntegratedSecurity = true;

            myDBConnectionString = scsb.ToString();
            cbclass();
           cboxclass.SelectedIndex = 0;
            //lboxname.SelectedIndex = 0;


            if (GlobalVar.Log.Count > 0)
            {
                foreach (ArrayList login in GlobalVar.Log)
                {
                    string name = (string)login[0];
                    string password = (string)login[1];
                    string sclass = (string)login[2];
                    bool daily = (bool)login[3];
                    bool admin = (bool)login[4];



                    if ((bool)login[4] == true)
                    {
                        menuStrip1.Visible = true;
                    }
                    else
                    {
                        menuStrip1.Visible = false;
                    }

                }


            }
        }
        private void cbclass()
        {
            SqlConnection con = new SqlConnection(myDBConnectionString);
            con.Open();
            SqlCommand cod = new SqlCommand("select  class from class", con);
            SqlDataReader reader = cod.ExecuteReader();
            DataTable mydatatable = new DataTable();
            mydatatable.Load(reader);
            cboxclass.DataSource = mydatatable;
            cboxclass.DisplayMember = "class";
            reader.Close();
            con.Close();

        }
        private void cboxclass_SelectedIndexChanged(object sender, EventArgs e)
        {
            lboxname.Items.Clear();
            SqlConnection con = new SqlConnection(myDBConnectionString);
            con.Open();
            string tSQL = "select * from [Tstudent] where [class] = @class";
            SqlCommand cmd = new SqlCommand(tSQL, con);
            cmd.Parameters.AddWithValue("@class", cboxclass.Text);
            SqlDataReader reader = cmd.ExecuteReader();
            //int i = 0;

            while (reader.Read())
            {
                lboxname.Items.Add((int)reader["s_id"]+"  "+(string)reader["class"]+"班  "+(string)reader["name"]);
               SearchIDs.Add((int)reader["s_id"]);
            }
            reader.Close();
            con.Close();
        }

        private void btn新增_Click(object sender, EventArgs e)
        {
            if ((txtaccount.Text != "") )
            {
                SqlConnection con = new SqlConnection(myDBConnectionString);
                con.Open();
                string tSQL = "insert into [Tstudent](name,class,password,class_id,daily,admin) values (@NewName,@NewClass,@NewPassword,@NewClassid,@Ndaily,@Nadmin)";
                SqlCommand cmd = new SqlCommand(tSQL, con);
                cmd.Parameters.AddWithValue("@NewName", txtaccount.Text);
                cmd.Parameters.AddWithValue("@NewPassword", txtpassword.Text);
                cmd.Parameters.AddWithValue("@NewClass", cboxclass.Text);
               cmd.Parameters.AddWithValue("@NewClassid", (int)cboxclass.SelectedIndex);
                cmd.Parameters.AddWithValue("@Ndaily", 0);
                cmd.Parameters.AddWithValue("@Nadmin", 0);

                int rows = cmd.ExecuteNonQuery();
             
                MessageBox.Show(rows.ToString() + "個資料列受到影響");
                
                con.Close();
                
                cboxclass.SelectedIndex = 0;
            }
            else
            {
                MessageBox.Show("請填入姓名, Email");
            }

            txtaccount.Clear();
           
            txtpassword.Clear();
            lboxname.Items.Clear();

            cboxclass.SelectedIndex = 0;
        }
    

      

        private void btnlogin_Click(object sender, EventArgs e)
        {
            txtaccount.Clear();
            txtid.Clear();
           
            txtpassword.Clear();
        }

        private void btn儲存修改_Click(object sender, EventArgs e)
        {
            int intID = 0;
            Int32.TryParse(txtid.Text, out intID);

            if (intID > 0)
            {
                SqlConnection con = new SqlConnection(myDBConnectionString);
                con.Open();
                string tSQL = "update [Tstudent] set name=@NewName,class=@NewClass,password=@NewPassword,daily=@Ndaily,admin=@Nadmin where s_id=@id";
                   
                SqlCommand cmd = new SqlCommand(tSQL, con);
                cmd.Parameters.AddWithValue("@id", intID);
                cmd.Parameters.AddWithValue("@NewName", txtaccount.Text);
                cmd.Parameters.AddWithValue("@NewPassword", txtpassword.Text);
                cmd.Parameters.AddWithValue("@NewClass", cboxclass.Text);
              //  cmd.Parameters.AddWithValue("@NewClassid", (int)cboxclass.SelectedIndex);
                cmd.Parameters.AddWithValue("@Ndaily", 0);
                cmd.Parameters.AddWithValue("@Nadmin", 0);


                int rows = cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show(rows.ToString() + "個資料列受到影響");
            }
            lboxname.Items.Clear();
            txtaccount.Clear();
            txtid.Clear();
           
            txtpassword.Clear();
            cboxclass.SelectedIndex = 0;
        }

        private void lboxname_SelectedIndexChanged(object sender, EventArgs e)
        {


              int intID = SearchIDs[lboxname.SelectedIndex];
           

            SqlConnection con = new SqlConnection(myDBConnectionString);
                con.Open();
                string tSQL = "select * from [Tstudent] where [s_id] = @id";
                SqlCommand cmd = new SqlCommand(tSQL, con);
            cmd.Parameters.AddWithValue("@id",intID);
                SqlDataReader reader = cmd.ExecuteReader();
                //int i = 0;

                if (reader.Read())
                {
                    txtaccount.Text = (string)reader["name"];
                    txtpassword.Text = (string)reader["password"];
                    
                    txtid.Text = reader["s_id"].ToString();
                //SearchIDs.Add((int)reader["s_id"]);
            }
                reader.Close();
                con.Close(); 
        }

        private void btn刪除_Click(object sender, EventArgs e)
        {

            //int intID = 0;
            //Int32.TryParse(txtid.Text, out intID);
            if (lboxname.SelectedIndex > -1)
            {
                int intID = SearchIDs[lboxname.SelectedIndex];

                SqlConnection con = new SqlConnection(myDBConnectionString);
                con.Open();
                string tSQL = "delete from [Tstudent] where [s_id] = @id";
                SqlCommand cmd = new SqlCommand(tSQL, con);
                cmd.Parameters.AddWithValue("@id", intID);
                SqlDataReader reader = cmd.ExecuteReader();
                // int rows = cmd.ExecuteNonQuery();
                //while (lboxname.SelectedItem != null)
                //{ lboxname.Items.Remove(lboxname.SelectedIndex); }
                // SearchIDs.RemoveAt(lboxname.SelectedIndex);
                reader.Close();
                con.Close();
                lboxname.Items.Clear();
                txtaccount.Clear();
                txtid.Clear();
               
                txtpassword.Clear();
                cboxclass.SelectedIndex = 0;
            }

        }

        private void 離開toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            //Form4 f4 = new Form4();
            //f4.ShowDialog();
              Application.Exit();
        }

        private void 學生資料toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 f3 = new Form3();
            f3.ShowDialog();
        }

        private void 菜單toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 f5 = new Form5();
            f5.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 f4 = new Form4();
            f4.ShowDialog();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
        }
    }
}

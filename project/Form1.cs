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
using System.Diagnostics.Eventing.Reader;

namespace project
{
    public partial class Form1 : Form
    {

        SqlConnectionStringBuilder scsb;
        List<int> SearchIDs = new List<int>();
        string myDBConnectionString = "";
        public int productID = 0;
        string image_dir = @"images\";
        string image_name = "";
        int 單價;
        int 數量;
        int 總價;
        
        string 品項;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @".";
            scsb.InitialCatalog = "James";
            scsb.IntegratedSecurity = true;

            myDBConnectionString = scsb.ToString();
            cboxC();
            cboxR();
          
            cboxClass.SelectedIndex = 0;
       
            cboxRestaurant.SelectedIndex = 0;
            
            數量 = 1;
            txtQuantity.Text = 數量.ToString();
            lboxMenu.SelectedIndex = 0;

            if (GlobalVar.Log.Count>0)
            {
                foreach (ArrayList login in GlobalVar.Log)
                {
                    string name = (string)login[0];
                    string password = (string)login[1];
                    string sclass = (string)login[2];
                    bool daily = (bool)login[3];
                    bool admin = (bool)login[4];



                    if ( (bool)login[4]==true)
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
        private void cboxC()
        {

            SqlConnection con = new SqlConnection(myDBConnectionString);
            con.Open();
            SqlCommand cod = new SqlCommand("select  class from class", con);
            SqlDataReader reader = cod.ExecuteReader();
            DataTable mydatatable = new DataTable();
            mydatatable.Load(reader);
            cboxClass.DataSource = mydatatable;
            cboxClass.DisplayMember = "class";
            reader.Close();
            con.Close();
        }
        private void cboxR()
        {

            SqlConnection con = new SqlConnection(myDBConnectionString);
            con.Open();
            SqlCommand cod = new SqlCommand("select distinct restaurant from RMenu", con);
            SqlDataReader reader = cod.ExecuteReader();
            DataTable mydatatable = new DataTable();
            mydatatable.Load(reader);
            cboxRestaurant.DataSource = mydatatable;
            cboxRestaurant.DisplayMember = "restaurant";
            reader.Close();
            con.Close();
        }
        private void cboxClass_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboxRestaurant_SelectedIndexChanged(object sender, EventArgs e)
        {
            lboxMenu.Items.Clear();
            //餐廳 = cboxRestaurant.SelectedItem.ToString();


            SqlConnection con = new SqlConnection(myDBConnectionString);
            con.Open();
            string tSQL = "select * from [RMenu] where [restaurant] = @Restaurant";
            SqlCommand cmd = new SqlCommand(tSQL, con);
            cmd.Parameters.AddWithValue("@Restaurant", cboxRestaurant.Text);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                lboxMenu.Items.Add((string)reader["meal"]);
            }
            reader.Close();
            con.Close();
        }

        private void lboxMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            品項 = lboxMenu.SelectedItem.ToString();

            SqlConnection con = new SqlConnection(myDBConnectionString);
            con.Open();
            string tSQL = "select price,pic from [RMenu] where [meal] = @Meal";
            SqlCommand cmd = new SqlCommand(tSQL, con);
            cmd.Parameters.AddWithValue("@Meal", 品項);
            SqlDataReader reader = cmd.ExecuteReader();
            int i = 0;

            while (reader.Read())
            {
                image_name = (string)reader["pic"];
                pictureBox1.Image = Image.FromFile(image_dir + image_name);
                i += 1;
                lblUPrice.Text = ((int)reader["price"]).ToString() + "元";
                單價 = (int)reader["price"];
                計算總價();
            }

            reader.Close();
            con.Close();
        }

        void 計算總價()
        {
            lblTPrice.Text = (單價 * 數量).ToString() + "元";
            總價 = 數量 * 單價;
        }
        private void btnCofiem_Click(object sender, EventArgs e)
        {
            lboxMenu.SelectedIndex = 0;
            品項 = lboxMenu.SelectedItem.ToString();

            if (lboxMenu.SelectedIndex > -1 && txtOrderer.Text != "")
            {
                SqlConnection con = new SqlConnection(myDBConnectionString);
            con.Open();
            string tSQL = "INSERT INTO [orderdetail] ([oclass],[oorderer],[orestaurant] ,[oquantity],[oprice],[omeal],[orderdate]) VALUES (@class,@orderer,@restaurant,@quantity,@price,@meal,@orderdate) ";
            SqlCommand cmd = new SqlCommand(tSQL, con);
            cmd.Parameters.AddWithValue("@class", cboxClass.Text);
            cmd.Parameters.AddWithValue("@meal", 品項);
            cmd.Parameters.AddWithValue("@orderer", txtOrderer.Text);
            cmd.Parameters.AddWithValue("@price", 單價);
            cmd.Parameters.AddWithValue("@quantity", 數量);
            cmd.Parameters.AddWithValue("@restaurant", cboxRestaurant.Text);
            cmd.Parameters.AddWithValue("@orderdate", DateTime.Now.ToString("MM/dd/yyyy H:mm"));

                //cmd.ExecuteNonQuery();
                //int rows = cmd.ExecuteNonQuery();
                int rows = cmd.ExecuteNonQuery(); //執行不查詢(不會回傳資料 只會回傳受影響資料筆數) 新增 刪除 修改都不會回傳資料 只有select會
               
                con.Dispose();
            con.Close();
            MessageBox.Show("已加入訂購單");

        }
            else
            {
                MessageBox.Show("請選擇品項或填寫訂購人");
            }
}

        private void btnCheck_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form訂購單列表 = new Form2();
            //form訂購單列表.Show();
            form訂購單列表.ShowDialog();
            this.Show();
        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {

            
            if (txtQuantity.Text != "")
            {
                bool ifNum = System.Int32.TryParse(txtQuantity.Text, out 數量);//用TryParse檢查是不是輸入整數

                if ((ifNum == true) && (數量 >= 1))
                {//輸入成功

                }
                else
                {//輸入失敗
                    MessageBox.Show("輸入數量錯誤");
                    數量 = 1;
                    txtQuantity.Text = 數量.ToString();
                }
            }
            else
            {
                數量 = 1;
            }
            計算總價();
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
    }
}

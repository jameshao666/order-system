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
using System.Collections;

namespace project
{
    public partial class Form2 : Form
    {

        SqlConnectionStringBuilder scsb;

        string myDBConnectionString = "";
        List<int> SearchIDs = new List<int>();
        List<ArrayList> list訂購單品項列表 = new List<ArrayList>();
        int count = 0;
        int count1 = 0;


        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: 這行程式碼會將資料載入 'jamesDataSet.orderdetail' 資料表。您可以視需要進行移動或移除。
            this.orderdetailTableAdapter.Fill(this.jamesDataSet.orderdetail);
            scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @".";
            scsb.InitialCatalog = "James";
            scsb.IntegratedSecurity = true;

            myDBConnectionString = scsb.ToString();
            cboxR();
            cboxC();

            cboxClass.SelectedIndex = 0;
            cboxRestaurant.SelectedIndex = 0;

            lblClass.Text = cboxClass.Text.ToString() + "班訂購表";

            foreach (ArrayList login in GlobalVar.Log)
            {
                string name = (string)login[0];
                string password = (string)login[1];
                string sclass = (string)login[2];
                bool daily = (bool)login[3];
                bool admin = (bool)login[4];



                if ((bool)login[3] == true || (bool)login[4] == true)
                {
                    btnClear.Visible = true;
                    btnSave.Visible = true;
                    btnDelete.Visible = true;
                }
                else
                {
                    btnClear.Visible = false;
                    btnSave.Visible = false;
                    btnDelete.Visible = false;
                }

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

            lblClass.Text = cboxClass.Text + " 班統計列表";
            lboxDetailEach.Items.Clear();
            讀取商家便當品項();
            讀取班級便當品項();
            計算總價();
        }

        private void cboxRestaurant_SelectedIndexChanged(object sender, EventArgs e)
        {
            lboxDetailEach.Items.Clear();
            讀取商家便當品項();
            讀取班級便當品項();
            計算總價();
        }

        void 讀取商家便當品項()
        {
            if (count != 0)
            {
                //班級 = cboxClass.SelectedItem.ToString();
                //餐廳 = cboxRestaurant.SelectedItem.ToString();
                SqlConnection con = new SqlConnection(myDBConnectionString);
                con.Open();

                string tSQL = "select * from orderdetail where [oclass] = @Class and orestaurant = @Store";
                SqlCommand cmd = new SqlCommand(tSQL, con);
                cmd.Parameters.AddWithValue("@Class", cboxClass.Text);
                cmd.Parameters.AddWithValue("@Store", cboxRestaurant.Text);
                SqlDataReader reader = cmd.ExecuteReader();


                while (reader.Read())
                {
                    lboxDetailEach.Items.Add((string)reader["oorderer"] + " 已訂購 " + (string)reader["omeal"] + " " + (int)reader["oquantity"] + " 個  單價" + (int)reader["oprice"] + "元");
                    SearchIDs.Add((int)reader["order_id"]);
                }
                reader.Close();
                con.Close();
            }
            else
            {
                count += 1;
            }
        }
        void 讀取班級便當品項()
        {


            if (count1 != 0)
            {

                lboxDetailEach.Items.Clear();
                lboxDetail.Items.Clear();
                讀取商家便當品項();
                //班級 = cboxClass.SelectedItem.ToString();
                //餐廳 = cboxRestaurant.SelectedItem.ToString();
                SqlConnection con = new SqlConnection(myDBConnectionString);
                con.Open();
                string tSQL = "select oclass, orestaurant, omeal, Sum(oquantity) as 項目總數量 from orderdetail group by oclass,orestaurant , omeal having [oclass] = @Class ";

                SqlCommand cmd = new SqlCommand(tSQL, con);
                cmd.Parameters.AddWithValue("@Class", cboxClass.Text);

                SqlDataReader reader = cmd.ExecuteReader();


                while (reader.Read())
                {
                    lboxDetail.Items.Add((string)reader["oclass"] + "  班 從 " + (string)reader["orestaurant"] + " 訂購 " + (string)reader["omeal"] + " " + (int)reader["項目總數量"] + " 個");
                }
                reader.Close();
                con.Close();
            }
            else
            {
                count1 += 1;
            }
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(myDBConnectionString);
            con.Open();
            string tSQL = "DELETE from [OrderDetail] ";
            SqlCommand cmd = new SqlCommand(tSQL, con);
            cmd.Parameters.AddWithValue("@Cclass", cboxClass.Text);
            SqlDataReader reader = cmd.ExecuteReader();
            con.Close();

            lblTPrice.Text = "總價: 0 元";
            lboxDetailEach.Items.Clear();
            lboxDetail.Items.Clear();

            cboxClass.SelectedIndex = 0;
        }
        void 計算總價()
        {
            lblTPrice.Text = "總價: 0 元";
            SqlConnection con = new SqlConnection(myDBConnectionString);
            con.Open();
            string tSQL = "select sum(oquantity*oprice) as 總價 from orderdetail group by oclass having oclass=@Class";
            SqlCommand cmd = new SqlCommand(tSQL, con);
            cmd.Parameters.AddWithValue("@Class", cboxClass.Text);
            SqlDataReader reader = cmd.ExecuteReader();
            
            if (reader.Read())
            {
                lblTPrice.Text = string.Format("總價 {0}  元", (int)reader["總價"]);
            }

            reader.Close();
            con.Close();



        }
        private void btnDelete_Click(object sender, EventArgs e)
        {


            if (lboxDetailEach.SelectedIndex > -1)
            {

                int intID = SearchIDs[lboxDetailEach.SelectedIndex];
                SqlConnection con = new SqlConnection(myDBConnectionString);
                con.Open();
                string tSQL = "delete from [orderdetail] where [order_id] = @SearchID";
                SqlCommand cmd = new SqlCommand(tSQL, con);
                cmd.Parameters.AddWithValue("@SearchID", intID);
                SqlDataReader reader = cmd.ExecuteReader();
                // int rows = cmd.ExecuteNonQuery();
                while (lboxDetailEach.SelectedItem != null)
                { lboxDetailEach.Items.Remove(lboxDetailEach.SelectedItem); }
                lboxDetail.Items.Clear();
                cboxClass.SelectedIndex = 0;
                reader.Close();
                con.Close();
                lblTPrice.Text = "總價: 0 元";
                計算總價();
            }








            // MessageBox.Show(rows.ToString() + "個資料列受到影響");



        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 訂購單 = new Form1();
            訂購單.ShowDialog();
            this.Show();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            int totalquan=0;
            int total=0;
            //string str檔案路徑 = @"C:\Users\iii\Documents\C#\";
            //Random myRnd = new Random();
            //int myNum = myRnd.Next(1000, 9999);
            //string str檔名 = DateTime.Now.ToString("yyyyMMddHHmmss") + myNum.ToString() + @"訂購檔.txt";
            //string str完整路徑檔 = str檔案路徑 + str檔名;

            ////string str完整路徑檔 = "";
            //SaveFileDialog sfd = new SaveFileDialog();
            //sfd.InitialDirectory = @"C:\Users\iii\Documents\C#\";
            //sfd.FileName = str檔名;
            //sfd.Filter = "文字檔 (*.txt)|*.txt|所有檔案 (*.*)|*.*";

            //if (sfd.ShowDialog() == DialogResult.OK)
            //{
            //    str完整路徑檔 = sfd.FileName;
            //}
            //else
            //{
            //    return;
            //}
            string stroutput = "";
            //int total = 0;
            int c = 0;
            //string  stroutput1 = "";
            SqlConnection con = new SqlConnection(myDBConnectionString);
            con.Open();
            //string tSQL = "select oclass,omeal,orestaurant,oorderer,oquantity,oprice,orderdate,sum(oquantity*oprice)  from orderdetail group by oclass,omeal,orestaurant,oorderer,oquantity,oprice,orderdate,sum(oquantity*oprice) having oclass=@Class";
            string tSQL = "select*from orderdetail where oclass=@Class ";
            SqlCommand cmd = new SqlCommand(tSQL, con);
            cmd.Parameters.AddWithValue("@Class", cboxClass.Text);
           // SqlDataReader reader = cmd.ExecuteReader();
           
                //stroutput1 += "" + cboxClass.Text + "班　" /*+ reader["orderer"] + "　訂購" + reader["quantity"] +  reader["meal"] +"金額"+reader["總價"]+*/ +"$\n\n" +
                //              "品名\t數量\t單價\t總價\t訂購人\n";

                //reader.Close();

            SqlDataReader reader = cmd.ExecuteReader();
            stroutput = 
                  "品名\t數量\t單價\t總價\t訂購人\n";
            while (reader.Read())
            {
                stroutput += String.Format("{0}\t{1}\t{2}\t{3}\t{4}",
                    reader["omeal"], reader["oquantity"], reader["oprice"], Convert.ToInt32(reader["oquantity"]) * Convert.ToInt32(reader["oprice"]), reader["oorderer"] + "\n");
                totalquan += Convert.ToInt32(reader["oquantity"]);
                total += Convert.ToInt32(reader["oquantity"]) * Convert.ToInt32(reader["oprice"]);

                c++;
            }
            stroutput += "-----------------------------------------------------\n" +
                         "\t" + totalquan.ToString() + "\t\t" + total.ToString() + "$\n" +
                         "\t\t\t總計收費" + Convert.ToString(total) + "$\n" +
                         "\t\t\t共" + c.ToString() + "筆";
            //if (reader.Read())
            //{

            //    ArrayList my訂購品項 = new ArrayList();
            //    my訂購品項.Add((string)reader["oclass"]);
            //    my訂購品項.Add((string)reader["oorderer"]);
            //    my訂購品項.Add((string)reader["omeal"]);
            //    my訂購品項.Add((string)reader["orestaurant"]);
            //    //  list訂購單品項列表.Add((string)reader["orderdate"]);
            //    my訂購品項.Add((int)reader["oprice"]);
            //    my訂購品項.Add((int)reader["oquantity"]);



            //    List<string> lines訂購所有品項列表 = new List<string>();
            //    lines訂購所有品項列表.Add("****** 便當訂購單 ******");
            //    lines訂購所有品項列表.Add(" ===================");
            //    lines訂購所有品項列表.Add("訂購日期:" + DateTime.Now.ToString("yyyy-MM-dd"));
            //    lines訂購所有品項列表.Add("-------------------------------");

            //    foreach (ArrayList my訂購 in GlobalVar.list品項總數)
            //    {
            //        string oclass = (string)my訂購[0];
            //        string oorderer = (string)my訂購[1];
            //        string orestaurant = (string)my訂購[2];
            //        string omeal = (string)my訂購[3];
            //        int oquantity = (int)my訂購[4];
            //        int oprice = (int)my訂購[5];
            //        // string orderdate = (string)my訂購品項[6];


            //        string str統計品項 = string.Format("{0} 班 {1} 從 {2} 訂購 {3}  {4} 個  總價{5}元 ", oclass, oorderer, orestaurant, omeal, oquantity, oquantity * oprice
            //                + "\n");

            //        lines訂購所有品項列表.Add(str統計品項);


            //        //lines訂購所有品項列表.Add(myclass + "班的總價:" + totalprice);
            //        //            lines訂購所有品項列表.Add("-------------------------------");


            //        // lines訂購所有品項列表.Add(cboxClass.Text + "班的總價:" + Convert.ToInt32(reader["oquantity"]) * Convert.ToInt32(reader["oprice"]));


            //        System.IO.File.WriteAllLines(str完整路徑檔, lines訂購所有品項列表, Encoding.UTF8);
            //    }

            reader.Close();
            con.Close();
            MessageBox.Show(stroutput, "訂購明細");
            //MessageBox.Show("存檔成功");
            //List<string> lines訂購所有品項列表 = new List<string>();

            //lines訂購所有品項列表.Add("----------------------------");
            //lines訂購所有品項列表.Add("總價:" + );
            //lines訂購所有品項列表.Add("============================");

            //System.IO.File.WriteAllLines(str完整路徑檔, lines訂購所有品項列表, Encoding.UTF8);
            //MessageBox.Show("存檔成功");


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

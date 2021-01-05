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
    public partial class Form5 : Form
    {
        SqlConnectionStringBuilder scsb;

        string myDBConnectionString = "";
        List<string> listProductName = new List<string>();
        List<int> listProductPrice = new List<int>();
        List<int> listProductID = new List<int>();
        string 餐廳;
        public int productID = 0;
        string image_dir = @"images\";
        string image_name = "";
        List<int> RIDs = new List<int>();
        
        public Form5()
        {
            InitializeComponent();
        }
        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: 這行程式碼會將資料載入 'jamesDataSet.menu' 資料表。您可以視需要進行移動或移除。
            this.menuTableAdapter.Fill(this.jamesDataSet.menu);
            scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @".";
            scsb.InitialCatalog = "James";
            scsb.IntegratedSecurity = true;

            myDBConnectionString = scsb.ToString();

           
            cboxR();
            讀取資料庫();
            產生圖片View();
            cboxRestaurant.SelectedIndex = 0;
            餐廳 = cboxRestaurant.SelectedItem.ToString();


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
        void 讀取資料庫()
        {
            listView1.Clear();
            //txtmeal.Clear();
            //txtprice.Clear();
            SqlConnection con = new SqlConnection(myDBConnectionString);
            con.Open();
            string tSQL = "select * from [RMenu] where [restaurant]=@restaurant";
            SqlCommand cmd = new SqlCommand(tSQL, con);
            cmd.Parameters.AddWithValue("@restaurant", cboxRestaurant.Text);
            SqlDataReader reader = cmd.ExecuteReader();

            string image_dir = @"images\";
            string image_name = "";
            imageList1.Images.Clear();
            listProductID.Clear();
            listProductName.Clear();
            listProductPrice.Clear();
         
            while (reader.Read())
            {
                listProductID.Add((int)reader["meal_id"]);
                listProductName.Add((string)reader["meal"]);
                listProductPrice.Add((int)reader["price"]);
               
                listView1.LargeImageList = imageList1;
                image_name = (string)reader["pic"];
                imageList1.Images.Add(Image.FromFile(image_dir + image_name));
             
               
            }
          
            reader.Close();
            con.Close();
        }

        void 顯示產品細項()
        {
            int i = 0;
            int selectedID = (int)listView1.SelectedItems[i].Tag;
            
            SqlConnection con = new SqlConnection(myDBConnectionString);
            con.Open();
            string tSQL = "select * from [RMenu] where meal_id=@Newmeal";
            SqlCommand cmd = new SqlCommand(tSQL, con);
            cmd.Parameters.AddWithValue("@Newmeal",selectedID);
            SqlDataReader reader = cmd.ExecuteReader();
           // int i = 0;
            while (reader.Read())
            {
                //txtid.Text = productID.ToString();
                txtmeal.Text = (string)reader["meal"];
                txtprice.Text = reader["price"].ToString();
                image_name = (string)reader["pic"];
                //pictureBox1.Image = Image.FromFile(image_dir + image_name);
                i += 1;
            }
            reader.Close();
            con.Close();

        }
        void 產生圖片View()
        {
            listView1.Clear();
            listView1.View = View.LargeIcon;
            imageList1.ImageSize = new Size(120, 120);
            listView1.LargeImageList = imageList1;


                for (int i = 0; i < imageList1.Images.Count; i += 1)
                {
                    ListViewItem item = new ListViewItem();
                    item.ImageIndex = i;
                    item.Font = new Font("微軟正黑體", 14, FontStyle.Regular);
                    item.Text = listProductName[i];
                    item.Tag = listProductID[i];
                    listView1.Items.Add(item);
                }
        }
        private void cboxRestaurant_SelectedIndexChanged(object sender, EventArgs e)
        {
            listView1.Items.Clear();
           
            讀取資料庫();
            產生圖片View();
          
        }

        private void txtmeal_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtprice_TextChanged(object sender, EventArgs e)
        {

        }

        private void btndelete_Click(object sender, EventArgs e)
        {

            if (listView1.SelectedItems != null ) {
                //int i = 0;
                //int selectedID = (int)listView1.SelectedItems[i].Tag;

                SqlConnection con = new SqlConnection(myDBConnectionString);
                con.Open();
                string tSQL = "delete from [RMenu] where meal_id=@Newmeal";
                SqlCommand cmd = new SqlCommand(tSQL, con);
                cmd.Parameters.AddWithValue("@Newmeal", txtid.Text);
                SqlDataReader reader = cmd.ExecuteReader();
                listView1.Items.Clear();

                讀取資料庫();
                產生圖片View();
                txtid.Text = "";
                txtmeal.Text = "";
                txtprice.Text = "";
                pictureBox1.Image = null;
            }
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            餐廳 = cboxRestaurant.SelectedItem.ToString();
            if ((txtprice.Text != "") && (txtmeal.Text != "") && (pictureBox1.Image != null))
            {
                pictureBox1.Image.Save(image_dir + image_name);
               //int intID = RIDs[cboxRestaurant.SelectedIndex];
                SqlConnection con = new SqlConnection(myDBConnectionString);
                con.Open();
                string tSQL = "insert into [RMenu] (meal,price,pic,restaurant,restaurant_id)values(@NewPname, @NewPrice, @NewPimage,@NewPrestaurant,@Newprestaurant_id)";
                SqlCommand cmd = new SqlCommand(tSQL, con);
                cmd.Parameters.AddWithValue("@NewPname", txtmeal.Text);
                cmd.Parameters.AddWithValue("@NewPimage", image_name);
                cmd.Parameters.AddWithValue("@NewPrestaurant", cboxRestaurant.Text);
                cmd.Parameters.AddWithValue("@Newprestaurant_id", (int)cboxRestaurant.SelectedIndex);

                // cmd.Parameters.AddWithValue("@NewPrice",txtprice.Text);
                int myPrice = 0;
                Int32.TryParse(txtprice.Text, out myPrice);
                cmd.Parameters.AddWithValue("@NewPrice", myPrice);

                int rows = cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("新增完成, 影響資料筆數:" + rows.ToString());
                txtid.Text = "";
                txtmeal.Text = "";
                txtprice.Text = "";
                pictureBox1.Image = null;
                listView1.Items.Clear();

                讀取資料庫();
                產生圖片View();

            }
            else
            {
                MessageBox.Show("所有欄位必填");
            }
        }
    

        private void btnpicadd_Click(object sender, EventArgs e)
        {
            txtid.Text = "";
            txtmeal.Text = "";
            txtprice.Text = "";
            pictureBox1.Image = null;

            OpenFileDialog f = new OpenFileDialog();
            f.Filter = "圖檔類型 (*.jpg, *.jpeg, *.png)|*.jpg;*.jpeg;*.png";

            DialogResult R = f.ShowDialog();

            if (R == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(f.FileName);
                string fileExt = Path.GetExtension(f.SafeFileName);//附檔名
                Random myRnd = new Random();
                image_name = DateTime.Now.ToString("yyyyMMddHHmmss") + myRnd.Next(1000, 9999).ToString() + fileExt;
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtmeal.Clear();
            txtprice.Clear();
            ListView.SelectedListViewItemCollection a = this.listView1.SelectedItems;

            foreach( ListViewItem item in a ){
               int selectedID = (int)listView1.SelectedItems[0].Tag;
                SqlConnection con = new SqlConnection(myDBConnectionString);
                con.Open();
                string tSQL = "select * from [RMenu] where meal_id=@Newmeal";
                SqlCommand cmd = new SqlCommand(tSQL, con);
                cmd.Parameters.AddWithValue("@Newmeal", selectedID);
                SqlDataReader reader = cmd.ExecuteReader();
                // int i = 0;
                while (reader.Read())
                {
                    txtid.Text = (string)reader["meal_id"].ToString();
                    txtmeal.Text = (string)reader["meal"];
                    txtprice.Text = reader["price"].ToString();
                    image_name = (string)reader["pic"];
                    //pictureBox1.Image = Image.FromFile(image_dir + image_name);
                    //i += 1;
                }
                reader.Close();
                con.Close();
            } }

        private void btnadd_Click(object sender, EventArgs e)
        {
            txtid.Text = "";
            txtmeal.Text = "";
            txtprice.Text = "";
            pictureBox1.Image = null;
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

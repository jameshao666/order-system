namespace project
{
    partial class Form5
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
            this.components = new System.ComponentModel.Container();
            this.label3 = new System.Windows.Forms.Label();
            this.cboxRestaurant = new System.Windows.Forms.ComboBox();
            this.btnsave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtmeal = new System.Windows.Forms.TextBox();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnpicadd = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.txtid = new System.Windows.Forms.TextBox();
            this.jamesDataSet = new project.JamesDataSet();
            this.menuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuTableAdapter = new project.JamesDataSetTableAdapters.menuTableAdapter();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.系統維護toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.學生資料toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.菜單toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.離開toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jamesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("新細明體", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(51, 47);
            this.label3.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 29;
            this.label3.Text = "餐廳";
            // 
            // cboxRestaurant
            // 
            this.cboxRestaurant.Font = new System.Drawing.Font("微軟正黑體", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cboxRestaurant.FormattingEnabled = true;
            this.cboxRestaurant.Location = new System.Drawing.Point(127, 40);
            this.cboxRestaurant.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.cboxRestaurant.Name = "cboxRestaurant";
            this.cboxRestaurant.Size = new System.Drawing.Size(147, 31);
            this.cboxRestaurant.TabIndex = 28;
            this.cboxRestaurant.SelectedIndexChanged += new System.EventHandler(this.cboxRestaurant_SelectedIndexChanged);
            // 
            // btnsave
            // 
            this.btnsave.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.Location = new System.Drawing.Point(530, 404);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(122, 34);
            this.btnsave.TabIndex = 30;
            this.btnsave.Text = "新增菜單";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("新細明體", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(51, 114);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 32;
            this.label1.Text = "品項";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("新細明體", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(51, 180);
            this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 33;
            this.label2.Text = "價格";
            // 
            // txtmeal
            // 
            this.txtmeal.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtmeal.Location = new System.Drawing.Point(127, 109);
            this.txtmeal.Name = "txtmeal";
            this.txtmeal.Size = new System.Drawing.Size(155, 33);
            this.txtmeal.TabIndex = 35;
            this.txtmeal.TextChanged += new System.EventHandler(this.txtmeal_TextChanged);
            // 
            // txtprice
            // 
            this.txtprice.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtprice.Location = new System.Drawing.Point(127, 171);
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(155, 33);
            this.txtprice.TabIndex = 36;
            this.txtprice.TextChanged += new System.EventHandler(this.txtprice_TextChanged);
            // 
            // btndelete
            // 
            this.btndelete.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.Location = new System.Drawing.Point(193, 404);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(122, 34);
            this.btndelete.TabIndex = 37;
            this.btndelete.Text = "刪除菜單";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnpicadd
            // 
            this.btnpicadd.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpicadd.Location = new System.Drawing.Point(603, 82);
            this.btnpicadd.Name = "btnpicadd";
            this.btnpicadd.Size = new System.Drawing.Size(143, 34);
            this.btnpicadd.TabIndex = 38;
            this.btnpicadd.Text = "新增產品";
            this.btnpicadd.UseVisualStyleBackColor = true;
            this.btnpicadd.Click += new System.EventHandler(this.btnpicadd_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(356, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(212, 174);
            this.pictureBox1.TabIndex = 39;
            this.pictureBox1.TabStop = false;
            // 
            // listView1
            // 
            this.listView1.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(55, 230);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(733, 168);
            this.listView1.SmallImageList = this.imageList1;
            this.listView1.TabIndex = 40;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // txtid
            // 
            this.txtid.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtid.Location = new System.Drawing.Point(390, 206);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(155, 33);
            this.txtid.TabIndex = 41;
            this.txtid.Visible = false;
            // 
            // jamesDataSet
            // 
            this.jamesDataSet.DataSetName = "JamesDataSet";
            this.jamesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // menuBindingSource
            // 
            this.menuBindingSource.DataMember = "menu";
            this.menuBindingSource.DataSource = this.jamesDataSet;
            // 
            // menuTableAdapter
            // 
            this.menuTableAdapter.ClearBeforeFill = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.系統維護toolStripMenuItem1,
            this.離開toolStripMenuItem2,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(3, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 42;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 系統維護toolStripMenuItem1
            // 
            this.系統維護toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.學生資料toolStripMenuItem1,
            this.菜單toolStripMenuItem1});
            this.系統維護toolStripMenuItem1.Name = "系統維護toolStripMenuItem1";
            this.系統維護toolStripMenuItem1.Size = new System.Drawing.Size(67, 22);
            this.系統維護toolStripMenuItem1.Text = "系統維護";
            // 
            // 學生資料toolStripMenuItem1
            // 
            this.學生資料toolStripMenuItem1.Name = "學生資料toolStripMenuItem1";
            this.學生資料toolStripMenuItem1.Size = new System.Drawing.Size(122, 22);
            this.學生資料toolStripMenuItem1.Text = "學生資料";
            this.學生資料toolStripMenuItem1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.學生資料toolStripMenuItem1.Click += new System.EventHandler(this.學生資料toolStripMenuItem1_Click);
            // 
            // 菜單toolStripMenuItem1
            // 
            this.菜單toolStripMenuItem1.Name = "菜單toolStripMenuItem1";
            this.菜單toolStripMenuItem1.Size = new System.Drawing.Size(122, 22);
            this.菜單toolStripMenuItem1.Text = "菜單資料";
            this.菜單toolStripMenuItem1.Click += new System.EventHandler(this.菜單toolStripMenuItem1_Click);
            // 
            // 離開toolStripMenuItem2
            // 
            this.離開toolStripMenuItem2.Name = "離開toolStripMenuItem2";
            this.離開toolStripMenuItem2.Size = new System.Drawing.Size(57, 22);
            this.離開toolStripMenuItem2.Text = "離開(x)";
            this.離開toolStripMenuItem2.Click += new System.EventHandler(this.離開toolStripMenuItem2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Maroon;
            this.button1.Font = new System.Drawing.Font("微軟正黑體", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(658, 26);
            this.button1.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 34);
            this.button1.TabIndex = 43;
            this.button1.Text = "離開";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(91, 22);
            this.toolStripMenuItem1.Text = "返回點餐畫面";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnpicadd);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.txtprice);
            this.Controls.Add(this.txtmeal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboxRestaurant);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jamesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboxRestaurant;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtmeal;
        private System.Windows.Forms.TextBox txtprice;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnpicadd;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TextBox txtid;
        private JamesDataSet jamesDataSet;
        private System.Windows.Forms.BindingSource menuBindingSource;
        private JamesDataSetTableAdapters.menuTableAdapter menuTableAdapter;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 系統維護toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 學生資料toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 菜單toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 離開toolStripMenuItem2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    }
}
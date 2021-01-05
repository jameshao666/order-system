namespace project
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.cboxRestaurant = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.lblTPrice = new System.Windows.Forms.Label();
            this.lboxMenu = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblUPrice = new System.Windows.Forms.Label();
            this.txtdaily = new System.Windows.Forms.TextBox();
            this.txtOrderer = new System.Windows.Forms.TextBox();
            this.cboxClass = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCheck = new System.Windows.Forms.Button();
            this.btnCofiem = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.系統維護toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.學生資料toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.菜單toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.離開toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboxRestaurant
            // 
            this.cboxRestaurant.Font = new System.Drawing.Font("微軟正黑體", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cboxRestaurant.FormattingEnabled = true;
            this.cboxRestaurant.Location = new System.Drawing.Point(87, 30);
            this.cboxRestaurant.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.cboxRestaurant.Name = "cboxRestaurant";
            this.cboxRestaurant.Size = new System.Drawing.Size(126, 31);
            this.cboxRestaurant.TabIndex = 5;
            this.cboxRestaurant.SelectedIndexChanged += new System.EventHandler(this.cboxRestaurant_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("新細明體", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label9.Location = new System.Drawing.Point(310, 305);
            this.label9.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 20);
            this.label9.TabIndex = 5;
            this.label9.Text = "總價";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("新細明體", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.Location = new System.Drawing.Point(310, 253);
            this.label8.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 20);
            this.label8.TabIndex = 4;
            this.label8.Text = "單價";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("新細明體", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(30, 253);
            this.label7.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 20);
            this.label7.TabIndex = 3;
            this.label7.Text = "數量";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("新細明體", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(25, 68);
            this.label6.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(54, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "菜單";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("新細明體", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(35, 37);
            this.label5.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "餐廳";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Font = new System.Drawing.Font("微軟正黑體", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtQuantity.Location = new System.Drawing.Point(98, 246);
            this.txtQuantity.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(127, 32);
            this.txtQuantity.TabIndex = 7;
            this.txtQuantity.TextChanged += new System.EventHandler(this.txtQuantity_TextChanged);
            // 
            // lblTPrice
            // 
            this.lblTPrice.Font = new System.Drawing.Font("新細明體", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblTPrice.Location = new System.Drawing.Point(410, 305);
            this.lblTPrice.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblTPrice.Name = "lblTPrice";
            this.lblTPrice.Size = new System.Drawing.Size(112, 20);
            this.lblTPrice.TabIndex = 8;
            this.lblTPrice.Text = "$";
            this.lblTPrice.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lboxMenu
            // 
            this.lboxMenu.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lboxMenu.FormattingEnabled = true;
            this.lboxMenu.ItemHeight = 19;
            this.lboxMenu.Location = new System.Drawing.Point(82, 68);
            this.lboxMenu.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.lboxMenu.Name = "lboxMenu";
            this.lboxMenu.Size = new System.Drawing.Size(364, 137);
            this.lboxMenu.TabIndex = 6;
            this.lboxMenu.SelectedIndexChanged += new System.EventHandler(this.lboxMenu_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.txtQuantity);
            this.groupBox2.Controls.Add(this.lblTPrice);
            this.groupBox2.Controls.Add(this.lblUPrice);
            this.groupBox2.Controls.Add(this.lboxMenu);
            this.groupBox2.Controls.Add(this.cboxRestaurant);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(61, 154);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.groupBox2.Size = new System.Drawing.Size(681, 344);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(468, 59);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(199, 157);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // lblUPrice
            // 
            this.lblUPrice.Font = new System.Drawing.Font("新細明體", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblUPrice.Location = new System.Drawing.Point(410, 253);
            this.lblUPrice.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblUPrice.Name = "lblUPrice";
            this.lblUPrice.Size = new System.Drawing.Size(112, 20);
            this.lblUPrice.TabIndex = 7;
            this.lblUPrice.Text = "$";
            this.lblUPrice.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtdaily
            // 
            this.txtdaily.Font = new System.Drawing.Font("微軟正黑體", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtdaily.Location = new System.Drawing.Point(538, 50);
            this.txtdaily.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.txtdaily.Name = "txtdaily";
            this.txtdaily.Size = new System.Drawing.Size(99, 32);
            this.txtdaily.TabIndex = 9;
            this.txtdaily.Visible = false;
            // 
            // txtOrderer
            // 
            this.txtOrderer.Font = new System.Drawing.Font("微軟正黑體", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtOrderer.Location = new System.Drawing.Point(304, 23);
            this.txtOrderer.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.txtOrderer.Name = "txtOrderer";
            this.txtOrderer.Size = new System.Drawing.Size(127, 32);
            this.txtOrderer.TabIndex = 6;
            // 
            // cboxClass
            // 
            this.cboxClass.Font = new System.Drawing.Font("微軟正黑體", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cboxClass.FormattingEnabled = true;
            this.cboxClass.Location = new System.Drawing.Point(87, 21);
            this.cboxClass.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.cboxClass.Name = "cboxClass";
            this.cboxClass.Size = new System.Drawing.Size(126, 31);
            this.cboxClass.TabIndex = 4;
            this.cboxClass.SelectedIndexChanged += new System.EventHandler(this.cboxClass_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("新細明體", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(474, 28);
            this.label3.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 20);
            this.label3.TabIndex = 2;
            this.label3.Tag = "";
            this.label3.Text = "值日生  Kenny";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("新細明體", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(243, 28);
            this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "訂購人";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("新細明體", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(30, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "班級";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtdaily);
            this.groupBox1.Controls.Add(this.txtOrderer);
            this.groupBox1.Controls.Add(this.cboxClass);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(65, 36);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.groupBox1.Size = new System.Drawing.Size(677, 114);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // btnCheck
            // 
            this.btnCheck.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnCheck.Font = new System.Drawing.Font("微軟正黑體", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCheck.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCheck.Location = new System.Drawing.Point(603, 510);
            this.btnCheck.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(99, 34);
            this.btnCheck.TabIndex = 6;
            this.btnCheck.Text = "查看訂單";
            this.btnCheck.UseVisualStyleBackColor = false;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // btnCofiem
            // 
            this.btnCofiem.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnCofiem.Font = new System.Drawing.Font("微軟正黑體", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCofiem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCofiem.Location = new System.Drawing.Point(130, 510);
            this.btnCofiem.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnCofiem.Name = "btnCofiem";
            this.btnCofiem.Size = new System.Drawing.Size(99, 34);
            this.btnCofiem.TabIndex = 5;
            this.btnCofiem.Text = "加入訂單";
            this.btnCofiem.UseVisualStyleBackColor = false;
            this.btnCofiem.Click += new System.EventHandler(this.btnCofiem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.系統維護toolStripMenuItem1,
            this.離開toolStripMenuItem2});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(3, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(1048, 24);
            this.menuStrip1.TabIndex = 9;
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
            this.button1.Location = new System.Drawing.Point(790, 54);
            this.button1.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 34);
            this.button1.TabIndex = 33;
            this.button1.Text = "離開";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 659);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.btnCofiem);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboxRestaurant;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label lblTPrice;
        private System.Windows.Forms.ListBox lboxMenu;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblUPrice;
        private System.Windows.Forms.TextBox txtdaily;
        private System.Windows.Forms.TextBox txtOrderer;
        private System.Windows.Forms.ComboBox cboxClass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Button btnCofiem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 系統維護toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 離開toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem 學生資料toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 菜單toolStripMenuItem1;
        private System.Windows.Forms.Button button1;
    }
}


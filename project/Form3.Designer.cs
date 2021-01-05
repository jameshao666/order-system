namespace project
{
    partial class Form3
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
            this.btnlogin = new System.Windows.Forms.Button();
            this.cboxclass = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtaccount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn刪除 = new System.Windows.Forms.Button();
            this.btn新增 = new System.Windows.Forms.Button();
            this.btn儲存修改 = new System.Windows.Forms.Button();
            this.lboxname = new System.Windows.Forms.ListBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.系統維護toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.學生資料toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.菜單toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.離開toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnlogin
            // 
            this.btnlogin.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogin.Location = new System.Drawing.Point(31, 322);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(99, 45);
            this.btnlogin.TabIndex = 0;
            this.btnlogin.Text = "新增學員";
            this.btnlogin.UseVisualStyleBackColor = true;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // cboxclass
            // 
            this.cboxclass.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cboxclass.FormattingEnabled = true;
            this.cboxclass.Location = new System.Drawing.Point(121, 34);
            this.cboxclass.Name = "cboxclass";
            this.cboxclass.Size = new System.Drawing.Size(155, 32);
            this.cboxclass.TabIndex = 1;
            this.cboxclass.SelectedIndexChanged += new System.EventHandler(this.cboxclass_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "班級";
            // 
            // txtaccount
            // 
            this.txtaccount.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtaccount.Location = new System.Drawing.Point(121, 91);
            this.txtaccount.Name = "txtaccount";
            this.txtaccount.Size = new System.Drawing.Size(174, 33);
            this.txtaccount.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "密碼";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(44, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "姓名";
            // 
            // txtpassword
            // 
            this.txtpassword.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtpassword.Location = new System.Drawing.Point(121, 138);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(174, 33);
            this.txtpassword.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox1.Controls.Add(this.btn刪除);
            this.groupBox1.Controls.Add(this.btn新增);
            this.groupBox1.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.Location = new System.Drawing.Point(354, 262);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(193, 112);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "新增資料";
            // 
            // btn刪除
            // 
            this.btn刪除.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn刪除.Location = new System.Drawing.Point(98, 38);
            this.btn刪除.Margin = new System.Windows.Forms.Padding(2);
            this.btn刪除.Name = "btn刪除";
            this.btn刪除.Size = new System.Drawing.Size(81, 44);
            this.btn刪除.TabIndex = 27;
            this.btn刪除.Text = "刪除";
            this.btn刪除.UseVisualStyleBackColor = true;
            this.btn刪除.Click += new System.EventHandler(this.btn刪除_Click);
            // 
            // btn新增
            // 
            this.btn新增.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn新增.Location = new System.Drawing.Point(13, 38);
            this.btn新增.Margin = new System.Windows.Forms.Padding(2);
            this.btn新增.Name = "btn新增";
            this.btn新增.Size = new System.Drawing.Size(81, 44);
            this.btn新增.TabIndex = 26;
            this.btn新增.Text = "儲存";
            this.btn新增.UseVisualStyleBackColor = true;
            this.btn新增.Click += new System.EventHandler(this.btn新增_Click);
            // 
            // btn儲存修改
            // 
            this.btn儲存修改.Font = new System.Drawing.Font("微軟正黑體", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn儲存修改.Location = new System.Drawing.Point(151, 322);
            this.btn儲存修改.Margin = new System.Windows.Forms.Padding(2);
            this.btn儲存修改.Name = "btn儲存修改";
            this.btn儲存修改.Size = new System.Drawing.Size(110, 45);
            this.btn儲存修改.TabIndex = 26;
            this.btn儲存修改.Text = "儲存修改";
            this.btn儲存修改.UseVisualStyleBackColor = true;
            this.btn儲存修改.Click += new System.EventHandler(this.btn儲存修改_Click);
            // 
            // lboxname
            // 
            this.lboxname.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lboxname.FormattingEnabled = true;
            this.lboxname.ItemHeight = 19;
            this.lboxname.Location = new System.Drawing.Point(374, 38);
            this.lboxname.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.lboxname.Name = "lboxname";
            this.lboxname.Size = new System.Drawing.Size(175, 194);
            this.lboxname.TabIndex = 28;
            this.lboxname.SelectedIndexChanged += new System.EventHandler(this.lboxname_SelectedIndexChanged);
            // 
            // txtid
            // 
            this.txtid.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtid.Location = new System.Drawing.Point(133, 262);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(174, 33);
            this.txtid.TabIndex = 29;
            this.txtid.Visible = false;
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
            this.menuStrip1.Size = new System.Drawing.Size(595, 24);
            this.menuStrip1.TabIndex = 30;
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
            this.button1.Location = new System.Drawing.Point(434, 415);
            this.button1.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 34);
            this.button1.TabIndex = 44;
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
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 518);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.lboxname);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn儲存修改);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtaccount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboxclass);
            this.Controls.Add(this.btnlogin);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.groupBox1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.ComboBox cboxclass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtaccount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn刪除;
        private System.Windows.Forms.Button btn新增;
        private System.Windows.Forms.Button btn儲存修改;
        private System.Windows.Forms.ListBox lboxname;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 系統維護toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 學生資料toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 菜單toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 離開toolStripMenuItem2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    }
}
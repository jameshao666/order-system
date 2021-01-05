namespace project
{
    partial class Form2
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
            this.btnSave = new System.Windows.Forms.Button();
            this.lblTPrice = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.restaurantBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cboxRestaurant = new System.Windows.Forms.ComboBox();
            this.lblClass = new System.Windows.Forms.Label();
            this.lboxDetailEach = new System.Windows.Forms.ListBox();
            this.lboxDetail = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.classBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cboxClass = new System.Windows.Forms.ComboBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtid = new System.Windows.Forms.TextBox();
            this.jamesDataSet = new project.JamesDataSet();
            this.orderdetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderdetailTableAdapter = new project.JamesDataSetTableAdapters.orderdetailTableAdapter();
            this.tableAdapterManager = new project.JamesDataSetTableAdapters.TableAdapterManager();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.系統維護toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.學生資料toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.菜單toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.離開toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jamesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderdetailBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("新細明體", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(42, 94);
            this.label3.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 27;
            this.label3.Text = "餐廳";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnSave.Font = new System.Drawing.Font("微軟正黑體", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSave.Location = new System.Drawing.Point(540, 500);
            this.btnSave.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(99, 34);
            this.btnSave.TabIndex = 26;
            this.btnSave.Text = "送出訂單";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblTPrice
            // 
            this.lblTPrice.Font = new System.Drawing.Font("新細明體", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblTPrice.Location = new System.Drawing.Point(487, 94);
            this.lblTPrice.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblTPrice.Name = "lblTPrice";
            this.lblTPrice.Size = new System.Drawing.Size(162, 20);
            this.lblTPrice.TabIndex = 25;
            this.lblTPrice.Text = "$";
            this.lblTPrice.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("新細明體", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label9.Location = new System.Drawing.Point(456, 56);
            this.label9.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 20);
            this.label9.TabIndex = 24;
            // 
            // restaurantBindingSource
            // 
            this.restaurantBindingSource.DataMember = "restaurant";
            // 
            // cboxRestaurant
            // 
            this.cboxRestaurant.Font = new System.Drawing.Font("微軟正黑體", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cboxRestaurant.FormattingEnabled = true;
            this.cboxRestaurant.Location = new System.Drawing.Point(109, 90);
            this.cboxRestaurant.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.cboxRestaurant.Name = "cboxRestaurant";
            this.cboxRestaurant.Size = new System.Drawing.Size(126, 31);
            this.cboxRestaurant.TabIndex = 23;
            this.cboxRestaurant.SelectedIndexChanged += new System.EventHandler(this.cboxRestaurant_SelectedIndexChanged);
            // 
            // lblClass
            // 
            this.lblClass.Font = new System.Drawing.Font("新細明體", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblClass.Location = new System.Drawing.Point(497, 41);
            this.lblClass.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(152, 30);
            this.lblClass.TabIndex = 22;
            this.lblClass.Text = "班訂購列表";
            this.lblClass.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lboxDetailEach
            // 
            this.lboxDetailEach.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lboxDetailEach.FormattingEnabled = true;
            this.lboxDetailEach.ItemHeight = 19;
            this.lboxDetailEach.Location = new System.Drawing.Point(30, 140);
            this.lboxDetailEach.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.lboxDetailEach.Name = "lboxDetailEach";
            this.lboxDetailEach.Size = new System.Drawing.Size(319, 289);
            this.lboxDetailEach.TabIndex = 21;
            // 
            // lboxDetail
            // 
            this.lboxDetail.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lboxDetail.FormattingEnabled = true;
            this.lboxDetail.ItemHeight = 19;
            this.lboxDetail.Location = new System.Drawing.Point(428, 140);
            this.lboxDetail.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.lboxDetail.Name = "lboxDetail";
            this.lboxDetail.Size = new System.Drawing.Size(313, 289);
            this.lboxDetail.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("新細明體", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(42, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "班級";
            // 
            // classBindingSource
            // 
            this.classBindingSource.DataMember = "class";
            // 
            // cboxClass
            // 
            this.cboxClass.Font = new System.Drawing.Font("微軟正黑體", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cboxClass.FormattingEnabled = true;
            this.cboxClass.Location = new System.Drawing.Point(109, 34);
            this.cboxClass.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.cboxClass.Name = "cboxClass";
            this.cboxClass.Size = new System.Drawing.Size(126, 31);
            this.cboxClass.TabIndex = 19;
            this.cboxClass.SelectedIndexChanged += new System.EventHandler(this.cboxClass_SelectedIndexChanged);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnBack.Font = new System.Drawing.Font("微軟正黑體", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnBack.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBack.Location = new System.Drawing.Point(540, 446);
            this.btnBack.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(99, 34);
            this.btnBack.TabIndex = 17;
            this.btnBack.Text = "繼續訂購";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnClear.Font = new System.Drawing.Font("微軟正黑體", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnClear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClear.Location = new System.Drawing.Point(123, 500);
            this.btnClear.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(99, 34);
            this.btnClear.TabIndex = 16;
            this.btnClear.Text = "清空訂單";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnDelete.Font = new System.Drawing.Font("微軟正黑體", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDelete.Location = new System.Drawing.Point(123, 446);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(99, 34);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "刪除項目";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(319, 50);
            this.txtid.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(119, 22);
            this.txtid.TabIndex = 28;
            this.txtid.Visible = false;
            // 
            // jamesDataSet
            // 
            this.jamesDataSet.DataSetName = "JamesDataSet";
            this.jamesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // orderdetailBindingSource
            // 
            this.orderdetailBindingSource.DataMember = "orderdetail";
            this.orderdetailBindingSource.DataSource = this.jamesDataSet;
            // 
            // orderdetailTableAdapter
            // 
            this.orderdetailTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.menuTableAdapter = null;
            this.tableAdapterManager.orderdetailTableAdapter = this.orderdetailTableAdapter;
            this.tableAdapterManager.restaurantTableAdapter = null;
            this.tableAdapterManager.RMenuTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = project.JamesDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
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
            this.menuStrip1.Size = new System.Drawing.Size(888, 24);
            this.menuStrip1.TabIndex = 31;
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
            this.button1.Location = new System.Drawing.Point(716, 39);
            this.button1.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 34);
            this.button1.TabIndex = 32;
            this.button1.Text = "離開";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 530);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblTPrice);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cboxRestaurant);
            this.Controls.Add(this.lblClass);
            this.Controls.Add(this.lboxDetailEach);
            this.Controls.Add(this.lboxDetail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboxClass);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDelete);
            this.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.restaurantBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jamesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderdetailBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblTPrice;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.BindingSource restaurantBindingSource;
        private System.Windows.Forms.ComboBox cboxRestaurant;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.ListBox lboxDetailEach;
        private System.Windows.Forms.ListBox lboxDetail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource classBindingSource;
        private System.Windows.Forms.ComboBox cboxClass;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtid;
        private JamesDataSet jamesDataSet;
        private System.Windows.Forms.BindingSource orderdetailBindingSource;
        private JamesDataSetTableAdapters.orderdetailTableAdapter orderdetailTableAdapter;
        private JamesDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 系統維護toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 學生資料toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 菜單toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 離開toolStripMenuItem2;
        private System.Windows.Forms.Button button1;
    }
}
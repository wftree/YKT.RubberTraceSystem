namespace YKT.RubberTraceSystem.Windows
{
    partial class 成品码打印
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dgProductCodes = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.产品型号DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.登记时间DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.帘布批号DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.外胶片批号DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.内胶片批号DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.作业员DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.生产时间DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.生产机台DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.删除DataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.皮囊成型BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnPrint = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.皮囊成型BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgProductCodes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.皮囊成型BindingSource)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.皮囊成型BindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel1.Controls.Add(this.dgProductCodes, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnPrint, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // dgProductCodes
            // 
            this.dgProductCodes.AllowUserToAddRows = false;
            this.dgProductCodes.AllowUserToDeleteRows = false;
            this.dgProductCodes.AutoGenerateColumns = false;
            this.dgProductCodes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProductCodes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.产品型号DataGridViewTextBoxColumn,
            this.登记时间DataGridViewTextBoxColumn,
            this.帘布批号DataGridViewTextBoxColumn,
            this.外胶片批号DataGridViewTextBoxColumn,
            this.内胶片批号DataGridViewTextBoxColumn,
            this.作业员DataGridViewTextBoxColumn,
            this.生产时间DataGridViewTextBoxColumn,
            this.生产机台DataGridViewTextBoxColumn,
            this.删除DataGridViewCheckBoxColumn});
            this.tableLayoutPanel1.SetColumnSpan(this.dgProductCodes, 2);
            this.dgProductCodes.DataSource = this.皮囊成型BindingSource;
            this.dgProductCodes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgProductCodes.Location = new System.Drawing.Point(3, 3);
            this.dgProductCodes.Name = "dgProductCodes";
            this.dgProductCodes.ReadOnly = true;
            this.dgProductCodes.RowTemplate.Height = 23;
            this.dgProductCodes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgProductCodes.Size = new System.Drawing.Size(794, 409);
            this.dgProductCodes.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 产品型号DataGridViewTextBoxColumn
            // 
            this.产品型号DataGridViewTextBoxColumn.DataPropertyName = "产品型号";
            this.产品型号DataGridViewTextBoxColumn.HeaderText = "产品型号";
            this.产品型号DataGridViewTextBoxColumn.Name = "产品型号DataGridViewTextBoxColumn";
            this.产品型号DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 登记时间DataGridViewTextBoxColumn
            // 
            this.登记时间DataGridViewTextBoxColumn.DataPropertyName = "登记时间";
            this.登记时间DataGridViewTextBoxColumn.HeaderText = "登记时间";
            this.登记时间DataGridViewTextBoxColumn.Name = "登记时间DataGridViewTextBoxColumn";
            this.登记时间DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 帘布批号DataGridViewTextBoxColumn
            // 
            this.帘布批号DataGridViewTextBoxColumn.DataPropertyName = "帘布批号";
            this.帘布批号DataGridViewTextBoxColumn.HeaderText = "帘布批号";
            this.帘布批号DataGridViewTextBoxColumn.Name = "帘布批号DataGridViewTextBoxColumn";
            this.帘布批号DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 外胶片批号DataGridViewTextBoxColumn
            // 
            this.外胶片批号DataGridViewTextBoxColumn.DataPropertyName = "外胶片批号";
            this.外胶片批号DataGridViewTextBoxColumn.HeaderText = "外胶片批号";
            this.外胶片批号DataGridViewTextBoxColumn.Name = "外胶片批号DataGridViewTextBoxColumn";
            this.外胶片批号DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 内胶片批号DataGridViewTextBoxColumn
            // 
            this.内胶片批号DataGridViewTextBoxColumn.DataPropertyName = "内胶片批号";
            this.内胶片批号DataGridViewTextBoxColumn.HeaderText = "内胶片批号";
            this.内胶片批号DataGridViewTextBoxColumn.Name = "内胶片批号DataGridViewTextBoxColumn";
            this.内胶片批号DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 作业员DataGridViewTextBoxColumn
            // 
            this.作业员DataGridViewTextBoxColumn.DataPropertyName = "作业员";
            this.作业员DataGridViewTextBoxColumn.HeaderText = "作业员";
            this.作业员DataGridViewTextBoxColumn.Name = "作业员DataGridViewTextBoxColumn";
            this.作业员DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 生产时间DataGridViewTextBoxColumn
            // 
            this.生产时间DataGridViewTextBoxColumn.DataPropertyName = "生产时间";
            this.生产时间DataGridViewTextBoxColumn.HeaderText = "生产时间";
            this.生产时间DataGridViewTextBoxColumn.Name = "生产时间DataGridViewTextBoxColumn";
            this.生产时间DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 生产机台DataGridViewTextBoxColumn
            // 
            this.生产机台DataGridViewTextBoxColumn.DataPropertyName = "生产机台";
            this.生产机台DataGridViewTextBoxColumn.HeaderText = "生产机台";
            this.生产机台DataGridViewTextBoxColumn.Name = "生产机台DataGridViewTextBoxColumn";
            this.生产机台DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 删除DataGridViewCheckBoxColumn
            // 
            this.删除DataGridViewCheckBoxColumn.DataPropertyName = "删除";
            this.删除DataGridViewCheckBoxColumn.HeaderText = "删除";
            this.删除DataGridViewCheckBoxColumn.Name = "删除DataGridViewCheckBoxColumn";
            this.删除DataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // 皮囊成型BindingSource
            // 
            this.皮囊成型BindingSource.DataSource = typeof(YKT.RubberTraceSystem.Data.皮囊成型);
            // 
            // btnPrint
            // 
            this.btnPrint.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPrint.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnPrint.Location = new System.Drawing.Point(683, 418);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(114, 29);
            this.btnPrint.TabIndex = 1;
            this.btnPrint.Text = "打印产品码";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 154F));
            this.tableLayoutPanel2.Controls.Add(this.dateTimePicker1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.comboBox1, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.button1, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 418);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(674, 29);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateTimePicker1.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dateTimePicker1.Location = new System.Drawing.Point(3, 3);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(254, 26);
            this.dateTimePicker1.TabIndex = 3;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.皮囊成型BindingSource1;
            this.comboBox1.DisplayMember = "产品型号";
            this.comboBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox1.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(263, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(254, 24);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.ValueMember = "产品型号";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // 皮囊成型BindingSource1
            // 
            this.皮囊成型BindingSource1.DataSource = typeof(YKT.RubberTraceSystem.Data.皮囊成型);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(523, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "查询";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // 成品码打印
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "成品码打印";
            this.Text = "成品码打印";
            this.Load += new System.EventHandler(this.成品码打印_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgProductCodes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.皮囊成型BindingSource)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.皮囊成型BindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dgProductCodes;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 产品型号DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 登记时间DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 帘布批号DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 外胶片批号DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 内胶片批号DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 作业员DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 生产时间DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 生产机台DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn 删除DataGridViewCheckBoxColumn;
        private System.Windows.Forms.BindingSource 皮囊成型BindingSource;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource 皮囊成型BindingSource1;
    }
}
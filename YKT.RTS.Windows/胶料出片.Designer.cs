namespace YKT.RubberTraceSystem.Windows
{
    partial class 胶料出片
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
            this.dgOutRubber = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.胶料牌号DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.箱号DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.生产线号DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.供应商产品代号DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.生产日期DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.批次号DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.重量DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.登记时间DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.删除DataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.胶料入库BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label8 = new System.Windows.Forms.Label();
            this.dgRubberChips = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.宽度 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.厚度 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.数量 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.胶料批号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.消耗重量 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.橡胶薄片BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnCreate = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tbTypeNo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnPrint = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.tbConsume = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbNum = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbThick = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbWidth = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbCounter = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dgOutRubber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.胶料入库BindingSource)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgRubberChips)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.橡胶薄片BindingSource)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgOutRubber
            // 
            this.dgOutRubber.AllowUserToAddRows = false;
            this.dgOutRubber.AllowUserToDeleteRows = false;
            this.dgOutRubber.AutoGenerateColumns = false;
            this.dgOutRubber.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgOutRubber.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.胶料牌号DataGridViewTextBoxColumn,
            this.箱号DataGridViewTextBoxColumn,
            this.生产线号DataGridViewTextBoxColumn,
            this.供应商产品代号DataGridViewTextBoxColumn,
            this.生产日期DataGridViewTextBoxColumn,
            this.批次号DataGridViewTextBoxColumn,
            this.重量DataGridViewTextBoxColumn,
            this.登记时间DataGridViewTextBoxColumn,
            this.删除DataGridViewCheckBoxColumn});
            this.dgOutRubber.DataSource = this.胶料入库BindingSource;
            this.dgOutRubber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgOutRubber.Location = new System.Drawing.Point(3, 38);
            this.dgOutRubber.MultiSelect = false;
            this.dgOutRubber.Name = "dgOutRubber";
            this.dgOutRubber.ReadOnly = true;
            this.dgOutRubber.RowTemplate.Height = 23;
            this.dgOutRubber.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgOutRubber.Size = new System.Drawing.Size(445, 506);
            this.dgOutRubber.TabIndex = 0;
            this.dgOutRubber.SelectionChanged += new System.EventHandler(this.dgOutRubber_SelectionChanged);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 胶料牌号DataGridViewTextBoxColumn
            // 
            this.胶料牌号DataGridViewTextBoxColumn.DataPropertyName = "胶料牌号";
            this.胶料牌号DataGridViewTextBoxColumn.HeaderText = "胶料牌号";
            this.胶料牌号DataGridViewTextBoxColumn.Name = "胶料牌号DataGridViewTextBoxColumn";
            this.胶料牌号DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 箱号DataGridViewTextBoxColumn
            // 
            this.箱号DataGridViewTextBoxColumn.DataPropertyName = "箱号";
            this.箱号DataGridViewTextBoxColumn.HeaderText = "箱号";
            this.箱号DataGridViewTextBoxColumn.Name = "箱号DataGridViewTextBoxColumn";
            this.箱号DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 生产线号DataGridViewTextBoxColumn
            // 
            this.生产线号DataGridViewTextBoxColumn.DataPropertyName = "生产线号";
            this.生产线号DataGridViewTextBoxColumn.HeaderText = "生产线号";
            this.生产线号DataGridViewTextBoxColumn.Name = "生产线号DataGridViewTextBoxColumn";
            this.生产线号DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 供应商产品代号DataGridViewTextBoxColumn
            // 
            this.供应商产品代号DataGridViewTextBoxColumn.DataPropertyName = "供应商产品代号";
            this.供应商产品代号DataGridViewTextBoxColumn.HeaderText = "供应商产品代号";
            this.供应商产品代号DataGridViewTextBoxColumn.Name = "供应商产品代号DataGridViewTextBoxColumn";
            this.供应商产品代号DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 生产日期DataGridViewTextBoxColumn
            // 
            this.生产日期DataGridViewTextBoxColumn.DataPropertyName = "生产日期";
            this.生产日期DataGridViewTextBoxColumn.HeaderText = "生产日期";
            this.生产日期DataGridViewTextBoxColumn.Name = "生产日期DataGridViewTextBoxColumn";
            this.生产日期DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 批次号DataGridViewTextBoxColumn
            // 
            this.批次号DataGridViewTextBoxColumn.DataPropertyName = "批次号";
            this.批次号DataGridViewTextBoxColumn.HeaderText = "批次号";
            this.批次号DataGridViewTextBoxColumn.Name = "批次号DataGridViewTextBoxColumn";
            this.批次号DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 重量DataGridViewTextBoxColumn
            // 
            this.重量DataGridViewTextBoxColumn.DataPropertyName = "重量";
            this.重量DataGridViewTextBoxColumn.HeaderText = "重量";
            this.重量DataGridViewTextBoxColumn.Name = "重量DataGridViewTextBoxColumn";
            this.重量DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 登记时间DataGridViewTextBoxColumn
            // 
            this.登记时间DataGridViewTextBoxColumn.DataPropertyName = "登记时间";
            this.登记时间DataGridViewTextBoxColumn.HeaderText = "登记时间";
            this.登记时间DataGridViewTextBoxColumn.Name = "登记时间DataGridViewTextBoxColumn";
            this.登记时间DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 删除DataGridViewCheckBoxColumn
            // 
            this.删除DataGridViewCheckBoxColumn.DataPropertyName = "删除";
            this.删除DataGridViewCheckBoxColumn.HeaderText = "删除";
            this.删除DataGridViewCheckBoxColumn.Name = "删除DataGridViewCheckBoxColumn";
            this.删除DataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // 胶料入库BindingSource
            // 
            this.胶料入库BindingSource.DataSource = typeof(YKT.RubberTraceSystem.Data.胶料入库);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(445, 35);
            this.label3.TabIndex = 1;
            this.label3.Text = "在库胶料";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.label8, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.dgRubberChips, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.dgOutRubber, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 163);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(903, 547);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Location = new System.Drawing.Point(454, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(446, 35);
            this.label8.TabIndex = 3;
            this.label8.Text = "胶片";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgRubberChips
            // 
            this.dgRubberChips.AllowUserToAddRows = false;
            this.dgRubberChips.AllowUserToDeleteRows = false;
            this.dgRubberChips.AutoGenerateColumns = false;
            this.dgRubberChips.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgRubberChips.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.宽度,
            this.厚度,
            this.数量,
            this.胶料批号,
            this.dataGridViewTextBoxColumn9,
            this.消耗重量,
            this.dataGridViewCheckBoxColumn1});
            this.dgRubberChips.DataSource = this.橡胶薄片BindingSource;
            this.dgRubberChips.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgRubberChips.Location = new System.Drawing.Point(454, 38);
            this.dgRubberChips.Name = "dgRubberChips";
            this.dgRubberChips.ReadOnly = true;
            this.dgRubberChips.RowTemplate.Height = 23;
            this.dgRubberChips.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgRubberChips.Size = new System.Drawing.Size(446, 506);
            this.dgRubberChips.TabIndex = 2;
            this.dgRubberChips.SelectionChanged += new System.EventHandler(this.dgRubberChips_SelectionChanged);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // 宽度
            // 
            this.宽度.DataPropertyName = "宽度";
            this.宽度.HeaderText = "宽度";
            this.宽度.Name = "宽度";
            this.宽度.ReadOnly = true;
            // 
            // 厚度
            // 
            this.厚度.DataPropertyName = "厚度";
            this.厚度.HeaderText = "厚度";
            this.厚度.Name = "厚度";
            this.厚度.ReadOnly = true;
            // 
            // 数量
            // 
            this.数量.DataPropertyName = "数量";
            this.数量.HeaderText = "数量";
            this.数量.Name = "数量";
            this.数量.ReadOnly = true;
            // 
            // 胶料批号
            // 
            this.胶料批号.DataPropertyName = "胶料批号";
            this.胶料批号.HeaderText = "胶料批号";
            this.胶料批号.Name = "胶料批号";
            this.胶料批号.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "登记时间";
            this.dataGridViewTextBoxColumn9.HeaderText = "登记时间";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // 消耗重量
            // 
            this.消耗重量.DataPropertyName = "消耗重量";
            this.消耗重量.HeaderText = "消耗重量";
            this.消耗重量.Name = "消耗重量";
            this.消耗重量.ReadOnly = true;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "删除";
            this.dataGridViewCheckBoxColumn1.HeaderText = "删除";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.ReadOnly = true;
            // 
            // 橡胶薄片BindingSource
            // 
            this.橡胶薄片BindingSource.DataSource = typeof(YKT.RubberTraceSystem.Data.橡胶薄片);
            // 
            // btnCreate
            // 
            this.btnCreate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCreate.Location = new System.Drawing.Point(603, 3);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(217, 74);
            this.btnCreate.TabIndex = 5;
            this.btnCreate.Text = "生成胶片码";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 40);
            this.label5.TabIndex = 1;
            this.label5.Text = "胶料批号";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbTypeNo
            // 
            this.tbTypeNo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tbTypeNo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tbTypeNo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbTypeNo.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbTypeNo.ImeMode = System.Windows.Forms.ImeMode.Alpha;
            this.tbTypeNo.Location = new System.Drawing.Point(103, 3);
            this.tbTypeNo.Name = "tbTypeNo";
            this.tbTypeNo.Size = new System.Drawing.Size(144, 26);
            this.tbTypeNo.TabIndex = 3;
            this.tbTypeNo.TextChanged += new System.EventHandler(this.tbTypeNo_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Location = new System.Drawing.Point(503, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 80);
            this.label7.TabIndex = 6;
            this.label7.Text = "准备扫码";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label7.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(503, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 1);
            this.label2.TabIndex = 2;
            this.label2.Text = "上传数据";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(503, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 80);
            this.label1.TabIndex = 0;
            this.label1.Text = "盘点模式";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Visible = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 223F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.btnPrint, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.label7, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.pictureBox3, 4, 1);
            this.tableLayoutPanel2.Controls.Add(this.label2, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.pictureBox2, 3, 2);
            this.tableLayoutPanel2.Controls.Add(this.label1, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.pictureBox1, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel5, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnCreate, 3, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 0F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 0F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(903, 154);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // btnPrint
            // 
            this.btnPrint.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPrint.Location = new System.Drawing.Point(603, 83);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(217, 74);
            this.btnPrint.TabIndex = 10;
            this.btnPrint.Text = "打印胶片码";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::YKT.RubberTraceSystem.Windows.Properties.Resources.清除盘点数据;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox3.Location = new System.Drawing.Point(826, 83);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(217, 74);
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::YKT.RubberTraceSystem.Windows.Properties.Resources.数据上传;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Location = new System.Drawing.Point(603, 163);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(217, 1);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::YKT.RubberTraceSystem.Windows.Properties.Resources.盘点模式_即存储模式_;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(826, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(217, 74);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 5;
            this.tableLayoutPanel2.SetColumnSpan(this.tableLayoutPanel5, 2);
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel5.Controls.Add(this.tbConsume, 3, 2);
            this.tableLayoutPanel5.Controls.Add(this.label11, 2, 2);
            this.tableLayoutPanel5.Controls.Add(this.tbNum, 1, 2);
            this.tableLayoutPanel5.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel5.Controls.Add(this.tbThick, 3, 1);
            this.tableLayoutPanel5.Controls.Add(this.label10, 2, 1);
            this.tableLayoutPanel5.Controls.Add(this.tbWidth, 1, 1);
            this.tableLayoutPanel5.Controls.Add(this.label9, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.label6, 2, 0);
            this.tableLayoutPanel5.Controls.Add(this.tbCounter, 3, 0);
            this.tableLayoutPanel5.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.tbTypeNo, 1, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 6;
            this.tableLayoutPanel2.SetRowSpan(this.tableLayoutPanel5, 4);
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(494, 154);
            this.tableLayoutPanel5.TabIndex = 4;
            // 
            // tbConsume
            // 
            this.tbConsume.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbConsume.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbConsume.ImeMode = System.Windows.Forms.ImeMode.Alpha;
            this.tbConsume.Location = new System.Drawing.Point(353, 83);
            this.tbConsume.Name = "tbConsume";
            this.tbConsume.Size = new System.Drawing.Size(144, 26);
            this.tbConsume.TabIndex = 14;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label11.Location = new System.Drawing.Point(253, 80);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(94, 32);
            this.label11.TabIndex = 13;
            this.label11.Text = "每卷消耗重量";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbNum
            // 
            this.tbNum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbNum.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbNum.ImeMode = System.Windows.Forms.ImeMode.Alpha;
            this.tbNum.Location = new System.Drawing.Point(103, 83);
            this.tbNum.Name = "tbNum";
            this.tbNum.Size = new System.Drawing.Size(144, 26);
            this.tbNum.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(3, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 32);
            this.label4.TabIndex = 11;
            this.label4.Text = "每卷米数";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbThick
            // 
            this.tbThick.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbThick.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbThick.ImeMode = System.Windows.Forms.ImeMode.Alpha;
            this.tbThick.Location = new System.Drawing.Point(353, 43);
            this.tbThick.Name = "tbThick";
            this.tbThick.Size = new System.Drawing.Size(144, 26);
            this.tbThick.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Location = new System.Drawing.Point(253, 40);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 40);
            this.label10.TabIndex = 9;
            this.label10.Text = "厚度";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbWidth
            // 
            this.tbWidth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbWidth.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbWidth.ImeMode = System.Windows.Forms.ImeMode.Alpha;
            this.tbWidth.Location = new System.Drawing.Point(103, 43);
            this.tbWidth.Name = "tbWidth";
            this.tbWidth.Size = new System.Drawing.Size(144, 26);
            this.tbWidth.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Location = new System.Drawing.Point(3, 40);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 40);
            this.label9.TabIndex = 7;
            this.label9.Text = "宽度";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(253, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 40);
            this.label6.TabIndex = 5;
            this.label6.Text = "胶片码数量";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbCounter
            // 
            this.tbCounter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbCounter.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbCounter.ImeMode = System.Windows.Forms.ImeMode.Alpha;
            this.tbCounter.Location = new System.Drawing.Point(353, 3);
            this.tbCounter.Name = "tbCounter";
            this.tbCounter.Size = new System.Drawing.Size(144, 26);
            this.tbCounter.TabIndex = 6;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(909, 713);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // 胶料出片
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 713);
            this.Controls.Add(this.tableLayoutPanel1);
            this.KeyPreview = true;
            this.Name = "胶料出片";
            this.Text = "胶料出片";
            this.Activated += new System.EventHandler(this.胶料出片_Activated);
            this.Deactivate += new System.EventHandler(this.胶料出片_Deactivate);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.胶料出片_FormClosing);
            this.Load += new System.EventHandler(this.胶料出片_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.胶料出片_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.胶料出片_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.dgOutRubber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.胶料入库BindingSource)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgRubberChips)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.橡胶薄片BindingSource)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgOutRubber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbTypeNo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbThick;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbWidth;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbCounter;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tbNum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 胶料牌号DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 箱号DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 生产线号DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 供应商产品代号DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 生产日期DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 批次号DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 重量DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 登记时间DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn 删除DataGridViewCheckBoxColumn;
        private System.Windows.Forms.BindingSource 胶料入库BindingSource;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.DataGridView dgRubberChips;
        private System.Windows.Forms.BindingSource 橡胶薄片BindingSource;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbConsume;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 宽度;
        private System.Windows.Forms.DataGridViewTextBoxColumn 厚度;
        private System.Windows.Forms.DataGridViewTextBoxColumn 数量;
        private System.Windows.Forms.DataGridViewTextBoxColumn 胶料批号;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn 消耗重量;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
    }
}
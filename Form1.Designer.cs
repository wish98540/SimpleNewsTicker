namespace SimpleNewsTicker
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
            this.components = new System.ComponentModel.Container();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnBackgroundColor2 = new System.Windows.Forms.Button();
            this.btnForeColor2 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.修改文字內容ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tstxtText = new System.Windows.Forms.ToolStripTextBox();
            this.字型ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFont = new System.Windows.Forms.ToolStripMenuItem();
            this.方向性ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDirection = new System.Windows.Forms.ToolStripComboBox();
            this.滾動速度ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSpeed = new System.Windows.Forms.ToolStripComboBox();
            this.lblText2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBackgroundColor1 = new System.Windows.Forms.Button();
            this.btnForeColor1 = new System.Windows.Forms.Button();
            this.lblText1 = new System.Windows.Forms.Label();
            this.panelTop = new System.Windows.Forms.Panel();
            this.lblMaxValue = new System.Windows.Forms.Label();
            this.lblMinValue = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.lblSpeed = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtText = new System.Windows.Forms.TextBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslFont = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslDirection = new System.Windows.Forms.ToolStripSplitButton();
            this.tsslLeftToRight = new System.Windows.Forms.ToolStripMenuItem();
            this.tsslRightToLeft = new System.Windows.Forms.ToolStripMenuItem();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelBody = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnBackgroundColor3 = new System.Windows.Forms.Button();
            this.btnForeColor3 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblText3 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.panelBody.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnBackgroundColor2);
            this.groupBox2.Controls.Add(this.btnForeColor2);
            this.groupBox2.Controls.Add(this.panel2);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 160);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(600, 80);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "整個 Label 元件位移";
            // 
            // btnBackgroundColor2
            // 
            this.btnBackgroundColor2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBackgroundColor2.BackColor = System.Drawing.Color.Red;
            this.btnBackgroundColor2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackgroundColor2.ForeColor = System.Drawing.Color.Black;
            this.btnBackgroundColor2.Location = new System.Drawing.Point(574, 14);
            this.btnBackgroundColor2.Margin = new System.Windows.Forms.Padding(2);
            this.btnBackgroundColor2.Name = "btnBackgroundColor2";
            this.btnBackgroundColor2.Size = new System.Drawing.Size(16, 19);
            this.btnBackgroundColor2.TabIndex = 1;
            this.btnBackgroundColor2.Tag = "2";
            this.btnBackgroundColor2.UseVisualStyleBackColor = false;
            this.btnBackgroundColor2.BackColorChanged += new System.EventHandler(this.btnBackgroundColor1_BackColorChanged);
            this.btnBackgroundColor2.Click += new System.EventHandler(this.btnForeColor1_Click);
            // 
            // btnForeColor2
            // 
            this.btnForeColor2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnForeColor2.BackColor = System.Drawing.Color.White;
            this.btnForeColor2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnForeColor2.ForeColor = System.Drawing.Color.Black;
            this.btnForeColor2.Location = new System.Drawing.Point(554, 14);
            this.btnForeColor2.Margin = new System.Windows.Forms.Padding(2);
            this.btnForeColor2.Name = "btnForeColor2";
            this.btnForeColor2.Size = new System.Drawing.Size(16, 19);
            this.btnForeColor2.TabIndex = 1;
            this.btnForeColor2.Tag = "2";
            this.btnForeColor2.UseVisualStyleBackColor = false;
            this.btnForeColor2.BackColorChanged += new System.EventHandler(this.btnForeColor1_BackColorChanged);
            this.btnForeColor2.Click += new System.EventHandler(this.btnForeColor1_Click);
            // 
            // panel2
            // 
            this.panel2.ContextMenuStrip = this.contextMenuStrip1;
            this.panel2.Controls.Add(this.lblText2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(2, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(596, 54);
            this.panel2.TabIndex = 2;
            this.panel2.DoubleClick += new System.EventHandler(this.lblText1_DoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.修改文字內容ToolStripMenuItem,
            this.tstxtText,
            this.字型ToolStripMenuItem,
            this.tsmiFont,
            this.方向性ToolStripMenuItem,
            this.tsmiDirection,
            this.滾動速度ToolStripMenuItem,
            this.tsmiSpeed});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(241, 218);
            // 
            // 修改文字內容ToolStripMenuItem
            // 
            this.修改文字內容ToolStripMenuItem.Name = "修改文字內容ToolStripMenuItem";
            this.修改文字內容ToolStripMenuItem.Size = new System.Drawing.Size(240, 24);
            this.修改文字內容ToolStripMenuItem.Text = "文字內容:";
            // 
            // tstxtText
            // 
            this.tstxtText.AutoSize = false;
            this.tstxtText.AutoToolTip = true;
            this.tstxtText.BackColor = System.Drawing.Color.Black;
            this.tstxtText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tstxtText.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tstxtText.ForeColor = System.Drawing.Color.LawnGreen;
            this.tstxtText.Name = "tstxtText";
            this.tstxtText.Size = new System.Drawing.Size(180, 28);
            this.tstxtText.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tstxtText.ToolTipText = "按 Enter 修改文字內容";
            this.tstxtText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tstxtText_KeyDown);
            // 
            // 字型ToolStripMenuItem
            // 
            this.字型ToolStripMenuItem.Name = "字型ToolStripMenuItem";
            this.字型ToolStripMenuItem.Size = new System.Drawing.Size(240, 24);
            this.字型ToolStripMenuItem.Text = "字型:";
            // 
            // tsmiFont
            // 
            this.tsmiFont.AutoToolTip = true;
            this.tsmiFont.ForeColor = System.Drawing.Color.Blue;
            this.tsmiFont.Name = "tsmiFont";
            this.tsmiFont.Size = new System.Drawing.Size(240, 24);
            this.tsmiFont.Text = "Font";
            this.tsmiFont.ToolTipText = "字型, 決定跑馬燈的字體";
            this.tsmiFont.Click += new System.EventHandler(this.tsmiFont_Click);
            // 
            // 方向性ToolStripMenuItem
            // 
            this.方向性ToolStripMenuItem.Name = "方向性ToolStripMenuItem";
            this.方向性ToolStripMenuItem.Size = new System.Drawing.Size(240, 24);
            this.方向性ToolStripMenuItem.Text = "方向性:";
            // 
            // tsmiDirection
            // 
            this.tsmiDirection.AutoToolTip = true;
            this.tsmiDirection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tsmiDirection.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.tsmiDirection.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tsmiDirection.ForeColor = System.Drawing.Color.Blue;
            this.tsmiDirection.Items.AddRange(new object[] {
            "左 -> 右 (>>)",
            "右 -> 左 (<<)"});
            this.tsmiDirection.Name = "tsmiDirection";
            this.tsmiDirection.Size = new System.Drawing.Size(180, 28);
            this.tsmiDirection.ToolTipText = "方向性, 決定文字的滾動方向";
            this.tsmiDirection.SelectedIndexChanged += new System.EventHandler(this.tsmiDirection_SelectedIndexChanged);
            // 
            // 滾動速度ToolStripMenuItem
            // 
            this.滾動速度ToolStripMenuItem.Name = "滾動速度ToolStripMenuItem";
            this.滾動速度ToolStripMenuItem.Size = new System.Drawing.Size(240, 24);
            this.滾動速度ToolStripMenuItem.Text = "滾動速度:";
            // 
            // tsmiSpeed
            // 
            this.tsmiSpeed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tsmiSpeed.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.tsmiSpeed.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tsmiSpeed.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.tsmiSpeed.Name = "tsmiSpeed";
            this.tsmiSpeed.Size = new System.Drawing.Size(180, 28);
            this.tsmiSpeed.SelectedIndexChanged += new System.EventHandler(this.tsmiSpeed_SelectedIndexChanged);
            // 
            // lblText2
            // 
            this.lblText2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblText2.Location = new System.Drawing.Point(0, 0);
            this.lblText2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblText2.Name = "lblText2";
            this.lblText2.Size = new System.Drawing.Size(596, 54);
            this.lblText2.TabIndex = 1;
            this.lblText2.Text = "文字內容";
            this.lblText2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.ContextMenuStrip = this.contextMenuStrip1;
            this.groupBox1.Controls.Add(this.btnBackgroundColor1);
            this.groupBox1.Controls.Add(this.btnForeColor1);
            this.groupBox1.Controls.Add(this.lblText1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 80);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(600, 80);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "使用 Label 文字位移";
            // 
            // btnBackgroundColor1
            // 
            this.btnBackgroundColor1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBackgroundColor1.BackColor = System.Drawing.Color.Red;
            this.btnBackgroundColor1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackgroundColor1.ForeColor = System.Drawing.Color.Black;
            this.btnBackgroundColor1.Location = new System.Drawing.Point(574, 13);
            this.btnBackgroundColor1.Margin = new System.Windows.Forms.Padding(2);
            this.btnBackgroundColor1.Name = "btnBackgroundColor1";
            this.btnBackgroundColor1.Size = new System.Drawing.Size(16, 19);
            this.btnBackgroundColor1.TabIndex = 1;
            this.btnBackgroundColor1.Tag = "1";
            this.btnBackgroundColor1.UseVisualStyleBackColor = false;
            this.btnBackgroundColor1.BackColorChanged += new System.EventHandler(this.btnBackgroundColor1_BackColorChanged);
            this.btnBackgroundColor1.Click += new System.EventHandler(this.btnForeColor1_Click);
            // 
            // btnForeColor1
            // 
            this.btnForeColor1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnForeColor1.BackColor = System.Drawing.Color.White;
            this.btnForeColor1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnForeColor1.ForeColor = System.Drawing.Color.Black;
            this.btnForeColor1.Location = new System.Drawing.Point(554, 13);
            this.btnForeColor1.Margin = new System.Windows.Forms.Padding(2);
            this.btnForeColor1.Name = "btnForeColor1";
            this.btnForeColor1.Size = new System.Drawing.Size(16, 19);
            this.btnForeColor1.TabIndex = 1;
            this.btnForeColor1.Tag = "1";
            this.btnForeColor1.UseVisualStyleBackColor = false;
            this.btnForeColor1.BackColorChanged += new System.EventHandler(this.btnForeColor1_BackColorChanged);
            this.btnForeColor1.Click += new System.EventHandler(this.btnForeColor1_Click);
            // 
            // lblText1
            // 
            this.lblText1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblText1.Location = new System.Drawing.Point(2, 24);
            this.lblText1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblText1.Name = "lblText1";
            this.lblText1.Size = new System.Drawing.Size(596, 54);
            this.lblText1.TabIndex = 0;
            this.lblText1.Text = "文字內容";
            this.lblText1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblText1.DoubleClick += new System.EventHandler(this.lblText1_DoubleClick);
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.lblMaxValue);
            this.panelTop.Controls.Add(this.lblMinValue);
            this.panelTop.Controls.Add(this.trackBar1);
            this.panelTop.Controls.Add(this.lblSpeed);
            this.panelTop.Controls.Add(this.label2);
            this.panelTop.Controls.Add(this.label1);
            this.panelTop.Controls.Add(this.txtText);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Margin = new System.Windows.Forms.Padding(2);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(600, 80);
            this.panelTop.TabIndex = 4;
            // 
            // lblMaxValue
            // 
            this.lblMaxValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMaxValue.Location = new System.Drawing.Point(482, 58);
            this.lblMaxValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMaxValue.Name = "lblMaxValue";
            this.lblMaxValue.Size = new System.Drawing.Size(84, 20);
            this.lblMaxValue.TabIndex = 0;
            this.lblMaxValue.Text = "maxValue";
            this.lblMaxValue.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblMinValue
            // 
            this.lblMinValue.AutoSize = true;
            this.lblMinValue.Location = new System.Drawing.Point(230, 58);
            this.lblMinValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMinValue.Name = "lblMinValue";
            this.lblMinValue.Size = new System.Drawing.Size(81, 20);
            this.lblMinValue.TabIndex = 0;
            this.lblMinValue.Text = "minValue";
            // 
            // trackBar1
            // 
            this.trackBar1.AutoSize = false;
            this.trackBar1.Location = new System.Drawing.Point(230, 35);
            this.trackBar1.Margin = new System.Windows.Forms.Padding(2);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(340, 32);
            this.trackBar1.TabIndex = 2;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // lblSpeed
            // 
            this.lblSpeed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSpeed.ForeColor = System.Drawing.Color.Blue;
            this.lblSpeed.Location = new System.Drawing.Point(478, 13);
            this.lblSpeed.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size(91, 20);
            this.lblSpeed.TabIndex = 0;
            this.lblSpeed.Text = "Now Speed";
            this.lblSpeed.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(226, 13);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "移動速度";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "文字內容";
            // 
            // txtText
            // 
            this.txtText.Location = new System.Drawing.Point(27, 35);
            this.txtText.Margin = new System.Windows.Forms.Padding(2);
            this.txtText.Name = "txtText";
            this.txtText.Size = new System.Drawing.Size(182, 29);
            this.txtText.TabIndex = 1;
            this.txtText.TextChanged += new System.EventHandler(this.txtText_TextChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.tsslFont,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3,
            this.tsslDirection});
            this.statusStrip1.Location = new System.Drawing.Point(0, 334);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(600, 26);
            this.statusStrip1.TabIndex = 9;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(45, 21);
            this.toolStripStatusLabel1.Text = "字型:";
            // 
            // tsslFont
            // 
            this.tsslFont.ForeColor = System.Drawing.Color.Blue;
            this.tsslFont.Name = "tsslFont";
            this.tsslFont.Size = new System.Drawing.Size(43, 21);
            this.tsslFont.Text = "Font";
            this.tsslFont.Click += new System.EventHandler(this.tsslFont_Click);
            this.tsslFont.TextChanged += new System.EventHandler(this.tsslFont_TextChanged);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(13, 21);
            this.toolStripStatusLabel2.Text = "|";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(61, 21);
            this.toolStripStatusLabel3.Text = "方向性:";
            // 
            // tsslDirection
            // 
            this.tsslDirection.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslLeftToRight,
            this.tsslRightToLeft});
            this.tsslDirection.ForeColor = System.Drawing.Color.Blue;
            this.tsslDirection.Name = "tsslDirection";
            this.tsslDirection.Size = new System.Drawing.Size(94, 24);
            this.tsslDirection.Text = "Direction";
            this.tsslDirection.TextChanged += new System.EventHandler(this.tsslDirection_TextChanged);
            // 
            // tsslLeftToRight
            // 
            this.tsslLeftToRight.Name = "tsslLeftToRight";
            this.tsslLeftToRight.Size = new System.Drawing.Size(180, 24);
            this.tsslLeftToRight.Text = "左 -> 右 (>>)";
            this.tsslLeftToRight.Click += new System.EventHandler(this.tsslLeftToRight_Click);
            // 
            // tsslRightToLeft
            // 
            this.tsslRightToLeft.Name = "tsslRightToLeft";
            this.tsslRightToLeft.Size = new System.Drawing.Size(180, 24);
            this.tsslRightToLeft.Text = "右 -> 左 (<<)";
            this.tsslRightToLeft.Click += new System.EventHandler(this.tsslRightToLeft_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panelBody
            // 
            this.panelBody.Controls.Add(this.groupBox3);
            this.panelBody.Controls.Add(this.groupBox2);
            this.panelBody.Controls.Add(this.groupBox1);
            this.panelBody.Controls.Add(this.panelTop);
            this.panelBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBody.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.panelBody.Location = new System.Drawing.Point(0, 0);
            this.panelBody.Margin = new System.Windows.Forms.Padding(2);
            this.panelBody.Name = "panelBody";
            this.panelBody.Size = new System.Drawing.Size(600, 360);
            this.panelBody.TabIndex = 8;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnBackgroundColor3);
            this.groupBox3.Controls.Add(this.btnForeColor3);
            this.groupBox3.Controls.Add(this.panel3);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(0, 240);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(600, 80);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "使用 Drawing 繪製";
            // 
            // btnBackgroundColor3
            // 
            this.btnBackgroundColor3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBackgroundColor3.BackColor = System.Drawing.Color.Red;
            this.btnBackgroundColor3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackgroundColor3.ForeColor = System.Drawing.Color.Black;
            this.btnBackgroundColor3.Location = new System.Drawing.Point(572, 16);
            this.btnBackgroundColor3.Margin = new System.Windows.Forms.Padding(2);
            this.btnBackgroundColor3.Name = "btnBackgroundColor3";
            this.btnBackgroundColor3.Size = new System.Drawing.Size(16, 19);
            this.btnBackgroundColor3.TabIndex = 1;
            this.btnBackgroundColor3.Tag = "3";
            this.btnBackgroundColor3.UseVisualStyleBackColor = false;
            this.btnBackgroundColor3.BackColorChanged += new System.EventHandler(this.btnBackgroundColor1_BackColorChanged);
            this.btnBackgroundColor3.Click += new System.EventHandler(this.btnForeColor1_Click);
            // 
            // btnForeColor3
            // 
            this.btnForeColor3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnForeColor3.BackColor = System.Drawing.Color.White;
            this.btnForeColor3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnForeColor3.ForeColor = System.Drawing.Color.Black;
            this.btnForeColor3.Location = new System.Drawing.Point(552, 16);
            this.btnForeColor3.Margin = new System.Windows.Forms.Padding(2);
            this.btnForeColor3.Name = "btnForeColor3";
            this.btnForeColor3.Size = new System.Drawing.Size(16, 19);
            this.btnForeColor3.TabIndex = 1;
            this.btnForeColor3.Tag = "3";
            this.btnForeColor3.UseVisualStyleBackColor = false;
            this.btnForeColor3.BackColorChanged += new System.EventHandler(this.btnForeColor1_BackColorChanged);
            this.btnForeColor3.Click += new System.EventHandler(this.btnForeColor1_Click);
            // 
            // panel3
            // 
            this.panel3.ContextMenuStrip = this.contextMenuStrip1;
            this.panel3.Controls.Add(this.lblText3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(2, 24);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(596, 54);
            this.panel3.TabIndex = 3;
            this.panel3.DoubleClick += new System.EventHandler(this.lblText1_DoubleClick);
            // 
            // lblText3
            // 
            this.lblText3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblText3.Location = new System.Drawing.Point(0, 0);
            this.lblText3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblText3.Name = "lblText3";
            this.lblText3.Size = new System.Drawing.Size(596, 54);
            this.lblText3.TabIndex = 2;
            this.lblText3.Text = "文字內容";
            this.lblText3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 360);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panelBody);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1 - 跑馬燈";
            this.Load += new System.EventHandler(this.FrmNewsTicker_Load);
            this.groupBox2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.contextMenuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panelBody.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnBackgroundColor2;
        private System.Windows.Forms.Button btnForeColor2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 修改文字內容ToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox tstxtText;
        private System.Windows.Forms.ToolStripMenuItem 字型ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiFont;
        private System.Windows.Forms.ToolStripMenuItem 方向性ToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox tsmiDirection;
        private System.Windows.Forms.ToolStripMenuItem 滾動速度ToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox tsmiSpeed;
        private System.Windows.Forms.Label lblText2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBackgroundColor1;
        private System.Windows.Forms.Button btnForeColor1;
        private System.Windows.Forms.Label lblText1;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblMaxValue;
        private System.Windows.Forms.Label lblMinValue;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label lblSpeed;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtText;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel tsslFont;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripSplitButton tsslDirection;
        private System.Windows.Forms.ToolStripMenuItem tsslLeftToRight;
        private System.Windows.Forms.ToolStripMenuItem tsslRightToLeft;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panelBody;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnBackgroundColor3;
        private System.Windows.Forms.Button btnForeColor3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblText3;
    }
}

